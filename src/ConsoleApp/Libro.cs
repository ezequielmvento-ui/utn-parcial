public class Libro : Material
{
    public Libro(int codigo, string nombre, int anio, string autor) : base(codigo, nombre, anio, autor)
    {

    }

    public override double MultaPorMora(int diasDeMora)
    {
        return 200*diasDeMora;
    }

    public override bool Retiro()
    {
        return true;
    }
}