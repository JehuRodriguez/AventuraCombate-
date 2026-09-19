using AventuraCombate;

public class MeleeEnemy : Entity
{
    public MeleeEnemy(int vidaInicial, int danoInicial) : base(vidaInicial, danoInicial)
    {
    }

    public override int ObtenerDano()
    {
        return dano;
    }
}
