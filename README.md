# Registro-Funcionario


Este programa em C# permite cadastrar, listar e visualizar funcionários em um sistema simples de gerenciamento de funcionários.

#### Estrutura do Programa

O programa consiste em uma aplicação de console que utiliza uma classe `Funcionario` para representar os dados de cada funcionário e uma classe `Program` que gerencia a interação com o usuário.

#### Funcionamento

1. **Inicialização e Menu Principal**:
   - O programa começa com uma tela de boas-vindas e um menu de opções que permite ao usuário escolher entre:
     - Cadastrar um novo funcionário (`Opção 1`).
     - Listar todos os funcionários cadastrados (`Opção 2`).
     - Sair do programa (`Opção 3`).

```csharp
static void Main()
{
    Console.Clear();
    Console.WriteLine("Sistema de Cadastro de Funcionários");
    Console.WriteLine("==================================");

    List<Funcionario> funcionarios = new List<Funcionario>();

    while (true)
    {
        Console.Clear();
        Console.WriteLine("\nOpções:");
        Console.WriteLine("1. Cadastrar novo funcionário");
        Console.WriteLine("2. Listar todos os funcionários");
        Console.WriteLine("3. Sair");

        Console.Write("\nEscolha uma opção: ");
        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                // Cadastro de novo funcionário
                Funcionario novoFuncionario = LerDadosFuncionario();
                funcionarios.Add(novoFuncionario);
                Console.WriteLine("\nFuncionário cadastrado com sucesso!");
                break;
            case "2":
                // Listar todos os funcionários cadastrados
                Console.WriteLine("\nLista de Funcionários:");
                foreach (var funcionario in funcionarios)
                {
                    Console.WriteLine(funcionario);
                }
                Console.ReadKey();
                break;
            case "3":
                // Sair do programa
                Console.WriteLine("\nSaindo do programa...");
                return;
            default:
                Console.WriteLine("\nOpção inválida. Tente novamente.");
                break;
        }
    }
}
```

2. **Cadastro de Funcionário**:
   - Ao escolher a opção `1`, o usuário é guiado através de prompts para inserir nome, idade, cargo e salário do novo funcionário. Os dados são então utilizados para criar um novo objeto `Funcionario`.

```csharp
static Funcionario LerDadosFuncionario()
{
    Console.Clear();
    Console.WriteLine("\nDigite os dados do novo funcionário:");

    Console.Write("Nome: ");
    string nome = Console.ReadLine();

    Console.Write("Idade: ");
    int idade = int.Parse(Console.ReadLine());

    Console.Write("Cargo: ");
    string cargo = Console.ReadLine();

    Console.Write("Salário: ");
    double salario = double.Parse(Console.ReadLine());

    // Criando um novo objeto Funcionario com os dados fornecidos
    Funcionario novoFuncionario = new Funcionario(nome, idade, cargo, salario);
    return novoFuncionario;
}
```

3. **Listagem de Funcionários**:
   - Ao selecionar a opção `2`, o programa exibe todos os funcionários cadastrados na lista `funcionarios`, formatando cada funcionário usando o método `ToString()` sobrescrito na classe `Funcionario`.

```csharp
public override string ToString()
{
    Console.Clear();
    return $"Nome: {Nome}, Idade: {Idade}, Cargo: {Cargo}, Salário: R${Salario:F2}";
}
```

#### Classe `Funcionario`

A classe `Funcionario` possui propriedades para `Nome`, `Idade`, `Cargo` e `Salario`, além de um construtor para inicializar esses dados. O método `ToString()` é sobrescrito para formatar a saída dos dados do funcionário.

```csharp
class Funcionario
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; set; }

    public Funcionario(string nome, int idade, string cargo, double salario)
    {
        Nome = nome;
        Idade = idade;
        Cargo = cargo;
        Salario = salario;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Idade: {Idade}, Cargo: {Cargo}, Salário: R${Salario:F2}";
    }
}
```

#### Considerações Finais

Este programa oferece uma maneira simples e interativa de gerenciar funcionários através de um console, permitindo ao usuário adicionar novos funcionários, listar os existentes e sair do programa quando necessário.
