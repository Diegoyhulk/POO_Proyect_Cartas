namespace POO_Proyect_Cartas;
using static System.Console;

public class Mesa
{
    public int turnos { get; set; }
    public void Turno(Mazo mazo, Player player, Enemy enemy)
    {
        mazo.LLamarCartas();
        WriteLine($"{mazo.CantidadCartas} cartas");
        //Turno
        while (true)
        {
            Write($"{turnos}\n" +
            
                  $"(1)CogerCarta\n");
            string input = ReadLine();
            if(input == "1"){mazo.CogerCarta(); break;}
            else{WriteLine("input no valido");}
        }
        turnos++;
    }
}