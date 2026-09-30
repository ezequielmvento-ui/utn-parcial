using System.Net.Sockets;

public class Biblioteca
{
    public Dictionary<int, Material> Material { get; set; } = new Dictionary<int, Material>();

    public List<Material> MaterialPrestado { get; set; } = new List<Material>();

    public Dictionary<int, Socio> Espera { get; set; } = new Dictionary<int, Socio>();

    public void IngresarMaterial(Material material)
    {
        try
        {
            Material.Add(material.Codigo, material);
        }
        catch (Exception e)
        {
            throw new($"Se rechaza el alta porque ya esta dado de alta {e}");
        }
    }

    public string ConusltarMostrador(int codigo)
    {
        return $"El libro buscado es: {this.Material[codigo]}";
    }

    public void Devoluciones(Material material)
    {

        MaterialPrestado.Remove(material);
    }

    public void PedidoRetiro(Material material)
    {
        try
        {
            if (material.Retiro())
                MaterialPrestado.Add(material);
        }
        catch (Retiro r)
        {
            throw new($"El {material} solo se puede consultar en Sala {r}");
        }

    }

    public string MaterialOcupado(Material material, Socio socio)
    {
        if (MaterialPrestado.Contains(material))
        {
            Espera.Add(socio.Dni, socio);
            return $"Lo sentimos, el {material.Titulo} no esta disponible, te agregamos a lista de espera";
        }
        else
        {
            return $"Te podemos prestar el material {material.Titulo}";
        }


    }

    public double CalcularRecaudacion()
    {
        return 1000;
    }

    public double CalularMulta(Material material, int diasDeMora)
    {
        return material.MultaPorMora(diasDeMora);
    }

    public double CierreMes()
    {
        return 1000;
    }

}