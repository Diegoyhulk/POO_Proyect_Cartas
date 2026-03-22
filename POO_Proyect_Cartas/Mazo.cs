using System.Collections;

using static System.Console;
namespace POO_Proyect_Cartas;

public class Mazo
{
    public List<Cartas> cartas { get; set; } = new List<Cartas>();

    public int CantidadCartas => cartas.Count;
    public abstract class Cartas
    {
        public abstract string Nombre { get; set; }
        public string Type;
    }

    public void LLamarCartas()
    {
        foreach (Cartas carta in cartas)
        {
            Console.WriteLine(carta.Nombre);
            if (carta.Type != null)
            {
                Console.WriteLine(carta.Type);
            }
            if (carta is Especiales esp)
            {
                Console.WriteLine(esp.Uso);
            }
        }
    }
    
    public void GenerarMazo()
    {
        for (int i = 1; i <= 21; i++)
        {
            switch (i)
            {
                case <= 5:
                    cartas.Add(new Organos
                    {
                        Type = "Sanguíneo"
                    });
                    break;
                case <= 10 and >5:
                    cartas.Add(new Organos
                    {
                        Type = "Ósseo"
                    });
                    break;
                case <= 15 and > 10:
                    cartas.Add(new Organos
                    {
                        Type = "Neuronal"
                    });
                    break;
                case <= 20 and >15:
                    cartas.Add(new Organos
                    {
                        Type = "Gástrico"
                    });
                    break;
                case <= 21 and >20:
                    cartas.Add(new Organos
                    {
                        Type = "Comodín"
                    });
                    break;
            }
        }
        for (int i = 1; i <= 17; i++)
        {
            switch (i)
            {
                case <= 4:
                    cartas.Add(new Bacterias
                    {
                        Type = "Sanguíneo"
                    });
                    break;
                case <= 8 and >4:
                    cartas.Add(new Bacterias
                    {
                        Type = "Ósseo"
                    });
                    break;
                case <= 12 and > 8:
                    cartas.Add(new Bacterias
                    {
                        Type = "Neuronal"
                    });
                    break;
                case <= 16 and >12:
                    cartas.Add(new Bacterias
                    {
                        Type = "Gástrico"
                    });
                    break;
                case <= 17 and >16:
                    cartas.Add(new Bacterias
                    {
                        Type = "Comodín"
                    });
                    break;
            }
        }
        for (int i = 1; i <= 20; i++)
        {
            switch (i)
            {
                case <= 4:
                    cartas.Add(new Curas
                    {
                        Type = "Sanguíneo"
                    });
                    break;
                case <= 8 and >4:
                    cartas.Add(new Curas
                    {
                        Type = "Ósseo"
                    });
                    break;
                case <= 12 and > 8:
                    cartas.Add(new Curas
                    {
                        Type = "Neuronal"
                    });
                    break;
                case <= 16 and >12:
                    cartas.Add(new Curas
                    {
                        Type = "Gástrico"
                    });
                    break;
                case <= 20 and >16:
                    cartas.Add(new Curas
                    {
                        Type = "Comodín"
                    });
                    break;
            }
        }
        for (int i = 1; i <= 10; i++)
        {
            if (i <= 2)
            {
                cartas.Add(new Especiales{Uso ="Robo"});
            }
            if (i is <= 4 and >2)
            {
                cartas.Add(new Especiales{Uso ="Descarte"});
            }
            if (i is <= 6 and >4)
            {
                cartas.Add(new Especiales{Uso ="Transplante"});
            }
            if (i is <= 8 and >6)
            {
                cartas.Add(new Especiales{Uso ="Error"});
            }
            if (i is <= 10 and >8)
            {
                cartas.Add(new Especiales{Uso ="Contagio"});
            }
        }
    }

    public void CogerCarta()
    {
        while (true)
        {
            int rand = new Random().Next(1, cartas.Count);
            if (cartas[rand] != null)
            {
                Eliminar_Carta(rand);
                break;
            }
        }
    }

    private void Eliminar_Carta(int i)
    {
        WriteLine($"Carta cogida: {cartas[i].Nombre}");
        cartas.Remove(cartas[i]);
        WriteLine($"Carta eliminada: {cartas[i].Nombre}");
        WriteLine($"Pulsa cualquier tecla para continuar");
        ReadLine();
    }
}

public class Organos : Mazo.Cartas
{
    public override string Nombre { get; set; } = "Organo";
}

public class Bacterias : Mazo.Cartas
{
    public override string Nombre { get; set; } = "Bacteria";
}

public class Curas : Mazo.Cartas
{
    public override string Nombre { get; set; } = "Cura";
}

public class Especiales : Mazo.Cartas
{
    public override string Nombre { get; set; } = "Especial";
    public string Uso;
}