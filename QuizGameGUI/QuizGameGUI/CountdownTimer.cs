using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGameGUI.Views.HomeView_Views
{
    public class CountdownTimer
    {
        private Timer timer;
        private int secondsRemaining;
        private bool stoppedPrematurely = false;

        public event Action OnTimerElapsed;
        public event Action OnTimerStoppedPrematurely;

        public CountdownTimer(int seconds)
        {
            secondsRemaining = seconds;
        }

        public void Start()
        {
            timer = new Timer(TimerCallback, null, 0, 1000); // 1000ms = 1 second
        }

        private void TimerCallback(object state)
        {
            secondsRemaining--;

            if (secondsRemaining == 0 && stoppedPrematurely == false)
            {
                OnTimerElapsed?.Invoke(); // Call the event handler when the timer is finished
            }
        }

        public void Stop()
        {
            if (timer != null)
            {
                timer.Dispose();
                stoppedPrematurely = true;
                OnTimerStoppedPrematurely?.Invoke(); // Call the event handler for premature stopping
            }
        }

        public int GetTimeRemaining()
        {
            return secondsRemaining;
        }

        public bool WasStoppedPrematurely()
        {
            return stoppedPrematurely;
        }
    }


}

