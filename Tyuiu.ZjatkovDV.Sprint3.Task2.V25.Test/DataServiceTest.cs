using Tyuiu.ZjatkovDV.Sprint3.Task2.V25.Lib;

namespace Tyuiu.ZjatkovDV.Sprint3.Task2.V25.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckGetSumSeries()
        {
            var result = new DataService();
            Assert.Equal(16.016, result.GetSumSeries(5, 1, 13));
        }
    }
}