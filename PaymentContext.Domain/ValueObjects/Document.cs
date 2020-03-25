using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValuesObject;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValuesObject
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }
    }
}