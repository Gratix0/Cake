namespace CakeOrder;

internal class ParametersCake
{
    void Cl()
    {
        Console.SetCursorPosition(0, 0);
        Console.Clear();
    }

    void Nav()
    {
        
    }

    public static int Prises;
    public static void Shape()
    {
            
            
            Console.Clear();
            Console.SetCursorPosition(0,0);
            
            Console.WriteLine("Press Esc to exit");
            Console.WriteLine("Choose menu item:\n--------");

            Console.WriteLine("  Circle - 4$");
            Console.WriteLine("  Square - 4$");
            Console.WriteLine("  Rectangle - 5$");
            Console.WriteLine("  Heart - 7$");
    }

    public static void size()
    {
        Console.Clear();
        Console.SetCursorPosition(0,0);
            
        Console.WriteLine("Press Esc to exit");
        Console.WriteLine("Choose menu item:\n--------");

        Console.WriteLine("  Small (diametr - 16 centimeters, 8 servings - 10$");
        Console.WriteLine("  Medium (diametr - 18 centimeters, 10 servings - 14$");
        Console.WriteLine("  Huge (diametr - 28 centimeters, 24 servings - 24$");
        
    }

    public static void tasteOfCakes()
    {
        Console.Clear();
        Console.SetCursorPosition(0,0);
            
        Console.WriteLine("Press Esc to exit");
        Console.WriteLine("Choose menu item:\n--------");

        Console.WriteLine("  Vanilla - 2$");
        Console.WriteLine("  Chocolate - 3$");
        Console.WriteLine("  Caramel - 3$");
        Console.WriteLine("  Berry - 5$");
        Console.WriteLine("  Coconut - 6$");
    }

    public static void layers()
    {
        Console.Clear();
        Console.SetCursorPosition(0,0);
            
        Console.WriteLine("Press Esc to exit");
        Console.WriteLine("Choose menu item:\n--------");

        Console.WriteLine("  1 Korzh - 2$");
        Console.WriteLine("  2 Korzh - 4$");
        Console.WriteLine("  3 Korzh - 6$");
        Console.WriteLine("  4 Korzh - 7$");
        Console.WriteLine("  5 Korzh - 8$");
    }

    public static void glaze()
    {
        Console.Clear();
        Console.SetCursorPosition(0,0);
            
        Console.WriteLine("Press Esc to exit");
        Console.WriteLine("Choose menu item:\n--------");

        Console.WriteLine("  Yes - 2$");
        Console.WriteLine("  No - 0$");
    }

    public static void decor()
    {
        Console.Clear();
        Console.SetCursorPosition(0,0);
            
        Console.WriteLine("Press Esc to exit");
        Console.WriteLine("Choose menu item:\n--------");

        Console.WriteLine("  Chocolate - 1$");
        Console.WriteLine("  Berry - 2$");
        Console.WriteLine("  Cosmostars - 5$");
        Console.WriteLine("  Vanila - 8$");
    }
}