Console.WriteLine("Informe sua palavra:\n");
string palavra = Console.ReadLine();

string palavraCodificada = palavra.ToLower()
                                  .Replace("a", "1 ")
                                  .Replace("b", "2 ")
                                  .Replace("c", "3 ")
                                  .Replace("d", "4 ")
                                  .Replace("e", "5 ")
                                  .Replace("f", "6 ")
                                  .Replace("g", "7 ")
                                  .Replace("h", "8 ")
                                  .Replace("i", "9 ")
                                  .Replace("j", "10 ")
                                  .Replace("k", "11 ")
                                  .Replace("l", "12 ")
                                  .Replace("m", "13 ")
                                  .Replace("n", "14 ")
                                  .Replace("o", "15 ")
                                  .Replace("p", "16 ")
                                  .Replace("q", "17 ")
                                  .Replace("r", "18 ")
                                  .Replace("s", "19 ")
                                  .Replace("t", "20 ")
                                  .Replace("u", "21 ")
                                  .Replace("v", "22 ")
                                  .Replace("w", "23 ")
                                  .Replace("x", "24 ")
                                  .Replace("y", "25 ")
                                  .Replace("z", "26 ");

Console.WriteLine($"\nCodificando palavra...\n\n{palavraCodificada}");


Console.ReadLine();
