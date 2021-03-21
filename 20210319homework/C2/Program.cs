using System;
using static System.Net.Mime.MediaTypeNames;

namespace C2 {
    class Program {
        static void Main(string[] args) {
            MyAlarm myAlarm = new MyAlarm();
            myAlarm.OnTick += () => {
                Console.WriteLine("currentTime: " + myAlarm.currentTime);
            };
            myAlarm.OnAlarm += () => {
                Console.WriteLine("starting again.");
            };
            for (int i = 1; i <= 100; i++) {
                myAlarm.tick();
                
            }
        }
    }


    public class MyAlarm {
        public delegate void tickHandler();
        public delegate void alarmHandler();
        public event tickHandler OnTick;
        public event alarmHandler OnAlarm;
        public int currentTime;

        public MyAlarm() {
            currentTime = 0;
        }

        public void tick() {
            currentTime++;
            //check for alarming
            if (currentTime == 90) {
                alarm();
            }
            else OnTick();
        }

        public void alarm() {
            Console.WriteLine("alarming.........");

            currentTime = 0;
            OnAlarm();
        }
    }
}
