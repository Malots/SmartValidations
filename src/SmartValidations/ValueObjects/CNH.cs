﻿using HelperConversion;

namespace SmartValidations.ValueObjects
{
    /// <summary>
    /// CNH value object
    /// </summary>
    public class CNH : IValidation
    {
        /// <summary>
        /// Create a CNH value object
        /// </summary>
        /// <param name="cnh">cnh value</param>
        public CNH(string cnh)
        {
            Cnh = cnh.GetOnlyNumbers();
        }

        /// <summary>
        /// CNH value
        /// </summary>
        public string Cnh { get; private set; }

        /// <summary>
        /// Check if CNH is valid
        /// </summary>
        /// <returns>true or false</returns>
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
            int baseValue = 0;
            int sum = 0;
            int factor = 9;
            for (int i = 0; i <= 8; i++) {
                sum += (Cnh[i].ToString().ToInt32(0) * factor);
                factor--;
            }
            int rest = sum % 11;
            if (rest == 10) 
              baseValue = -2;
            if (rest > 9)
              rest = 0;
            string result = rest.ToString();
            sum = 0;
            factor = 1;
            for (int i = 0; i <= 8; i++) {
                sum += (Cnh[i].ToString().ToInt32(0) * factor);
                factor++;
            }

            if (((sum % 11) + baseValue) < 0)
                rest = 11 + (sum % 11) + baseValue;

            if (((sum % 11) + baseValue) >= 0)
                rest = (sum % 11) + baseValue;

            if (rest > 9)
              rest = 0;

            result = result + rest.ToString();

            if (Cnh.Substring(9, 2) == result)
                return true;
            return false;
        }
    }
}
