using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MusinND.Sprint2.Task4.V10.Lib
{
    public class DataService : ISprint2Task4V10
    {
        public double Calculate(double x, double y)
        {
            double z = (x * Math.Pow(2, x) < y / 3)
            ? Math.Pow(1 + (3 / y), x)
            : y + 10 * x - (5 / x);
            z = Math.Round(z, 3);
            return z;
        }
    }
}
