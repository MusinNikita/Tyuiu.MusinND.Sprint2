using System.Diagnostics;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MusinND.Sprint2.Task1.V24.Lib
{
    public class DataService : ISprint2Task1V24
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] results = new bool[6];

            results[0] = (a == b) | (c < d);
            results[1] = (a != b) & (c > d);
            results[2] = (c <= d) || (b >= a);
            results[3] = (a > d) && (c > d);
            results[4] = !(b == c);
            results[5] = (b == c) ^ (a < d);              


            Console.WriteLine(results);
            return results;
        }
    }
}
