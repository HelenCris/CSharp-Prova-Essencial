namespace CSharpEssencial{
    public class Person
    {
        public string CpfCnpj { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }

        public Person(
            string cpfCnpj, 
            string nome, 
            string sobrenome, 
            string logradouro, 
            string bairro, 
            string cidade,
            string estado,
            string telefone)
            {
                CpfCnpj = cpfCnpj;
                Nome = nome;
                Sobrenome = sobrenome;
                Logradouro = logradouro;
                Bairro = bairro;
                Cidade = cidade;
                Estado = estado;
                Telefone = telefone;
            }
    }
}