
        int num;
        bool salir = false;

        while (!salir)
        {
           
            Console.WriteLine("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());

            
            Console.Clear();

            
            Console.WriteLine("\t\tMENU");
            Console.WriteLine("1. Factorial del número");
            Console.WriteLine("2. Raíz cuadrada del número");
            Console.WriteLine("3. Salir");

            
            int opcion = int.Parse(Console.ReadLine());

            
            switch (opcion)
            {
                case 1:
                    
                    int factorial = 1;
                    for (int i = 1; i <= num; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine("El factorial de {0} es {1}", num, factorial);
                    break;

                case 2:
                    
                    double raizCuadrada = Math.Sqrt(num);
                    Console.WriteLine("La raíz cuadrada de {0} es {1}", num, raizCuadrada);
                    break;

                case 3:
                    
                    salir = true;
                    break;

                default:
                    
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        
        Console.WriteLine("¡Hasta luego!");
   


