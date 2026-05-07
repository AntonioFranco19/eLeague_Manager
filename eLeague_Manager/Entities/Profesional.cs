using eLeague_Manager.Interfaces;

namespace eLeague_Manager.Entities;

public class Profesional : Jugador, IEntrevistable
{
    public decimal Sueldo { get; set; }
    public string Patrocinador { get; set; }
    
    public void DarDeclaraciones()
    {
        Console.WriteLine($"Sueldo: {Sueldo}");
    }
}