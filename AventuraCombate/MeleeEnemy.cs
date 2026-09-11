{
    private int vida;
    private int dano;

    public MeleeEnemy(int vidaInicial, int danoInicial)
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

    public bool EstaVivo()
    {
        return vida > 0;
    }
}