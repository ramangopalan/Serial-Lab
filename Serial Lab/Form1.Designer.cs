﻿namespace Seriallab
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.connect = new System.Windows.Forms.Button();
            this.portConfig = new System.Windows.Forms.ComboBox();
            this.baudrateConfig = new System.Windows.Forms.ComboBox();
            this.databitsConfig = new System.Windows.Forms.ComboBox();
            this.stopbitsConfig = new System.Windows.Forms.ComboBox();
            this.parityConfig = new System.Windows.Forms.ComboBox();
            this.mySerial = new System.IO.Ports.SerialPort(this.components);
            this.serial_options_group = new System.Windows.Forms.GroupBox();
            this.flowconrol_label = new System.Windows.Forms.Label();
            this.baudrate_label = new System.Windows.Forms.Label();
            this.flowcontrolConfig = new System.Windows.Forms.ComboBox();
            this.parity_label = new System.Windows.Forms.Label();
            this.port_label = new System.Windows.Forms.Label();
            this.stopbits_label = new System.Windows.Forms.Label();
            this.databits_label = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.byte_counter_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rx_textarea = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.read_options_group = new System.Windows.Forms.GroupBox();
            this.dsiplayas_options_panel = new System.Windows.Forms.Panel();
            this.display_hex_radiobutton = new System.Windows.Forms.RadioButton();
            this.display_string_radiobutton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tx_terminal = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.write_options_group = new System.Windows.Forms.GroupBox();
            this.tx_num_panel = new System.Windows.Forms.Panel();
            this.send_delay = new System.Windows.Forms.NumericUpDown();
            this.send_repeat = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_radiobuttons_panel = new System.Windows.Forms.Panel();
            this.write_form_file_radiobutton = new System.Windows.Forms.RadioButton();
            this.key_capture_radiobutton = new System.Windows.Forms.RadioButton();
            this.send_word_radiobutton = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.send_status = new System.Windows.Forms.Label();
            this.sendData = new System.Windows.Forms.Button();
            this.tx_textarea = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.plotter_option_group = new System.Windows.Forms.GroupBox();
            this.graph_max = new System.Windows.Forms.NumericUpDown();
            this.set_graph_min_enable = new System.Windows.Forms.CheckBox();
            this.graph_min = new System.Windows.Forms.NumericUpDown();
            this.set_graph_max_enable = new System.Windows.Forms.CheckBox();
            this.graph_scale = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.graph_speed = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graph_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datalogger_options_panel = new System.Windows.Forms.Panel();
            this.graph_trigger = new System.Windows.Forms.CheckBox();
            this.datalogger_overwrite_radiobutton = new System.Windows.Forms.RadioButton();
            this.datalogger_append_radiobutton = new System.Windows.Forms.RadioButton();
            this.datalogger_checkbox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.power_percent = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tx_repeater_delay = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.alert_messege = new System.Windows.Forms.NotifyIcon(this.components);
            this.temperature_group = new System.Windows.Forms.GroupBox();
            this.ext_temp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.int_temp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.flow_text_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.temp_up_down = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.set_temperature_apply = new System.Windows.Forms.Button();
            this.serial_options_group.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.read_options_group.SuspendLayout();
            this.dsiplayas_options_panel.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.write_options_group.SuspendLayout();
            this.tx_num_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.send_delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.send_repeat)).BeginInit();
            this.tx_radiobuttons_panel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.plotter_option_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.graph_menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.datalogger_options_panel.SuspendLayout();
            this.temperature_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temp_up_down)).BeginInit();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(19, 13);
            this.connect.Margin = new System.Windows.Forms.Padding(4);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(133, 38);
            this.connect.TabIndex = 0;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // portConfig
            // 
            this.portConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portConfig.FormattingEnabled = true;
            this.portConfig.Location = new System.Drawing.Point(84, 25);
            this.portConfig.Margin = new System.Windows.Forms.Padding(4);
            this.portConfig.Name = "portConfig";
            this.portConfig.Size = new System.Drawing.Size(80, 24);
            this.portConfig.TabIndex = 1;
            this.portConfig.Click += new System.EventHandler(this.portConfig_Click);
            // 
            // baudrateConfig
            // 
            this.baudrateConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudrateConfig.FormattingEnabled = true;
            this.baudrateConfig.Location = new System.Drawing.Point(84, 60);
            this.baudrateConfig.Margin = new System.Windows.Forms.Padding(4);
            this.baudrateConfig.Name = "baudrateConfig";
            this.baudrateConfig.Size = new System.Drawing.Size(80, 24);
            this.baudrateConfig.TabIndex = 2;
            // 
            // databitsConfig
            // 
            this.databitsConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databitsConfig.FormattingEnabled = true;
            this.databitsConfig.Location = new System.Drawing.Point(84, 96);
            this.databitsConfig.Margin = new System.Windows.Forms.Padding(4);
            this.databitsConfig.Name = "databitsConfig";
            this.databitsConfig.Size = new System.Drawing.Size(80, 24);
            this.databitsConfig.TabIndex = 3;
            // 
            // stopbitsConfig
            // 
            this.stopbitsConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.stopbitsConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopbitsConfig.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.stopbitsConfig.FormattingEnabled = true;
            this.stopbitsConfig.Location = new System.Drawing.Point(276, 25);
            this.stopbitsConfig.Margin = new System.Windows.Forms.Padding(4);
            this.stopbitsConfig.Name = "stopbitsConfig";
            this.stopbitsConfig.Size = new System.Drawing.Size(79, 24);
            this.stopbitsConfig.TabIndex = 4;
            // 
            // parityConfig
            // 
            this.parityConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityConfig.FormattingEnabled = true;
            this.parityConfig.Location = new System.Drawing.Point(276, 61);
            this.parityConfig.Margin = new System.Windows.Forms.Padding(4);
            this.parityConfig.Name = "parityConfig";
            this.parityConfig.Size = new System.Drawing.Size(79, 24);
            this.parityConfig.TabIndex = 5;
            // 
            // serial_options_group
            // 
            this.serial_options_group.Controls.Add(this.flowconrol_label);
            this.serial_options_group.Controls.Add(this.baudrate_label);
            this.serial_options_group.Controls.Add(this.flowcontrolConfig);
            this.serial_options_group.Controls.Add(this.parity_label);
            this.serial_options_group.Controls.Add(this.port_label);
            this.serial_options_group.Controls.Add(this.portConfig);
            this.serial_options_group.Controls.Add(this.baudrateConfig);
            this.serial_options_group.Controls.Add(this.parityConfig);
            this.serial_options_group.Controls.Add(this.stopbitsConfig);
            this.serial_options_group.Controls.Add(this.stopbits_label);
            this.serial_options_group.Controls.Add(this.databitsConfig);
            this.serial_options_group.Controls.Add(this.databits_label);
            this.serial_options_group.Location = new System.Drawing.Point(19, 63);
            this.serial_options_group.Margin = new System.Windows.Forms.Padding(4);
            this.serial_options_group.Name = "serial_options_group";
            this.serial_options_group.Padding = new System.Windows.Forms.Padding(4);
            this.serial_options_group.Size = new System.Drawing.Size(368, 160);
            this.serial_options_group.TabIndex = 9;
            this.serial_options_group.TabStop = false;
            this.serial_options_group.Text = "Serial port options";
            // 
            // flowconrol_label
            // 
            this.flowconrol_label.AutoSize = true;
            this.flowconrol_label.Location = new System.Drawing.Point(183, 98);
            this.flowconrol_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flowconrol_label.Name = "flowconrol_label";
            this.flowconrol_label.Size = new System.Drawing.Size(87, 17);
            this.flowconrol_label.TabIndex = 13;
            this.flowconrol_label.Text = "Flow control:";
            // 
            // baudrate_label
            // 
            this.baudrate_label.AutoSize = true;
            this.baudrate_label.Location = new System.Drawing.Point(7, 64);
            this.baudrate_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baudrate_label.Name = "baudrate_label";
            this.baudrate_label.Size = new System.Drawing.Size(70, 17);
            this.baudrate_label.TabIndex = 8;
            this.baudrate_label.Text = "Baudrate:";
            // 
            // flowcontrolConfig
            // 
            this.flowcontrolConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flowcontrolConfig.FormattingEnabled = true;
            this.flowcontrolConfig.Location = new System.Drawing.Point(276, 96);
            this.flowcontrolConfig.Margin = new System.Windows.Forms.Padding(4);
            this.flowcontrolConfig.Name = "flowcontrolConfig";
            this.flowcontrolConfig.Size = new System.Drawing.Size(79, 24);
            this.flowcontrolConfig.TabIndex = 12;
            // 
            // parity_label
            // 
            this.parity_label.AutoSize = true;
            this.parity_label.Location = new System.Drawing.Point(183, 64);
            this.parity_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.parity_label.Name = "parity_label";
            this.parity_label.Size = new System.Drawing.Size(48, 17);
            this.parity_label.TabIndex = 11;
            this.parity_label.Text = "Parity:";
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Location = new System.Drawing.Point(9, 28);
            this.port_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(38, 17);
            this.port_label.TabIndex = 7;
            this.port_label.Text = "Port:";
            // 
            // stopbits_label
            // 
            this.stopbits_label.AutoSize = true;
            this.stopbits_label.Location = new System.Drawing.Point(181, 28);
            this.stopbits_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stopbits_label.Name = "stopbits_label";
            this.stopbits_label.Size = new System.Drawing.Size(67, 17);
            this.stopbits_label.TabIndex = 10;
            this.stopbits_label.Text = "Stop bits:";
            // 
            // databits_label
            // 
            this.databits_label.AutoSize = true;
            this.databits_label.Location = new System.Drawing.Point(8, 100);
            this.databits_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.databits_label.Name = "databits_label";
            this.databits_label.Size = new System.Drawing.Size(68, 17);
            this.databits_label.TabIndex = 9;
            this.databits_label.Text = "Data bits:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byte_counter_label,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 733);
            this.statusStrip1.MinimumSize = new System.Drawing.Size(759, 31);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(832, 31);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // byte_counter_label
            // 
            this.byte_counter_label.Name = "byte_counter_label";
            this.byte_counter_label.Size = new System.Drawing.Size(0, 25);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(50, 25);
            this.toolStripStatusLabel2.Text = "About";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(6, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(101, 26);
            this.toolStripStatusLabel1.Text = "No Connection";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(19, 231);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 498);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.rx_textarea);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.read_options_group);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(789, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Read";
            // 
            // rx_textarea
            // 
            this.rx_textarea.BackColor = System.Drawing.Color.White;
            this.rx_textarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rx_textarea.ContextMenuStrip = this.contextMenuStrip1;
            this.rx_textarea.DetectUrls = false;
            this.rx_textarea.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rx_textarea.HideSelection = false;
            this.rx_textarea.Location = new System.Drawing.Point(24, 94);
            this.rx_textarea.Margin = new System.Windows.Forms.Padding(4);
            this.rx_textarea.Name = "rx_textarea";
            this.rx_textarea.ReadOnly = true;
            this.rx_textarea.Size = new System.Drawing.Size(711, 375);
            this.rx_textarea.TabIndex = 29;
            this.rx_textarea.Text = "";
            this.rx_textarea.TextChanged += new System.EventHandler(this.rx_textarea_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 28);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clear_rx_textarea_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(547, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Ext.";
            // 
            // read_options_group
            // 
            this.read_options_group.Controls.Add(this.dsiplayas_options_panel);
            this.read_options_group.Controls.Add(this.label4);
            this.read_options_group.Location = new System.Drawing.Point(24, 20);
            this.read_options_group.Margin = new System.Windows.Forms.Padding(4);
            this.read_options_group.Name = "read_options_group";
            this.read_options_group.Padding = new System.Windows.Forms.Padding(4);
            this.read_options_group.Size = new System.Drawing.Size(711, 66);
            this.read_options_group.TabIndex = 26;
            this.read_options_group.TabStop = false;
            this.read_options_group.Text = "Read Options";
            // 
            // dsiplayas_options_panel
            // 
            this.dsiplayas_options_panel.Controls.Add(this.display_hex_radiobutton);
            this.dsiplayas_options_panel.Controls.Add(this.display_string_radiobutton);
            this.dsiplayas_options_panel.Location = new System.Drawing.Point(111, 22);
            this.dsiplayas_options_panel.Margin = new System.Windows.Forms.Padding(4);
            this.dsiplayas_options_panel.Name = "dsiplayas_options_panel";
            this.dsiplayas_options_panel.Size = new System.Drawing.Size(307, 31);
            this.dsiplayas_options_panel.TabIndex = 18;
            // 
            // display_hex_radiobutton
            // 
            this.display_hex_radiobutton.AutoSize = true;
            this.display_hex_radiobutton.Location = new System.Drawing.Point(84, 6);
            this.display_hex_radiobutton.Margin = new System.Windows.Forms.Padding(4);
            this.display_hex_radiobutton.Name = "display_hex_radiobutton";
            this.display_hex_radiobutton.Size = new System.Drawing.Size(53, 21);
            this.display_hex_radiobutton.TabIndex = 26;
            this.display_hex_radiobutton.Text = "Hex";
            this.display_hex_radiobutton.UseVisualStyleBackColor = true;
            // 
            // display_string_radiobutton
            // 
            this.display_string_radiobutton.AutoSize = true;
            this.display_string_radiobutton.Checked = true;
            this.display_string_radiobutton.Location = new System.Drawing.Point(4, 6);
            this.display_string_radiobutton.Margin = new System.Windows.Forms.Padding(4);
            this.display_string_radiobutton.Name = "display_string_radiobutton";
            this.display_string_radiobutton.Size = new System.Drawing.Size(66, 21);
            this.display_string_radiobutton.TabIndex = 25;
            this.display_string_radiobutton.TabStop = true;
            this.display_string_radiobutton.Text = "String";
            this.display_string_radiobutton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Display as:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(461, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(72, 22);
            this.textBox1.TabIndex = 31;
            this.textBox1.Text = "0.00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Int.";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tx_terminal);
            this.tabPage3.Controls.Add(this.write_options_group);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(789, 469);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Write";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tx_terminal
            // 
            this.tx_terminal.BackColor = System.Drawing.Color.White;
            this.tx_terminal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_terminal.ContextMenuStrip = this.contextMenuStrip2;
            this.tx_terminal.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_terminal.HideSelection = false;
            this.tx_terminal.Location = new System.Drawing.Point(25, 180);
            this.tx_terminal.Margin = new System.Windows.Forms.Padding(4);
            this.tx_terminal.Name = "tx_terminal";
            this.tx_terminal.ReadOnly = true;
            this.tx_terminal.Size = new System.Drawing.Size(709, 284);
            this.tx_terminal.TabIndex = 30;
            this.tx_terminal.Text = "";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(113, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(112, 24);
            this.toolStripMenuItem1.Text = "Clear";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // write_options_group
            // 
            this.write_options_group.Controls.Add(this.tx_num_panel);
            this.write_options_group.Controls.Add(this.tx_radiobuttons_panel);
            this.write_options_group.Controls.Add(this.progressBar1);
            this.write_options_group.Controls.Add(this.send_status);
            this.write_options_group.Controls.Add(this.sendData);
            this.write_options_group.Controls.Add(this.tx_textarea);
            this.write_options_group.Enabled = false;
            this.write_options_group.Location = new System.Drawing.Point(24, 20);
            this.write_options_group.Margin = new System.Windows.Forms.Padding(4);
            this.write_options_group.Name = "write_options_group";
            this.write_options_group.Padding = new System.Windows.Forms.Padding(4);
            this.write_options_group.Size = new System.Drawing.Size(711, 148);
            this.write_options_group.TabIndex = 25;
            this.write_options_group.TabStop = false;
            this.write_options_group.Text = "Write Options";
            // 
            // tx_num_panel
            // 
            this.tx_num_panel.Controls.Add(this.send_delay);
            this.tx_num_panel.Controls.Add(this.send_repeat);
            this.tx_num_panel.Controls.Add(this.label1);
            this.tx_num_panel.Controls.Add(this.label2);
            this.tx_num_panel.Location = new System.Drawing.Point(37, 98);
            this.tx_num_panel.Margin = new System.Windows.Forms.Padding(4);
            this.tx_num_panel.Name = "tx_num_panel";
            this.tx_num_panel.Size = new System.Drawing.Size(337, 33);
            this.tx_num_panel.TabIndex = 31;
            // 
            // send_delay
            // 
            this.send_delay.Location = new System.Drawing.Point(252, 5);
            this.send_delay.Margin = new System.Windows.Forms.Padding(4);
            this.send_delay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.send_delay.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.send_delay.Name = "send_delay";
            this.send_delay.Size = new System.Drawing.Size(71, 22);
            this.send_delay.TabIndex = 21;
            this.send_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.send_delay.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // send_repeat
            // 
            this.send_repeat.Location = new System.Drawing.Point(72, 5);
            this.send_repeat.Margin = new System.Windows.Forms.Padding(4);
            this.send_repeat.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.send_repeat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.send_repeat.Name = "send_repeat";
            this.send_repeat.Size = new System.Drawing.Size(71, 22);
            this.send_repeat.TabIndex = 22;
            this.send_repeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.send_repeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Repeats:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Delay (ms):";
            // 
            // tx_radiobuttons_panel
            // 
            this.tx_radiobuttons_panel.Controls.Add(this.write_form_file_radiobutton);
            this.tx_radiobuttons_panel.Controls.Add(this.key_capture_radiobutton);
            this.tx_radiobuttons_panel.Controls.Add(this.send_word_radiobutton);
            this.tx_radiobuttons_panel.Location = new System.Drawing.Point(39, 34);
            this.tx_radiobuttons_panel.Margin = new System.Windows.Forms.Padding(4);
            this.tx_radiobuttons_panel.Name = "tx_radiobuttons_panel";
            this.tx_radiobuttons_panel.Size = new System.Drawing.Size(368, 26);
            this.tx_radiobuttons_panel.TabIndex = 27;
            // 
            // write_form_file_radiobutton
            // 
            this.write_form_file_radiobutton.AutoSize = true;
            this.write_form_file_radiobutton.Location = new System.Drawing.Point(261, 0);
            this.write_form_file_radiobutton.Margin = new System.Windows.Forms.Padding(4);
            this.write_form_file_radiobutton.Name = "write_form_file_radiobutton";
            this.write_form_file_radiobutton.Size = new System.Drawing.Size(83, 21);
            this.write_form_file_radiobutton.TabIndex = 20;
            this.write_form_file_radiobutton.Text = "From file";
            this.write_form_file_radiobutton.UseVisualStyleBackColor = true;
            this.write_form_file_radiobutton.CheckedChanged += new System.EventHandler(this.write_form_file_radiobutton_CheckedChanged);
            // 
            // key_capture_radiobutton
            // 
            this.key_capture_radiobutton.AutoSize = true;
            this.key_capture_radiobutton.Location = new System.Drawing.Point(131, 0);
            this.key_capture_radiobutton.Margin = new System.Windows.Forms.Padding(4);
            this.key_capture_radiobutton.Name = "key_capture_radiobutton";
            this.key_capture_radiobutton.Size = new System.Drawing.Size(105, 21);
            this.key_capture_radiobutton.TabIndex = 19;
            this.key_capture_radiobutton.Text = "Key capture";
            this.key_capture_radiobutton.UseVisualStyleBackColor = true;
            this.key_capture_radiobutton.CheckedChanged += new System.EventHandler(this.key_capture_radiobutton_CheckedChanged);
            // 
            // send_word_radiobutton
            // 
            this.send_word_radiobutton.AutoSize = true;
            this.send_word_radiobutton.Checked = true;
            this.send_word_radiobutton.Location = new System.Drawing.Point(0, 0);
            this.send_word_radiobutton.Margin = new System.Windows.Forms.Padding(4);
            this.send_word_radiobutton.Name = "send_word_radiobutton";
            this.send_word_radiobutton.Size = new System.Drawing.Size(96, 21);
            this.send_word_radiobutton.TabIndex = 18;
            this.send_word_radiobutton.TabStop = true;
            this.send_word_radiobutton.Text = "Send word";
            this.send_word_radiobutton.UseVisualStyleBackColor = true;
            this.send_word_radiobutton.CheckedChanged += new System.EventHandler(this.send_word_radiobutton_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar1.Location = new System.Drawing.Point(39, 90);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(515, 4);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 26;
            this.progressBar1.Visible = false;
            // 
            // send_status
            // 
            this.send_status.AutoSize = true;
            this.send_status.Location = new System.Drawing.Point(392, 106);
            this.send_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.send_status.Name = "send_status";
            this.send_status.Size = new System.Drawing.Size(0, 17);
            this.send_status.TabIndex = 25;
            // 
            // sendData
            // 
            this.sendData.Location = new System.Drawing.Point(563, 59);
            this.sendData.Margin = new System.Windows.Forms.Padding(4);
            this.sendData.Name = "sendData";
            this.sendData.Size = new System.Drawing.Size(84, 31);
            this.sendData.TabIndex = 13;
            this.sendData.Text = "Send";
            this.sendData.UseVisualStyleBackColor = true;
            this.sendData.Click += new System.EventHandler(this.sendData_Click);
            // 
            // tx_textarea
            // 
            this.tx_textarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tx_textarea.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_textarea.Location = new System.Drawing.Point(39, 60);
            this.tx_textarea.Margin = new System.Windows.Forms.Padding(4);
            this.tx_textarea.Name = "tx_textarea";
            this.tx_textarea.Size = new System.Drawing.Size(513, 29);
            this.tx_textarea.TabIndex = 14;
            this.tx_textarea.Click += new System.EventHandler(this.tx_textarea_Click);
            this.tx_textarea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_textarea_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.plotter_option_group);
            this.tabPage2.Controls.Add(this.graph);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(789, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plotter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // plotter_option_group
            // 
            this.plotter_option_group.Controls.Add(this.graph_max);
            this.plotter_option_group.Controls.Add(this.set_graph_min_enable);
            this.plotter_option_group.Controls.Add(this.graph_min);
            this.plotter_option_group.Controls.Add(this.set_graph_max_enable);
            this.plotter_option_group.Controls.Add(this.graph_scale);
            this.plotter_option_group.Controls.Add(this.label3);
            this.plotter_option_group.Controls.Add(this.graph_speed);
            this.plotter_option_group.Controls.Add(this.label7);
            this.plotter_option_group.Location = new System.Drawing.Point(24, 20);
            this.plotter_option_group.Margin = new System.Windows.Forms.Padding(4);
            this.plotter_option_group.Name = "plotter_option_group";
            this.plotter_option_group.Padding = new System.Windows.Forms.Padding(4);
            this.plotter_option_group.Size = new System.Drawing.Size(722, 79);
            this.plotter_option_group.TabIndex = 25;
            this.plotter_option_group.TabStop = false;
            this.plotter_option_group.Text = "Plotter options";
            // 
            // graph_max
            // 
            this.graph_max.AutoSize = true;
            this.graph_max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graph_max.Enabled = false;
            this.graph_max.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.graph_max.Location = new System.Drawing.Point(97, 35);
            this.graph_max.Margin = new System.Windows.Forms.Padding(4);
            this.graph_max.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.graph_max.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.graph_max.Name = "graph_max";
            this.graph_max.Size = new System.Drawing.Size(101, 22);
            this.graph_max.TabIndex = 28;
            this.graph_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.graph_max.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.graph_max.ValueChanged += new System.EventHandler(this.graph_max_ValueChanged);
            // 
            // set_graph_min_enable
            // 
            this.set_graph_min_enable.AutoSize = true;
            this.set_graph_min_enable.Location = new System.Drawing.Point(206, 35);
            this.set_graph_min_enable.Margin = new System.Windows.Forms.Padding(4);
            this.set_graph_min_enable.Name = "set_graph_min_enable";
            this.set_graph_min_enable.Size = new System.Drawing.Size(81, 21);
            this.set_graph_min_enable.TabIndex = 27;
            this.set_graph_min_enable.Text = "Set Min:";
            this.set_graph_min_enable.UseVisualStyleBackColor = true;
            this.set_graph_min_enable.CheckedChanged += new System.EventHandler(this.set_graph_min_enable_CheckedChanged);
            // 
            // graph_min
            // 
            this.graph_min.AutoSize = true;
            this.graph_min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graph_min.Enabled = false;
            this.graph_min.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.graph_min.Location = new System.Drawing.Point(295, 35);
            this.graph_min.Margin = new System.Windows.Forms.Padding(4);
            this.graph_min.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.graph_min.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.graph_min.Name = "graph_min";
            this.graph_min.Size = new System.Drawing.Size(101, 22);
            this.graph_min.TabIndex = 26;
            this.graph_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.graph_min.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.graph_min.ValueChanged += new System.EventHandler(this.graph_min_ValueChanged);
            // 
            // set_graph_max_enable
            // 
            this.set_graph_max_enable.AutoSize = true;
            this.set_graph_max_enable.Location = new System.Drawing.Point(8, 36);
            this.set_graph_max_enable.Margin = new System.Windows.Forms.Padding(4);
            this.set_graph_max_enable.Name = "set_graph_max_enable";
            this.set_graph_max_enable.Size = new System.Drawing.Size(84, 21);
            this.set_graph_max_enable.TabIndex = 25;
            this.set_graph_max_enable.Text = "Set Max:";
            this.set_graph_max_enable.UseVisualStyleBackColor = true;
            this.set_graph_max_enable.CheckedChanged += new System.EventHandler(this.set_graph_max_enable_CheckedChanged);
            // 
            // graph_scale
            // 
            this.graph_scale.AutoSize = true;
            this.graph_scale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graph_scale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.graph_scale.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.graph_scale.Location = new System.Drawing.Point(457, 36);
            this.graph_scale.Margin = new System.Windows.Forms.Padding(4);
            this.graph_scale.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.graph_scale.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.graph_scale.Name = "graph_scale";
            this.graph_scale.Size = new System.Drawing.Size(91, 22);
            this.graph_scale.TabIndex = 19;
            this.graph_scale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.graph_scale.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.graph_scale.ValueChanged += new System.EventHandler(this.graph_scale_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Points:";
            // 
            // graph_speed
            // 
            this.graph_speed.AllowDrop = true;
            this.graph_speed.AutoSize = true;
            this.graph_speed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graph_speed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.graph_speed.Location = new System.Drawing.Point(623, 36);
            this.graph_speed.Margin = new System.Windows.Forms.Padding(4);
            this.graph_speed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.graph_speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.graph_speed.Name = "graph_speed";
            this.graph_speed.Size = new System.Drawing.Size(91, 22);
            this.graph_speed.TabIndex = 17;
            this.graph_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.graph_speed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.graph_speed.ValueChanged += new System.EventHandler(this.graph_speed_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(550, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Interval:";
            // 
            // graph
            // 
            this.graph.BorderlineWidth = 0;
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BorderColor = System.Drawing.Color.Maroon;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea1);
            this.graph.ContextMenuStrip = this.graph_menu;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.MaximumAutoSize = 20F;
            legend1.Name = "Legend1";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Near;
            legend1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graph.Legends.Add(legend1);
            this.graph.Location = new System.Drawing.Point(1, 102);
            this.graph.Margin = new System.Windows.Forms.Padding(4);
            this.graph.Name = "graph";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(123)))), ((int)(((byte)(182)))));
            series1.Legend = "Legend1";
            series1.Name = "var 1";
            series1.YValuesPerPoint = 32;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            series2.Legend = "Legend1";
            series2.Name = "var 2";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(163)))), ((int)(((byte)(84)))));
            series3.Legend = "Legend1";
            series3.Name = "var 3";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(170)))), ((int)(((byte)(79)))));
            series4.Legend = "Legend1";
            series4.Name = "var 4";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(81)))), ((int)(((byte)(154)))));
            series5.Legend = "Legend1";
            series5.Name = "var 5";
            this.graph.Series.Add(series1);
            this.graph.Series.Add(series2);
            this.graph.Series.Add(series3);
            this.graph.Series.Add(series4);
            this.graph.Series.Add(series5);
            this.graph.Size = new System.Drawing.Size(733, 367);
            this.graph.TabIndex = 16;
            this.graph.Text = "chart2";
            // 
            // graph_menu
            // 
            this.graph_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.graph_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsImageToolStripMenuItem,
            this.clearToolStripMenuItem1});
            this.graph_menu.Name = "clear_graph";
            this.graph_menu.Size = new System.Drawing.Size(174, 52);
            // 
            // saveAsImageToolStripMenuItem
            // 
            this.saveAsImageToolStripMenuItem.Name = "saveAsImageToolStripMenuItem";
            this.saveAsImageToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.saveAsImageToolStripMenuItem.Text = "Save as image";
            this.saveAsImageToolStripMenuItem.Click += new System.EventHandler(this.saveAsImageToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(173, 24);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.clear_graph_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datalogger_options_panel);
            this.groupBox1.Location = new System.Drawing.Point(395, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(216, 160);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // datalogger_options_panel
            // 
            this.datalogger_options_panel.Controls.Add(this.graph_trigger);
            this.datalogger_options_panel.Controls.Add(this.datalogger_overwrite_radiobutton);
            this.datalogger_options_panel.Controls.Add(this.datalogger_append_radiobutton);
            this.datalogger_options_panel.Controls.Add(this.datalogger_checkbox);
            this.datalogger_options_panel.Location = new System.Drawing.Point(9, 25);
            this.datalogger_options_panel.Margin = new System.Windows.Forms.Padding(4);
            this.datalogger_options_panel.Name = "datalogger_options_panel";
            this.datalogger_options_panel.Size = new System.Drawing.Size(197, 111);
            this.datalogger_options_panel.TabIndex = 28;
            // 
            // graph_trigger
            // 
            this.graph_trigger.AutoSize = true;
            this.graph_trigger.BackColor = System.Drawing.Color.Transparent;
            this.graph_trigger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.graph_trigger.Cursor = System.Windows.Forms.Cursors.Default;
            this.graph_trigger.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graph_trigger.Location = new System.Drawing.Point(4, 70);
            this.graph_trigger.Margin = new System.Windows.Forms.Padding(4);
            this.graph_trigger.MaximumSize = new System.Drawing.Size(533, 23);
            this.graph_trigger.Name = "graph_trigger";
            this.graph_trigger.Size = new System.Drawing.Size(170, 23);
            this.graph_trigger.TabIndex = 30;
            this.graph_trigger.Text = "Trigger graph plotter";
            this.graph_trigger.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.graph_trigger.UseVisualStyleBackColor = false;
            this.graph_trigger.CheckedChanged += new System.EventHandler(this.graph_trigger_CheckedChanged);
            // 
            // datalogger_overwrite_radiobutton
            // 
            this.datalogger_overwrite_radiobutton.AutoSize = true;
            this.datalogger_overwrite_radiobutton.Enabled = false;
            this.datalogger_overwrite_radiobutton.Location = new System.Drawing.Point(90, 38);
            this.datalogger_overwrite_radiobutton.Margin = new System.Windows.Forms.Padding(4);
            this.datalogger_overwrite_radiobutton.Name = "datalogger_overwrite_radiobutton";
            this.datalogger_overwrite_radiobutton.Size = new System.Drawing.Size(89, 21);
            this.datalogger_overwrite_radiobutton.TabIndex = 29;
            this.datalogger_overwrite_radiobutton.Text = "Overwrite";
            this.datalogger_overwrite_radiobutton.UseVisualStyleBackColor = true;
            // 
            // datalogger_append_radiobutton
            // 
            this.datalogger_append_radiobutton.AutoSize = true;
            this.datalogger_append_radiobutton.Checked = true;
            this.datalogger_append_radiobutton.Enabled = false;
            this.datalogger_append_radiobutton.Location = new System.Drawing.Point(4, 37);
            this.datalogger_append_radiobutton.Margin = new System.Windows.Forms.Padding(4);
            this.datalogger_append_radiobutton.Name = "datalogger_append_radiobutton";
            this.datalogger_append_radiobutton.Size = new System.Drawing.Size(78, 21);
            this.datalogger_append_radiobutton.TabIndex = 28;
            this.datalogger_append_radiobutton.TabStop = true;
            this.datalogger_append_radiobutton.Text = "Append";
            this.datalogger_append_radiobutton.UseVisualStyleBackColor = true;
            // 
            // datalogger_checkbox
            // 
            this.datalogger_checkbox.AutoSize = true;
            this.datalogger_checkbox.BackColor = System.Drawing.Color.Transparent;
            this.datalogger_checkbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.datalogger_checkbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.datalogger_checkbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datalogger_checkbox.Location = new System.Drawing.Point(4, 4);
            this.datalogger_checkbox.Margin = new System.Windows.Forms.Padding(4);
            this.datalogger_checkbox.MaximumSize = new System.Drawing.Size(533, 23);
            this.datalogger_checkbox.Name = "datalogger_checkbox";
            this.datalogger_checkbox.Size = new System.Drawing.Size(158, 23);
            this.datalogger_checkbox.TabIndex = 15;
            this.datalogger_checkbox.Text = "Enable data logger";
            this.datalogger_checkbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.datalogger_checkbox.UseVisualStyleBackColor = false;
            this.datalogger_checkbox.CheckedChanged += new System.EventHandler(this.datalogger_checkbox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Heat (%):";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // power_percent
            // 
            this.power_percent.Location = new System.Drawing.Point(81, 55);
            this.power_percent.Name = "power_percent";
            this.power_percent.ReadOnly = true;
            this.power_percent.Size = new System.Drawing.Size(98, 22);
            this.power_percent.TabIndex = 29;
            this.power_percent.Text = "0.00";
            this.power_percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.power_percent.TextChanged += new System.EventHandler(this.power_percent_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "log_file";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.FileName = "figure";
            this.saveFileDialog1.Filter = "PNG|.png| JPEG|.jpg";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // alert_messege
            // 
            this.alert_messege.Text = "notifyIcon1";
            this.alert_messege.Visible = true;
            // 
            // temperature_group
            // 
            this.temperature_group.Controls.Add(this.ext_temp);
            this.temperature_group.Controls.Add(this.label12);
            this.temperature_group.Controls.Add(this.int_temp);
            this.temperature_group.Controls.Add(this.label11);
            this.temperature_group.Controls.Add(this.power_percent);
            this.temperature_group.Controls.Add(this.label5);
            this.temperature_group.Controls.Add(this.flow_text_box);
            this.temperature_group.Controls.Add(this.label8);
            this.temperature_group.Location = new System.Drawing.Point(619, 63);
            this.temperature_group.Margin = new System.Windows.Forms.Padding(4);
            this.temperature_group.Name = "temperature_group";
            this.temperature_group.Padding = new System.Windows.Forms.Padding(4);
            this.temperature_group.Size = new System.Drawing.Size(197, 160);
            this.temperature_group.TabIndex = 29;
            this.temperature_group.TabStop = false;
            this.temperature_group.Text = "Data";
            // 
            // ext_temp
            // 
            this.ext_temp.Location = new System.Drawing.Point(81, 116);
            this.ext_temp.Name = "ext_temp";
            this.ext_temp.ReadOnly = true;
            this.ext_temp.Size = new System.Drawing.Size(98, 22);
            this.ext_temp.TabIndex = 35;
            this.ext_temp.Text = "0.00";
            this.ext_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 34;
            this.label12.Text = "External:";
            // 
            // int_temp
            // 
            this.int_temp.Location = new System.Drawing.Point(81, 85);
            this.int_temp.Name = "int_temp";
            this.int_temp.ReadOnly = true;
            this.int_temp.Size = new System.Drawing.Size(98, 22);
            this.int_temp.TabIndex = 33;
            this.int_temp.Text = "0.00";
            this.int_temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Internal:";
            // 
            // flow_text_box
            // 
            this.flow_text_box.Location = new System.Drawing.Point(81, 24);
            this.flow_text_box.Name = "flow_text_box";
            this.flow_text_box.ReadOnly = true;
            this.flow_text_box.Size = new System.Drawing.Size(98, 22);
            this.flow_text_box.TabIndex = 31;
            this.flow_text_box.Text = "0.0";
            this.flow_text_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Flow rate:";
            // 
            // temp_up_down
            // 
            this.temp_up_down.DecimalPlaces = 2;
            this.temp_up_down.Location = new System.Drawing.Point(303, 22);
            this.temp_up_down.Margin = new System.Windows.Forms.Padding(4);
            this.temp_up_down.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.temp_up_down.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.temp_up_down.Name = "temp_up_down";
            this.temp_up_down.Size = new System.Drawing.Size(108, 22);
            this.temp_up_down.TabIndex = 3;
            this.temp_up_down.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Set point:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(696, 13);
            this.start_button.Margin = new System.Windows.Forms.Padding(4);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(116, 38);
            this.start_button.TabIndex = 30;
            this.start_button.Text = "Thermo Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // set_temperature_apply
            // 
            this.set_temperature_apply.Location = new System.Drawing.Point(428, 13);
            this.set_temperature_apply.Margin = new System.Windows.Forms.Padding(4);
            this.set_temperature_apply.Name = "set_temperature_apply";
            this.set_temperature_apply.Size = new System.Drawing.Size(117, 38);
            this.set_temperature_apply.TabIndex = 31;
            this.set_temperature_apply.Text = "Apply";
            this.set_temperature_apply.UseVisualStyleBackColor = true;
            this.set_temperature_apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(832, 764);
            this.Controls.Add(this.set_temperature_apply);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.temperature_group);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.temp_up_down);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.serial_options_group);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heat Transfer Lab";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.serial_options_group.ResumeLayout(false);
            this.serial_options_group.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.read_options_group.ResumeLayout(false);
            this.read_options_group.PerformLayout();
            this.dsiplayas_options_panel.ResumeLayout(false);
            this.dsiplayas_options_panel.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.write_options_group.ResumeLayout(false);
            this.write_options_group.PerformLayout();
            this.tx_num_panel.ResumeLayout(false);
            this.tx_num_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.send_delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.send_repeat)).EndInit();
            this.tx_radiobuttons_panel.ResumeLayout(false);
            this.tx_radiobuttons_panel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.plotter_option_group.ResumeLayout(false);
            this.plotter_option_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.graph_menu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.datalogger_options_panel.ResumeLayout(false);
            this.datalogger_options_panel.PerformLayout();
            this.temperature_group.ResumeLayout(false);
            this.temperature_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temp_up_down)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.ComboBox portConfig;
        private System.Windows.Forms.ComboBox baudrateConfig;
        private System.Windows.Forms.ComboBox databitsConfig;
        private System.Windows.Forms.ComboBox stopbitsConfig;
        private System.Windows.Forms.ComboBox parityConfig;
        private System.IO.Ports.SerialPort mySerial;
        private System.Windows.Forms.GroupBox serial_options_group;
        private System.Windows.Forms.Label parity_label;
        private System.Windows.Forms.Label stopbits_label;
        private System.Windows.Forms.Label databits_label;
        private System.Windows.Forms.Label baudrate_label;
        private System.Windows.Forms.Label port_label;
        private System.Windows.Forms.Label flowconrol_label;
        private System.Windows.Forms.ComboBox flowcontrolConfig;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button sendData;
        private System.Windows.Forms.TextBox tx_textarea;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown graph_speed;
        private System.Windows.Forms.Timer tx_repeater_delay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip graph_menu;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsImageToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.NumericUpDown graph_scale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox plotter_option_group;
        private System.Windows.Forms.CheckBox set_graph_min_enable;
        private System.Windows.Forms.NumericUpDown graph_min;
        private System.Windows.Forms.CheckBox set_graph_max_enable;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        protected System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.RadioButton write_form_file_radiobutton;
        private System.Windows.Forms.RadioButton key_capture_radiobutton;
        private System.Windows.Forms.RadioButton send_word_radiobutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown send_repeat;
        private System.Windows.Forms.NumericUpDown send_delay;
        private System.Windows.Forms.GroupBox write_options_group;
        private System.Windows.Forms.Panel datalogger_options_panel;
        private System.Windows.Forms.Label send_status;
        private System.Windows.Forms.NotifyIcon alert_messege;
        private System.Windows.Forms.RichTextBox rx_textarea;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton datalogger_overwrite_radiobutton;
        private System.Windows.Forms.RadioButton datalogger_append_radiobutton;
        private System.Windows.Forms.CheckBox datalogger_checkbox;
        private System.Windows.Forms.GroupBox read_options_group;
        private System.Windows.Forms.Panel dsiplayas_options_panel;
        private System.Windows.Forms.RadioButton display_hex_radiobutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton display_string_radiobutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox tx_terminal;
        private System.Windows.Forms.NumericUpDown graph_max;
        private System.Windows.Forms.ToolStripStatusLabel byte_counter_label;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel tx_num_panel;
        private System.Windows.Forms.Panel tx_radiobuttons_panel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox temperature_group;
        private System.Windows.Forms.NumericUpDown temp_up_down;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button set_temperature_apply;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox power_percent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ext_temp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox int_temp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox flow_text_box;
        private System.Windows.Forms.CheckBox graph_trigger;
    }
}

