using Tyuiu.ZjatkovDV.Sprint3.Task6.V23.Lib;

namespace Tyuiu.ZjatkovDV.Sprint3.Task6.V23.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckGetSumTheDivisors()
        {
            var result = new DataService();
            Assert.Equal(34, result.GetSumTheDivisors(18, 28));
        }
    }
}