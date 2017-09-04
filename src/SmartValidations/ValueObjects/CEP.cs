using HelperConversion;

namespace SmartValidations.ValueObjects
{
    public class CEP : IValidation
    {
        public CEP(string number, string uf = "")
        {
            Number = number.GetOnlyNumbers();
            UF = new UF(uf);
        }

        public string Number { get; private set; }
        public UF UF { get; private set; }

        public bool IsValid()
        {
            if (Number.Length != 8)
                return false;
            if (UF.Initials != "")
            {
                if (!UF.IsValid())
                    return false;
            }
            //TODO: Validar CEP
            return false;
        }
    }
}
