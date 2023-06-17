public class RegistrationNumberGeneratorFord : ICarRegistrationNumberGenerator
{
    public string GenerateRegistrationNumber(string endCustomerRegistrationReference, string registrationRegistrationId)
    {
        return string.IsNullOrWhiteSpace(endCustomerRegistrationReference) ? registrationRegistrationId : endCustomerRegistrationReference;
    }
}