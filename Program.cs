


class Program
{
    static void Main(string[] args)
    {
        byte aggression = 1;
        byte democracyModifier = 2;

        try
        {
            checked
            {
                aggression = (byte)(aggression - democracyModifier); //  сужающее преобразование ланных
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine("Ошибка");
        }
        
        

        Console.WriteLine(aggression);


        int a = int.MaxValue;
        a = a + 1; // переполнение через верзную границу
        Console.WriteLine(a);

        int b = int.MinValue;
        b = b - 1; // переполнение через нижную границу
        Console.WriteLine(checked(b));
       
    }
}