using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    public class Factory
    {
        DateTime UretimTarihi {  get; set; }
        public string SerialNo { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int DoorCount { get; set; }

        public Factory(string serialNo, string brand, string model, string color, int doorCount)
        {
            UretimTarihi = DateTime.Now;
            SerialNo = serialNo;
            Brand = brand;
            Model = model;
            Color = color;
            DoorCount = doorCount;
        }
    }
}
