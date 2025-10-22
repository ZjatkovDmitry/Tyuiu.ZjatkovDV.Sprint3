using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZjatkovDV.Sprint3.Task6.V23.Lib
{
    public class DataService : ISprint3Task6V23
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalCount = 0;

            for (int number = startValue; number <= stopValue; number++)
            {
                int divisorsCount = 0;

                for (int divisor = 1; divisor <= 10 && divisor <= number; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        divisorsCount++;
                    }
                }

                totalCount += divisorsCount;
            }

            return totalCount;
        }
    }
}
