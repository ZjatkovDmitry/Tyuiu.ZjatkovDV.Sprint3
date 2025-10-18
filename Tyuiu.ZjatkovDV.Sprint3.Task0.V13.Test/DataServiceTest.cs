using Tyuiu.ZjatkovDV.Sprint3.Task0.V13.Lib;

namespace Tyuiu.ZjatkovDV.Sprint3.Task0.V13.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckGetSumSeries()
        {
            var result = new DataService();
            Assert.Equal(0.298, result.GetSumSeries(0.5, 1, 20));
        }
    }
}