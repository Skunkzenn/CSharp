namespace Exceptions_Roles.Entities.Exceptions
{
    class DomainException : ApplicationException 
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
