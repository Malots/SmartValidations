using SmartValidations.ValueObjects;

namespace SmartValidations
{
    /// <summary>
    /// Webservices
    /// </summary>
    public static class Validation
    {
        /// <summary>
        /// Extension validation
        /// </summary>
        /// <param name="value">string value</param>
        /// <param name="op">type of validation</param>
        /// <returns>true or false</returns>
        public static bool IsValid(this string value, Options op)
        {
            switch (op)
            {
                case Options.CEP:
                    return new CEP(value).IsValid();
                case Options.CNH:
                    return new CNH(value).IsValid();
                case Options.CNPJ:
                    return new CNPJ(value).IsValid();
                case Options.CPF:
                    return new CPF(value).IsValid();
                case Options.CreditCard:
                    return new CreditCard(value).IsValid();
                case Options.Email:
                    return new Email(value).IsValid();
                case Options.PIS:
                    return new PIS(value).IsValid();
                case Options.UF:
                    return new UF(value).IsValid();
            }
            return false;
        }
    }
}
