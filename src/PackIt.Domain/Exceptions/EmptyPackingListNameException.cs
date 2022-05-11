using PackIt.Shared.Abstractions.Exceptions;

namespace PackIt.Domain.Exceptions
{
    public class EmptyPackingListNameException : PackItExceptionBase
    {
        public EmptyPackingListNameException() : base("Packing list name cannot be null or empty.")
        {

        }
    }
}
