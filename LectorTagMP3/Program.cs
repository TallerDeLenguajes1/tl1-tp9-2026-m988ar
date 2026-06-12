System.Console.WriteLine("Ingrese el path del archivo mp3");
Id3v1Tag mp3 = new Id3v1Tag();
mp3.Archivo = Console.ReadLine();
 mp3.Cargar();

 System.Console.WriteLine($"Nombre de la cancion: {mp3.Titulo}");
 System.Console.WriteLine($"Artista: {mp3.Artista}");
 System.Console.WriteLine($"Album: {mp3.Album}");
 System.Console.WriteLine($"Fecha: {mp3.Fecha}");