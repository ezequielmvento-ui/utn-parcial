public abstract class Material
{
    public string Titulo { get; set; }

    public int Anio { get; set; }

    public string Autor { get; set; }

    public int Codigo { get; set; }


    public Material(int codigo, string titulo, int anio, string autor)
    {
        this.Codigo = codigo;
        this.Titulo = titulo;
        this.Anio = anio;
        this.Autor = autor;
    }

    public abstract bool Retiro();

    public abstract double MultaPorMora(int diasDeMora);

    internal double MultaPorMora(object diasDeMora)
    {
        throw new NotImplementedException();
    }
}