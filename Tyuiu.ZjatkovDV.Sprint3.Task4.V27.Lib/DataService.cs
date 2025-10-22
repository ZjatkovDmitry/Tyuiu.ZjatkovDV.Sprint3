using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZjatkovDV.Sprint3.Task4.V27.Lib
{
    public class DataService : ISprint3Task4V27
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                    continue;

                double y = x / (Math.Cos(x) + Math.Sin(x));
                sum += y;
            }

            return Math.Round(sum, 3);
        }
    }
}
