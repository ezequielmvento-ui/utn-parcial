public class Revistas : Material
{

    public Revistas(int codigo, string nombre, int anio, string autor) : base(codigo, nombre, anio, autor)
    {

    }

    public override double MultaPorMora(int diasDeMora)
    {
        return 100*diasDeMora;
    }

    public override bool Retiro()
    {
        return false;
    }
}