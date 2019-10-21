using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Model
{
    public class Q_TaxDetails
    {

        public bool Tax_Freight_Bool;
        public float Tax_Freight_Rate;
        public string Tax_Freight_VerifiedBy;

        public bool Tax_Labor_Bool;
        public float Tax_Labor_Rate;
        public string Tax_Labor_VerifiedBy;

        public bool Tax_OSP_Bool;
        public float Tax_OSP_Rate;
        public string Tax_OSP_VerifiedBy;

        public bool Tax_Product_Bool;
        public float Tax_Product_Rate;
        public string Tax_Product_VerifiedBy;

        public bool ReqBond_Bool;
        public float ReqBond_Rate;

        public bool CCIP_OCIP_Bool;
        public float CCIP_OCIP_Rate;

        public string Other1_Name;
        public bool Other1_Bool;
        public float Other1_Rate;

        public string Other2_Name;
        public bool Other2_Bool;
        public float Other2_Rate;

        public string Verify_ID;
        public string Verify_Date;



    }
}
