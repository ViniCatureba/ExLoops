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
for (int i = 0;i < 11; i++)
{
    int resultadoTabuada = i * tabuada;
    Console.WriteLine($"O valor {tabuada} vezes {i} eh {resultadoTabuada}");
}

//Contagem regressiva 
Console.WriteLine("Insira o numero para contagem regressiva");

int contagemreg = int.Parse(Console.ReadLine());

for (int i = contagemreg; contagemreg != 0 ; contagemreg--)
{
    Console.WriteLine("teste"+contagemreg);
}


//Media de notas
