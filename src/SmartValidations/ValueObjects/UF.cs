using System.Linq;

namespace SmartValidations.ValueObjects
{
    public class UF : IValidation
    {
        public UF(string initials)
        {
            Initials = initials.ToUpper().Trim();
        }

        public string Initials { get; private set; }

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
