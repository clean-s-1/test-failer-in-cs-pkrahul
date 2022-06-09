using System;
using System.Diagnostics;

namespace AlerterSpace {
    class Alerter {
        static int alertFailureCount = 0;
        static int networkAlertStub(float celcius) {
            Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
            int statusCode = validateTemperature(celcius);
            return statusCode;
        }
        static int validateTemperature(float celcius)
        {
           return celcius <= 25 ? 200 : 500;
        }
        static void alertInCelcius(float farenheit) {
            float celcius = (farenheit - 32) * 5 / 9;
            int returnCode = networkAlertStub(celcius);
            if (returnCode != 200) {
                alertFailureCount += 1;
            }
        }
        static void Main(string[] args) {
            alertInCelcius(400.5f);
            alertInCelcius(303.6f);
            Debug.Assert(alertFailureCount == 2);
            Console.WriteLine("{0} alerts failed.", alertFailureCount);
            Console.WriteLine("All is well (maybe!)\n");
        }
    }
}
