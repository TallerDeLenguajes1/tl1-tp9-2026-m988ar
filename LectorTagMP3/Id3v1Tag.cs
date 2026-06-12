using System.Text;

class Id3v1Tag
{
    private string archivo;
    private string header;
    private string titulo;
    private string album;
    private string artista;
    private string fecha;
    private string comentario;
    private string genero;

    public string Archivo { get => archivo; set => archivo = value; }
    public string Header { get => header;}
    public string Titulo { get => titulo;}
    public string Album { get => album;}
    public string Artista { get => artista;}
    public string Fecha { get => fecha;}
    public string Comentario {get => comentario;}
    public string Genero {get => genero;}

    public void Cargar()
    {
        using (FileStream fs = new FileStream(Archivo, FileMode.Open))
            {
                fs.Seek(-128, SeekOrigin.End);
                
                byte[] buffer = new byte[128];

                fs.Read(buffer, 0, 128);

                
                header = Encoding.UTF8.GetString(buffer, 0 ,3);

                
                titulo = Encoding.UTF8.GetString(buffer, 3 ,30);

                
                album = Encoding.UTF8.GetString(buffer, 63 ,30);

                
                artista = Encoding.UTF8.GetString(buffer, 33 ,30);

                
                fecha = Encoding.UTF8.GetString(buffer, 93 ,4);

                
                comentario = Encoding.UTF8.GetString(buffer, 97 ,30);

                
                genero = Encoding.UTF8.GetString(buffer, 127, 1);

            }
    }

    
}