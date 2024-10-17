using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MusinND.Sprint2.Task2.V23
{
    public class DataService : ISprint2Task2V23
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x == 3 && ((y >= 3 && y <= 5) || (y >= 9 && y <= 12))) ||
                (x == 5 && y >= 3 && y <= 12) ||
                ((x >= 6 && x <= 8) && y >= 7 && y <= 13) ||
                ((x == 9 || x == 10) && y >= 6 && y <= 12) ||
                (x == 11 && y >= 3 && y <= 13) ||
                (x == 12 && ((y >= 7 && y <= 10) || (y == 12 || y == 13))))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
