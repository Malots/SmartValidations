using HelperConversion;

namespace SmartValidations.ValueObjects
{
    /// <summary>
    /// PIS value object
    /// </summary>
    public class PIS : IValidation
    {
        /// <summary>
        /// Create PIS value object
        /// </summary>
        /// <param name="pis">pis value</param>
        public PIS(string pis)
        {
            Pis = pis.GetOnlyNumbers();
        }

        /// <summary>
        /// Pis value
        /// </summary>
        public string Pis { get; private set; }

        /// <summary>
        /// Check PIS is valid
        /// </summary>
        /// <returns>true or false</returns>
        public bool IsValid()
        {
            int[] mult = new int[10] { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int sum;
            int rest;
            if (Pis.Length != 11)
                return false;
            Pis = Pis.PadLeft(11, '0');
            sum = 0;
            for (int i = 0; i < 10; i++)
                sum += int.Parse(Pis[i].ToString()) * mult[i];
            rest = sum % 11;
            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;
            return Pis.EndsWith(rest.ToString());
        }
    }
}
