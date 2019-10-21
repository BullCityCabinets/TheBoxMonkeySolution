using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Model
{ 
    public class Q_Style
    {
        public string ID;
        public enum Brand { ADV, ECH }
        public enum Construction { Premier, Allwood, Premium }
        public enum ADV_Hinges { Adjustable_6way, Gentle_Close }
        public enum ADV_Drawers { Standard, UM_16mm, SC_16mm }

        public string Fronts;
        public string Finish;
        public string Glaze;
        public float Multiplier;

    }
}
