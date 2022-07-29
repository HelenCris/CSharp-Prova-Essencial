using System;
using System.Collections.Generic;

namespace CSharpEssencial
{
    class Program
    {
        static void Main(string [] args)
        {
            bool sair = false;

            List<Person> persons = new List<Person>();

            while(sair != true)
            {
                Console.Write("Digite o CPF/CNPJ: ");
                string cpfCnpj = Console.ReadLine();
                Console.Write("Digite o Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o Sobrenome: ");
                string sobrenome = Console.ReadLine();
                Console.Write("Digite o Logradouro: ");
                string logradouro = Console.ReadLine();
                Console.Write("Digite o Bairro: ");
                string bairro = Console.ReadLine();
                Console.Write("Digite o Cidade: ");
                string cidade = Console.ReadLine();
                Console.Write("Digite o Estado: ");
                string estado = Console.ReadLine();
                Console.Write("Digite o Telefone: ");
                string telefone = Console.ReadLine();
                
                Person pessoa = new Person(
                    cpfCnpj, nome, sobrenome, logradouro, bairro, cidade, estado, telefone
                );

                persons.Add(pessoa);

                Console.Write("Deseja cadastrar mais pessoas?");
                sair = bool.Parse(Console.ReadLine());
            }
        }
    }
}