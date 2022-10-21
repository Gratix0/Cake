  int pos = 3;
 
 void Menu()
 {
     Console.WriteLine("Order cakes in Tsybulko. Plenty of cakes for you to choose from\nChoise you cake\n---------------------------------------------------------------");
     
     Console.WriteLine("  Cake shape");
     Console.WriteLine("  Cake size");
     Console.WriteLine("  The taste of cakes");
     Console.WriteLine("  Number of layers");
     Console.WriteLine("  Glaze");
     Console.WriteLine("  Decor\n  --------");
     Console.WriteLine("  Apply");

     Console.WriteLine("\nTotal Price: ");
     Console.WriteLine("Your cake: ");
 }
  void Cl()
  {
      Console.SetCursorPosition(0, 0);
      Console.Clear();
  }

      while (true)
      {
          Cl();
          Menu();
          Console.SetCursorPosition(0, pos);
          Console.WriteLine("->");

          ConsoleKeyInfo key = Console.ReadKey();
          if (key.Key == ConsoleKey.UpArrow && pos >= 4)
          {
              pos--; continue;
          }

          if (key.Key == ConsoleKey.DownArrow && pos <= 9)
          {
              pos++; continue;
          }
      }
  