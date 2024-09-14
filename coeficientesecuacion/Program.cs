public class ecuacion
{
    static void Main(string[]args)

    {
      

        // ingresar datos
        Console.Write("Ingrese el coeficiente a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el coeficiente b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        // Verificamos si a es cero
        if (a == 0)
        {
            // Si a es cero, la ecuación no tiene solución o todos los números son solución
            if (b == 0)
            {
                Console.WriteLine("Todos los números son solución");
            }
            else
            {
                Console.WriteLine("La ecuación no tiene solución");
            }
        }
        else
        {
            double solucion = -b / a;

            Console.WriteLine("La solución es x = " + solucion);
        }
    }
}

