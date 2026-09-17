public class Player
{
    private int vida;
    private int dano;

    public Player(int vidaInicial, int danoInicial)
    {
        this.vida = vidaInicial;
        this.dano = danoInicial;
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
        return dano;
    }

    public int ObtenerVida()
    {
        return vida;
    }
}
