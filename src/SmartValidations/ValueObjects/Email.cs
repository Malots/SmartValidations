using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SmartValidations.ValueObjects
{
    /// <summary>
    /// Email value object
    /// </summary>
    public class Email : IValidation
    {
        /// <summary>
        /// Create value object email
        /// </summary>
        /// <param name="address">email address</param>
        public Email(string address)
        {
            Address = address;
        }

        /// <summary>
        /// Email address value
        /// </summary>
        public string Address { get; private set; }

        /// <summary>
        /// Property for domain validation
        /// </summary>
        private bool invalid = false;

        /// <summary>
        /// Check if email address is valid
        /// </summary>
        /// <returns>true or false</returns>
        public bool IsValid()
        {
            invalid = false;
            if (String.IsNullOrEmpty(Address))
                return false;
            try
            {
                Address = Regex.Replace(Address, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;
            try
            {
                return Regex.IsMatch(Address,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        /// <summary>
        /// Check domain
        /// </summary>
        /// <param name="match">domain match</param>
        /// <returns>domain string</returns>
        private string DomainMapper(Match match)
        {
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }
    }
}
