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
        }

        Console.WriteLine("Estimado Cliente " + nombre);
        
    }
}