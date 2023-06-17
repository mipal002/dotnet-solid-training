using DevBasics.CarManagement.Dependencies;

public class RegistrationNumberGeneratorFord : ICarRegistrationNumberGenerator
{
    public CarBrand validFor => CarBrand.Ford;

    public string GenerateRegistrationNumber(string endCustomerRegistrationReference, string registrationRegistrationId)
    {
        return string.IsNullOrWhiteSpace(endCustomerRegistrationReference) ? registrationRegistrationId : endCustomerRegistrationReference;
    }
}