﻿class gestor_vuelos
{
    public static void Main(string[] args)
    {
        //Declaramos variables que influyen en el costo del vuelo
        string nombre, continente, pais, clase;
        double costo;
        int dias, codigo;
        Random rnd = new Random();

        //Se piden los datos al usuario
        Console.WriteLine("Hola bienvenido a aerolíneas Skyweb, usted ha ingresado al sistema para la compra de un boleto aéreo");
        Console.WriteLine("Ingrese su nombre para continuar");
        Console.WriteLine(" ");
        nombre = Console.ReadLine();
        Console.WriteLine(" ");

        Console.WriteLine("Bienvenido " + nombre + " Seleccione el continente de su destino");
        Console.WriteLine(" ");
        Console.WriteLine("AMERICA");
        Console.WriteLine("ASIA");
        Console.WriteLine("AFRICA");
        Console.WriteLine("EUROPA");
        Console.WriteLine("OCEANIA");
        Console.WriteLine(" ");
        continente = Console.ReadLine().ToUpper();

        switch (continente)
        {
            case "AMERICA":
                Console.WriteLine(" ");
                Console.WriteLine("DESTINOS DISPONIBLES: ");
                Console.WriteLine(" ");
                Console.WriteLine("ESTADOS UNIDOS");
                Console.WriteLine("CANADA");
                Console.WriteLine("MEXICO");
                Console.WriteLine("GUATEMALA");
                Console.WriteLine("BELICE");
                Console.WriteLine("HONDURAS");
                Console.WriteLine("NICARAGUA");
                Console.WriteLine("COSTA RICA");
                Console.WriteLine("PANAMA");
                Console.WriteLine("COLOMBIA");
                Console.WriteLine("ECUADOR");
                Console.WriteLine("VENEZUELA");
                Console.WriteLine("PERU");
                Console.WriteLine("BOLIVIA");
                Console.WriteLine("BRASIL");
                Console.WriteLine("PARAGUAY");
                Console.WriteLine("URUGUAY");
                Console.WriteLine("ARGENTINA");
                Console.WriteLine("CHILE");
                Console.WriteLine("GUYANA");
                Console.WriteLine("SURINAM");
                Console.WriteLine("JAMAICA");
                Console.WriteLine("CUBA");
                Console.WriteLine("BAHAMAS");
                Console.WriteLine("HAITI");
                Console.WriteLine("REPUBLICA DOMINICANA");
                Console.WriteLine("SAN CRISTOBAL Y NIEVES");
                Console.WriteLine("ANTIGUA Y BARBUDA");
                Console.WriteLine("DOMINICA");
                Console.WriteLine("SANTA LUCIA");
                Console.WriteLine("SAN VICENTE Y GRANADINAS");
                Console.WriteLine("BARBADOS");
                Console.WriteLine("GRANADA");
                Console.WriteLine("TRINIDAD Y TOBAGO");
                Console.WriteLine(" ");
                pais = Console.ReadLine().ToUpper();

                switch (pais)
                {
                    case "ESTADOS UNIDOS":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 300;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 500;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 800;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;
                    case "CANADA":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 400;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 800;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 1200;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");

                        break;
                    case "MEXICO":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 250;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 400;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 600;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "GUATEMALA":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 50;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 125;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 200;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "BELICE":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 50;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 125;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 175;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "HONDURAS":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 75;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 150;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 175;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "NICARAGUA":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 80;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 140;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 180;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "COSTA RICA":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 125;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 190;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 210;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "PANAMA":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 190;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 250;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 280;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "COLOMBIA":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 620;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 750;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 800;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "ECUADOR":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 712;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 775;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 835;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;

                    case "VENEZUELA":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 700;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 750;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 800;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;


                    case "PERU":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 824;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 845;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 875;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;

                    case "BOLIVIA":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 813;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 850;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 865;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;

                    case "BRASIL":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 820;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 870;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 885;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;

                    case "PARAGUAY":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 820;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 870;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 875;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "ARGENTINA":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 800;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 820;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 835;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "CHILE":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 810;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 820;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 835;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "GUYANA":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 806;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 817;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 827;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "SURINAM":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 815;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 826;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 835;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;

                    case "JAMAICA":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 810;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 820;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 825;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "CUBA":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 800;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 810;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 845;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "BAHAMAS":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 625;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 675;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 755;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "HAITI":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 615;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 625;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 745;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "REPUBLICA DOMINICANA":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 635;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 655;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 675;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "SAN CRISTOBAL Y NIEVES":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 655;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 675;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 685;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "ANTIGUA Y BARBUDA":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 625;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 675;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 755;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "DOMINICA":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 617;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 626;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 635;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "SAN VICENTE Y GRANADINAS":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 643;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 657;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 675;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "BARBADOS":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 633;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 647;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 655;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "GRANADA":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 603;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 617;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 625;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;
                    case "TRINIDAD Y TOBAGO":
                        Console.WriteLine("Cuantos dias desea viajar");
                        dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Seleccione su clase");
                        Console.WriteLine("turista");
                        Console.WriteLine("primera clase");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 633;

                        }
                        else if (clase == "primera clase")
                        {
                            costo = dias * 647;
                        }
                        else if (clase == "negocios")
                        {
                            costo = dias * 667;
                        }
                        else
                        {
                            Console.WriteLine("Seleccione una opcion valida");
                            costo = 0;
                        }
                        Console.WriteLine("El costo de su ticket es " + costo + " dolares");
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;






                }
                break;

            case "EUROPA":

                Console.WriteLine(" ");
                Console.WriteLine("DESTINOS DISPONIBLES:");
                Console.WriteLine(" ");
                Console.WriteLine(" RUSIA");
                Console.WriteLine(" ALEMANIA");
                Console.WriteLine("REINO UNIDO ");
                Console.WriteLine(" FRANCIA");
                Console.WriteLine(" ITALIA ");
                Console.WriteLine(" ESPAÑA");
                Console.WriteLine(" UCRANIA");
                Console.WriteLine(" POLONIA");
                Console.WriteLine(" RUMANIA ");
                Console.WriteLine(" PAISES BAJOS");
                Console.WriteLine(" BELGICA");
                Console.WriteLine(" REPUBLCA CHECA ");
                Console.WriteLine(" SUECIA");
                Console.WriteLine(" GRECIA");
                Console.WriteLine(" PORTUGAL ");
                Console.WriteLine(" HUNGRIA ");
                Console.WriteLine(" BELORRUSIA");
                Console.WriteLine("  AUSTRIA ");
                Console.WriteLine(" SUIZA");
                Console.WriteLine(" SERBIA");
                Console.WriteLine(" BULGARIA");
                Console.WriteLine(" DINAMARCA");
                Console.WriteLine(" FINLANDIA ");
                Console.WriteLine(" NORUEGA");
                Console.WriteLine(" ESLOVAQUIA");
                Console.WriteLine(" IRLANDIA");
                Console.WriteLine(" CROACIA");
                Console.WriteLine(" BOSNIA Y HERZEGOVINA ");
                Console.WriteLine(" ALBANIA");
                Console.WriteLine(" LITUANIA");
                Console.WriteLine(" MACEDONIA");
                Console.WriteLine(" ESLOVAQUIA");
                Console.WriteLine(" LETONIA ");
                Console.WriteLine(" MONTENEGRO");
                Console.WriteLine(" LUXEMBURGO ");
                Console.WriteLine(" ISLANDIA ");
                Console.WriteLine(" ANDORRA");
                Console.WriteLine("  LIECHTENSTEIN");
                Console.WriteLine(" MONACO");
                Console.WriteLine(" ");

                pais = Console.ReadLine();

                switch (pais.ToUpper())
                {
                    case "RUSIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primera clase")
                        {
                            costo = dias * 200;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 150;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 300;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;

                    case "ALEMANIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 250;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 120;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 200;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "REINO UNIDO":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 250;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 200;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 350;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "FRANCIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 2500;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 2000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 1500;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "ITALIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 1250;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 1000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 900;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "ESPAÑA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 2000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 1500;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 1000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "UCRANIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 900;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 400;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 450;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "POLONIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 800;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 500;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 500;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "RUMANIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 1000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 650;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 700;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "PAISES BAJOS":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 1200;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 1000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 1100;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "BELGICA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 2000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 1600;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 1400;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "REPUBLICA CHECA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 2000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 1800;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 1700;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "SUECIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 1000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 850;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 900;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "GRECIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 1000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 850;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 900;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "PORTUGAL":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 2000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 1500;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 1200;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "HUNGRIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 1000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 850;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 900;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "BIELORRUSIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 1000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 700;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 750;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "AUSTRIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 1000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 850;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 900;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "SUIZA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 2000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 1500;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 1000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "SERBIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 1000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 700;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 850;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "BULGARIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 900;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 850;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 750;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "DINAMARCA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 1200;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 900;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 1000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "FINLANDIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 900;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 850;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 750;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "NORUEGA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 1000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 950;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 850;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "ESLOVAQUIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 900;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 850;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 750;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "IRLANDIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 1200;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 850;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 900;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "CROACIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 1500;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 1000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 1000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "BOSNIA Y HERZEGOVINA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 900;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 850;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 750;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "ALBANIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 1000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 900;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 950;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "LITUANIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 850;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 800;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 750;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "MACEDONIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 900;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 850;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 750;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "ESLOVENIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 1200;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 900;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 1000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "LETONIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 900;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 850;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 750;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "MONTENEGRO":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 1100;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 950;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 1000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "LUXEMBURGO":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 900;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 850;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 750;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "ISLANDIA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 1300;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 1000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 1100;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "ANDORRA":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 2000;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 1500;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 1800;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "LIECHTENSTEIN":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 900;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 850;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 750;
                            Console.WriteLine("el costo de su ticket es de " + costo + "dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "MONACO":
                        Console.WriteLine("cuantos dias desea viajar");
                        dias = int.Parse(Console.ReadLine());
                        Console.WriteLine("escoja la de clase de vuelo ");
                        Console.WriteLine("primeraclase");
                        Console.WriteLine("turista");
                        Console.WriteLine("negocios");
                        clase = Console.ReadLine();

                        if (clase == "primeraclase")
                        {
                            costo = dias * 1200;
                            Console.WriteLine("el costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "turista")
                        {
                            costo = dias * 900;
                            Console.WriteLine("el costo de su ticket es de " + costo + " dolares ");

                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 1000;
                            Console.WriteLine("el costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;
                }

                break;

            case "ASIA":

                Console.WriteLine(" ");
                Console.WriteLine("DESTINOS DISPONIBLES: ");
                Console.WriteLine(" ");
                Console.WriteLine("AFAGANISTAN");
                Console.WriteLine("ARABIA SAUDITA");
                Console.WriteLine("ARMENIA");
                Console.WriteLine("AZERBAIYAN");
                Console.WriteLine("BANGLADESH");
                Console.WriteLine("BAREIN");
                Console.WriteLine("BIRMANIA");
                Console.WriteLine("BRUNEI");
                Console.WriteLine("BUTAN");
                Console.WriteLine("CAMBOYA");
                Console.WriteLine("CATAR");
                Console.WriteLine("CHINA");
                Console.WriteLine("CHIPRE");
                Console.WriteLine("COREA DEL NORTE");
                Console.WriteLine("COREA DEL SUR");
                Console.WriteLine("EMIRATOS ARABES UNIDOS");
                Console.WriteLine("FILIPINAS");
                Console.WriteLine("INDIA");
                Console.WriteLine("INDONESIA");
                Console.WriteLine("IRAK");
                Console.WriteLine("IRAN");
                Console.WriteLine("ISRAEL");
                Console.WriteLine("JAPON");
                Console.WriteLine("JORDANIA");
                Console.WriteLine("KAZAJISTAN");
                Console.WriteLine("KIRGUISTAN");
                Console.WriteLine("KUWAIT");
                Console.WriteLine("LAOS");
                Console.WriteLine("LIBANO");
                Console.WriteLine("MALASIA");
                Console.WriteLine("MALDIVAS");
                Console.WriteLine("MONGOLIA");
                Console.WriteLine("NEPAL");
                Console.WriteLine("OMAN");
                Console.WriteLine("PAKISTAN");
                Console.WriteLine("SINGAPUR");
                Console.WriteLine("SIRIA");
                Console.WriteLine("SRI LANKA");
                Console.WriteLine("TAILANDIA");
                Console.WriteLine("TAYIKISTAN");
                Console.WriteLine("TIMOR ORIENTAL");
                Console.WriteLine("TURKMENISTAN");
                Console.WriteLine("TURQUIA");
                Console.WriteLine("UZBEKISTAN");
                Console.WriteLine("VIETNAM");
                Console.WriteLine("YEMEN");
                Console.WriteLine(" ");

                pais = Console.ReadLine();

                switch (pais.ToUpper())
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

                        if (clase == "primera clase")
                        {
                            costo = dias * 70;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 50;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;
                }

                break;

            case "OCEANIA":

                Console.WriteLine(" ");
                Console.WriteLine("DESTINOS DISPONIBLES: ");
                Console.WriteLine(" ");
                Console.WriteLine("AUSTRALIA");
                Console.WriteLine("ISLA NOLFORK");
                Console.WriteLine("ISLAS COCOS");
                Console.WriteLine("ISLA DE NAVIDAD");
                Console.WriteLine("NUEVA ZELANDA");
                Console.WriteLine("NIUE");
                Console.WriteLine("ISLAS COOK");
                Console.WriteLine("ISLAS MARIANAS DEL NORTE");
                Console.WriteLine("MICRONESIA");
                Console.WriteLine("NAURU");
                Console.WriteLine("FIYI");
                Console.WriteLine("GUAM");
                Console.WriteLine("KIRIBATI");
                Console.WriteLine("NUEVA CALEDONIA");
                Console.WriteLine("PALAOS");
                Console.WriteLine("POLINESIA FRANCESA");
                Console.WriteLine("ISLAS COOK (NUEVA ZELANDA)");
                Console.WriteLine("ISLAS MARSHALL");
                Console.WriteLine("ISLAS SALOMON");
                Console.WriteLine("SAMOA");
                Console.WriteLine("TONGA");
                Console.WriteLine("TUVALU");
                Console.WriteLine("VANATU");
                Console.WriteLine("WALLIS Y FUTUNA");
                Console.WriteLine(" ");

                pais = Console.ReadLine();

                switch (pais.ToUpper())
                {

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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
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
                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();
                        break;


                }

                break;

            case "AFRICA":

                Console.WriteLine(" ");
                Console.WriteLine("DESTINOS DISPONIBLES: ");
                Console.WriteLine(" ");
                Console.WriteLine("ANGOLA");
                Console.WriteLine("ARGELIA");
                Console.WriteLine("BENIN");
                Console.WriteLine("BOTSUANA");
                Console.WriteLine("BURUNDI");
                Console.WriteLine("CAMERUN");
                Console.WriteLine("COMORAS");
                Console.WriteLine("BURKINA FASO");
                Console.WriteLine("CABO VERDE");
                Console.WriteLine("REPUBLICA CENTROAFRICANA");
                Console.WriteLine("CHAD");
                Console.WriteLine("YIBUTI");
                Console.WriteLine("EGIPTO");
                Console.WriteLine("GUINEA ACUATORIAL");
                Console.WriteLine("ERITREA");
                Console.WriteLine("ESWATINI");
                Console.WriteLine("ETIOPIA");
                Console.WriteLine("GABON");
                Console.WriteLine("GAMBIA");
                Console.WriteLine("GHANA");
                Console.WriteLine("GUINEA");
                Console.WriteLine("GUINEA-BISSAU");
                Console.WriteLine("COSTA DE MARFIL");
                Console.WriteLine("KENIA");
                Console.WriteLine("LESOTO");
                Console.WriteLine("LIBERIA");
                Console.WriteLine("LIBIA");
                Console.WriteLine("MADAGASCAR");
                Console.WriteLine("MALAUI");
                Console.WriteLine("MALI");
                Console.WriteLine("MAURITANIA");
                Console.WriteLine("MAURICIO");
                Console.WriteLine("MARRUECOS");
                Console.WriteLine("MOZAMBIQUE");
                Console.WriteLine("NAMIBIA");
                Console.WriteLine("NIGER");
                Console.WriteLine("NIGERIA");
                Console.WriteLine("REPUBLICA DEL CONGO");
                Console.WriteLine("RUANDA");
                Console.WriteLine("SANTO TOME Y PRINCIPE");
                Console.WriteLine("SENEGAL");
                Console.WriteLine("SEYCHELLES");
                Console.WriteLine("SIERRA LEONA");
                Console.WriteLine("SOMALIA");
                Console.WriteLine("SUDAFRICA");
                Console.WriteLine("SUDAN");
                Console.WriteLine("SUDAN DEL SUR");
                Console.WriteLine("TANZANIA");
                Console.WriteLine("TOGO");
                Console.WriteLine("TUNEZ");
                Console.WriteLine("UGANDA");
                Console.WriteLine("ZAMBIA");
                Console.WriteLine("ZIMBABUE");
                Console.WriteLine(" ");

                pais = Console.ReadLine();

                switch (pais.ToUpper())
                {

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "GUINEA ECUATORIAL":

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
                            costo = dias * 230;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 190;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "ERITREA":

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
                            costo = dias * 180;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "ESWATINI":

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "ETIOPIA":

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
                            costo = dias * 220;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 190;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "GABON":

                        Console.WriteLine("¿Cuantos dias planea viajar?");
                        dias = int.Parse(Console.ReadLine());

                        Console.WriteLine("Escoja la clase de su vuelo:");
                        Console.WriteLine("Turista");
                        Console.WriteLine("Primera clase");
                        Console.WriteLine("Negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 190;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "primera clase")
                        {
                            costo = dias * 230;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 170;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "GAMBIA":

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
                            costo = dias * 230;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 200;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "GHANA":

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
                            costo = dias * 220;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "GUINEA":

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "GUINEA BISSAU":

                        Console.WriteLine("¿Cuantos dias planea viajar?");
                        dias = int.Parse(Console.ReadLine());

                        Console.WriteLine("Escoja la clase de su vuelo:");
                        Console.WriteLine("Turista");
                        Console.WriteLine("Primera clase");
                        Console.WriteLine("Negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 190;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "primera clase")
                        {
                            costo = dias * 230;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 210;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "COSTA DE MARFIL":

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "KENIA":

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
                            costo = dias * 280;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 240;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "LESOTO":

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
                            costo = dias * 230;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 200;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "LIBERIA":

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "LIBIA":

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
                            costo = dias * 180;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "MADAGASCAR":

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
                            costo = dias * 220;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "MALAUI":

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
                            costo = dias * 220;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 200;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "MALI":

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "MAURITANIA":

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "MAURICIO":

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
                            costo = dias * 260;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 240;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "MARRUECOS":

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "MOZAMBIQUE":

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
                            costo = dias * 230;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 200;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "NAMIBIA":

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "NIGER":

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "NIGERIA":

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
                            costo = dias * 220;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 190;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "REPUBLICA DEL CONGO":

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "RUANDA":

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "SANTO TOME Y PRINCIPE":

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
                            costo = dias * 230;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 200;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "SENEGAL":

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
                            costo = dias * 220;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "SEYCHELLES":

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
                            costo = dias * 230;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 200;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "SIERRA LEONA":

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "SOMALIA":

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
                            costo = dias * 180;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "SUDAFRICA":

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "SUDAN":

                        Console.WriteLine("¿Cuantos dias planea viajar?");
                        dias = int.Parse(Console.ReadLine());

                        Console.WriteLine("Escoja la clase de su vuelo:");
                        Console.WriteLine("Turista");
                        Console.WriteLine("Primera clase");
                        Console.WriteLine("Negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 190;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "primera clase")
                        {
                            costo = dias * 250;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 220;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "SUDAN DEL SUR":

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "TANZANIA":

                        Console.WriteLine("¿Cuantos dias planea viajar?");
                        dias = int.Parse(Console.ReadLine());

                        Console.WriteLine("Escoja la clase de su vuelo:");
                        Console.WriteLine("Turista");
                        Console.WriteLine("Primera clase");
                        Console.WriteLine("Negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 190;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "primera clase")
                        {
                            costo = dias * 240;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 220;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "TOGO":

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "TUNEZ":

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
                            costo = dias * 230;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "UGANDA":

                        Console.WriteLine("¿Cuantos dias planea viajar?");
                        dias = int.Parse(Console.ReadLine());

                        Console.WriteLine("Escoja la clase de su vuelo:");
                        Console.WriteLine("Turista");
                        Console.WriteLine("Primera clase");
                        Console.WriteLine("Negocios");
                        clase = Console.ReadLine();

                        if (clase == "turista")
                        {
                            costo = dias * 190;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "primera clase")
                        {
                            costo = dias * 220;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        if (clase == "negocios")
                        {
                            costo = dias * 210;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "ZAMBIA":

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

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;

                    case "ZIMBABUE":

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
                            costo = dias * 250;
                            Console.WriteLine("El costo de su ticket es de " + costo + " dolares");
                        }

                        codigo = rnd.Next(100000, 999999);
                        Console.WriteLine("Estimado cliente " + nombre + " Usted ha comprado un vuelo desde El Salvador con destino a " + pais);
                        Console.WriteLine("Con una duracion de " + dias + " dias");
                        Console.WriteLine("El numero de su vuelo es: " + codigo + " ¡le deseamos un excelente viaje");
                        Console.ReadKey();

                        break;
                }
                break;

            default:
                Console.WriteLine("Usted ha ingresado un destino inválido, por favor intente de nuevo");
                break;
        }

    }
}