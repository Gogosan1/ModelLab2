using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;

namespace conveyorSystem
{
    public class Model
    {
        public List<HandlerOfRequests> Handlers { get; private set; }
        public int modelingTime;
        private double arrivalTimeOfRequest;
        private double requestProsessingTime;
        private const int OneMinute = 60;
        private int counterOfRefusal;
        private int numberOfHandlers;
        private int queueSize;
        private Random rnd; 
        public Model(int modelingTime, int queueSize, int numberOfHandlers, Random rnd)
        {
            this.rnd = rnd;
            if (modelingTime <= 0)
                throw new Exception("время не может быть отрицательным");
            this.modelingTime = modelingTime * OneMinute;
            if (queueSize < 0)
                throw new Exception("размер очереди не может быть отрицательным");
            this.queueSize = queueSize;
            if (numberOfHandlers <= 0)
                throw new Exception("количество обработчиков не может быть отрицательным");
            this.numberOfHandlers = numberOfHandlers;
            arrivalTimeOfRequest = 0;
            requestProsessingTime = 0;
            counterOfRefusal = 0;
            Handlers = new List<HandlerOfRequests>();
        }

        public void Modeling()
        {
            // Создание обработчиков заявок
            for (int i = 0; i < numberOfHandlers; i++)
                Handlers.Add(new HandlerOfRequests(modelingTime, queueSize, rnd));

            int counterOfRequests = 0;

            while (true)
            {
                // создание времени прихода заявки в секундах
                double randomValue = rnd.NextDouble();
                const int intensivnostPerMinute = 4;
                arrivalTimeOfRequest += randomValue * OneMinute / intensivnostPerMinute;
                
                // подсчёт пришедших заявок
                counterOfRequests++;

                // заканчиваем моделирование
                if (arrivalTimeOfRequest > modelingTime)
                    break;


                // обработка заявки
                bool flagOfProcessing = false;
                for (int i = 0; i <  Handlers.Count; i++) 
                {
                    double arrivalTime = arrivalTimeOfRequest;
                    if (Handlers[i].IsFreeWhenProsessing(arrivalTimeOfRequest))
                    {
                        flagOfProcessing = true;
                        break;
                    }
                    arrivalTime += OneMinute;
                }
               
                // считаем количество отказов
                if (!flagOfProcessing) 
                {
                    counterOfRefusal++;
                }

            }

            FalureProbability = Math.Round((double)counterOfRefusal/counterOfRequests, 2);
            ServiceProbability = 1 - FalureProbability;

            for (int i = 0; i < Handlers.Count; i++)
            {
                Handlers[i].FinalCollectionOfStatistics();
            }

           // ModelingDone.Invoke();
        }
       // public event Action ModelingDone;
        public double ServiceProbability { get; private set; }
        public double FalureProbability { get; private set; }
    }
}
