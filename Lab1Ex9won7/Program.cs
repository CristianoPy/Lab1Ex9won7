//Scrieti un program care interschimba valoarea a doua variabile intregi.


Console.Write("Introduce primul numar: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Introduce al doilea numar: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int tem;

tem = num1;
num1 = num2;
num2 = tem;

Console.WriteLine("\n Dupa interschimbarea: ");
Console.WriteLine("\n primul numar: " + num1);
Console.WriteLine("\n Al doilea numar: " + num2);

Console.ReadLine();

