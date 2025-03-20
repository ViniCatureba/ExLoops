// Imprimir numeros ate 20
using System.Net.Mail;

for (int i = 0; i < 21; i++)
{
    Console.WriteLine(i);
}

//Validacao de senha
string senha;
string senhacorreta = "1234";
do
{
    Console.WriteLine("Insira a senha correta");
    senha = Console.ReadLine();
}
while (senha != senhacorreta);

//Tabuada

Console.WriteLine("Insira o numero para apresentar a tabuada");
int tabuada = int.Parse(Console.ReadLine());
for (int i = 0; i < 11; i++)
{
    int resultadoTabuada = i * tabuada;
    Console.WriteLine($"O valor {tabuada} vezes {i} eh {resultadoTabuada}");
}

//Contagem regressiva 
Console.WriteLine("Insira o numero para contagem regressiva");

int contagemreg = int.Parse(Console.ReadLine());

for (int i = contagemreg; contagemreg != 0; contagemreg--)
{
    Console.WriteLine("teste" + contagemreg);
}


//Media de notas
int media = 0;
int indice = 0;
bool validador = true;
do
{
    Console.WriteLine("Insira a nota:");
    int input = int.Parse(Console.ReadLine());

    if (input >= 0 && input <= 10)
    {
        media = media + input;
        indice++;
    }
    else
    {
        validador = false;
        int calculo = media / indice;
        Console.WriteLine("A media eh: " + calculo);
    }
}
while (validador == true);



//Somat


// Ex de error handling

//Entrada segura de num

try
{
    Console.WriteLine("Insira um numero inteiro");
    int numero4 = int.Parse(Console.ReadLine());
}
catch
{
    throw new FormatException("ERRO: Entrada invalida, digite um numero inteiro valido");
}

//Divisao segura

try
{
    Console.WriteLine("Insira o numerador");
    int numerador = int.Parse(Console.ReadLine());
    Console.WriteLine("Denominador:");
    int denominador = int.Parse(Console.ReadLine());
    int resultado = numerador / denominador;
    Console.WriteLine($"Resultado é: {resultado}");
}
catch (FormatException ex)
{
    Console.WriteLine("Erro: o tipo de dado é invalido");

}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Erro: o denominador nao pode ser 0");
}




//validacao de idade

try
{
    Console.WriteLine("Insira uma idade");
    int idade5 = int.Parse(Console.ReadLine());
    if (idade5 < 0 || idade5 > 120)
    {
        throw new OverflowException("Idade ou muito grande ou negativa");
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Insira um numero inteiro");
}



//Contagem progressiva segura

try
{
    Console.WriteLine("Insira um numero para contagem progressiva, inteiro e positivo: ");
    int num9 = int.Parse(Console.ReadLine());
    if (num9 < 0)
    {
        throw new OverflowException("Erro numero NEGATIVO");
    }
    for (int i = 0; i != num9; i++)
    {
        Console.WriteLine(i);
    }
}
catch (FormatException ex)
{

    Console.WriteLine("erro: Insira um numero");
}
catch (OverflowException ex)
{
    Console.WriteLine("Numero muito grande");
}
