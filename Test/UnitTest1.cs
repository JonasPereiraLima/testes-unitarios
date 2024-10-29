using newTalents;

namespace Test;

public class UnitTest1
{
    public Calculadora construirClass()
    {
        string data = "29/10/2024";
        Calculadora calculadora = new(data);
        return calculadora;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TestSomar(int number1, int number2, int result)
    {
        Calculadora calculadora = construirClass();

        int resultadoCalculadora = calculadora.Somar(number1, number2);

        Assert.Equal(result, resultadoCalculadora);
    }

    [Theory]
    [InlineData(10, 2, 8)]
    [InlineData(40, 5, 35)]
    public void TestSubtrair(int number1, int number2, int result)
    {
        Calculadora calculadora = construirClass();

        int resultadoCalculadora = calculadora.Subtrair(number1, number2);

        Assert.Equal(result, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TestMultiplicar(int number1, int number2, int result)
    {
        Calculadora calculadora = construirClass();

        int resultadoCalculadora = calculadora.Multiplicar(number1, number2);

        Assert.Equal(result, resultadoCalculadora);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(40, 5, 8)]
    public void TestDividir(int number1, int number2, int result)
    {
        Calculadora calculadora = construirClass();

        int resultadoCalculadora = calculadora.Dividir(number1, number2);

        Assert.Equal(result, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calculadora = construirClass();

        Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(3, 0));
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calculadora = construirClass();

        calculadora.Somar(1, 8);
        calculadora.Somar(2, 7);
        calculadora.Somar(3, 6);
        calculadora.Somar(4, 5);

        var lista = calculadora.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}