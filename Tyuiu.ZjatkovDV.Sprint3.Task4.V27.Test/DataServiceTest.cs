using Tyuiu.ZjatkovDV.Sprint3.Task4.V27.Lib;

namespace Tyuiu.ZjatkovDV.Sprint3.Task4.V27.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckCalc()
        {
            var result = new DataService();
            Assert.Equal(-44.313, result.Calculate(-5, 5));
        }
    }
}