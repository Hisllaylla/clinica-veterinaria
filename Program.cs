namespace ClinicaVeterinaria;

var gato = new Paciente();
var cachorro = new Paciente();

var verificacaoGato = gato.ObterInformacoes();
var verificacaoCachorro = cachorro.ObterInformacoes();

Console.WriteLine("Informações do Gato:");
Console.WriteLine($"Nome: {verificacaoGato.Nome}");
Console.WriteLine($"Espécie: {verificacaoGato.Especie}");
Console.WriteLine($"Raça: {verificacaoGato.Raca}");
Console.WriteLine($"Cor: {verificacaoGato.Cor}");
Console.WriteLine($"Idade: {verificacaoGato.Idade}");
Console.WriteLine($"Peso: {verificacaoGato.Peso}");
Console.WriteLine($"Sexo: {verificacaoGato.Sexo}");
Console.WriteLine($"Proprietario: {verificacaoGato.Proprietario.Nome}");
Console.WriteLine($"Endereço: {verificacaoGato.Proprietario.ObterEndereco().ToString()}");

Console.WriteLine(); // Linha em branco

Console.WriteLine("Informações do Cachorro:");
Console.WriteLine($"Nome: {verificacaoCachorro.Nome}");
Console.WriteLine($"Espécie: {verificacaoCachorro.Especie}");
Console.WriteLine($"Raça: {verificacaoCachorro.Raca}");
Console.WriteLine($"Cor: {verificacaoCachorro.Cor}");
Console.WriteLine($"Idade: {verificacaoCachorro.Idade}");
Console.WriteLine($"Peso: {verificacaoCachorro.Peso}");
Console.WriteLine($"Sexo: {verificacaoCachorro.Sexo}");
Console.WriteLine($"Proprietario: {verificacaoCachorro.Proprietario.Nome}");
Console.WriteLine($"Endereço: {verificacaoCachorro.Proprietario.ObterEndereco().ToString()}");
