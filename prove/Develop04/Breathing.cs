using System;
using System.Threading;

namespace MindfulnessApp
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity(int _duration) : base("Breathing", "This activity will guide you through a calming breathing exercise to help you relax and reduce stress.", _duration)
        {
        }

        protected override void PerformActivity()
        {
            Console.WriteLine("Prepare to begin breathing...");
            SpinnerAnimation(3); // Display spinner animation for 3 seconds

            Console.WriteLine("Start breathing...");

            int _breathCycles = _duration / 6; // 6 seconds per breath cycle (3 seconds inhale + 3 seconds exhale)
            int _secondsRemaining = _duration % 6; // Remaining seconds after breath cycles

            for (int i = 1; i <= _breathCycles; i++)
            {
                BreatheIn();
                BreatheOut();
            }

            if (_secondsRemaining > 0)
            {
                if (_secondsRemaining >= 3)
                {
                    BreatheIn();
                    _secondsRemaining -= 3;
                }

                if (_secondsRemaining > 0)
                {
                    CountdownTimer(_secondsRemaining); // Countdown the remaining seconds
                }
            }
        }

        private void BreatheIn()
        {
            Console.WriteLine("Breathe in...");
            CountdownTimer(3); // Inhale for 3 seconds
        }

        private void BreatheOut()
        {
            Console.WriteLine("Breathe out...");
            CountdownTimer(3); // Exhale for 3 seconds
        }
    }
}