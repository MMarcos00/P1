using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Introduzca el primer número: ");
        decimal num1 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Introduzca el segundo número: ");
        decimal num2 = decimal.Parse(Console.ReadLine());

        
        Console.WriteLine("Introduzca el operador (+, -, *, /): ");
        char operador = Console.ReadKey().KeyChar;

        
        try
        {
            if (!ValidarDatos(num1, num2, operador))
            {
                throw new Exception("Datos no válidos.");
            }

            decimal resultado = RealizarOperacion(num1, num2, operador);

            
            Console.WriteLine("\nEl resultado es {0}", resultado);
        }
        catch (Exception ex)
        {
            
            Console.WriteLine("\nError: " + ex.Message);
        }
    }

    static bool ValidarDatos(decimal num1, decimal num2, char operador)
    {
        
        if (operador != '+' && operador != '-' && operador != '*' && operador != '/')
        {
            return false;
        }

        return true;
    }

    static decimal RealizarOperacion(decimal num1, decimal num2, char operador)
    {
        decimal resultado = 0;
        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                break;

            case '-':
                resultado = num1 - num2;
                break;

            case '*':
                resultado = num1 * num2;
                break;

            case '/':
                if (num2 == 0)
                {
                    throw new Exception("No se puede dividir por cero.");
                }
                resultado = num1 / num2;
                break;
        }

        return resultado;
    }
}

