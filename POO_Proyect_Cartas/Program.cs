namespace POO_Proyect_Cartas;
using static System.Console;
class Program
{
    private static bool win;
    static void Main(string[] args)
    {
        Player player = new Player();
        Enemy enemy = new Enemy();
        Mazo mazo = new Mazo();
       Mesa mesa = new Mesa();
       mazo.GenerarMazo();
       while (true)
       {
           
           mesa.Turno(mazo,player,enemy);
           if(win){break;}
       }
        
    }
}