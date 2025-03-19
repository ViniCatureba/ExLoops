// Estruturas Condicionais
// Estruturas de repeticao
// Repete uma acao especifica

// Imprimir todos os numeros de 1 a 5
// While

int contador = 1;
while (contador != 6)
{
    Console.WriteLine($"Numero: {contador}"); 
    contador++;
}

// Faca - Enquanto
int idade;
do
{
    Console.WriteLine("Informe a idade");
    idade = int.Parse(Console.ReadLine());
    
}
while (idade != 20);


// Para - FOR
// 1 - Cria uma varialvel cahamda i ( index)
// 2 - Condicao para continuar
// 3 - Incrementa ao executra as chaves
for (int i = 0; i< 6; i++)
{
    Console.WriteLine(i);
}

// Tratamento de execeções
int numero = int.Parse(Console.ReadLine());


//Exception
//IOException - In and Out - Entrada e saida
//FormatException - Erros no formato (tipo de dado)

// Try/Catch  - Tentar/Pegar

try
{
    int num = int.Parse(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Informe apenas numeros");
}