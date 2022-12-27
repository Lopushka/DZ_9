static int SumOfElements(int numder1, int numder2)
{
    if (numder1 >= numder2)
        return numder2;
    return numder1 + SumOfElements(numder1 + 1, numder2);
}

Console.Write("Give me a number 1: ");
int numder1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Give me a number 2: ");
int numder2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"sum of elements from {numder1} to {numder2}: {SumOfElements(numder1, numder2)}");
