using System;
using System.Collections.Generic;

namespace Seriallab
{
    public class RampSoakStep
    {
        public double Target { get; set; }
        public double RampRate { get; set; } // °C per second
        public double SoakSeconds { get; set; }
    }

    public class RampSoakProfile
    {
        public string Name { get; set; }
        public List<RampSoakStep> Steps { get; set; } = new List<RampSoakStep>();
    }

    public class RampSoakEngine
    {
        public RampSoakProfile Profile { get; private set; }
        public int StepIndex { get; private set; }
        public double CurrentSP { get; private set; }

        private DateTime stepStart;
        private double startValue;

        public bool Running { get; private set; }

        public void Start(RampSoakProfile profile, double initialValue)
        {
            Profile = profile;
            StepIndex = 0;
            startValue = initialValue;
            stepStart = DateTime.Now;
            Running = true;
        }

        public void Stop()
        {
            Running = false;
        }

        public void Update()
        {
            if (!Running || Profile == null) return;

            var step = Profile.Steps[StepIndex];
            double elapsed = (DateTime.Now - stepStart).TotalSeconds;

            double rampTime = Math.Abs(step.Target - startValue) / step.RampRate;

            if (elapsed < rampTime)
            {
                // Ramp
                CurrentSP = startValue + (step.Target - startValue) * (elapsed / rampTime);
            }
            else if (elapsed < rampTime + step.SoakSeconds)
            {
                // Soak
                CurrentSP = step.Target;
            }
            else
            {
                // Next step
                StepIndex++;

                if (StepIndex >= Profile.Steps.Count)
                {
                    Stop();
                    return;
                }

                startValue = step.Target;
                stepStart = DateTime.Now;
            }
        }
    }
}