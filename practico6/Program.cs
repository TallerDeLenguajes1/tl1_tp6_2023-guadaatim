// See https://aka.ms/new-console-template for more information

//Calculadora V1

int aux = 1;

while (aux != 0)
{
    Console.WriteLine("Calculadora");
    Console.WriteLine("1 - Suma");
    Console.WriteLine("2 - Resta");
    Console.WriteLine("3 - Multiplicacion");
    Console.WriteLine("4 - Division");
    Console.WriteLine("5 - Otras operaciones");
    Console.WriteLine("Ingrese la operacion que desea realizar: ");

    int opcion; 

    int.TryParse(Console.ReadLine(), out opcion);

    //Console.Write(opcion);

    int num1;
    int num2;
    int resultado = 0;

    Console.WriteLine("ingrese el primer numero: ");
    int.TryParse(Console.ReadLine(), out num1);

    Console.WriteLine("Ingrese el segundo numero: ");
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
        default:
            int a;
            double numradian;
            
            Console.WriteLine("Elija uno de los numeros ingresados: ");
            Console.WriteLine("1 - " + num1);
            Console.WriteLine("2 - " + num2);
            int.TryParse(Console.ReadLine(), out a);
            if (a == 1)
            {
                Console.WriteLine("Valor Absoluto: " + Math.Abs(num1));
                Console.WriteLine("Cuadrado: " + Math.Pow(num1, 2));
                Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(num1));
                numradian = num1 * Math.PI / 180;
                Console.WriteLine("Seno: " + Math.Asin(numradian));
                Console.WriteLine("Coseno: " + Math.Acos(numradian));
                Console.WriteLine("Parte entera de float: ");
            } else
            {
                Console.WriteLine("Valor Absoluto: " + Math.Abs(num2));
                Console.WriteLine("Cuadrado: " + Math.Pow(num2, 2));
                Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(num2));
                numradian = num2 * Math.PI / 180;
                Console.WriteLine("Seno: " + Math.Asin(numradian));
                Console.WriteLine("Coseno: " + Math.Acos(numradian));
                Console.WriteLine("Parte entera de float: ");
            }
            break;
    }

    if (opcion != 5)
    {
        Console.WriteLine("El resultado es: ");
        Console.Write(resultado);
    }

    Console.WriteLine("Ingrese 0 para temrinar o 1 para realizar otro calculo: ");
    int.TryParse(Console.ReadLine(), out aux);
}

