namespace ClinicaVeterinaria;

public class Cachorro : Paciente
{
    public override Paciente ObterInformacoes()
    {
        var cachorro = new Cachorro();
        cachorro.Nome = "Melissa";
        cachorro.Especie = "Cachorro";
        cachorro.Raca = "Pastor Alemão";
        cachorro.Cor = "Preto";
        cachorro.Idade = 0.8;
        cachorro.Peso = 1.5;
        cachorro.Sexo = "F";

        return cachorro;
    }
}
