  using CakeOrder;

  int pos = 3;
  string[] CakePar = new[] {"", "", "", "", "", ""};
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

     Console.Write("\nTotal Price in $: ");
     CakeOrder.countPrice.CountingResult();
     
     Console.WriteLine("Your cake: \n-----------------");
     for (int i = 0; i < 6; i++)
     {
         Console.WriteLine(CakePar[i]);
     }
     
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
          if (pos == 10)
          {
              pos = 8;
              continue;
          }

          pos--;
          continue;
      }

      if (key.Key == ConsoleKey.DownArrow && pos <= 9)
      {
          if (pos == 8)
          {
              pos = 10;
              continue;
          }

          pos++;
          continue;
      }

      if (key.Key == ConsoleKey.Enter)
      {
          if (pos == 3)
          {

              while (!false)
              {
                  CakeOrder.ParametersCake.Shape();
                  Console.SetCursorPosition(0, pos);
                  Console.WriteLine("->");

                  ConsoleKeyInfo keyChape = Console.ReadKey();
                  {
                      // nav

                      if (keyChape.Key == ConsoleKey.Enter)
                      {

                          if (pos == 3)
                          {
                              CakeOrder.countPrice.OnePun = 4;
                              //parametersCake.Prepend("Shape: Circle");
                              CakePar[0] = "Shape: Circle";
                              break;
                          }

                          if (pos == 4)
                          {
                              CakeOrder.countPrice.TwoPun = 4;
                              CakePar[0] = "Shape: Square";
                              pos = 3;
                              break;
                          }

                          if (pos == 5)
                          {
                              CakeOrder.countPrice.TwoPun = 5;
                              CakePar[0] = "Shape: Rectangle";
                              pos = 3;
                              break;
                          }

                          if (pos == 6)
                          {
                              CakeOrder.countPrice.TwoPun = 7;
                              CakePar[0] = "Shape: Heart";
                              pos = 3;
                              break;
                          }
                      }

                      if (keyChape.Key == ConsoleKey.UpArrow && pos >= 4)
                      {
                          pos--;
                          continue;
                      }

                      if (keyChape.Key == ConsoleKey.DownArrow && pos <= 5)
                      {
                          pos++;
                          continue;
                      }

                      if (pos <= 3)
                      {
                          pos = 3;
                          continue;
                      }

                      if (pos >= 6)
                      {
                          pos = 6;
                          continue;
                      }

                      if (keyChape.Key == ConsoleKey.Escape)
                      {
                          pos = 3;
                          break;
                      }


                  }
                  if (pos == 4)
                  {


                  }

              }

          }

          if (pos == 4)
          {
              while (!false)
              {
                  CakeOrder.ParametersCake.size();
                  Console.SetCursorPosition(0, pos);
                  Console.WriteLine("->");

                  ConsoleKeyInfo keyChape = Console.ReadKey();
                  {
                      // nav

                      if (keyChape.Key == ConsoleKey.Enter)
                      {

                          if (pos == 3)
                          {
                              CakeOrder.countPrice.OnePun = 10;
                              CakePar[1] = "Size: Small";
                              pos = 3;
                              break;
                          }

                          if (pos == 4)
                          {
                              CakeOrder.countPrice.OnePun = 14;
                              CakePar[1] = "Size: Medium";
                              pos = 3;
                              break;
                          }

                          if (pos == 5)
                          {
                              CakeOrder.countPrice.OnePun = 24;
                              CakePar[1] = "Size: Huge";
                              pos = 3;
                              break;
                          }
                      }

                      if (keyChape.Key == ConsoleKey.UpArrow && pos >= 4)
                      {
                          pos--;
                          continue;
                      }

                      if (keyChape.Key == ConsoleKey.DownArrow && pos <= 5)
                      {
                          pos++;
                          continue;
                      }

                      if (pos <= 3)
                      {
                          pos = 3;
                          continue;
                      }

                      if (pos >= 5)
                      {
                          pos = 5;
                          continue;
                      }

                      if (keyChape.Key == ConsoleKey.Escape)
                      {
                          break;
                      }
                  }
              }

          }

          if (pos == 5)
          {
              pos = 3;
              while (!false)
              {
                  
                  CakeOrder.ParametersCake.tasteOfCakes();
                  Console.SetCursorPosition(0, pos);
                  Console.WriteLine("->");

                  ConsoleKeyInfo keyChape = Console.ReadKey();
                  {
                      // nav

                      if (keyChape.Key == ConsoleKey.Enter)
                      {

                          if (pos == 3)
                          {
                              CakeOrder.countPrice.ThreePun = 2;
                              CakePar[2] = "Tastle of Cake: Vanilla";
                              pos = 3;
                              break;
                          }

                          if (pos == 4)
                          {
                              CakeOrder.countPrice.ThreePun = 3;
                              CakePar[2] = "Tastle of Cake: Chocolate";
                              pos = 3;
                              break;
                          }

                          if (pos == 5)
                          {
                              CakeOrder.countPrice.ThreePun = 3;
                              CakePar[2] = "Tastle of Cake: Caramel";
                              pos = 3;
                              break;
                          }

                          if (pos == 6)
                          {
                              CakeOrder.countPrice.ThreePun = 5;
                              CakePar[2] = "Tastle of Cake: Berry";
                              pos = 3;
                              break;
                          }

                          if (pos == 7)
                          {
                              CakeOrder.countPrice.ThreePun = 6;
                              CakePar[2] = "Tastle of Cake: Cocount";
                              pos = 3;
                              break;
                          }
                      }

                      if (keyChape.Key == ConsoleKey.UpArrow && pos >= 4)
                      {
                          pos--;
                          continue;
                      }

                      if (keyChape.Key == ConsoleKey.DownArrow && pos <= 6)
                      {
                          pos++;
                          continue;
                      }

                      if (pos <= 3)
                      {
                          pos = 3;
                          continue;
                      }

                      if (pos >= 5)
                      {
                          pos = 5;
                          continue;
                      }

                      if (keyChape.Key == ConsoleKey.Escape)
                      {
                          break;
                      }


                  }
              }
          }

          if (pos == 6)
          {
              pos = 3;
              while (!false)
              {
                  CakeOrder.ParametersCake.layers();
                  Console.SetCursorPosition(0, pos);
                  Console.WriteLine("->");

                  ConsoleKeyInfo keyChape = Console.ReadKey();
                  {
                      // nav

                      if (keyChape.Key == ConsoleKey.Enter)
                      {

                          if (pos == 3)
                          {
                              CakeOrder.countPrice.ThreePun = 2;
                              CakePar[3] = "Layers: 1 Korzh";
                              pos = 3;
                              break;
                          }

                          if (pos == 4)
                          {
                              CakeOrder.countPrice.ThreePun = 4;
                              CakePar[3] = "Layers: 2 Korzh";
                              pos = 3;
                              break;
                          }

                          if (pos == 5)
                          {
                              CakeOrder.countPrice.ThreePun = 6;
                              CakePar[3] = "Layers: 3 Korzh";
                              pos = 3;
                              break;
                          }

                          if (pos == 6)
                          {
                              CakeOrder.countPrice.ThreePun = 7;
                              CakePar[3] = "Layers: 4 Korzh";
                              pos = 3;
                              break;
                          }

                          if (pos == 7)
                          {
                              CakeOrder.countPrice.ThreePun = 8;
                              CakePar[3] = "Layers: 5 Korzh";
                              pos = 3;
                              break;
                          }
                      }

                      if (keyChape.Key == ConsoleKey.UpArrow && pos >= 4)
                      {
                          pos--;
                          continue;
                      }

                      if (keyChape.Key == ConsoleKey.DownArrow && pos <= 6)
                      {
                          pos++;
                          continue;
                      }

                      if (pos <= 3)
                      {
                          pos = 3;
                          continue;
                      }

                      if (pos >= 7)
                      {
                          pos = 7;
                          continue;
                      }

                      if (keyChape.Key == ConsoleKey.Escape)
                      {
                          break;
                      }
                  }
              }
          }

          if (pos == 7)
          {
              pos = 3;
              while (!false)
              {
                  CakeOrder.ParametersCake.glaze();
                  Console.SetCursorPosition(0, pos);
                  Console.WriteLine("->");

                  ConsoleKeyInfo keyChape = Console.ReadKey();
                  {
                      // nav

                      if (keyChape.Key == ConsoleKey.Enter)
                      {

                          if (pos == 3)
                          {
                              CakeOrder.countPrice.ThreePun = 2;
                              CakePar[4] = "Glaze: Yes";
                              pos = 3;
                              break;
                          }

                          if (pos == 4)
                          {
                              CakeOrder.countPrice.ThreePun = 0;
                              CakePar[4] = "Glaze: No";
                              pos = 3;
                              break;
                          }
                      }

                      if (keyChape.Key == ConsoleKey.UpArrow && pos >= 4)
                      {
                          pos--;
                          continue;
                      }

                      if (keyChape.Key == ConsoleKey.DownArrow && pos <= 4)
                      {
                          pos++;
                          continue;
                      }

                      if (pos <= 3)
                      {
                          pos = 3;
                          continue;
                      }

                      if (pos >= 4)
                      {
                          pos = 4;
                          continue;
                      }

                      if (keyChape.Key == ConsoleKey.Escape)
                      {
                          break;
                      }

                  }
              }
          }

          if (pos == 8)
          {
              pos = 3;
              while (!false)
              {
                  CakeOrder.ParametersCake.decor();
                  Console.SetCursorPosition(0, pos);
                  Console.WriteLine("->");

                  ConsoleKeyInfo keyChape = Console.ReadKey();
                  {
                      // nav

                      if (keyChape.Key == ConsoleKey.Enter)
                      {

                          if (pos == 3)
                          {
                              CakeOrder.countPrice.ThreePun = 1;
                              CakePar[5] = "Decor: Chocolate";
                              pos = 3;
                              break;
                          }

                          if (pos == 4)
                          {
                              CakeOrder.countPrice.ThreePun = 2;
                              CakePar[5] = "Decor: Berry";
                              pos = 3;
                              break;
                          }

                          if (pos == 5)
                          {
                              CakeOrder.countPrice.ThreePun = 5;
                              CakePar[5] = "Decor: Cosmostars";
                              pos = 3;
                              break;
                          }

                          if (pos == 6)
                          {
                              CakeOrder.countPrice.ThreePun = 8;
                              CakePar[5] = "Decor: Vanila";
                              pos = 3;
                              break;
                          }
                      }

                      if (keyChape.Key == ConsoleKey.UpArrow && pos >= 4)
                      {
                          pos--;
                          continue;
                      }

                      if (keyChape.Key == ConsoleKey.DownArrow && pos <= 5)
                      {
                          pos++;
                          continue;
                      }

                      if (pos <= 3)
                      {
                          pos = 3;
                          continue;
                      }

                      if (pos >= 6)
                      {
                          pos = 6;
                          continue;
                      }

                      if (keyChape.Key == ConsoleKey.Escape)
                      {
                          break;
                      }
                  }
              }
          }
      }
  }