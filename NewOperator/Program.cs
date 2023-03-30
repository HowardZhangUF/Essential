using System; /*  w  w  w  .  j a v  a 2 s.c  o  m*/

class MainClass
{
    public static void Main()
    {
        int i = new int(); // initialize i to zero 
        a hi = new a();
        a you = hi;//把hi指派給一個a 型別的變數
        you.b = 4;
        

        Console.WriteLine(you.b);
        Console.ReadLine();
    }
}

public class a
{
    public int b = 2;
    public int c = 3;
    
}