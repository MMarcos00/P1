        Console.WriteLine("Introduzca un número: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Tabla de multiplicar del {0}", numero);
        Console.WriteLine("---------------------");
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine("{0} x {1} = {2}", numero, i, resultado);
        }