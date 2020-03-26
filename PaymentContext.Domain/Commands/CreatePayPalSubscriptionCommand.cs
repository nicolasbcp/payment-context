using System;
using PaymentContext.Domain.Enums;

namespace PaymentContext.Domain.Commands
{
    public class CreatePayPalSubscriptionCommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public string TransactionCode { get; set; }
        public string PaymentNumber { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string Owner { get; set; }
        public string DocumentType { get; set; }
        public EDocumentType OwnerDocumentType { get; set; }
        public string OwnerEmail { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}