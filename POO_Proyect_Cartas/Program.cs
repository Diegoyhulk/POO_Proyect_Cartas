namespace POO_Proyect_Cartas;
using static System.Console;
class Program
{
    private static bool win;
    static void Main(string[] args)
    {
        Mazo mazo = new Mazo();
       Partida partida = new Partida();
       mazo.GenerarMazo();
       while (true)
       {
          
           partida.Turno(mazo);
           if(win){break;}
       }
        
    }
}