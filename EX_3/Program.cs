static uint AckermanFunction (uint numder1, uint numder2)
{

    if (numder1 == 0)
    return numder2 + 1;
  else
    if ((numder1 != 0) && (numder2 == 0))
      return AckermanFunction(numder1 - 1, 1);
    else
      return AckermanFunction(numder1 - 1, AckermanFunction(numder1, numder2 - 1));
}

Console.Write("give me a positive number 1: ");
uint numder1 = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("give me a positive number 2: ");
uint numder2 = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Ackerman Function {numder1}, {numder2}: {AckermanFunction(numder1, numder2)}");
