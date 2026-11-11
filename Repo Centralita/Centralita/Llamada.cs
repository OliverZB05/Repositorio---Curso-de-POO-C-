public abstract class Llamada
{
    // El modificador 'protected' (representado con '#' en tu diagrama) es un "secreto familiar".
    // Significa que estas variables SOLO pueden ser usadas por esta clase (Llamada) 
    // y por sus clases hijas (Local y Provincial). Nadie más de afuera puede tocarlas.
    protected float duracion;
    protected string nroDestino;
    protected string nroOrigen;
    // 'public' (+) significa que todos pueden verlo. 'get' significa que solo pueden LEERLO.
    // No hay 'set', por lo que una vez creada la llamada, es imposible cambiar su duración desde afuera.

    public float Duracion { get { return duracion; } }
    public string NroDestino { get { return nroDestino; } }
    public string NroOrigen { get { return nroOrigen; } }

    // ¡AQUÍ ESTÁ LA HERENCIA EN ACCIÓN!
    // 'abstract' obliga a las clases hijas (Local y Provincial) a programar este cálculo. 
    // La clase base dice: "No sé cómo calcular el costo, ustedes háganlo".
    public abstract float CostoLlamada { get; }

    // El constructor es el "acta de nacimiento". Recibe los datos.
    public Llamada(string nroOrigen, string nroDestino, float duracion)
    {
        this.nroOrigen = nroOrigen;
        this.nroDestino = nroDestino;
        this.duracion = duracion;
    }

    // 'protected' porque solo lo usan las clases de la familia.
    // 'virtual' es clave para la herencia: significa que las clases hijas PUEDEN usar este método 
    // y sobrescribirlo (agregarle más texto) sin perder esta base.
    protected virtual string Mostrar()
    {
        // NOTA: El enunciado pedía usar StringBuilder. El código entregado usa interpolación ($"") que es más moderna, 
        // pero logra el mismo objetivo: armar un texto con los datos comunes.
        return $"Duración: {this.duracion} min. Origen: {this.nroOrigen} - Destino: {this.nroDestino}";
    }

    // Sobrecarga de operadores == y !=
    // 'static' significa que este método NO pertenece a un objeto específico (como "la llamada de Juan"), 
    // sino a la CLASE general "Llamada". Es como una herramienta de la fábrica, no del auto.
    public static bool operator ==(Llamada l1, Llamada l2)
    {
        // Si ambos son nulos o ambos son la misma instancia
        if (ReferenceEquals(l1, null) || ReferenceEquals(l2, null)) return false;
        if (ReferenceEquals(l1, l2)) return true;

        // Aquí se apoya en el Equals de las clases derivadas para el tipo concreto
        if (l1.Equals(l2))
        {
            return l1.nroOrigen == l2.nroOrigen && l1.nroDestino == l2.nroDestino;
        }
        return false;
    }

    public static bool operator !=(Llamada l1, Llamada l2)
    {
        return !(l1 == l2);
    }

    // Método estático para ordenar
    public static int OrdenarPorDuracion(Llamada a, Llamada b)
    {
        return a.duracion.CompareTo(b.duracion);
        // CompareTo hace la magia: 
        // Retorna -1 si 'a' es menor que 'b'.
        // Retorna 0 si son iguales.
        // Retorna 1 si 'a' es mayor que 'b'.
        // Esto es exactamente lo que necesita el método .Sort() de las listas para ordenar de menor a mayor.
    }
}