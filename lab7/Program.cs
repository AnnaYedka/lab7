using lab7;

Matrix a = new Matrix(2, 3, 3, 4);
Matrix b = new Matrix(5, 6, 9, -1);

Console.WriteLine("A: " + a.ToString());
Console.WriteLine("B: " + b.ToString());

if (a == b)
{
    Console.WriteLine("A equals B");
}
else
{
    Console.WriteLine("A is NOT equal to B");
}

Console.WriteLine("A + B = " + (a + b).ToString() );
Console.WriteLine("A - B = " + (a - b).ToString());
Console.WriteLine("A * B = " + (a * b).ToString());

Console.WriteLine("A * 5 = " + (a * 5).ToString());
Console.WriteLine("B / 2 = " + (b / 2).ToString());

Console.WriteLine("A to int: " + (int)a);