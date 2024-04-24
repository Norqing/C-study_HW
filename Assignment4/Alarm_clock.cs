using System;
using System.Threading;

namespace clock {

    class AlarmClock
    {
        public event Action<AlarmClock> AlarmEvent;
        public event Action<AlarmClock> TickEvent;
        public ClockTime CurrentTime { get; private set; }
        public ClockTime AlarmTime { get; set; }
        private bool stop = false;

        private Timer timer;
        public AlarmClock()
        {
            CurrentTime = new ClockTime();
            TickEvent += c => Console.WriteLine("Tick!Tick!Tick!Now is :" + CurrentTime);
            AlarmEvent += c => Console.WriteLine("Ding! Your time is over!");
        }

        public void Run()
        {
            stop = false;
            Console.WriteLine("Clock is started!");
            timer = new Timer(TimerCallback, null, 0, 1000);
        }

        private void TimerCallback(object state)
        {
            DateTime now = DateTime.Now;
            CurrentTime = new ClockTime(now.Hour, now.Minute, now.Second);
            TickEvent?.Invoke(this);
            if (AlarmTime.Equals(CurrentTime))
            {
                AlarmEvent?.Invoke(this);
            }
        }

        public void Stop()
        {
            Console.WriteLine("Clock is stopped!");
            timer?.Change(Timeout.Infinite, Timeout.Infinite);
            timer?.Dispose();
        }
    }
    public class ClockTime
    {

        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public ClockTime(int hour = 0, int minute = 0, int second = 0)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }

        public bool isValid()
        {
            return Hour > 0 && Minute >= 0 && Second >= 0
                && Hour < 24 && Minute < 60 && Second < 60;
        }

        public override bool Equals(object obj)
        {
            var time = obj as ClockTime;
            return time != null &&
                   Hour == time.Hour &&
                   Minute == time.Minute &&
                   Second == time.Second;
        }

        public override int GetHashCode()
        {
            var hashCode = 114514119;
            hashCode = hashCode * -991999 + Hour.GetHashCode();
            hashCode = hashCode * -991999 + Minute.GetHashCode();
            hashCode = hashCode * -991999 + Second.GetHashCode();
            return hashCode;
        }
        public override string ToString()
        {
            return Hour + ":" + Minute + ":" + Second;
        }
    }
    class MainClass {
        static void Main(string[] args) {
            try {
                AlarmClock clock = new AlarmClock();
                clock.AlarmTime = new ClockTime(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second +5);
                clock.AlarmEvent += AlarmTime;
                int sum = 0;
                clock.TickEvent += (c => time_pass(c, ref sum));
                new Thread(clock.Run).Start(); 


                Console.WriteLine("press any key to stop.");
                Console.ReadKey();
                clock.Stop();

            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }private static void time_pass(AlarmClock clock,ref int sum)
        {
            ClockTime time = clock.CurrentTime;
            sum += 1;
        }

        public static void AlarmTime (AlarmClock clock) {
            ClockTime time = clock.CurrentTime;
            Console.WriteLine($"Alarm Event: {time.Hour}:{time.Minute}:{time.Second}");
            Console.WriteLine("Time is out!!Time is out!");
        }
    }
}
