namespace CSharpEssencial
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Escreva seu nome completo:");
      string nome = Console.ReadLine();

      Console.WriteLine("Escreva seu endereço:");
      string endereco = Console.ReadLine();

      Console.WriteLine("Escreva seu bairro:");
      string bairro = Console.ReadLine();

      Console.WriteLine("Escreva seu telefone:");
      string telefone = Console.ReadLine();

      Console.WriteLine("Escreva seu CPF:");
      string CPF = Console.ReadLine();

      Console.WriteLine("Escreva seu CNPJ:");
      string CNPJ = Console.ReadLine(); 
      


      Console.WriteLine("Carregando...");
      Console.WriteLine("Seus dados são: ");
      Console.WriteLine(
        $"Nome Completo: "+ nome + "\nEndereço: " + endereco + "\nBairro: " + bairro + "\nTelefone: " + telefone + "\nCPF: " + CPF +"\nCNPJ: " + CNPJ);
      Console.WriteLine($"Clique enter para confirmar");
      Console.ReadLine();
      Console.WriteLine("Cadastro efetuado!");

    }

    
  }
}

