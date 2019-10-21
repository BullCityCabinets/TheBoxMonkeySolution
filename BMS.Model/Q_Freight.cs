using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Model
{
    public class Q_Freight
    {
        public enum FreightMethod { Unspecified, Delivered_Multiplier, Truck, Intermodal, Flat_Fee_Per_Section };

        public bool isTruck;
        public int TruckCubesMax;
        public float TruckAdditional;



    }

    


}
