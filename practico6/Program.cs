// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int a;
int b;

a = 10;
b = a;

Console.WriteLine("valor de a: "+a);
Console.WriteLine("valor de b: "+b);

int x;
bool control = int.TryParse(Console.ReadLine(), out x);

//Console.WriteLine(control);

int resto = 1;
int aux, i = 0;
double invertido = 0;

if (control)
{
    if (x > 0)
    {
        aux = x;
        while (aux > 0)
        {
            aux = aux / 10;
            i++;
        }

        while (x > 0)
        {
            resto = x % 10;
            x = x / 10;  
            invertido = invertido + (resto * (Math.Pow(10, i)));
            i--;
        }
        
        invertido = invertido / 10;
        Console.WriteLine(invertido);
    } else
    {
        Console.WriteLine("no se acepta ese numero");  
    } 

} else
{
    Console.WriteLine("no es numero");
}