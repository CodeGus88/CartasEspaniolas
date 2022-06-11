using CartasEspaniolasApp.statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasEspaniolasApp.models
{
    public class Baraja
    {
        public List<Carta> baraja { get; set; }

        public List<Carta> cartasSacadas { get; set; }

        public Baraja() {
            baraja = new List<Carta>();
            cartasSacadas =  new List<Carta>();
            generarBaraja();
        }

        // Genera las cartas para la baraja
        private void generarBaraja() {
            for (int i = 0; i < Recursos.PALOS.Length; i++)
            {
                for (int j = Recursos.LIMITE_INFERIOR; j <= Recursos.LIMITE_SUPERIOR; j++)
                {
                    if (!Recursos.EXCLUSIONES.Contains(j))
                    {
                        baraja.Add(new Carta((byte)j, Recursos.PALOS[i]));
                    }
                }
            }
        }

        // Cambia de posición todas las cartas aleatoriamente.
        public void barajar() {
            for (int i = 0; i < baraja.Count; i++) {
                Random random = new Random();
                int indice = random.Next(0, baraja.Count);
                Carta carta = baraja[i];
                baraja[i] = baraja[indice];
                baraja[indice] = carta;
            }
        }

        public Carta SiguienteCarta() {
            if (baraja.Count > 0)
            {
                Carta carta = baraja[0];
                cartasSacadas.Add(baraja[0]);
                baraja.RemoveAt(0);
                return carta;
            }
            else {
                Console.WriteLine("Ya no hay más cartas...");
                return null;
            }
        }

        public int cartasDisponibles() {
            return baraja.Count();
        }

        public List<Carta> darCartas(int cantidad){

            if (baraja.Count >= cantidad)
            {
                List<Carta> cartas = new List<Carta>();
                for (int i = 0; i < cantidad; i++)
                {
                    cartas.Add(baraja[0]);
                    cartasSacadas.Add(baraja[0]);
                    baraja.RemoveAt(0);
                   
                }
                return cartas;
            }
            else {
                return null;
            }
        }

        public List<Carta> cartasMonton()
        {
            if (cartasSacadas.Count > 0)
            {
                return cartasSacadas;
            }
            else {
                return null;
            }

        }

    }

}
