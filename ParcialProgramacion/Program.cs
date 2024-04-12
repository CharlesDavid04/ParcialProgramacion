class gestor_vuelos
{
    public static void Main(string[] args)
    {
        //Declaramos variables que influyen en el costo del vuelo
        string nombre;
        string pais;
        double costo;
        int dias;
        string clase;
        //Se piden los datos al usuario
        Console.WriteLine("Hola bienvenido al sistema para compra de boletos aéreos");
        Console.WriteLine("Ingrese su nombre para continuar");
        nombre = Console.ReadLine();   
        
        Console.WriteLine("Escriba el destino de su viaje"); //Aqui tienen que ir todos los paises del mundo
        pais = Console.ReadLine();

        switch (pais.ToUpper()) // El ToUpper es para cambiar lo que ingrese el usuario a todo mayusculas
        {

            //ASIA
            case "AFGANISTAN":

                Console.WriteLine("¿Cuantos dias planea viajar?"); //dias de duracion del viaje
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:"); //clase del viaje
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                //el IF esta para que el precio varie dependiendo de la clase

                if (clase == "turista")
                {
                    costo = dias * 30;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if(clase == "primera clase")
                {
                    costo = dias * 70;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if(clase == "negocios")
                {
                    costo = dias * 50;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                
                break;

            case "ARABIA SAUDITA":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:"); 
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 50;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 100;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 75;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "ARMENIA":

                Console.WriteLine("¿Cuantos dias planea viajar?"); 
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:"); 
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 78;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 196;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 100;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "AZERBAIYAN":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 70;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 180;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 115;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "BANGLADESH":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 75;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 190;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 108;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "BAREIN":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 65;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 180;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 98;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "BIRMANIA":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 95;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 170;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 128;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "BRUNEI":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 120;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 220;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "BUTAN":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 390;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 200;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "CAMBOYA":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 105;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 290;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 108;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "CATAR":

                Console.WriteLine("¿Cuantos dias planea viajar?"); 
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 100;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 125;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "CHINA":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 250;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 200;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "CHIPRE":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 120;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 200;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 175;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "COREA DEL NORTE":
                
                Console.WriteLine("Lo sentimos pero las leyes de este pais no nos permiten realizar un vuelo hacia este destino");
              
                break;

            case "COREA DEL SUR":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 200;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 300;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 225;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "EMIRATOS ARABES UNIDOS":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 500;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 1200;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 700;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "FILIPINAS":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 90;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 130;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 115;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "INDIA":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 220;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 280;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 115;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "INDONESIA":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 100;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 125;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "IRAK":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 220;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 300;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 255;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "IRAN":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 300;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 250;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "ISRAEL":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 300;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 600;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 400;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "JAPON":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 90;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 125;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "JORDANIA":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 250;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 300;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 265;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "KAZAJISTAN":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 165;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 215;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 190;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "KIRGUISTAN":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 90;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 105;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "KUWAIT":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 400;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 550;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 425;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "LAOS":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 120;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 180;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 145;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "LIBANO":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 220;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 300;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 250;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "MALASIA":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 90;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 135;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "MALDIVAS":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 100;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 125;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "MONGOLIA":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 250;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 165;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "NEPAL":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 90;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 110;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 95;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "OMAN":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 110;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 165;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 145;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "PAKISTAN":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 250;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 175;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "SINGAPUR":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 80;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 90;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 85;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "SIRIA":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 50;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 80;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 65;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "SRI LANKA":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 110;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 135;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "TAILANDIA":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 100;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 125;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "TAYIKISTAN":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 60;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 75;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 85;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "TIMOR ORIENTAL":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 50;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 80;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 65;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "TURKMENISTAN":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 130;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 175;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 155;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "TURQUIA":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 200;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 215;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 205;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "UZBEKISTAN":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 265;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 207;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "VIETNAM":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 250;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 350;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 265;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "YEMEN":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 90;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 160;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 125;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            //AFRICA
            case "ANGOLA":

                Console.WriteLine("¿Cuantos dias planea viajar?"); 
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:"); 
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 75;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 200;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 85;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "ARGELIA":

                Console.WriteLine("¿Cuantos dias planea viajar?"); 
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:"); 
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 125;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 225;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "BENIN":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:"); 
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 125;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 220;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 135;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "BOTSUANA":

                Console.WriteLine("¿Cuantos dias planea viajar?"); 
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:"); 
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 115;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 236;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 170;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "BURUNDI":

                Console.WriteLine("¿Cuantos dias planea viajar?"); 
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:"); 
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 225;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 170;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "CAMERUN":

                Console.WriteLine("¿Cuantos dias planea viajar?"); 
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:"); 
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 140;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 250;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 170;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "COMORAS":

                Console.WriteLine("¿Cuantos dias planea viajar?"); 
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 140;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 200;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 175;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "BURKINA FASO":

                Console.WriteLine("¿Cuantos dias planea viajar?"); 
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:"); 
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 125;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 225;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "CABO VERDE":

                Console.WriteLine("¿Cuantos dias planea viajar?"); 
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:"); 
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 100;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 125;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "REPUBLICA CENTROAFRICANA":

                Console.WriteLine("¿Cuantos dias planea viajar?"); 
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:"); 
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();               

                if (clase == "turista")
                {
                    costo = dias * 130;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 240;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 160;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "CHAD":

                Console.WriteLine("¿Cuantos dias planea viajar?"); 
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:"); 
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();             

                if (clase == "turista")
                {
                    costo = dias * 140;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 160;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "YIBUTI":

                Console.WriteLine("¿Cuantos dias planea viajar?"); 
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:"); 
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();


                if (clase == "turista")
                {
                    costo = dias * 160;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 200;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 175;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            case "EGIPTO":

                Console.WriteLine("¿Cuantos dias planea viajar?"); 
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:"); 
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                if (clase == "turista")
                {
                    costo = dias * 180;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 250;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 200;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }
                break;

            //OCEANIA

            case "AUSTRALIA":

                Console.WriteLine("¿Cuantos dias planea viajar?"); 
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:"); 
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();

                

                if (clase == "turista")
                {
                    costo = dias * 175;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 200;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 250;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "ISLA NOLFORK":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 170;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 190;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 225;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "ISLAS COCOS":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 170;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 200;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 240;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "ISLA DE NAVIDAD":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 180;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 205;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 260;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "NUEVA ZELANDA":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 170;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 190;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 225;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "NIUE":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 175;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 195;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 230;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "ISLAS COOK":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 160;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 170;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 200;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "ISLAS MARIANAS DEL NORTE":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 200;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 250;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 275;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "MICRONESIA":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 170;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 200;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 275;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "NAURU":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 200;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 275;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 325;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "FIYI":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 180;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 200;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 275;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "GUAM":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 170;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 190;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 225;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "KIRIBATI":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 170;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 190;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 225;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "NUEVA CALEDONIA":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 210;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 250;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 290;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "PALAOS":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 175;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 205;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 245;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "POLINESIA FRANCESA":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 140;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 170;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 200;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "ISLAS COOK (NUEVA ZELANDA)":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 100;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 130;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 190;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "ISLAS MARSHALL":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 120;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 140;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 175;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "ISLAS SALOMON":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 170;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 190;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 210;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "SAMOA":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 200;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 225;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "TONGA":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 100;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 120;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 245;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "TUVALU":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 100;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 115;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 135;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "VANATU":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 150;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 170;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 195;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;

            case "WALLIS Y FUTUNA":

                Console.WriteLine("¿Cuantos dias planea viajar?");
                dias = int.Parse(Console.ReadLine());

                Console.WriteLine("Escoja la clase de su vuelo:");
                Console.WriteLine("Turista");
                Console.WriteLine("Primera clase");
                Console.WriteLine("Negocios");
                clase = Console.ReadLine();



                if (clase == "turista")
                {
                    costo = dias * 170;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "primera clase")
                {
                    costo = dias * 190;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                if (clase == "negocios")
                {
                    costo = dias * 225;
                    Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                }

                break;
        }
        
    }
}