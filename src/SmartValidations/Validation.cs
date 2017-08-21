using System;

namespace SmartValidations
{
    public class Validation<T> : IValidation<T>
    {
        public bool IsValid(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
