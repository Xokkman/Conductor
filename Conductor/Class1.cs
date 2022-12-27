using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conductor
{

    public class Statics
    {
        public int posit_down = 0;
        public int posit_up = 2;
    }
    class strela
    {
        public void strel()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("->");
            int posit = 0;
            do
            {
                string[] array = new string[] { "->", "  " };
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    posit--;
                    if (posit < 0)
                    {
                        posit = 0;
                    }
                    Console.SetCursorPosition(0, posit + 1);
                    Console.WriteLine(array[1]);
                    Console.SetCursorPosition(0, posit);
                    Console.WriteLine(array[0]);
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    posit++;
                    if (posit > 3)
                    {
                        posit = 3;
                    }
                    Console.SetCursorPosition(0, posit);
                    Console.WriteLine(array[0]);
                    Console.SetCursorPosition(0, posit - 1);
                    Console.WriteLine(array[1]);
                }
                if (key.Key == ConsoleKey.Enter && posit == 0)
                {
                    Console.Clear();
                    break;
                }

            } while (true);
        }
        public void strelka()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("->");
            int posit = 0;
            Files f = new Files();
            do
            {
                string[] array = new string[] { "->", "  " };
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    posit--;
                    if (posit < 0)
                    {
                        posit = 0;
                    }
                    Console.SetCursorPosition(0, posit + 1);
                    Console.WriteLine(array[1]);
                    Console.SetCursorPosition(0, posit);
                    Console.WriteLine(array[0]);
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    posit++;
                    if (posit > 3)
                    {
                        posit = 3;
                    }
                    Console.SetCursorPosition(0, posit);
                    Console.WriteLine(array[0]);
                    Console.SetCursorPosition(0, posit - 1);
                    Console.WriteLine(array[1]);
                }
                if (key.Key == ConsoleKey.Enter && posit == 0)
                {
                    Console.Clear();
                    f.Words();
                }
                if (key.Key == ConsoleKey.Enter && posit == 1)
                {
                    Console.Clear();
                    f.TxT();
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    break;
                }
            } while (true);
        }
    }
    class Files
    {
        public void Words()
        {
            if (File.Exists("C:\\Users\\lexre\\Desktop\\wordich.docx") && File.Exists("C:\\Users\\lexre\\Desktop\\wordich.docx"))
            {
                string[] allFiles = Directory.GetFiles("C:\\Users\\lexre\\Desktop");
                foreach (string filePath in allFiles)
                {
                    Console.WriteLine("  " + filePath.Substring(filePath.LastIndexOf('\\') + 1) + "<->Время создания папки: " + File.GetCreationTime("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Exsel") + "<->Время последней записи: " + File.GetLastWriteTime("C:\\Users\\nikol\\Desktop\\Папка с другими папками\\Exsel"));
                }
            }
            else
            {
                File.Create("C:\\Users\\lexre\\Desktop\\wordich.docx");
                File.Create("C:\\Users\\lexre\\Desktop\\Цифры.docx");
                File.Create("C:\\Users\\lexre\\Desktop\\Статистики.docx");
                string[] allFiles = Directory.GetFiles("C:\\Users\\lexre\\Desktop\\Words");
                foreach (string filePath in allFiles)
                {
                    Console.WriteLine("  " + filePath.Substring(filePath.LastIndexOf('\\') + 1) + "<->Время создания папки: " + File.GetCreationTime("C:\\Users\\lexre\\Desktop\\Words") + "<->Время последней записи: " + File.GetLastWriteTime("C:\\Users\\lexre\\Desktop\\Words"));
                }
            }
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("->");
            int posit = 0;
            do
            {
                string[] array = new string[] { "->", "  " };
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    posit--;
                    if (posit < 0)
                    {
                        posit = 0;
                    }
                    Console.SetCursorPosition(0, posit + 1);
                    Console.WriteLine(array[1]);
                    Console.SetCursorPosition(0, posit);
                    Console.WriteLine(array[0]);
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    posit++;
                    if (posit > 2)
                    {
                        posit = 2;
                    }
                    Console.SetCursorPosition(0, posit);
                    Console.WriteLine(array[0]);
                    Console.SetCursorPosition(0, posit - 1);
                    Console.WriteLine(array[1]);
                }
                if (key.Key == ConsoleKey.Enter && posit == 0)
                {
                    Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\lexre\\Desktop\\Цифры.docx", UseShellExecute = true });
                }
                if (key.Key == ConsoleKey.Enter && posit == 1)
                {
                    Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\lexre\\Desktop\\Статистики.docx", UseShellExecute = true });
                }
                if (key.Key == ConsoleKey.Enter && posit == 2)
                {
                    Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\lexre\\Desktop\\wordich.docx", UseShellExecute = true });
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
            } while (true);
        }

        public void TxT()
        {
            if (File.Exists("C:\\Users\\lexre\\Desktop\\Документ.txt") && File.Exists("C:\\Users\\lexre\\Desktop\\Блокнот.txt") && File.Exists("C:\\Users\\lexre\\Desktop\\Студенты.txt"))
            {
                string[] allFiles = Directory.GetFiles("C:\\Users\\lexre\\Desktop\\txt");
                foreach (string filePath in allFiles)
                {
                    Console.WriteLine("  " + filePath.Substring(filePath.LastIndexOf('\\') + 1) + "<->Время создания папки: " + File.GetCreationTime("C:\\Users\\lexre\\Desktop\\txt") + "<->Время последней записи: " + File.GetLastWriteTime("C:\\Users\\lexre\\Desktop\\txt"));
                }
            }
            else
            {
                File.Create("C:\\Users\\lexre\\Desktop\\Студенты.txt");
                File.Create("C:\\Users\\lexre\\Desktop\\Блокнот.txt");
                File.Create("C:\\Users\\lexre\\Desktop\\Документ.txt");
                string[] allFiles = Directory.GetFiles("C:\\Users\\lexre\\Desktop\\txt");
                foreach (string filePath in allFiles)
                {
                    Console.WriteLine("  " + filePath.Substring(filePath.LastIndexOf('\\') + 1) + "<->Время создания папки: " + File.GetCreationTime("C:\\Users\\lexre\\Desktop\\Студенты.txt") + "<->Время последней записи: " + File.GetLastWriteTime("C:\\Users\\lexre\\Desktop\\Студенты.txt"));
                }
            }
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("->");
            int posit = 0;
            do
            {
                string[] array = new string[] { "->", "  " };
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    posit--;
                    if (posit < 0)
                    {
                        posit = 0;
                    }
                    Console.SetCursorPosition(0, posit + 1);
                    Console.WriteLine(array[1]);
                    Console.SetCursorPosition(0, posit);
                    Console.WriteLine(array[0]);
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    posit++;
                    if (posit > 2)
                    {
                        posit = 2;
                    }
                    Console.SetCursorPosition(0, posit);
                    Console.WriteLine(array[0]);
                    Console.SetCursorPosition(0, posit - 1);
                    Console.WriteLine(array[1]);
                }
                if (key.Key == ConsoleKey.Enter && posit == 0)
                {
                    Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\lexre\\Desktop\\Студенты.txt", UseShellExecute = true });
                }
                if (key.Key == ConsoleKey.Enter && posit == 1)
                {
                    Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\lexre\\Desktop\\Документ.txt", UseShellExecute = true });
                }
                if (key.Key == ConsoleKey.Enter && posit == 2)
                {
                    Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\lexre\\Desktop\\Блокнот.txt", UseShellExecute = true });
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
            } while (true);
        }

    }
}