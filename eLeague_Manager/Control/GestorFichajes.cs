using eLeague_Manager.Entities;

namespace eLeague_Manager.Control;

public class GestorFichajes
{
    public bool Fichar(Equipo equipo, Jugador jugador)
    {
        Console.WriteLine("Fichar");
        return true;
    }
    public bool DarDeBaja(Equipo equipo, Jugador jugador)
    {
        Console.WriteLine("Dar De Baja");
        return true;
    }
}