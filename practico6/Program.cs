// See https://aka.ms/new-console-template for more information

//Calculadora V1

Console.WriteLine("Calculadora");
Console.WriteLine("1 - Suma");
Console.WriteLine("1 - Resta");
Console.WriteLine("1 - Multiplicacion");
Console.WriteLine("1 - Division");
Console.WriteLine("Ingrese la operacion que desea realizar: ");

int opcion; 

int.TryParse(Console.ReadLine(), out opcion);

Console.Write(opcion);

int num1;
int num2;

Console.WriteLine("ingrese un numero: ");
int.TryParse(Console.ReadLine(), out num1);

Console.WriteLine("Ingrese otro numero: ");
int.TryParse(Console.ReadLine(), out num2);
/*
switch (opcion)
{
    case 1:

    default:
}
*/
