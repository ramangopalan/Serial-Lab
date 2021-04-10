/*
    Serial Lab is an open source project 
    Licensed under the GNU GPLv3
    Author : Ahmed El-Sayed
    ahmed.m.elsayed93@gmail.com
 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
using System.Timers;
using System.IO;

namespace Seriallab
{
    public partial class MainForm : Form
    {
        public string data{ get; set; }
        int graph_scaler = 500;
        int send_repeat_counter = 0;
        bool send_data_flag = false;
        bool plotter_flag = false;
        System.IO.StreamWriter out_file;
        System.IO.StreamReader in_file;
        bool mstart = false;

        public MainForm()
        {
            InitializeComponent();
            configrations();
        }

        public void configrations()
        {
           portConfig.Items.AddRange(SerialPort.GetPortNames());
            baudrateConfig.DataSource = new[] { "115200", "19200", "230400", "57600", "38400", "9600", "4800" };
            parityConfig.DataSource = new[] { "None", "Odd", "Even", "Mark", "Space" };
            databitsConfig.DataSource = new[] { "5", "6", "7", "8" };
            stopbitsConfig.DataSource = new[] { "1", "2", "1.5" };
            flowcontrolConfig.DataSource = new[] { "None", "RTS", "RTS/X", "Xon/Xoff" };
            //portConfig.SelectedIndex = 0;
            baudrateConfig.SelectedIndex = 5;
            parityConfig.SelectedIndex = 0;
            databitsConfig.SelectedIndex = 3;
            stopbitsConfig.SelectedIndex = 0;
            flowcontrolConfig.SelectedIndex = 0;
            openFileDialog1.Filter = "Text|*.txt";
            temperature_group.Enabled = false;
            start_button.Enabled = false;
            //((Control)this.tabPage1).Enabled = false;

            mySerial.DataReceived += rx_data_event;
            tx_repeater_delay.Tick += new EventHandler(send_data);
            backgroundWorker1.DoWork += new DoWorkEventHandler(update_rxtextarea_event);
            tabControl1.Selected += new TabControlEventHandler(tabControl1_Selecting);

            for (int i = 0; i < 5 && i < 5; i++)
                graph.Series[i].Points.Add(0);

            // Set series legend text.
            graph.Series[0].LegendText = "Int. " + "\u00B0C";
            graph.Series[1].LegendText = "Ext. " + "\u00B0C";
            graph.Series[2].LegendText = "####";
            graph.Series[3].LegendText = "####";
            graph.Series[4].LegendText = "####";

        }

        /*connect and disconnect*/
        private void connect_Click(object sender, EventArgs e)
        {
            /*Connect*/
            if (!mySerial.IsOpen)
            {
                if (Serial_port_config())
                {
                    try
                    {
                        mySerial.Open();
                    }
                    catch
                    {
                        alert("Can't open " + mySerial.PortName + " port! It might be used in another program");
                        return;
                    }

                    if (datalogger_checkbox.Checked)
                    {
                        try
                        {
                            out_file = new System.IO.StreamWriter(datalogger_checkbox.Text, datalogger_append_radiobutton.Checked);
                        }
                        catch
                        {
                            alert("Can't open " + datalogger_checkbox.Text + " file! It might be used in another program");
                            return;
                        }
                    }

                    UserControl_state(true);
                }
            }

            /*Disconnect*/
            else if (mySerial.IsOpen)
            {
                try
                {
                    mySerial.Close();
                    mySerial.DiscardInBuffer();
                    mySerial.DiscardOutBuffer();
                }
                catch {/*ignore*/}

                if (datalogger_checkbox.Checked)
                    try { out_file.Dispose(); }
                    catch {/*ignore*/ }

                try {in_file.Dispose();}
                catch {/*ignore*/ }


                UserControl_state(false);
            }
        }

        /* RX -----*/

        /* read data from serial */
        private void rx_data_event(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            float max_lim = 200, min_lim = -90;
            if (mySerial.IsOpen)
            {
                try
                {
                    //int dataLength = mySerial.BytesToRead;
                    //byte[] dataRecevied = new byte[dataLength];
                    //int nbytes = mySerial.Read(dataRecevied, 0, dataLength);
                    //string indata = mySerial.ReadLine();
                    //Console.WriteLine(indata);
                    //if (nbytes == 0) return;
                    data = mySerial.ReadLine();
                    if (data.Contains("->") && data.Contains("deg C") && data.Contains("Int") && data.Contains("Ext"))
                    {
                        string data_1 = data.Substring(data.IndexOf("Int:") + 4, 8);
                        float d1 = float.Parse(data_1);
                        string data_2 = data.Substring(data.IndexOf("Ext:") + 4, 8);
                        float d2 = float.Parse(data_2);
                        if (d1 < min_lim || d1 > max_lim)
                        {
                            data_1 = "";
                        }
                        if (d2 < min_lim || d2 > max_lim)
                        {
                            data_2 = "";
                        }
                        data = data_1 + ", " + data_2 + "\n";
                    }
                    else
                    {
                        data = "";
                        return;
                    }

                    if (datalogger_checkbox.Checked)
                    {
                        try
                        {
                            DateTime now = DateTime.Now;
                            out_file.Write(now + ", " + data.Replace("\\n", Environment.NewLine)); 
                        }
                        catch { alert("Can't write to " + datalogger_checkbox.Text + " file! Either it doesn't exist or it is opened in another program"); return; }
                    }

                    this.BeginInvoke((Action)(() =>
                    {
                        //data = System.Text.Encoding.Default.GetString(dataRecevied);
                        //data = mySerial.ReadLine();
                        //Console.WriteLine(data);

                        if (!plotter_flag && !backgroundWorker1.IsBusy)
                        {
                            //if (display_hex_radiobutton.Checked)
                            //    data = BitConverter.ToString(dataRecevied);

                            backgroundWorker1.RunWorkerAsync();
                        }

                        else if (plotter_flag)
                        {
                            double number;
                            string[] variables = data.Split('\n')[0].Split(',');
                            //Console.WriteLine(variables);
                            for (int i = 0; i < variables.Length && i < 5; i++)
                            {
                                if (double.TryParse(variables[i], out number))
                                {
                                    if (graph.Series[i].Points.Count > graph_scaler)
                                        graph.Series[i].Points.RemoveAt(0);
                                    graph.Series[i].Points.Add(number);
                                }
                            }
                            graph.ResetAutoValues();
                        }
                    }));
                }
                catch { alert("Can't read from  " + mySerial.PortName + " port! It might be opened in another program"); }
            }
        }

        /* Append text to rx_textarea*/
        private void update_rxtextarea_event(object sender, DoWorkEventArgs e)
        {
            this.BeginInvoke((Action)(() =>
            {
                if (rx_textarea.Lines.Count() > 5000)
                    rx_textarea.ResetText();
                rx_textarea.AppendText("[Receive]: " + data);
            }));
        }

        /* Enable data logger and log file selection */
        private void datalogger_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (datalogger_checkbox.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    datalogger_checkbox.Text = openFileDialog1.FileName;
                    datalogger_append_radiobutton.Enabled = true;
                    datalogger_overwrite_radiobutton.Enabled = true;
                    datalogger_append_radiobutton.Enabled = true;
                    datalogger_overwrite_radiobutton.Enabled = true;
                }
                else
                {
                    datalogger_checkbox.Checked = false;
                    datalogger_append_radiobutton.Enabled = false;
                    datalogger_overwrite_radiobutton.Enabled = false;
                    datalogger_append_radiobutton.Enabled = false;
                    datalogger_overwrite_radiobutton.Enabled = false;
                }
            }
            else
            {
                datalogger_append_radiobutton.Enabled = false;
                datalogger_overwrite_radiobutton.Enabled = false;
                datalogger_checkbox.Text = "Enable Data logger";
            }
        }

        /* clear rx textarea */
        private void clear_rx_textarea_Click(object sender, EventArgs e)
        {
            rx_textarea.Clear();
        }

        /*TX------*/

        /* Write data to serial port */
        private void sendData_Click(object sender, EventArgs e)
        {
            if (!send_data_flag)
            {
                tx_repeater_delay.Interval = (int)send_delay.Value;
                tx_repeater_delay.Start();       
               
                if (send_word_radiobutton.Checked)
                {
                    progressBar1.Maximum = (int)send_repeat.Value;
                    progressBar1.Visible = true;
                }
                else if (write_form_file_radiobutton.Checked)
                {
                    try
                    {
                        in_file = new System.IO.StreamReader(tx_textarea.Text, true);
                    }
                    catch
                    {
                        alert("Can't open " + tx_textarea.Text + " file, it might be not exist or it is used in another program");
                        return;
                    }

                    progressBar1.Maximum = file_size(tx_textarea.Text);
                    progressBar1.Visible = true;
                }

                send_data_flag = true;
                tx_num_panel.Enabled = false;
                tx_textarea.Enabled = false;
                tx_radiobuttons_panel.Enabled = false;
                sendData.Text = "Stop";
            }
            else
            {
                tx_repeater_delay.Stop();
                progressBar1.Value = 0;
                send_repeat_counter = 0;
                send_data_flag = false;
                progressBar1.Visible = false;
                tx_num_panel.Enabled = true;
                tx_textarea.Enabled = true;
                tx_radiobuttons_panel.Enabled = true;     
                sendData.Text = "Send";
                if (write_form_file_radiobutton.Checked)
                    try { in_file.Dispose(); }
                    catch { } 
            }
        }

        private void send_data(object sender, EventArgs e)
        {

            string tx_data = "";
            if (send_word_radiobutton.Checked)
            {
                tx_data = tx_textarea.Text.Replace("\n", Environment.NewLine);
                if (send_repeat_counter < (int)send_repeat.Value)
                {
                    send_repeat_counter++;
                    progressBar1.Value = send_repeat_counter;
                    progressBar1.Update();
                }
                else
                    send_data_flag = false;
            }

            else if (write_form_file_radiobutton.Checked)
            {
                try { tx_data = in_file.ReadLine(); }
                catch { }
                
                if (tx_data == null)
                    send_data_flag = false;
                else
                {
                    progressBar1.Value = send_repeat_counter;
                    send_repeat_counter++;
                }
                tx_data += "\\n";
            }

            if (send_data_flag)
            {
                if (mySerial.IsOpen)
                {
                    try
                    {
                        
                        mySerial.Write(tx_data.Replace("\\n", Environment.NewLine));
                        tx_terminal.AppendText("[Transmit]: " + tx_data+"\n");
                    }
                    catch
                    {
                        alert("Can't write to " + mySerial.PortName + " port! It might be opened in another program");
                    }
                }
            }
            else
            {
                tx_repeater_delay.Stop();
                sendData.Text = "Send";
                send_repeat_counter = 0;
                progressBar1.Value = 0;
                progressBar1.Visible = false;
                tx_radiobuttons_panel.Enabled = true;
                tx_num_panel.Enabled = true;
                tx_textarea.Enabled = true;

                if (write_form_file_radiobutton.Checked)
                    try { in_file.Dispose(); }
                    catch { }
            }
        }

        /* write data when keydown*/
        private void tx_textarea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (key_capture_radiobutton.Checked && mySerial.IsOpen)
            {
                try
                {
                    mySerial.Write(e.KeyChar.ToString());
                    tx_terminal.AppendText("[Transmit]: " + e.KeyChar.ToString() + "\n");
                    tx_textarea.Clear();
                }
                catch {alert("Can't write to "+mySerial.PortName+" port! It might be opened in another program"); }
            }
        }


        private void send_word_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            tx_textarea.Clear();
            send_repeat.Enabled = send_word_radiobutton.Checked;
            send_delay.Enabled = send_word_radiobutton.Checked;
            this.ActiveControl = tx_textarea;
        }
        private void key_capture_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            tx_textarea.Clear();
            send_repeat.Enabled = !key_capture_radiobutton.Checked;
            send_delay.Enabled = !key_capture_radiobutton.Checked;
            sendData.Enabled = !key_capture_radiobutton.Checked;
            this.ActiveControl = tx_textarea;
        }
        private void write_form_file_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            tx_textarea.Clear();
            send_repeat.Enabled = !write_form_file_radiobutton.Checked;
            send_delay.Enabled = write_form_file_radiobutton.Checked;

            if (write_form_file_radiobutton.Checked)
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    tx_textarea.Text = openFileDialog1.FileName;
                    tx_textarea.Cursor = Cursors.Hand;
                    tx_textarea.ReadOnly = true;
                }
                else
                {
                    send_word_radiobutton.Checked = true;
                }
            else
            {
                tx_textarea.Cursor = Cursors.IBeam;
                tx_textarea.ReadOnly = false;
            }
        }

        /* Plotter ------*/
        private void graph_speed_ValueChanged(object sender, EventArgs e)
        {
            graph.ChartAreas[0].AxisY.Interval = (int)graph_speed.Value;
        }
        /* change graph scale*/
        private void graph_scale_ValueChanged(object sender, EventArgs e)
        {
            graph_scaler = (int)graph_scale.Value;
            for (int i = 0; i < 5; i++)
                graph.Series[i].Points.Clear();
        }
        /* set graph max value*/
        private void set_graph_max_enable_CheckedChanged(object sender, EventArgs e)
        {
            if (set_graph_max_enable.Checked)
                try
                {
                    graph_max.Value = (int)graph.ChartAreas[0].AxisY.Maximum;
                    graph.ChartAreas[0].AxisY.Maximum = (int)graph_max.Value;
                }
                catch {alert("Invalid Minimum value");}
            else
                graph.ChartAreas[0].AxisY.Maximum = Double.NaN;

            graph_max.Enabled = set_graph_max_enable.Checked;
        }
        private void graph_max_ValueChanged(object sender, EventArgs e)
        {
            if (graph_max.Value > graph_min.Value)
                graph.ChartAreas[0].AxisY.Maximum = (int)graph_max.Value;
            else
                alert("Invalid Maximum value");
        }
        /* set graph min value*/
        private void set_graph_min_enable_CheckedChanged(object sender, EventArgs e)
        {
            if (set_graph_min_enable.Checked)
                try
                {
                    graph_min.Value = (int)graph.ChartAreas[0].AxisY.Minimum;
                    graph.ChartAreas[0].AxisY.Minimum = (int)graph_min.Value;
                }
                catch { alert("Invalid Minimum value"); }
            else
                graph.ChartAreas[0].AxisY.Minimum = Double.NaN;

            graph_min.Enabled = set_graph_min_enable.Checked;
        }
        private void graph_min_ValueChanged(object sender, EventArgs e)
        {
            if (graph_min.Value < graph_max.Value)
                graph.ChartAreas[0].AxisY.Minimum = (int)graph_min.Value;
            else
                alert("Invalid Minimum value");
        }
        /* save graph as image*/
        private void saveAsImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                graph.SaveImage(saveFileDialog1.FileName, ChartImageFormat.Png);
        }
        /*clear graph*/
        private void clear_graph_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                graph.Series[i].Points.Clear();
        }

        /*Application-----*/
        /*serial port config*/
        private bool Serial_port_config()
        {
            try {mySerial.PortName = portConfig.Text; }
            catch { alert("There are no available ports"); return false;}
            mySerial.BaudRate = (Int32.Parse(baudrateConfig.Text));
            mySerial.StopBits = (StopBits)Enum.Parse(typeof(StopBits), (stopbitsConfig.SelectedIndex + 1).ToString(), true);
            mySerial.Parity = (Parity)Enum.Parse(typeof(Parity), parityConfig.SelectedIndex.ToString(), true);
            mySerial.DataBits = (Int32.Parse(databitsConfig.Text));
            mySerial.Handshake = (Handshake)Enum.Parse(typeof(Handshake), flowcontrolConfig.SelectedIndex.ToString(), true);

            return true;
        }

        private void UserControl_state(bool value)
        {
            serial_options_group.Enabled = !value;
            datalogger_options_panel.Enabled = !value;
            write_options_group.Enabled = value;
            temperature_group.Enabled = value;
            start_button.Enabled = value;

            if (value)
            {
                connect.Text = "Disconnect";
                toolStripStatusLabel1.Text = "Connected port: " + mySerial.PortName + " - " + mySerial.BaudRate + ", " + mySerial.DataBits + ", " + mySerial.Parity + ", " + mySerial.StopBits;
            }
            else
            {
                connect.Text = "Connect";
                toolStripStatusLabel1.Text = "No Connection";
            }
        }

        /* tabcontrol*/
        void tabControl1_Selecting(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
                plotter_flag = true;
            else
                plotter_flag = false;
        }
        /* Search for available serial ports */
        private void portConfig_Click(object sender, EventArgs e)
        {
            portConfig.Items.Clear();
            portConfig.Items.AddRange(SerialPort.GetPortNames());
        }
        /*alert function*/
        private void alert(string text)
        {
            alert_messege.Icon = Icon;
            alert_messege.Visible = true;
            alert_messege.ShowBalloonTip(5000, "Serial Lab", text, ToolTipIcon.Error);
        }
        /*about box*/
        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.ShowDialog();
        }
        /* Close serial port when closing*/
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mySerial.IsOpen)
                mySerial.Close();
        }
        private void tx_textarea_Click(object sender, EventArgs e)
        {
            if (write_form_file_radiobutton.Checked)
                write_form_file_radiobutton_CheckedChanged(sender, e);
        }
        /*get number of lines*/
        private int file_size(string path)
        {
            var file = new StreamReader(path).ReadToEnd();
            string [] lines = file.Split(new char[] { '\n' });
            int count = lines.Count();
            return count;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tx_terminal.Clear();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = set_point.SelectedIndex + 1;
            if (index != 0)
            {
                mySerial.Write("eval \"temp(" + index.ToString() + "," + temp_up_down.Value.ToString() + ")\"\r\n");
                Task.Delay(500).ContinueWith(t =>
                {
                    mySerial.Write("eval \"spsel(" + index.ToString() + ")\"\r\n");
                });
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            mstart = !mstart;
            if (mstart)
            {
                start_button.Text = "Stop";
                mySerial.Write("eval start\r\n");
            }
            else
            {
                start_button.Text = "Start";
                mySerial.Write("eval stop\r\n");
            }
        }

        private void trigger_plot_Click(object sender, EventArgs e)
        {
            mySerial.Write("eval \"plot\"\r\n");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
  }















