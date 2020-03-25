using Flunt.Validations;
using PaymentContext.Shared.ValuesObject;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValuesObject
    {
        public Email(string address)
        {
            Address = address;

            AddNotifications(new Contract()
                .Requires()
                .IsEmail(Address, "Email.Address", "E-mail inválido.")
            );

        }
        public string Address { get; private set; }
    }
}