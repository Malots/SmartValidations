using HelperConversion;

namespace SmartValidations.ValueObjects
{
    public class CNPJ : IValidation
    {
        public CNPJ(string cnpj)
        {
            Cnpj = cnpj.GetOnlyNumbers();
        }

        public string Cnpj { get; private set; }

        public bool IsValid()
        {
            int[] multOne = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multTwo = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int sum;
            int rest;
            string digit;
            string tempCnpj;
            if (Cnpj.Length != 14)
                return false;
            tempCnpj = Cnpj.Substring(0, 12);
            sum = 0;
            for (int i = 0; i < 12; i++)
                sum += int.Parse(tempCnpj[i].ToString()) * multOne[i];
            rest = (sum % 11);
            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;
            digit = rest.ToString();
            tempCnpj = tempCnpj + digit;
            sum = 0;
            for (int i = 0; i < 13; i++)
                sum += int.Parse(tempCnpj[i].ToString()) * multTwo[i];
            rest = (sum % 11);
            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;
            digit = digit + rest.ToString();
            return Cnpj.EndsWith(digit);
        }
    }
}
