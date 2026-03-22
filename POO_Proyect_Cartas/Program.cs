namespace POO_Proyect_Cartas;
using static System.Console;

class Program
{
    private static bool win;
    static void Main(string[] args)
    {
       Partida partida = new Partida();
       while (true)
       {
           partida.Turno();
           if(partida.turnos >= 3){win=true;}
           if(win){break;}
       }
        
    }
}