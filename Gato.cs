namespace ClinicaVeterinaria;

public class Gato : Paciente
{
    public override Paciente ObterInformacoes()
    {
        var gato = new Gato();
        gato.Nome = "Puma";
        gato.Especie = "Gato";
        gato.Raca = "Vira-lata";
        gato.Cor = "Rajada, predominantemente preta com tons amarelados";
        gato.Idade = 0.8;
        gato.Peso = 1.5;
        gato.Sexo = "F";

        return gato;
    }
}