using System;

class Program
{ 
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 36; i++)
        {
            for(int j = 1; j <= 36; j++)
            {
                for(int x = 1; x <= 36; x++)
                {
                    if(i + j +x == 13 && i*j*x == 36)
                    {
                        Console.WriteLine(i + " " + x + " " + j + " ");
                    }
                }
            }
        }
    }
}
