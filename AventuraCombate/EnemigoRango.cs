public class EnemigoRango
{
    private int vida;
    private int dano;
    private int municion;

    public EnemigoRango(int vidaInicial, int danoInicial, int municionInicial)
    {
        this.vida = vidaInicial;
        this.dano = danoInicial;
        this.municion = municionInicial;
    }

    public void RecibirDano(int cantidad)
    {
        vida -= cantidad;
        if (vida < 0)
        {
            vida = 0;
        }
    }

    public int ObtenerDano()
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

    public bool EstaVivo()
    {
        return vida > 0;
    }

    public int ObtenerMunicion()
    {
        return municion;
    }
}