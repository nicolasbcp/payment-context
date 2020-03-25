using PaymentContext.Shared.ValuesObject;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValuesObject
    {
        public Email(string address)
        {
            Address = address;

        }
        public string Address { get; private set; }
    }
}