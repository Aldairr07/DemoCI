using DemoCI;

namespace DemoCI.Tests;

public class CalculadoraTests
{
    private readonly Calculadora _calc = new();

    [Fact]
    public void Sumar_DosNumeros_RegresaLaSuma()
    {
        Assert.Equal(8, _calc.Sumar(5, 3));
    }

    [Fact]
    public void Restar_DosNumeros_RegresaLaResta()
    {
        Assert.Equal(2, _calc.Restar(5, 3));
    }

    [Fact]
    public void Multiplicar_DosNumeros_RegresaElProducto()
    {
        Assert.Equal(15, _calc.Multiplicar(5, 3));
    }

    [Fact]
    public void Dividir_DosNumeros_RegresaElCociente()
    {
        Assert.Equal(2, _calc.Dividir(6, 3));
    }

    [Fact]
    public void Dividir_EntreCero_LanzaExcepcion()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(5, 0));
    }
}
