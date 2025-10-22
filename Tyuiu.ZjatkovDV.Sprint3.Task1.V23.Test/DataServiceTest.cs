using Tyuiu.ZjatkovDV.Sprint3.Task1.V23.Lib;

namespace Tyuiu.ZjatkovDV.Sprint3.Task1.V23.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckGetMultiplySeries()
        {
            var result = new DataService();
            Assert.Equal(0.071, result.GetMultiplySeries(5, 1, 5));
        }
    }
}