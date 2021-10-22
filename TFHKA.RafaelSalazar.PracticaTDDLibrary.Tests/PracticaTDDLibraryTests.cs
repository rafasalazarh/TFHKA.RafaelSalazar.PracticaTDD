using NUnit.Framework;

namespace TFHKA.RafaelSalazar.PracticaTDDLibrary.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Library_When_PrimeroMayor_ReturnMayor([Values(5)] int value1, [Values(1)] int value2)
        {
            //Arrange
            int input1 = value1;
            int input2 = value2;

            //Act
            string output = PracticaTDDL.GetBigger(input1, input2);

            //Assert
            Assert.AreEqual("El primero es el mayor", output);
        }

        [Test]
        public void Library_When_SegundoMayor_ReturnMayor([Values(1)] int value1, [Values(5)] int value2)
        {
            //Arrange
            int input1 = value1;
            int input2 = value2;

            //Act
            string output = PracticaTDDL.GetBigger(input1, input2);

            //Assert
            Assert.AreEqual("El segundo es el mayor", output);
        }

        [Test]
        public void Sumar_When_ReturnSuma([Values(5)] int value1, [Values(1)] int value2)
        {
            //Arrange
            int input1 = value1;
            int input2 = value2;

            //Act
            int output = PracticaTDDL.GetSum(input1, input2);

            //Assert
            Assert.AreEqual(input1 + input2, output);
        }

        [Test]
        public void Restar_When_ReturnResta([Values(5)] int value1, [Values(1)] int value2)
        {
            //Arrange
            int input1 = value1;
            int input2 = value2;

            //Act
            int output = PracticaTDDL.GetSubstraction(input1, input2);

            //Assert
            Assert.AreEqual(input1 - input2, output);
        }

        [Test]
        public void Multiplicar_When_ReturnMultiplicar([Values(5)] int value1, [Values(1)] int value2)
        {
            //Arrange
            int input1 = value1;
            int input2 = value2;

            //Act
            int output = PracticaTDDL.GetMultiply(input1, input2);

            //Assert
            Assert.AreEqual(input1 * input2, output);
        }
    }
}