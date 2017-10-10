using HelperConversion;

namespace SmartValidations.ValueObjects
{
    /// <summary>
    /// CreditCard value object
    /// </summary>
    public class CreditCard : IValidation
    {
        /// <summary>
        /// Create CreditCard Value Object
        /// </summary>
        /// <param name="number">credit card number</param>
        public CreditCard(string number)
        {
            Number = number.GetOnlyNumbers();
        }

        /// <summary>
        /// CreditCard number
        /// </summary>
        public string Number { get; private set; }

        /// <summary>
        /// Check if credit card number is valid
        /// </summary>
        /// <returns>true or false</returns>
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
