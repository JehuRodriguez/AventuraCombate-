using System;


namespace AventuraCombate
{
    public abstract class Entity
    {
        protected int vida;
        protected int dano;

        public Entity(int vidaInicial, int danoInicial)
        {
            vida = vidaInicial;
            dano = danoInicial;
        }

        public void RecibirDano(int cantidad)
        {
            vida -= cantidad;
            if (vida < 0)
            {
                vida = 0;
            }
        }

        public bool EstaVivo()
        {
            return vida > 0;
        }

        public int ObtenerVida()
        {
            return vida;
        }

        public abstract int ObtenerDano();

    }
}
