// See https://aka.ms/new-console-template for more information
// primeiro programa: "Hello, World!"
using System.Security;

void apresentacao()
{
    Console.WriteLine("Hello, World!");
}

// Saída de dados: formas de exibição
void saidas_de_dados()
{
    string nome = "Edson de Olieira";
    int idade = 50;
    double altura = 1.71;
    Console.WriteLine("Nome: " + nome + "\nIdade: " + idade + "\nAltura: " + altura);
    Console.WriteLine("Nome: {0}\nIdade: {1}\nAltura: {2} ", nome, idade, altura);
    Console.WriteLine($"Nome: {nome}\nIdade: {idade}\nAltura: {altura} ");
}

// Casting
void casting()
{
    // converte double para int
    double x = 45.76;
    int a = (int) x;
    Console.WriteLine($"x = {x} a = {a}");

    // verifica o tipo da variável
    string s = "123,45";
    Console.WriteLine(s is DateTime);

    // converte string para double
    x = Convert.ToDouble(s);
    Console.WriteLine(x);

    // converte double para int
    a = Convert.ToInt32(x);
    Console.WriteLine(a);
}
saidas_de_dados();