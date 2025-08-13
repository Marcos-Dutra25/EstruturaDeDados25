// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine(
    "Hello, World!"
);

Console.WriteLine("");

Console.WriteLine("informe seu nome");

String? name = Console.ReadLine();

// ? -> operador nullable : indica que a variáveç pode receber valor nulo

Console.WriteLine(
    $"Seja Bem-Vindo {name}"
);

//Declarando vetor
//Sem inicilização
int[] numbers;

//inicializando vetor
numbers = new int[5];

int[] numbers2 = new int[5];

// atribuindo valores
numbers2[0] = 1;
numbers2[1] = 2;
numbers2[2] = 3;
numbers2[3] = 4;
numbers2[4] = 5;

//declarando e inicializando com valores
int[] numbers3 = new int[] { 1, 2, 3, 4, 5};
//simplificada
int[] numbers4 = { 1, 2, 3, 4, 5, };

// Preenchendo um vetor com os 12 meses do ano

string[] months = new string[12];

for (int i = 1; i <= 12; i++) {
    DateTime firstday =
     new DateTime(DateTime.Now.Year, i, 1);

    string monthName =
    firstday.ToString("MMMM", CultureInfo.CreateSpecificCulture("en-US"));
     
     months[i - 1] = monthName;
}

foreach (var month in months)
{
    Console.WriteLine(month);
};

// ARRAY MULTI-DIMENSIONAL
 
 // 2 dimensões

 int[,] numbers52 = new int[5,2];

// 3 dimensões

int[,,] numbers543 = new int[5, 4, 3];

// inicializando matriz valorada
int[,] nmb = new int[,]  
{
     { 1, 2, -9},
     { 5, 7, 10},
     { 6, 115, 54}

};   

// também podemos acessar a matriz da seguinte mneira

int mynumber = nmb[2, 1];
Console.WriteLine("imprimindo o valor da matriz");
Console.WriteLine(mynumber);

