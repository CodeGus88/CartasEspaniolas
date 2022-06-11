

using CartasEspaniolasApp.models;

String pressedKey = "X";
String tab = "      ";
String margen = "**************************************************************";
Baraja baraja = new Baraja();
while(!pressedKey.Equals("7")) {
    Console.WriteLine("\n1 - Barajar\n2 - Mostrar siguiente carta\n3 - Mostrar número de cartas disponibles\n4 - Dar cartas\n5 - Mostrar cartas del monton\n6 - Mostrar baraja\n7 - Salir ");
    Console.Write("\nIngrese un número: ");
    pressedKey = Console.ReadLine();
    Console.Clear();
    Console.WriteLine(margen);
    switch (pressedKey) {
        case "1":
            Console.WriteLine("\n-> Barajar\n");
            baraja.barajar();
            Console.WriteLine($"{tab}Se barajó correctamente");
            Console.WriteLine();
            break;
        case "2":
            Console.WriteLine("\n-> Mostrar siguiente carta\n");
            Carta carta = baraja.SiguienteCarta();
            if (carta != null)
            {
                Console.WriteLine($"{tab}Carta sacada: |{carta.numero} de {carta.palo}|");
            }
            else {
                Console.WriteLine($"{tab}Ya no existen cartas disponibles");
            }
            
            Console.WriteLine();
            break;
        case "3":
            Console.WriteLine("\n-> Mostrar número de cartas disponibles\n");
            Console.WriteLine($"{tab}Total número de cartas disponibles: {baraja.cartasDisponibles()}");
            Console.WriteLine();
            break;
        case "4":
            Console.WriteLine("\n-> Dar cartas\n");
            Console.Write($"{tab}Ingresa la cantidad de cartas para dar: ");
            int cantidadCartas = int.Parse(Console.ReadLine());
            List<Carta> cartasDadas = baraja.darCartas(cantidadCartas);
            if (cartasDadas != null)
            {
                String mensaje = (cartasDadas.Count>0)? "Las cartas sacadas son:\n" : "Ninguna carta sacada\n";
                Console.Write($"{tab}{mensaje}");
                foreach (Carta c in cartasDadas)
                {
                    Console.WriteLine($"{tab}|{c.numero:00} de {c.palo}|  ");
                }
            }
            else {
                Console.WriteLine($"{tab}Ninguna carta sacada, cartas insuficientes"); ;
            }
            Console.WriteLine();
            break;
        case "5":
            Console.WriteLine("\n-> Mostrar cartas del montón\n");
            List<Carta> lista = baraja.cartasMonton();
            if (lista != null)
                foreach (Carta c in lista)
                {
                    Console.WriteLine($"{tab}|{c.numero:00} de {c.palo}|  ");
                }
            else
                Console.WriteLine($"{tab}Aún no salió ninguna carta....");
            Console.WriteLine();
            break;
        case "6":
            Console.WriteLine("\n-> Mostrar baraja\n");
            foreach (Carta c in baraja.baraja)
            {
                Console.WriteLine($"{tab}|{c.numero:00} de {c.palo}|  ");
            }
            Console.WriteLine();
            break;
        case "7":
            Console.WriteLine($"\n-> Salir...\n");
            break;
        default:
            Console.WriteLine($"\n-> Opción enválida!\n");
            break;
    }
    Console.WriteLine(margen);

}

