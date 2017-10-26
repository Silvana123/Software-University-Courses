using System;
/*
 * Чертае триъгълник от 10х10 звездички
 */
class Program
{
    static void Main(string[] args)
    {
        for (var i = 0; i <= 10; i++)
        {
            Console.WriteLine(new string ('*', 10));
        }
    }
}

