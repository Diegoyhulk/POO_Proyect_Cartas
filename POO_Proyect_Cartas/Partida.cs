namespace POO_Proyect_Cartas;
using static System.Console;

public class Partida
{
    public int turnos { get; set; }
    public void Turno()
    {
        Write($"{turnos}\n");
        ReadLine();
        Clear();
        turnos++;
    }
}