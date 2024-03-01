
        
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);

       
        int numeroUsuario;
        bool adivinado = false;
        int intentos = 0;

       
        while (!adivinado)
        {
            
            Console.WriteLine("Intento {0}:", intentos);

            
            Console.WriteLine("Introduce un número entre 1 y 100: ");
            string input = Console.ReadLine();

            
            if (int.TryParse(input, out numeroUsuario) && numeroUsuario >= 1 && numeroUsuario <= 100)
            {
                
                if (numeroUsuario < numeroSecreto)
                {
                    Console.WriteLine("El número secreto es mayor.");
                }
                else if (numeroUsuario > numeroSecreto)
                {
                    Console.WriteLine("El número secreto es menor.");
                }
                else
                {
                  
                    adivinado = true;
                    Console.WriteLine("¡Felicidades! Has adivinado el número secreto en {0} intentos.", intentos);
                }

                
                intentos++;
            }
            else
            {
              
                Console.WriteLine("El número introducido no es válido. Intenta de nuevo.");
            }
        }

        
        if (adivinado)
        {
            Console.WriteLine("¡Felicidades! Has adivinado el número secreto en {0} intentos.", intentos);
        }
        else
        {
            Console.WriteLine("Lo siento, no has adivinado el número secreto en {0} intentos.", intentos);
        }

        
        Console.WriteLine("¿Desea jugar de nuevo? (s/n)");
        string respuesta = Console.ReadLine().ToLower();

        
        bool jugarDeNuevo = respuesta == "s";

        if (jugarDeNuevo)
        {
        
        }
        else
        {
            Console.WriteLine("¡Gracias por jugar!");
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    
