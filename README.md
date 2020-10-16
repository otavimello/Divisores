# Divisores
Aplicação responsável possui basicamente duas funcionalidades: BuscarDivisores e BuscarDivisoresPrimos

webapi desenvolvida em .Net core 

Para executar o projeto execute o comando dotnet run 
EndPoints:
  [GET] http://localhost:5000/api/divisores/BuscaDivisores/{dividendo}
    - Responsável por retornar uma lista de inteiros com todos os divisores do dividendo informado.
    
  [GET] http://localhost:5000/api/divisores/BuscaDivisoresPrimos/{dividendo}
    - Responsável por retornar uma lista de inteiros com todos os divisores do dividendo informado que são números primos.

Para realizar os testes unitários entre na pasta test e execute o comando dotnet test

Estão implementados os seguintes testes:
[Fact]
PassingDivisores2Test: Testa se com o número 2 como entrada temos a lista [1,2] de divisores na saída.

[Fact]
FalseDivisores2Test: Testa se com o número 2 como entrada temos a lista [1] de divisores na saída.

[Theory]
[InlineData(10)]
DivisoresPrimos10Test: Testa se com o número 10 como entrada temos a lista [2,5] de divisores primos na saída.

[Theory]
[InlineData(-1)]
[InlineData(0)]
[InlineData(1)]
FalseDivisoresPrimosTest: Testa se com as entradas -1,0 e 1 temos uma lista [] (vazia) na saída.
