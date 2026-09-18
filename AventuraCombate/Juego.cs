using System;
using System.Collections.Generic;

namespace AventuraCombate
{
    internal class Juego
    {
        private Player jugador;
        private List<Entity> enemigos;

        public void IniciarJuego()
        {
            Console.Write("Vida de tu personaje (max 100): ");
            int vida = int.Parse(Console.ReadLine());
            while (vida > 100 || vida <= 0)
            {
                Console.Write("Valor invalido. Vida de tu personaje (max 100): ");
                vida = int.Parse(Console.ReadLine());
            }

            Console.Write("Daño de tu personaje (max 100): ");
            int dano = int.Parse(Console.ReadLine());
            while (dano > 100 || dano <= 0)
            {
                Console.Write("Valor invalido. Daño de tu personaje (max 100): ");
                dano = int.Parse(Console.ReadLine());
            }

            jugador = new Player(vida, dano);

            enemigos = new List<Entity>();
            enemigos.Add(new MeleeEnemy(50, 10));
            enemigos.Add(new EnemigoRango(40, 15, 5));

            Jugar();
        }

        private void Jugar()
        {
            while (jugador.EstaVivo() && enemigos.Count > 0)
            {
                Console.WriteLine("\nElige un enemigo (0 a " + (enemigos.Count - 1) + "):");
                for (int i = 0; i < enemigos.Count; i++)
                {
                    Console.WriteLine(i + " - Vida: " + enemigos[i].ObtenerVida());
                }
                int indice = int.Parse(Console.ReadLine());
                Entity enemigo = enemigos[indice];

                enemigo.RecibirDano(jugador.ObtenerDano());
                Console.WriteLine("Le hiciste daño al enemigo.");

                if (!enemigo.EstaVivo())
                {
                    Console.WriteLine("Enemigo eliminado.");
                    enemigos.Remove(enemigo);
                }

                if (enemigos.Count == 0)
                {
                    break;
                }

                int danoRecibido = enemigos[0].ObtenerDano();
                jugador.RecibirDano(danoRecibido);
                Console.WriteLine("El enemigo te hizo " + danoRecibido + " de daño. Tu vida: " + jugador.ObtenerVida());
            }

            if (jugador.EstaVivo())
            {
                Console.WriteLine("¡Victoria!");
            }
            else
            {
                Console.WriteLine("Derrota.");
            }


        }
    }
}
