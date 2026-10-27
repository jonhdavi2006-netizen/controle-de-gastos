# Controle de gastos

Aplicação de console em C# para comparar a renda mensal com gastos de alimentação, transporte e lazer.

## Funcionalidades

- Solicita nome, renda mensal e os valores de três categorias de despesas.
- Soma as despesas e calcula o saldo do mês.
- Informa se o saldo ficou negativo, positivo ou igual a zero.

## Tecnologias

- C#
- .NET 10 (`net10.0`)

## Como executar

Com o SDK do .NET 10 instalado, abra um terminal na pasta do projeto e execute:

```sh
dotnet run --project ConsoleApp1.csproj
```

Digite os valores quando solicitado. O separador decimal segue a configuração regional do ambiente.

## Exemplo de cálculo

Exemplo ilustrativo, calculado a partir das operações do código:

| Entrada | Valor |
| --- | ---: |
| Renda mensal | 2000 |
| Alimentação | 600 |
| Transporte | 200 |
| Lazer | 150 |
| Total de despesas | 950 |
| Saldo restante | 1050 |

## Estrutura

- `Program.cs`: leitura das entradas, cálculo e mensagens no console.
- `ConsoleApp1.csproj`: configuração do projeto.
- `.gitignore`: exclusão das pastas geradas `bin/` e `obj/`.

## Limitações atuais

- Os valores são lidos com `decimal.Parse`; entradas inválidas podem encerrar o programa.
- Valores negativos ainda não são validados.
- Os dados não são salvos em arquivo ou banco de dados.
- O nome é solicitado, mas ainda não é utilizado na saída.

## Possíveis próximos passos

Sugestões para evolução; ainda não implementadas:

- Validar entradas com `decimal.TryParse` e impedir valores negativos.
- Formatar os resultados como moeda.
- Separar leitura, cálculo e apresentação em funções.
- Adicionar testes para saldo positivo, negativo e zero.

Para experimentar, utilize valores fictícios. Não envie dados financeiros pessoais ao repositório.
