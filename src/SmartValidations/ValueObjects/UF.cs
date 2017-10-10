using System.Linq;

namespace SmartValidations.ValueObjects
{
    /// <summary>
    /// UF value object
    /// </summary>
    public class UF : IValidation
    {
        /// <summary>
        /// Create UF value object
        /// </summary>
        /// <param name="initials">Initial value of UF</param>
        public UF(string initials)
        {
            Initials = initials.ToUpper().Trim();
        }

        /// <summary>
        /// UF initial
        /// </summary>
        public string Initials { get; private set; }

        /// <summary>
        /// Check UF is valid
        /// </summary>
        /// <returns>true or false</returns>
        public bool IsValid()
        {
            if (!string.IsNullOrEmpty(Initials))
            {
                return new string[]
                {
                "AC", "AL", "AP", "AM", "BA",
                "CE", "DF", "ES", "GO", "MA",
                "MT", "MS", "MG", "PA", "PB",
                "PR", "PE", "PI", "RJ", "RN",
                "RS", "RO", "RR", "SC", "SP",
                "SE", "TO"
                }.Contains(Initials);
            }
            return false;
        }
    }
}
