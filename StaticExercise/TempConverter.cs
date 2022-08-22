namespace MyApp // Note: actual namespace depends on the project name.
{
    static class TempConverter 
    {
        public static double FahrenheitToCelsius(double num) 
        {
            double result;

            result = ((num - 32.00) * (5.00 / 9.00));
            
            return result;
        }

        public static double CelsiusToFahrenheit(double num) 
        {
            double result;

            result = (num * (9.00 / 5.00)) + 32.00;

            return result;
        }
    }
}