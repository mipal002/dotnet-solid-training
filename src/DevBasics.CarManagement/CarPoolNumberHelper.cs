using System;

namespace DevBasics.CarManagement
{
    public static class CarPoolNumberHelper
    {
        public static void Generate(ICarRegistrationNumberGenerator requestOrigin, string endCustomerRegistrationReference, out string registrationRegistrationId, out string registrationNumber)
        {
            registrationRegistrationId = GenerateRegistrationRegistrationId();

            registrationNumber = requestOrigin.GenerateRegistrationNumber(endCustomerRegistrationReference, registrationRegistrationId);
        }

        public static string GenerateRegistrationRegistrationId() //vlt in DateUtil.cs auslagern und Methode GetCurrentTicksAsString benennen
        {
            return DateTime.Now.Ticks.ToString();
        }
    }
}