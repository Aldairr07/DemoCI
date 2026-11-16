# DemoCI

Proyecto de demostración de **Integración Continua (CI)** con **GitHub Actions**.

Es una calculadora sencilla en consola (.NET 10) con pruebas unitarias en xUnit.
El pipeline compila el proyecto y ejecuta las pruebas en cada `push` o `pull request` a `main`.

## Estructura

```
DemoCI/
├── DemoCI.slnx                     # Solución
├── src/DemoCI/                     # Aplicación de consola
│   ├── Calculadora.cs
│   └── Program.cs
└── tests/DemoCI.Tests/             # Pruebas unitarias (xUnit)
    └── CalculadoraTests.cs
```

## Ejecutar localmente

```bash
dotnet build
dotnet test
dotnet run --project src/DemoCI
```
