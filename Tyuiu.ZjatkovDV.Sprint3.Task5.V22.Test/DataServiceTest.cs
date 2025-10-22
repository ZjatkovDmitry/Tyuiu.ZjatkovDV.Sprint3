using Tyuiu.ZjatkovDV.Sprint3.Task5.V22.Lib;

namespace Tyuiu.ZjatkovDV.Sprint3.Task5.V22.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckCalc()
        {
            var result = new DataService();
            Assert.Equal(2.991, result.GetSumSumSeries(2, 1, 1, 3, 12));
        }
    }
}