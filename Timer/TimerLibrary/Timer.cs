using System.Collections.Generic;
using System.Threading;

namespace TimerLibrary
{
    public delegate void TimerEvent(object sender, TimerEventArg e);

    public class TimerEventArg
    {
        public string message { get; private set; }
        public int time { get; private set; }

        public TimerEventArg(string message, int time)
        {
            this.message = message;
            this.time = time;
        }
    }


    public class Timer
    {
        
        public event TimerEvent sendTimerEvent;

        public int waitingTime { get; private set; }
        private int countTime = 0;
        private bool runTimer;

        public Timer(int waitingTime)
        {
            this.waitingTime = waitingTime;
        }

        /// <summary>
        /// Метод для старта таймера
        /// </summary>
        public void Start()
        {
           while (countTime <= waitingTime)
           {
                Thread.Sleep(1000);
                countTime++;
           }

            ///Вызов события SendTimerEvent с проверкой существуют ли зарегистрированные события 
            if(sendTimerEvent != null)
            {
                sendTimerEvent(this, new TimerEventArg("Время установленное для таймера истекло", waitingTime));
            }
            countTime = 0;
        }

        /// <summary>
        /// Метод для регистрации обработчика события
        /// </summary>
        /// <param name="timerEvent">Принимает делегат вида TimerEvent</param>
        public void AddHandler(TimerEvent showMessage)
        {
            sendTimerEvent += showMessage;
        }

        /// <summary>
        /// Метод для удаления регистрации обработчика события
        /// </summary>
        /// <param name="timerEvent">Принимает делегат вида TimerEvent</param>
        public void RemoveHandler(TimerEvent showMessage)
        {
            sendTimerEvent -= showMessage;
        }
    }
}
