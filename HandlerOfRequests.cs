using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;

namespace conveyorSystem
{
    public class HandlerOfRequests
    {
        public double RequestProssesingTime { get; set; }
        private int modelingTime;
        List<double> reqestInQueue = new List<double>();
        private int queueSize;
        private bool end;
        private Random rnd;
        public HandlerOfRequests(int modelingTime, int queueSize, Random rnd) 
        {
            this.rnd = rnd;
            end = false;
            this.modelingTime = modelingTime;
            if (queueSize < 0)
                throw new Exception("размер очереди не может быть меньше нуля");
            this.queueSize = queueSize;
            RequestProssesingTime = 0;
            totalDownTime = 0;
            totalWaitingTime = 0;
            totalProcessingTime = 0;
            counterOfServedRequests = 0;
        }

        public bool IsFreeWhenProsessing(double ArrivalRequestTime)
        {
            // удаление из очереди заявки если пришло время ее обработки
            if (reqestInQueue.Count == queueSize && queueSize != 0)
            {
                if (ArrivalRequestTime >= reqestInQueue[0])
                {
                    reqestInQueue.RemoveAt(0);
                } 
            }

            // если обработчик свободен, обрабатываем заявку
            if (ArrivalRequestTime > RequestProssesingTime && ArrivalRequestTime < modelingTime)
            {
                if (end == true)
                    return false;

                // обработать случай конца моделирования
                totalDownTime += ArrivalRequestTime - RequestProssesingTime;
                StartProsessing(ArrivalRequestTime);
                return true;
            }
            // если обработчик занят, добавляем заявку в очередь
            else if (reqestInQueue.Count != queueSize && queueSize != 0)
            {
                if (end == true)
                    return false;
                totalWaitingTime += RequestProssesingTime - ArrivalRequestTime;
                reqestInQueue.Add(RequestProssesingTime);
                StartProsessing(reqestInQueue[0]);

                return true;
            }
            else
                return false;
        }

        private void StartProsessing(double ArrivalRequestTime)
        {
            
            // время когда освободиться тот или иной обработчик
            double randomValue = rnd.NextDouble();
            double nnn = -(1.0 * 60) * Math.Log(randomValue);
            RequestProssesingTime = nnn + ArrivalRequestTime;
            
            if (RequestProssesingTime > modelingTime)
                end = true;
            else
            {
                totalProcessingTime += nnn;
                counterOfServedRequests++;
            }
        }


        public void FinalCollectionOfStatistics()
        {
            if (counterOfServedRequests > 0)
            {
                AverageDownTime = Math.Round(totalDownTime / counterOfServedRequests / 60, 2);
                AverageWaitingTime = Math.Round(totalWaitingTime / counterOfServedRequests / 60, 2);
                AverageProcessingTime = Math.Round(totalProcessingTime / counterOfServedRequests / 60, 2);
            }
        }
        private double totalDownTime;
        private double totalWaitingTime;
        private double totalProcessingTime;
        private int counterOfServedRequests;

        public double AverageDownTime { get; private set; }
        public double AverageWaitingTime { get; private set; }
        public double AverageProcessingTime { get; private set; }
    }
}
