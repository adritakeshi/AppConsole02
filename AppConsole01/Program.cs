// See https://aka.ms/new-console-template for more information

using AppConsole01;

Console.WriteLine("Hello, World!");

/*
double n2 = 3.1415;

Console.WriteLine(n2);

string nome = "Adriano";
string sobrenome = "Takeshi";
Console.WriteLine(nome + " " + sobrenome);
*/
/*
bool par;

int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
    par = true;
else
    par = false;

if (par)
    Console.WriteLine(num + " é par");
else
    Console.WriteLine(num + " é impar"); 

string strnum = Console.ReadLine();
double num = double.Parse(strnum);

Console.WriteLine(num);


int n1, n2, n3;
n1 = 7;
n2 = 5;
n3 = 2;

if ((n1 > n2) && (n2 > n3))
{
   Console.WriteLine(n1 + " é maior do que o " + n2 + " e " + n3);
}
else
{
    if (n2 > n1)
        Console.WriteLine(n2 + " é maior do que " + n1);
    else
        Console.WriteLine("Os numeros são iguais");
}
/*
string fruta = "Laranja";
if (fruta.ToUpper() == "LARANJA")
{
    Console.WriteLine(fruta);
}
else
{
    Console.WriteLine("Eu queria uma laranja");
}*/
/*
int num = int.Parse(Console.ReadLine());
int contador = 1;
int resultado;

for (int i = -10; i < 11; i++)
{
    resultado = num * i;
    Console.WriteLine(num + " x " + i + " = " + resultado);
}


DateTime DataNasc;

try
{
    DataNasc = DateTime.Parse(Console.ReadLine());
    int idade = ((DateTime.Now - DataNasc).Days) / 365;

    Console.WriteLine("Minha idade é " + idade);
}
catch
{
    Console.WriteLine("Data inválida");
}



long fatorial(int num)
{
    long fat = 1;
    for(int i = 1; i <= num; i++)
    {
        fat = fat * i;
    }

    return fat;
    
}
*/
/*

long fatorial(int num)
{
    if ((num == 0) || (num == 1))
        return 1;
    else
        return num * fatorial(num - 1);
}

Console.WriteLine(fatorial(6));  */

/*
fatorial 4 = 4 * fatorial(3)
             4 * 3 * fatorial(2)
             4 * 3 * 2 * fatorial(1)
             4 * 3 * 2 * 1 = 120 

1, 1, 2, 3, 5, 8, 13, 21, 34, 55 

long fibonnaci(int num)
{
    if ((num == 1) || (num == 2))
        return 1;
    else
        return fibonnaci(num - 1) + fibonnaci(num - 2);
}

Console.WriteLine(fibonnaci(6)); 
*/

Pessoas pes = new Pessoas(36547839485, "Adriano", DateTime.Parse("26/08/1988"), "#000");
pes.darNomeAoFilho("Jose Loreto");
Console.WriteLine(pes.Soma(1, 2));
Console.WriteLine(pes.Soma(1, 2, 3));


Funcionarios func = new Funcionarios(376485948543, "Carol", DateTime.Parse("10/08/2000"), "#000");
func.Contrata(3000, DateTime.Now);
func.atualizaSalario(4000);
Console.WriteLine(func.salario);