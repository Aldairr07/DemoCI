using DemoCI;

var calc = new Calculadora();

Console.WriteLine("=== Demo CI con GitHub Actions ===");
Console.WriteLine($"5 + 3 = {calc.Sumar(5, 3)}");
Console.WriteLine($"5 - 3 = {calc.Restar(5, 3)}");
Console.WriteLine($"5 * 3 = {calc.Multiplicar(5, 3)}");
Console.WriteLine($"6 / 3 = {calc.Dividir(6, 3)}");
