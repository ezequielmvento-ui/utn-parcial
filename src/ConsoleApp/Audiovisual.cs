public class Audiovisual : Material
{
    public int diasTolerancia { get; set; }
    public Audiovisual(int codigo, string nombre, int anio, string autor) : base(codigo, nombre, anio, autor)
    {

    }

    public override double MultaPorMora(int diasDeMora)
    {
        if (this.diasTolerancia > diasDeMora)
        {
            return 500 * diasDeMora;
        }
        else
        {
            return 500 * diasDeMora + 3000;
        }

    }

    public override bool Retiro()
    {
        return true;
    }
}