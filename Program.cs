Console.Clear();

Console.WriteLine("--- Fluxograma da Engenharia ---");

Console.Write("O objeto está se movendo (S/N)?: ");
char movendo = Convert.ToChar(Console.ReadLine()!.ToUpper());

Console.Write("Deveria?: ");
char deveria = Convert.ToChar(Console.ReadLine()!.ToUpper());

if (movendo == 'S' && deveria == 'S')
{
    Console.WriteLine("\nÓtimo!");
}
else if (movendo == 'S' && deveria == 'N')
{
    Console.WriteLine("\nUse Silver Tape.");
}
else if (movendo == 'N' && deveria == 'S')
{
    Console.WriteLine("\nUse WD-40.");
}
else if (movendo == 'N' && deveria == 'N')
{
    Console.WriteLine("\nÓtimo!");
}
else
{
    Console.WriteLine("Responda apenas com S/N!");
}