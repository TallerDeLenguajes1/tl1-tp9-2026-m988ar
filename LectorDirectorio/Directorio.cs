
class Directorio
{
    public static void existe(string carpeta)
    {
        if(Directory.Exists(carpeta))
        {
            System.Console.WriteLine("COSAS");
        }
        else
        {
            System.Console.WriteLine("Ese path no existe eztupido!!!");
        }
    }
}