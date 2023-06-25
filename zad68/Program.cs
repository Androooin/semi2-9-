int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0 && m > 0) return Akkerman(m - 1, 1);
    else return (Akkerman(m - 1, Akkerman(m, n - 1)));
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");
}



int digitM = ReadInt("Write your digit m ");
int digitN = ReadInt("Write your digit n ");
Console.WriteLine($"A(m,n) = {Akkerman(digitM, digitN)}");
Lutsenko();