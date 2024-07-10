using System;
using System.Windows.Forms;

namespace FitnessTracker.helpers
{
    internal class CountdownTimer
    {
        private readonly Timer timer;
        private int remainingTime;

        public event Action<int> Tick;
        public event Action Completed;

        public CountdownTimer(int countdownTimeInSeconds, int interval = 1000)
        {
            timer = new Timer();
            remainingTime = countdownTimeInSeconds;
            timer.Interval = interval;
            timer.Tick += OnTick;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        private void OnTick(object sender, EventArgs e)
        {
            remainingTime--;
            Tick?.Invoke(remainingTime);

            if (remainingTime <= 0)
            {
                timer.Stop();
                Completed?.Invoke();
            }
        }
    }
}
