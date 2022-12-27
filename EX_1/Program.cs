static void OutputCounter( int i)
{
    Console.Write(i + " ");
    if (i<=1)
        return;
    
    i--;
    OutputCounter(i);
}


Console.Write("Give me a number: ");
int numder = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
OutputCounter(numder);
