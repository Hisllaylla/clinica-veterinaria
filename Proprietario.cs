namespace ClinicaVeterinaria
{
    public class Proprietario : Endereco
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string NumeroCelular { get; set; }

        public Proprietario(string nome, string documento, string numeroCelular)
        {
            Nome = nome;
            Documento = documento;
            NumeroCelular = numeroCelular;
        }

        public Endereco ObterEndereco()
        {
            var endereco = new Endereco()
            {
                Nome = "Vinícius",
                Numero = "99999999999",
                Bairro = "Imperial",
                Cidade = "Cidade A",
                Estado = "SP"
            };

            return endereco;
        }
    }
}
