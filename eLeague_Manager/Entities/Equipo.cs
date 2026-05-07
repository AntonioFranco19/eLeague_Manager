namespace eLeague_Manager.Entities;

public class Equipo
{
    public string Nombre { get; set; }
    public DateOnly Fecha { get; set; }
    public List<Jugador> Jugadores { get; set; } = [];
    public PerfilEstadisticas Estadisticas { get; set; }
}