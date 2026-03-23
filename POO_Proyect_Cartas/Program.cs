namespace POO_Proyect_Cartas;
using static System.Console;
class Program
{
    private static bool win;
    static void Main(string[] args)
    {
        Mazo mazo = new Mazo();
        Player player = new Player();
        Enemy enemy = new Enemy();
        Coleccion coleccion = new Coleccion();
       Mesa mesa = new Mesa();
       coleccion.GenerarMazo();
       mazo.Shuffle(coleccion.cartas);
       mazo.CartasIniciales(player);
       while (true)
       {
           mesa.Turno(ref coleccion,ref mazo,ref player,ref enemy);
           if(win){break;}
       }
        
    }
}