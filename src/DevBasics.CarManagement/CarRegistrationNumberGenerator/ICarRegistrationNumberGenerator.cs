using DevBasics.CarManagement.Dependencies;

public interface ICarRegistrationNumberGenerator {
    string GenerateRegistrationNumber(string endCustomerRegistrationReference, string registrationRegistrationId);

    public CarBrand validFor { get; }
}