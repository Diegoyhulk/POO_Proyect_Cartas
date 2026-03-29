namespace POO_Proyect_Cartas;

public class Jugador
{
    public List<Coleccion.Cartas> cartasmano = new List<Coleccion.Cartas>();
    public Coleccion.Cartas[] organos = new Organos[5];
    public void poner_organos(int i)
    {
        if (cartasmano[i] is Organos organo)
        {
            switch (organo.Type)
            {
                case "Sanguíneo":
                {
                    organos[0] = cartasmano[i];
                    cartasmano.RemoveAt(i);
                    break;
                }
                case "Ósseo":
                {
                    organos[1] = cartasmano[i];
                    cartasmano.RemoveAt(i);
                    break;
                }
                case "Neuronal":
                {
                    organos[2] = cartasmano[i];
                    cartasmano.RemoveAt(i);
                    break;
                }
                case "Gástrico":
                {
                    organos[3] = cartasmano[i];
                    cartasmano.RemoveAt(i);
                    break;
                }
                case "Comodín":
                {
                    organos[4] = cartasmano[i];
                    cartasmano.RemoveAt(i);
                    break;
                }
            }
        }
        
    }
}
public class Player : Jugador
{
    
}
public class Enemy : Jugador
{
    
}