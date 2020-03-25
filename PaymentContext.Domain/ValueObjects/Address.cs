using Flunt.Validations;
using PaymentContext.Shared.ValuesObject;

namespace PaymentContext.Domain.ValueObjects
{
    public class Address : ValuesObject
    {
        public Address(
            string street, 
            string number, 
            string neighborhood, 
            string city, 
            string state, 
            string country, 
            string zipCode)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Street, 3, "Address.Street", "A rua deve conter no mínimo 3 caracteres.")
                .HasMinLen(Number, 1, "Address.Number", "O número deve conter no mínimo 1 caractere.")
                .HasMinLen(Neighborhood, 3, "Address.Neighborhood", "O bairro deve conter no mínimo 3 caracteres.")
                .HasMinLen(City, 3, "Address.City", "A cidade deve conter no mínimo 3 caracteres.")
                .HasMinLen(State, 2, "Address.State", "O estado deve conter no mínimo 2 caracteres.")
                .HasMinLen(Country, 2, "Address.Country", "O país deve conter no mínimo 2 caracteres.")
                .HasMinLen(ZipCode, 8, "Address.ZipCode", "O CEP deve conter no mínimo 8 caracteres.")
                .HasMaxLen(Street, 40, "Address.Street", "A rua deve conter no máximo 40 caracteres.")
                .HasMaxLen(Number, 6, "Address.Number", "O número deve conter no máximo 6 caracteres.")
                .HasMaxLen(Neighborhood, 20, "Address.Neighborhood", "O bairro deve conter no máximo 20 caracteres.")
                .HasMaxLen(City, 30, "Address.City", "A cidade deve conter no máximo 30 caracteres.")
                .HasMaxLen(State, 2, "Address.State", "O estado deve conter no máximo 2 caracteres.")
                .HasMaxLen(Country, 2, "Address.Country", "O país deve conter no máximo 2 caracteres.")
                .HasMaxLen(ZipCode, 8, "Address.ZipCode", "O CEP deve conter no máximo 8 caracteres.")
            );
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
    }
}