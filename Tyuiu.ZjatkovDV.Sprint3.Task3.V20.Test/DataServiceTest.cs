using Tyuiu.ZjatkovDV.Sprint3.Task3.V20.Lib;

namespace Tyuiu.ZjatkovDV.Sprint3.Task3.V20.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckGetCharCount()
        {
            var result = new DataService();
            Assert.Equal(5, result.GetCharCount("gfft ntf f opf", 'f'));
        }
    }
}