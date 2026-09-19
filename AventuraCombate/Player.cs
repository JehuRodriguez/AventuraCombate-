using AventuraCombate;

public class Player : Entity
{
    public Player(int vidaInicial, int danoInicial) : base(vidaInicial, danoInicial)
    {
    }

    public override int ObtenerDano()
    {
        return dano;
    }
}
