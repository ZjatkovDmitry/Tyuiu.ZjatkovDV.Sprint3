using Tyuiu.ZjatkovDV.Sprint3.Task7.V11.Lib;

namespace Tyuiu.ZjatkovDV.Sprint3.Task7.V11.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckGetSumTheDivisors()
        {
            var result = new DataService();
            Assert.Equal([20.36, 15.42, 10.99, 7.43, 4.33, 1, 0, -8.87, -13.03, -16.53, -19.60], result.GetMassFunction(-5, 5));
        }
    }
}