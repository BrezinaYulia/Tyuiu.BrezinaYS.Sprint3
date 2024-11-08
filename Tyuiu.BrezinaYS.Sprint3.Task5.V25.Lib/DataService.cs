using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BrezinaYS.Sprint3.Task5.V25.Lib
{
    public class DataService : ISprint3Task5V25
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            int i, k;
            double res = 0;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (k = startValue2; k <= stopValue2; k++)
                {
                    res = res + (Math.Pow(x, k) + Math.Cos(k));
                }
            }
            return Math.Round(res, 3);
        }
    }
}
