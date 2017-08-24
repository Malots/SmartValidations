using HelperConversion;
using System;

namespace SmartValidations.ValueObjects
{
    public class CNH : IValidation
    {
        public CNH(string cnh)
        {
            Cnh = cnh.GetOnlyNumbers();
        }

        public string Cnh { get; private set; }

        public bool IsValid()
        {
            if (Cnh.Length != 11)
                return false;
            switch (Cnh)
            {
                case "00000000000":
                    return false;
                case "11111111111":
                    return false;
                case "2222222222":
                    return false;
                case "33333333333":
                    return false;
                case "44444444444":
                    return false;
                case "55555555555":
                    return false;
                case "66666666666":
                    return false;
                case "77777777777":
                    return false;
                case "88888888888":
                    return false;
                case "99999999999":
                    return false;
            }
            int vBase = 0;
            int vSoma = 0;
            int vFator = 9;
            for (int i = 0; i <= 8; i++) {
                vSoma += (Convert.ToInt32(Cnh[i]) * vFator);
                vFator--;
            }
            int vResto = vSoma % 11;
            if (vResto == 10) 
              vBase = -2;
            if (vResto > 9)
              vResto = 0;
            string sResultado = vResto.ToString();
            vSoma = 0;
            vFator = 1;
            for (int i = 0; i <= 8; i++) {
                vSoma = vSoma + (Convert.ToInt32(Cnh[i]) * vFator);
                vFator++;
            }

            if ((vSoma % 11) + vBase < 0)
                vResto = 11 + (vSoma % 11) + vBase;

            if ((vSoma % 11) + vBase >= 0)
                vResto = (vSoma % 11) + vBase;

            if (vResto > 9)
              vResto = 0;

            sResultado = sResultado + vResto.ToString();

            if (Cnh.Substring(8, 2) == sResultado)
                return true;
            return false;
        }
    }
}
