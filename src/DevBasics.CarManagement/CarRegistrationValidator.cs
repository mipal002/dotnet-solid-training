
using DevBasics.CarManagement.Dependencies;

public class CarRegistrationValidator {


    public bool HasMissingData(CarRegistrationModel car)
        {
            return (string.IsNullOrWhiteSpace(car.CompanyId))
                        || (string.IsNullOrWhiteSpace(car.VehicleIdentificationNumber))
                            || (string.IsNullOrWhiteSpace(car.CustomerId))
                                || car.DeliveryDate == null
                                    || (string.IsNullOrWhiteSpace(car.ErpDeliveryNumber));
        }
}