using HelperConversion;

namespace SmartValidations.ValueObjects
{
    public class CPF : IValidation
    {
        public CPF(string cpf)
        {
            Cpf = cpf.GetOnlyNumbers();
        }

        public string Cpf { get; private set; }

        public bool IsValid()
        {
            int[] multOne = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multTwo = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            switch (Cpf)
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
            string tempCpf;
            string digit;
            int sum;
            int rest;
            if (Cpf.Length != 11)
                return false;
            tempCpf = Cpf.Substring(0, 9);
            sum = 0;
            for (int i = 0; i < 9; i++)
                sum += int.Parse(tempCpf[i].ToString()) * multOne[i];
            rest = sum % 11;
            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;
            digit = rest.ToString();
            tempCpf = tempCpf + digit;
            sum = 0;
            for (int i = 0; i < 10; i++)
                sum += int.Parse(tempCpf[i].ToString()) * multTwo[i];
            rest = sum % 11;
            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;
            digit = digit + rest.ToString();
            return Cpf.EndsWith(digit);
        }
    }
}
