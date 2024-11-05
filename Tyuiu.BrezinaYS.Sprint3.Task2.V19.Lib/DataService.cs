using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BrezinaYS.Sprint3.Task2.V19.Lib
{
    public class DataService : ISprint3Task2V19
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double res = 0;
            do
            {
                res = res + (Math.Cos(startValue) * (1.0 / 2));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(res, 3);

        }
    }
}
