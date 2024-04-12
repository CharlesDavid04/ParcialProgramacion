﻿class gestor_vuelos
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

            case "QATAR":

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

            case "ANGOLA":

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

            case "ISLAS COCOS (AUSTRALIA)":

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

            case "ISLA DE NAVIDAD (AUSTRALIA)":

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

            case "NIUE (NUEVA ZELANDA)":

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
        }

        Console.WriteLine("Estimado Cliente " + nombre);
        
    }
}