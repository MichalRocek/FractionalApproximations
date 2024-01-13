static int DecimalPlaces(double number)
{
    int places = 0;
    while (number % 1 != 0)
    {
        number *= 10;
        places++;
    }
    return places;
}

double constant;
//constant = double.Parse(Console.ReadLine()!);
constant = Math.Exp(1);

long precision = (long)(constant * Math.Pow(10, DecimalPlaces(constant)));

while (precision % 2 == 0)
{
    precision /= 2;
}
while (precision % 5 == 0)
{
    precision /= 5;
}

Console.WriteLine(precision);
double reciprocal = 1 / constant;
Console.WriteLine(reciprocal);
double best = 0;
double turn = 0;
for (int i = 0; i < 100000000; i++)
{
    turn += reciprocal;
    if (turn - Math.Floor(turn) > best)  //vyřešit záporný
    {
        best = turn - Math.Floor(turn);
        Console.WriteLine((i + 1) + ", " + Math.Ceiling(turn));
        Console.WriteLine("Value: " + (i + 1) / Math.Ceiling(turn));
        Console.WriteLine("Deviation: " + ((i + 1) / Math.Ceiling(turn) - constant));

    }
    else if (turn - Math.Floor(turn) < 1 - best)
    {
        best = 1 - (turn - Math.Floor(turn));
        Console.WriteLine((i + 1) + ", " + Math.Floor(turn));
        Console.WriteLine((i + 1) / Math.Floor(turn));
        Console.WriteLine("Deviation: " + ((i + 1) / Math.Floor(turn) - constant));
    }
}

/*
Console.WriteLine(Math.PI);
Console.WriteLine(DecimalPlaces(Math.PI));*/