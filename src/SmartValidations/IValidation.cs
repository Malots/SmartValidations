namespace SmartValidations
{
    /// <summary>
    /// Interface validation
    /// </summary>
    public interface IValidation
    {
        /// <summary>
        /// Chech if value object is valid
        /// </summary>
        /// <returns>true or false</returns>
        bool IsValid();
    }
}
