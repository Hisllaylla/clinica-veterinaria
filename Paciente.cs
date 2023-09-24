namespace ClinicaVeterinaria
{
    public abstract class Paciente
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public string Cor { get; set; }
        public double Idade { get; set; }
        public double Peso { get; set; }
        public string Sexo { get; set; }
        public Proprietario Proprietario { get; set; }

        public abstract void ObterInformacoes();
    }
}