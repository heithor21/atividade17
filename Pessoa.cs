using System;
using System.Data; 


class Pessoa 
{
    //Atributos
    public string? Nome;
    public string? Sobrenome;
    public DateTime DataNascimento;
    public int CPF;
    public decimal Peso;
    public decimal Altura;

   public Pessoa (string? nome, string? sobrenome, DateTime dataNascimento, int cpf, decimal peso, decimal altura)
  {
    Nome = nome;
    Sobrenome = sobrenome;
    DataNascimento = dataNascimento;
    CPF = cpf;
    Peso = peso;
    Altura = altura;
}
        //Metodos

public int CalcularIdade()
    {
    DateTime dataAtual = DateTime.Now;
    int idade = dataAtual.Year - DataNascimento.Year;

    return idade;

    }

public decimal CalcularIMC()
{
    decimal peso = (decimal)Peso;
    decimal altura = (decimal)Altura;

    decimal imc = peso / (altura * altura);

    return imc;
}




public bool Maioridade()
    {
        int Idade = CalcularIdade();
        return Idade >=18;
    }


}
