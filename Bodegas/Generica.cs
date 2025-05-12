using Dsw2025Ej9.Entidades;
using System.Collections;

namespace Dsw2025Ej9.Bodegas;

public class Generica<T> where T : IMercancia
{
    private readonly List<T> _items = new List<T>();
    private readonly string _nombre;

    public Generica(string nombre)
    {
        _nombre = nombre;
    }

    public string Nombre => _nombre;

    public void Agregar(T item)
    {
        _items.Add(item);
    }

    public T Obtener(int index)
    {
        if (_items.Count == 0 || index >= _items.Count)
            throw new Exception("No hay elementos en la bodega");
        return _items[index]!;
    }

    public List<T> Listar() => _items;

    public void MostrarContenido()
    {
        Console.WriteLine($"Contenido de la bodega '{Nombre}':");
        foreach (var item in _items)
        {
            Console.WriteLine($"- {item.Nombre}");
        }
    }
}
