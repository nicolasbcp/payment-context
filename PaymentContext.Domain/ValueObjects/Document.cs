using Flunt.Validations;
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

            AddNotifications(new Contract()
                .Requires()
                .IsTrue(Validate(), "Document.Number", "Documento inválido.")
            );
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }

        public bool Validate ()
        {
            if(Type == EDocumentType.CNPJ && Number.Length == 14)
            {
                return true;
            }

            if(Type == EDocumentType.CPF && Number.Length == 11)
            {
                return true;
            }

            return false;
        }
    }
}