using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Laba14._03.Test
{
    [TestClass]
    public class quadmatrixTest
    {
        [TestMethod]
        public void generateQuadTest()//тест на то что матрица 3 на 3
        {
            //arrange
            int n = 3;
            double a = 0;
            double b = 10;
            int expected = 9;
            //act
            quadMatrix A = new quadMatrix(n, a, b);
            int actual = A.Matrix.Length;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void toStringTest()//проверка на то что тустринг работает и не остается пустым
        {
            //arrange

            //act
            quadMatrix A = new quadMatrix(3, 0, 10);
            //assert
            Assert.IsNotNull(A.MatrixToString());
        }

        [TestMethod]
        public void operatorPlusTest()//тест на сложение матриц
        {
            //arrange
            int n = 3;
            quadMatrix A = new quadMatrix(n, 1, 1);
            quadMatrix B = new quadMatrix(n, 1, 1);
            double expected = 18;


            //act
            double actual = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    actual += (A+B).Matrix[i, j];
                }
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void incrementTest()//тестируем инкремент
        {
            //arrange
            int n = 3;
            quadMatrix A = new quadMatrix(n, 1, 1);
            double expected = 18;


            //act
            double actual = 0;
            A++;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    actual += A.Matrix[i, j];
                }
            //assert
            Assert.AreEqual(expected, actual);
        }
            
        [TestMethod]
        public void minusTest()//тестируем оператор вычитания
        {
            //arrange
            int n = 3;
            quadMatrix A = new quadMatrix(n, 1, 1);
            quadMatrix B = new quadMatrix(n, 1, 1);
            double expected = 1;


            //act
            double actual = 1;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    actual += (A-B).Matrix[i, j];
                }
            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void umnozhenieTest()//тестируем оператор умножения
        {
            //arrange
            int n = 3;
            quadMatrix A = new quadMatrix(n, 2, 2);
            quadMatrix B = new quadMatrix(n, 2, 2);
            double expected = 36;


            //act
            double actual = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    actual += (A * B).Matrix[i, j];
                }
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void umnozhenienachisloTest()//тестируем оператор умножения на число
        {
            //arrange
            int n = 3;
            quadMatrix A = new quadMatrix(n, 2, 2);
            double expected = 36;


            //act
            double actual = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    actual += (A * 2).Matrix[i, j];
                }
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
