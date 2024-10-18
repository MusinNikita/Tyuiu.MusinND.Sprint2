using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MusinND.Sprint2.Task7.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            
            bool insideCircle = (x * x + y * y) <= 1;
            bool insideRegion = (y >= -x) && (y <= x);

            if (insideCircle && insideRegion)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
