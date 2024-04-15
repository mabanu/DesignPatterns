namespace DesingPatterns.CustomClass;
internal class CustomClassTest
{
    public static Padre GetCustomClassTest()
    {
        Console.WriteLine("It worked!...");

        var result = new Hijo() { NamePadre = "Maxi", NameHijo = "Hugo" };

        Console.WriteLine(result.ToString());

        return result;
    }
}
