


class Program
{
    static void Main(string[] args)
    {
        byte aggression = 1;
        byte democracyModifier = 2;


        checked
        {
            aggression = (byte)(aggression - democracyModifier); //  сужающее преобразование ланных
        }
        

        Console.WriteLine(aggression);


        int a = int.MaxValue;
        a = a + 1; // переполнение через верзную границу
        Console.WriteLine(a);

        int b = int.MinValue;
        b = b - 1; // переполнение через нижную границу
        Console.WriteLine(b);
    }
}