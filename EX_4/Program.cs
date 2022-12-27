Console.Write("give me a positive number: ");
uint numder = Convert.ToUInt32(Console.ReadLine());
int[,] TwoArray = new int[numder, numder];
int yStart = 0, yEnd = 0, xStart = 0, xEnd = 0;

int digit = 1;
int y = 0;
int x = 0;

while (digit <= numder * numder)
{
    TwoArray[y,x] = digit;
    if (y == yStart && x < numder - xEnd - 1)
        ++x;
    else if (x == numder - xEnd - 1 && y < numder - yEnd - 1)
        ++y;
    else if (y == numder - yEnd - 1 && x > xStart)
        --x;
    else
        --y;

    if ((y == yStart + 1) && (x == xStart) && (xStart != numder - xEnd - 1))
    {
        ++yStart;
        ++yEnd;
        ++xStart;
        ++xEnd;
    }
    ++digit;
}

Console.WriteLine($"Заполнение спирально массива {numder} на {numder}.");
for (int k = 0; k < TwoArray.GetLength(0); k++)
{
    for (int l = 0; l < TwoArray.GetLength(1); l++)
    {
        Console.Write(TwoArray[k, l] + "\t");
    }
    Console.WriteLine();
}