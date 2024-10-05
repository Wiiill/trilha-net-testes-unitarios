using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{

    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5com10ERetornar15()
    {
        // Arrange - monta cenario
        int num1 = 5;
        int num2 = 10;

        // Act - ja tem o cenario, executa a ação
        int resultado = _calc.Somar(num1, num2);

        // Assert - valida se o resultado é o esperado
        Assert.Equal(15, resultado);
    }

        [Fact]
    public void DeveMultiplicar10com10ERetornar100()
    {
        // Arrange - monta cenario
        int num1 = 10;
        int num2 = 10;

        // Act - ja tem o cenario, executa a ação
        int resultado = _calc.Multiplicar(num1, num2);

        // Assert - valida se o resultado é o esperado
        Assert.Equal(100, resultado);
    }


        [Fact]
    public void DeveDividir50com10ERetornar5()
    {
        // Arrange - monta cenario
        int num1 = 50;
        int num2 = 10;

        // Act - ja tem o cenario, executa a ação
        int resultado = _calc.Dividir(num1, num2);

        // Assert - valida se o resultado é o esperado
        Assert.Equal(5, resultado);
    }

    
        [Fact]
    public void DeveSubtrair20com5ERetornar15()
    {
        // Arrange - monta cenario
        int num1 = 20;
        int num2 = 5;

        // Act - ja tem o cenario, executa a ação
        int resultado = _calc.Subtrair(num1, num2);

        // Assert - valida se o resultado é o esperado
        Assert.Equal(15, resultado);
    }

[Fact]
    public void TestarHistorico()
    {
        CalculadoraImp c = new CalculadoraImp();

        c.Somar(1,3);
        c.Somar(5,2);
        c.Somar(9,1);
        c.Somar(14,2);

        var lista = c.Historico();

        Assert.NotEmpty(c.Historico());
        Assert.Equal(3, lista.Count());
    }
}



