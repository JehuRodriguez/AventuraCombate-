using AventuraCombate;

public class EnemigoRango : Entity
{
    private int municion;

    public EnemigoRango(int vidaInicial, int danoInicial, int municionInicial) : base(vidaInicial, danoInicial)
    {
        municion = municionInicial;
    }

    public override int ObtenerDano()
    {
        if (municion > 0)
        {
            municion--;
            return dano;
        }
        else
        {
            return 0;
        }
    }

    public int ObtenerMunicion()
    {
        return municion;
    }
}