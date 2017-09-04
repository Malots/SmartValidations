using HelperConversion;

namespace SmartValidations.ValueObjects
{
    public class CreditCard : IValidation
    {
        public CreditCard(string number)
        {
            Number = number.GetOnlyNumbers();
        }

        public string Number { get; private set; }

        public bool IsValid()
        {
            int idLength = Number.Length;
            int currentDigit;
            int idSum = 0;
            int currentProcNum = 0; 

            for (int i = idLength - 1; i >= 0; i--)
            {
                string idCurrentRightmostDigit = Number.Substring(i, 1);

                if (!int.TryParse(idCurrentRightmostDigit, out currentDigit))
                    return false;
                if (currentProcNum % 2 != 0)
                {
                    if ((currentDigit *= 2) > 9)
                        currentDigit -= 9;
                }
                currentProcNum++; 
                idSum += currentDigit;
            }
            return (idSum % 10 == 0);
        }
    }
}
