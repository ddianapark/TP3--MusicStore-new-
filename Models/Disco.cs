namespace TP3_MusicStore_new_.Models;

public class Disco
{
    public string Id { get; private set; }
    public string Titulo { get; private set; }
    public string Artista { get; private set; }
    public string Productor { get; private set; }
    public string Genero { get; private set; }
    public List<string> Temas { get; private set; }
    public string FotoUrl { get; private set; }

    public Disco (string Id, string Titulo, string Artista, string Productor, string Genero, List<string> Temas, string FotoUrl)
    {
        this.Id = Id;
        this.Titulo = Titulo;
        this.Artista = Artista;
        this.Productor = Productor;
        this.Genero = Genero;
        this.Temas = Temas;
        this.FotoUrl = FotoUrl;
    }
}

