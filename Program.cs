/* Reto 2: Multiplicación rusa: Desarrolle un programa que reciba como entrada el multiplicador y el multiplicando, y entregue
como resultado el producto de ambos, calculado mediante el método de multiplicación rusa. */

while (true)
{
    Console.Write("\nIngrese el número multiplicador: ");
    int multiplicador = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nIngrese el número multiplicando: ");
    int multiplicando = Convert.ToInt32(Console.ReadLine());

    int suma = 0;

    do
    {
        if(multiplicador %2 != 0)
        {
            suma += multiplicando;
        }

        multiplicador /= 2;
        multiplicando *= 2;
    } while (1<multiplicador);

    suma += multiplicando;
    Console.WriteLine("\nEl resultado es: " + suma + "\n");
}