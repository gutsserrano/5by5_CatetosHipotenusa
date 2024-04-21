// Faça um programa que leia 2 valores de cateto e calcule a hipotenusa

double cateto1, cateto2, hipotenusa;

int option;

do
{

    do
    {
        Console.WriteLine("Digite o primeiro cateto:");
        cateto1 = double.Parse(Console.ReadLine());

        if (cateto1 <= 0)
        {
            Console.WriteLine("\nCateto deve ser maior que zero!");
        }
    } while (cateto1 <= 0);

    do
    {
        Console.WriteLine("Digite o segundo cateto:");
        cateto2 = double.Parse(Console.ReadLine());

        if (cateto2 <= 0)
        {
            Console.WriteLine("\nCateto deve ser maior que zero!");
        }
    } while (cateto2 <= 0);

    hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));

    Console.WriteLine($"\nHipotenusa = {hipotenusa}\n");

    do
    {
        Console.WriteLine("\nDeseja sair?");
        Console.WriteLine("1 - sim");
        Console.WriteLine("2 - não");
        option = int.Parse(Console.ReadLine());
    } while (option < 1 || option > 2);
} while (option == 2);