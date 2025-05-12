namespace Dsw2025Ej9.Entidades;

public class Alimento : IMercancia
{
    public string Nombre { get; }
    public Alimento(string nombre) => Nombre = nombre;
}
