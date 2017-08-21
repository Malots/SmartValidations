namespace SmartValidations
{
    public interface IValidation<T>
    {
        bool IsValid(T obj);
    }
}
