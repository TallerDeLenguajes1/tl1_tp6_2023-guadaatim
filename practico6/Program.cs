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

//calculadora ???

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
string cadenacar = string.Empty;
