using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZjatkovDV.Sprint3.Task3.V20.Lib
{
    public class DataService : ISprint3Task3V20
    {
        public int GetCharCount(string value, char item)
        {
            int sum = 0;

            foreach (char c in value)
            {
                if (c == item)
                    sum++;
            }

            return sum;
        }
    }
}
