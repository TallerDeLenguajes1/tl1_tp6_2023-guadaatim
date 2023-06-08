// See https://aka.ms/new-console-template for more information

//primera cadena
string cadena = String.Empty;

Console.WriteLine("Ingrese una palabra: ");
cadena = Console.ReadLine(); //?

//longitud primera cadena
int longitudcad1 = cadena.Length;

Console.WriteLine("Longitud de la cadena ingresada: " + longitudcad1);

//segunda cadena
string cadena2 = String.Empty;

Console.WriteLine("Ingrese otra palabra: ");
cadena2 = Console.ReadLine();

//concatenar cadenas
string cadenasconcatenadas = String.Empty;

cadenasconcatenadas = cadena + cadena2;
Console.WriteLine("Cadenas concatenadas: " + cadenasconcatenadas);

//extraer subcadena
int caracter;
int palabra;

Console.WriteLine("Ingrese el caracter que desea extraer");
int.TryParse(Console.ReadLine(), out caracter);
Console.WriteLine("Ingrese la palabra de la que desea extrae el caracter: ");
int.TryParse(Console.ReadLine(), out palabra);

Console.WriteLine(cadena.Substring(caracter, palabra));

//recorrer cadena
foreach (var car in cadena)
{
    Console.WriteLine(car);
}

//buscar ocurrencia en cadena

string palabrabuscada = String.Empty;

Console.WriteLine("Ingrese la palabra que desea buscar: ");
palabrabuscada = Console.ReadLine();

if (cadena.Contains(palabrabuscada))
{
    Console.WriteLine("La palabra " + palabrabuscada + "se encuentra en la cadena ingresada");
}


//convertir a mayuscula y minuscula
Console.WriteLine("Cadena en mayusculas: " + cadena.ToUpper());
Console.WriteLine("Cadena en minuscula: " + cadena.ToLower());

//cadena separada por caracteres
string cadenacar = String.Empty;

Console.WriteLine("Ingrese una cadena separada por - : ");
cadenacar = Console.ReadLine();

string[] cadenaseparada = cadenacar.Split('-');

foreach (var car in cadenaseparada)
{
    Console.WriteLine(car);
}

//resolver string

string expresionarit = String.Empty;
int numero1;
int numero2;
int resultado2 = 0; 
string operador;

Console.WriteLine("Inggrese una operacion: ");
expresionarit = Console.ReadLine();

string[] expresionseparada = expresionarit.Split('+', '-', '/', '*');


    numero1 = Convert.ToInt32(expresionseparada[0]);
    numero2 = Convert.ToInt32(expresionseparada[1]);

    Console.WriteLine(numero1);
    Console.WriteLine(numero2);


if (expresionarit.Contains('+'))
{
    resultado2 = numero1 + numero2; 
} else
{
    if (expresionarit.Contains('-'))
    {
        resultado2 = numero1 - numero2;
    } else
    {
        if (expresionarit.Contains('*'))
        {
            resultado2 = numero1 * numero2;
        } else
        {
            if (expresionarit.Contains('/') && numero2 != 0)
            {
                resultado2 = numero1 / numero2;   
            }
        }
    }
}

Console.WriteLine("El resultado es: " + resultado2);

//calculadora ???


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

    float num1;
    float num2;
    float resultado = 0;

    Console.WriteLine("ingrese el primer numero: ");
    float.TryParse(Console.ReadLine(), out num1);

    Console.WriteLine("Ingrese el segundo numero: ");
    float.TryParse(Console.ReadLine(), out num2);

    Console.WriteLine(num1);

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
            Console.WriteLine("1 - " +num1);
            Console.WriteLine("2 - " + num2);
            int.TryParse(Console.ReadLine(), out a);
            if (a == 1)
            {
                Console.WriteLine("Valor Absoluto: " + Math.Abs(num1));
                Console.WriteLine("Cuadrado: " + Math.Pow(num1, 2));
                if (num1 >= 0)
                {
                    Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(num1));

                }
                numradian = num1 * Math.PI / 180;
                Console.WriteLine("Seno: " + Math.Asin(numradian));
                Console.WriteLine("Coseno: " + Math.Acos(numradian));
                Console.WriteLine("Parte entera de float: " + Math.Truncate(num1));
            } else
            {
                Console.WriteLine("Valor Absoluto: " + Math.Abs(num2));
                Console.WriteLine("Cuadrado: " + Math.Pow(num2, 2));
                if (num2 >= 0)
                {
                    Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(num2));
                }
                numradian = num2 * Math.PI / 180;
                Console.WriteLine("Seno: " + Math.Asin(numradian));
                Console.WriteLine("Coseno: " + Math.Acos(numradian));
                Console.WriteLine("Parte entera de float: " + Math.Truncate(num2));
            }
            break;
    }

    if (opcion != 5)
    {
        Console.WriteLine("El resultado es: " + resultado);
    }

    if (num1 > num2)
    {
        Console.WriteLine("El maximo numero es: " + num1);
        Console.WriteLine("El minimo numero es: " + num2);
    } else
    {
        Console.WriteLine("El maximo numero es: " + num2);
        Console.WriteLine("El minimo numero es: " + num1);
    }

    Console.WriteLine("Ingrese 0 para temrinar o 1 para realizar otro calculo: ");
    int.TryParse(Console.ReadLine(), out aux);
}
