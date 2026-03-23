namespace POO_Proyect_Cartas;
using static System.Console;

public class Mesa
{
    public int turnos { get; set; }
    public void Turno(ref Coleccion coleccion,ref Mazo mazo,ref Player player,ref Enemy enemy)
    {
        
        mazo.Shuffle(coleccion.cartas);
        mazo.LLamarCartas();
        WriteLine($"{mazo.CantidadMazo} cartas");
        //Turno
        while (true)
        {
            Write($"Turno: {turnos}\n" +
                  $"(1)CogerCarta\n" +
                  $"(2)Descartar carta\n");
            string input = ReadLine();
            if(input == "1"){mazo.CogerCarta(player); break;}
            if (input == "2" &&  player.cartasmano.Count > 0)
            {
                if (Descarte(mazo, player)) break;
            }
            else{WriteLine("input no valido");}
        }
        turnos++;
    }

    private static bool Descarte(Mazo mazo, Player player)
    {
        WriteLine("Que carta quieres descartar?");
        if (player.cartasmano.Count > 0){Nombrar_Carta(player, 0);}
        if (player.cartasmano.Count > 1){Nombrar_Carta(player, 1);}
        if (player.cartasmano.Count > 2){Nombrar_Carta(player, 2);}
        var input1 = ReadLine();
        if (input1 == "1")
        {
            mazo.Descartar_Carta(player, 0);
            return true;
        }
        if (input1 == "2" && player.cartasmano.Count > 1)
        {
            mazo.Descartar_Carta(player, 1);
            return true;
        }
        if (input1 == "3"&& player.cartasmano.Count > 2)
        {
            mazo.Descartar_Carta(player, 2);
            return true;
        }
        else{WriteLine("Input no válido");}

        return false;
    }

    private static void Nombrar_Carta(Player player, int i)
    {
        WriteLine($"Carta 1:{player.cartasmano[i].Nombre}");
        if (player.cartasmano[i].Nombre != "Especial")
        {
            WriteLine($"Carta 1 tipo:{player.cartasmano[i].Type}");
        }
        if (player.cartasmano[i] is Especiales esp)
        {
            WriteLine($"Carta 1 uso:{esp.Uso}");
        }
    }
}