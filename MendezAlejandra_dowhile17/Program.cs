// See https://aka.ms/new-console-template for more information
Console.WriteLine("Cree un programa que permita ingresar números y cuente cuántos de ellos son pares hasta que el usuario ingrese 0");

int numero;
int contador = 0;

do
{
    Console.WriteLine("Ingrese un número: ");
    numero = int.Parse(Console.ReadLine());

    if (numero != 0 && numero % 2 == 0)
    {
        contador++;
    }

} while (numero != 0);

Console.WriteLine($"Cantidad de números pares: {contador}");