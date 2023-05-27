// See https://aka.ms/new-console-template for more information

//Calculadora V1

Console.WriteLine("Calculadora");
Console.WriteLine("1 - Suma");
Console.WriteLine("2 - Resta");
Console.WriteLine("3 - Multiplicacion");
Console.WriteLine("4 - Division");
Console.WriteLine("Ingrese la operacion que desea realizar: ");

int opcion; 

int.TryParse(Console.ReadLine(), out opcion);

//Console.Write(opcion);

int num1;
int num2;
int resultado = 0;

Console.WriteLine("ingrese un numero: ");
int.TryParse(Console.ReadLine(), out num1);

Console.WriteLine("Ingrese otro numero: ");
int.TryParse(Console.ReadLine(), out num2);

switch (opcion)
{
    case 1:
        resultado = num1 + num2;
    break;
    case 2:
        resultado = num1 - num2;
    break;
    case 3:
        //resultado = num1 * num2;
        for (int i = 0; i < num1; i++)
        {
            resultado = resultado + num2;
        }
        resultado = num1 * num2;
    break;
    case 4:
        if (num2 != 0)
        {
            resultado = num1 / num2;
        } else
        {
            Console.WriteLine("Error");
        }
    break;
}

Console.WriteLine("El resultado es: ");
Console.Write(resultado);