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
        Console.WriteLine("A media eh: "+ calculo);
    }

}
while (validador == true);



//Somat