using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class TRAIN
    {
        public string Destination; // пункт назначения
        public int TrNumber;       // номер поезда
        public string StartTime;   // время отправления
                                   //   DateTime DT;

        public TRAIN(string destination, int trNumber, string startTime)
        {
            Destination = destination;
            TrNumber = trNumber;
            StartTime = startTime;
            //DT = dT;
        }
        public TRAIN()
        {
            Destination = "NoWay";
            TrNumber = -1;
            StartTime = "NoTime";
            // DT = new DateTime(); // 01.01.0001 0:00:00
        }

        public override string ToString()
        {
            return
                "Пункта назначения: " + Destination +
                "  Номер поезда: " + TrNumber +
                "  Время отправления: " + StartTime;
        }
    }
}