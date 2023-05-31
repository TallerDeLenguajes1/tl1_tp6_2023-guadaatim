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
Console.WriteLine(cadena.Substring(2, 1));

//calculadora ???

//recorrer cadena
foreach (var car in cadena)
{
    Console.WriteLine(car);
}

//buscar ocurrencia en cadena

//convertir a mayuscula y minuscula
Console.WriteLine("Cadena en mayusculas: " + cadena.ToUpper());
Console.WriteLine("Cadena en minuscula: " + cadena.ToLower());

//cadena separada por caracteres
string cadenacar = string.Empty;
