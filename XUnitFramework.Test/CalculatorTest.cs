using Moq;
using XUnitFramework.Controllers;
using XUnitFramework.Repository;

namespace XUnitFramework.Test;

public class CalculatorTest
{

    private readonly Mock<ICalculatorRepository> _calculatorRepositoryMock;

    public CalculatorTest(){
        _calculatorRepositoryMock = new Mock<ICalculatorRepository>();
    }

    [Theory]
    [InlineData(2, 4)]
    [InlineData(0,3)]
    [InlineData(9,12)]
    public void Test1(int a, int b)
    {
        //Arrange
        CalcutorController calculator = new CalcutorController(_calculatorRepositoryMock.Object);
        _calculatorRepositoryMock.Setup(x => x.Sum(It.IsAny<int>(),It.IsAny<int>()))
            .Returns(Sum(a,b));


        //Act
        var actual = calculator.Sum(1, 2);

        //Assert

        Assert.Equal(actual, Sum(a,b));
    }

    private int Sum(int a, int b)
    {
        return a + b;
    }
}
