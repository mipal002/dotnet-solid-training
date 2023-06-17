using System;
using System.Collections.Generic;
using System.Linq;
using DevBasics.CarManagement.Dependencies;

namespace DevBasics.CarManagement
{
    public class CarPoolNumberHelper
    {

        private readonly IEnumerable<ICarRegistrationNumberGenerator> _generator;
        public CarPoolNumberHelper(IEnumerable<ICarRegistrationNumberGenerator> list){
            _generator = list;
        }

        public void Generate(CarBrand carBrand, string endCustomerRegistrationReference, out string registrationRegistrationId, out string registrationNumber)
        {
            var generator = _generator.Single(x => x.validFor.Equals(carBrand));
            registrationRegistrationId = GenerateRegistrationRegistrationId();
            registrationNumber = generator.GenerateRegistrationNumber(endCustomerRegistrationReference, registrationRegistrationId);
        }

        public string GenerateRegistrationRegistrationId() //vlt in DateUtil.cs auslagern und Methode GetCurrentTicksAsString benennen
        {
            return DateTime.Now.Ticks.ToString();
        }
    }
}