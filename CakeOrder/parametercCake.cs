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




}