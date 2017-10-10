using HelperConversion;

namespace SmartValidations.ValueObjects
{
    /// <summary>
    /// Cep value object
    /// </summary>
    public class CEP : IValidation
    {
        /// <summary>
        /// Create only cep or cep and UF
        /// </summary>
        /// <param name="number">string with cep number</param>
        /// <param name="uf">string with UF initial</param>
        public CEP(string number, string uf = "")
        {
            Number = number.GetOnlyNumbers();
            UF = new UF(uf);
        }

        /// <summary>
        /// Cep Number
        /// </summary>
        public string Number { get; private set; }

        /// <summary>
        /// Cel UF
        /// </summary>
        public UF UF { get; private set; }

        /// <summary>
        /// Check if CEp is valid
        /// </summary>
        /// <returns>true or false</returns>
        public bool IsValid()
        {
            if (Number.Length != 8)
                return false;
            if (UF.Initials != "")
            {
                if (!UF.IsValid())
                    return false;
            }
            if ((Number.ToInt32(0) >= "01000000".ToInt32()) && (Number.ToInt32(0) <= "19999999".ToInt32(0)) && (UF.Initials == "SP" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "20000000".ToInt32()) && (Number.ToInt32(0) <= "28999999".ToInt32(0)) && (UF.Initials == "RJ" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "29000000".ToInt32()) && (Number.ToInt32(0) <= "29999999".ToInt32(0)) && (UF.Initials == "ES" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "30000000".ToInt32()) && (Number.ToInt32(0) <= "39999999".ToInt32(0)) && (UF.Initials == "MG" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "40000000".ToInt32()) && (Number.ToInt32(0) <= "48999999".ToInt32(0)) && (UF.Initials == "BA" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "49000000".ToInt32()) && (Number.ToInt32(0) <= "49999999".ToInt32(0)) && (UF.Initials == "SE" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "50000000".ToInt32()) && (Number.ToInt32(0) <= "56999999".ToInt32(0)) && (UF.Initials == "PE" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "57000000".ToInt32()) && (Number.ToInt32(0) <= "57999999".ToInt32(0)) && (UF.Initials == "AL" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "58000000".ToInt32()) && (Number.ToInt32(0) <= "58999999".ToInt32(0)) && (UF.Initials == "PB" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "59000000".ToInt32()) && (Number.ToInt32(0) <= "59999999".ToInt32(0)) && (UF.Initials == "RN" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "60000000".ToInt32()) && (Number.ToInt32(0) <= "63999999".ToInt32(0)) && (UF.Initials == "CE" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "64000000".ToInt32()) && (Number.ToInt32(0) <= "64999999".ToInt32(0)) && (UF.Initials == "PI" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "65000000".ToInt32()) && (Number.ToInt32(0) <= "65999999".ToInt32(0)) && (UF.Initials == "MA" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "66000000".ToInt32()) && (Number.ToInt32(0) <= "68899999".ToInt32(0)) && (UF.Initials == "PA" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "68900000".ToInt32()) && (Number.ToInt32(0) <= "68999999".ToInt32(0)) && (UF.Initials == "AP" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "69000000".ToInt32()) && (Number.ToInt32(0) <= "69299999".ToInt32(0)) && (UF.Initials == "AM" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "69300000".ToInt32()) && (Number.ToInt32(0) <= "69399999".ToInt32(0)) && (UF.Initials == "RR" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "69400000".ToInt32()) && (Number.ToInt32(0) <= "69899999".ToInt32(0)) && (UF.Initials == "AM" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "69900000".ToInt32()) && (Number.ToInt32(0) <= "69999999".ToInt32(0)) && (UF.Initials == "AC" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "70000000".ToInt32()) && (Number.ToInt32(0) <= "72799999".ToInt32(0)) && (UF.Initials == "DF" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "72800000".ToInt32()) && (Number.ToInt32(0) <= "72999999".ToInt32(0)) && (UF.Initials == "GO" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "73000000".ToInt32()) && (Number.ToInt32(0) <= "73699999".ToInt32(0)) && (UF.Initials == "DF" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "73700000".ToInt32()) && (Number.ToInt32(0) <= "76799999".ToInt32(0)) && (UF.Initials == "GO" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "77000000".ToInt32()) && (Number.ToInt32(0) <= "77999999".ToInt32(0)) && (UF.Initials == "TO" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "78000000".ToInt32()) && (Number.ToInt32(0) <= "78899999".ToInt32(0)) && (UF.Initials == "MT" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "76800000".ToInt32()) && (Number.ToInt32(0) <= "76999999".ToInt32(0)) && (UF.Initials == "RO" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "79000000".ToInt32()) && (Number.ToInt32(0) <= "79999999".ToInt32(0)) && (UF.Initials == "MS" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "80000000".ToInt32()) && (Number.ToInt32(0) <= "87999999".ToInt32(0)) && (UF.Initials == "PR" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "88000000".ToInt32()) && (Number.ToInt32(0) <= "89999999".ToInt32(0)) && (UF.Initials == "SC" || UF.Initials == ""))
                return true;
            if ((Number.ToInt32(0) >= "90000000".ToInt32()) && (Number.ToInt32(0) <= "99999999".ToInt32(0)) && (UF.Initials == "RS" || UF.Initials == ""))
                return true;
            return false;
        }
    }
}
