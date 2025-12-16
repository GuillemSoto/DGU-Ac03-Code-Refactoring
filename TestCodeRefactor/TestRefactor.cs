using Refactor;

namespace TestCodeRefactor
{
    public class TestRefactor
    {
        [Theory]
        [InlineData(0, 0, 0, 0, "El resultat és zero.")]

        [InlineData(1, 1, 1, 3, "El resultat és positiu.")]
        [InlineData(1, 1, 0, 2, "El resultat és positiu.")]
        [InlineData(1, 0, 1, 1, "El resultat és positiu.")]
        [InlineData(1, 0, 0, 1, "El resultat és positiu.")]
        [InlineData(0, 1, 1, 0, "El resultat és zero.")]
        [InlineData(0, 0, 1, 0, "El resultat és zero.")]

        [InlineData(3, 7, 9, 19, "El resultat és positiu.")]
        [InlineData(-4, 1, 9, 0, "El resultat és zero.")]
        [InlineData(6, 2, -8, 8, "El resultat és positiu.")]
        [InlineData(5, 0, 8, 5, "El resultat és positiu.")]
        public void TC3_Test_AfterRefactor_With_ConsoleOutput(int firstNum, int secondNum, int thirdNum, int expectedResult, string msgExpected)
        {
            //Arrange
            StringWriter msgResult = new StringWriter();
            Console.SetOut(msgResult);
            int result;

            //Act
            Program.CalculateResult(ref firstNum, ref secondNum, ref thirdNum, out result);

            //Assert
            Assert.Equal(expectedResult, result);
            Assert.Equal(msgExpected, msgResult.ToString());
        }

        [Fact]
        public void TC3_Test_FunctionMain_PrintMessages()
        {
            // Arrange
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            Program.Main(Array.Empty<string>());

            // Assert
            string result = output.ToString();

            Assert.Contains("Benvingut al programa de càlculs!", result);
            Assert.Contains("El resultat és positiu.", result);
            Assert.Contains("Finalitzant el programa...", result);
        }
    }
}
