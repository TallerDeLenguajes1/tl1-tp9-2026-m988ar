
class Directorio
{
    public static void existe(string carpeta)
    {
        if (Directory.Exists(carpeta))
        {
            System.Console.WriteLine("Carpetas:");
            foreach (string nombreCarpeta in Directory.GetDirectories(carpeta))
            {
                System.Console.WriteLine($"_{nombreCarpeta.Split('\\').LastOrDefault()}");
            }
            System.Console.WriteLine("Archivos:");
            foreach (string NombreArchivo in Directory.GetFiles(carpeta))
            {
                FileInfo archivo = new FileInfo(NombreArchivo);
                System.Console.WriteLine($"_{archivo.Name} {archivo.Length / 1000}kb");
            }
            using (StreamWriter reporte = new StreamWriter(System.IO.Path.Combine(carpeta, "reporte_archivos.csv")))
            {
                reporte.WriteLine("Nombre,Tamanio,Ultima Modificacion");
                foreach (string NombreArchivo in Directory.GetFiles(carpeta))
                {
                    FileInfo archivo = new FileInfo(NombreArchivo);
                    reporte.WriteLine($"{archivo.Name},{Math.Round((double)(archivo.Length / 1000),2)}KB,{archivo.CreationTime}");
                }
            }
        }
        else
        {
            System.Console.WriteLine("Ese path no existe eztupido!!!");
        }
    }
}