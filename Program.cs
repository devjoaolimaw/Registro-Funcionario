using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Sistema de Cadastro de Funcionários");
        Console.WriteLine("==================================");

        // Criando uma lista para armazenar os funcionários
        List<Funcionario> funcionarios = new List<Funcionario>();

        // Loop para permitir o cadastro de múltiplos funcionários
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
                    Console.Clear();
                    // Cadastro de novo funcionário
                    Funcionario novoFuncionario = LerDadosFuncionario();
                    funcionarios.Add(novoFuncionario);
                    Console.WriteLine("\nFuncionário cadastrado com sucesso!");
                    break;
                case "2":
                    Console.Clear();
                    // Listar todos os funcionários cadastrados
                    Console.WriteLine("\nLista de Funcionários:");
                    foreach (var funcionario in funcionarios)
                    {
                        Console.WriteLine(funcionario);
                    }
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    // Sair do programa
                    Console.WriteLine("\nSaindo do programa...");
                    return;
                default:
                    Console.WriteLine("\nOpção inválida. Tente novamente.");
                    break;
            }
        }
    }

    // Método para ler os dados de um novo funcionário
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
}

// Classe Funcionario para representar um funcionário
class Funcionario
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; set; }

    // Construtor para inicializar um Funcionario com os dados básicos
    public Funcionario(string nome, int idade, string cargo, double salario)
    {
        Nome = nome;
        Idade = idade;
        Cargo = cargo;
        Salario = salario;
    }

    // Sobrescrevendo o método ToString para formatar a exibição do funcionário
    public override string ToString()
    {
        Console.Clear();
        return $"Nome: {Nome}, Idade: {Idade}, Cargo: {Cargo}, Salário: R${Salario:F2}";
    }
}
