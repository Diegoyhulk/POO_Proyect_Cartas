using System.ComponentModel;

namespace POO_Proyect_Cartas;
using static System.Console;

public class Mazo
{
    public Queue<Coleccion.Cartas> coleccion = new Queue<Coleccion.Cartas>();
    public int CantidadMazo => coleccion.Count;

    public void Shuffle(List<Coleccion.Cartas> cartas)
    {
        while (cartas.Count > 0)
        {
            int rand = new Random().Next(0, cartas.Count);
            coleccion.Enqueue(cartas[rand]);
            cartas.Remove(cartas[rand]);
        }
    }
    public void LLamarCartas()
    {
        foreach (Coleccion.Cartas carta in coleccion)
        {
            WriteLine(carta.Nombre);
            if (carta.Type != null)
            {
                WriteLine(carta.Type);
            }
            if (carta is Especiales esp)
            {
                WriteLine(esp.Uso);
            }
        }
    }
    public void CogerCarta(Jugador p)
    {
        if (p.cartasmano.Count == 3){WriteLine("Tienes no puedes coger más!");
            WriteLine("Pulsa cualquier tecla para continuar");
            ReadLine(); return;}
        WriteLine($"Has cogido la carta{coleccion.Peek().Nombre}");
        p.cartasmano.Add(coleccion.Dequeue());
        WriteLine($"Pulsa cualquier tecla para continuar");
        ReadLine();
    }

    public void CartasIniciales(Jugador p)
    {
        for (int i = 0; i < 3; i++)
        {
            WriteLine($"Has cogido la carta{coleccion.Peek().Nombre}");
            p.cartasmano.Add(coleccion.Dequeue());
        }
    }
    public void Descartar_Carta(List<Coleccion.Cartas> cartas,Jugador p, int i)
    {
        WriteLine($"Carta eliminada: {p.cartasmano[i].Nombre}");
        cartas.Add(p.cartasmano[i]);
        p.cartasmano.Remove(p.cartasmano[i]);
        WriteLine("Pulsa cualquier tecla para continuar");
        ReadLine();
    }

    public void ECogerCarta(Enemy e)
    {
        e.cartasmano.Add(coleccion.Dequeue());
    }
}