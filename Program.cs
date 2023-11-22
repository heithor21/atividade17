// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, Word!");

Pessoa p = new Pessoa();

p.Nome = "Gomes";
p.Sobrenome = "OLiveira";
p.CPF = 12345678;

Console.WriteLine($"Ola {p.Nome} {p.Sobrenome} seu CPF é {p.CPF}");
*/
using System.Runtime.InteropServices;

Console.WriteLine ("Digite seu nome: ");
string? nome = Console.ReadLine();

Console.WriteLine ("Digite seu sobrenome: ");
string? sobrenome = Console.ReadLine();

Console.WriteLine ("Digite a sua data de nascimento no formato dd/mm/yy: ");
DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento);

Console.WriteLine ("Digite seu CPF sem ponto ou caracter: ");
int.TryParse(Console.ReadLine(), out int cpf);

Console.WriteLine ("Digite seu peso: ");
decimal.TryParse(Console.ReadLine(), out decimal peso);

Console.WriteLine ("Digite seu altura: ");
decimal.TryParse(Console.ReadLine(), out decimal altura);

Pessoa p = new Pessoa(nome, sobrenome, dataNascimento, cpf, peso, altura);

int idade = p.CalcularIdade();

decimal imc = Math.Round(p.CalcularIMC(),2);

bool sair = false;

while(!sair)
{
    Console.WriteLine("Escolha uma das opções abaixo!");
    Console.WriteLine("0 - inforções do usuario");
    Console.WriteLine("1 - Calcular IMC");
    Console.WriteLine("2 - Verificar a maioridade do usuario");
    Console.WriteLine("3 - Sair");

    string? opcao = Console.ReadLine();

switch(opcao)
{
    case "0":
    Console.WriteLine($" Nome Completo:{nome} {sobrenome}");
    Console.WriteLine($"Data de Nascimento: {dataNascimento}");
    Console.WriteLine($"Altura: {altura}");
    Console.WriteLine($"CPF: {cpf}");
    Console.WriteLine($"Peso: {peso}");
    Console.WriteLine($"Idade: {idade}");
    break;

    case "1":
    Console.WriteLine($"Seu imc é {imc}");

    if(imc < 17)
        {
            Console.WriteLine($"Voce esta muito abaixo do peso");
        }
        else if( imc >= 17 && imc < 18)
        { 
         Console.WriteLine($"Voce esta abaixo do peso");
         }
         else if(imc >= 18 && imc < 25)
         {
           Console.WriteLine($"Voce esta  no peso normal"); 
         }
         else if(imc >= 25 && imc < 30)
          {
           Console.WriteLine($"Voce esta  acima do peso"); 
         }
         else if(imc >= 30 && imc < 35)
          {
           Console.WriteLine($"Voce esta  Obesidade grau 1"); 
         }
         else if(imc >= 35 && imc < 40)
          {
           Console.WriteLine($"Voce esta  Obesidade grau 2"); 
         }
         else if(imc > 40)
          {
           Console.WriteLine($"Voce esta  Obesidade grau 3"); 
         }

       
    break;

    case "2":
    if(idade >= 18)
    {
        Console.WriteLine($"Ola {nome}, parabens voce ja e maior de idade por ja ter {idade}");
    }else
    {
        Console.WriteLine($"Ola {nome}, voce é Menor de idade por ter {idade}");
    }

    break;

    case "3":
    sair = true;
    break;
}
}










