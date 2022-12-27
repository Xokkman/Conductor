using Conductor;
using Conductor;
using System.Diagnostics;
class Program
{
    static void Main()
    {
        DriveInfo[] drives = DriveInfo.GetDrives();
        Statics h = new Statics();
        foreach (DriveInfo drive in drives)
        {

            if (drive.IsReady)
            {
                Console.SetCursorPosition(h.posit_up, h.posit_down);
                Console.WriteLine("Имя диска: " + drive.Name);
                h.posit_up++;
                h.posit_down++;
                Console.SetCursorPosition(h.posit_up, h.posit_down);
                Console.WriteLine("Свободное пространство " + SizeConverter(drive.TotalFreeSpace));
                h.posit_up++;
                h.posit_down++;
                Console.SetCursorPosition(h.posit_up, h.posit_down);
                Console.WriteLine("Объём диска " + SizeConverter(drive.TotalSize));
                h.posit_up++;
                h.posit_down++;
                Console.SetCursorPosition(h.posit_up, h.posit_down);
                Console.WriteLine("Используемое пространство " + SizeConverter(drive.TotalSize - drive.TotalFreeSpace).ToString());
                h.posit_down++;
                h.posit_up = 2;
            }
            strela g = new strela();
            g.strel();
        }
    lable:
        if (Directory.Exists("C:\\Users\\lexre\\Desktop\\txt"))
        {
            string[] allFiles = Directory.GetDirectories("C:\\Users\\lexre\\Desktop\\txt");
            foreach (string filePath in allFiles)
            {
                Console.WriteLine("  " + filePath.Substring(filePath.LastIndexOf('\\') + 1) + "<->Время создания папки: " + Directory.GetCreationTime("C:\\Users\\lexre\\Desktop\\") + "<->Время последней записи: " + Directory.GetLastWriteTime("C:\\Users\\lexre\\Desktop\\"));
            }

        }
        else
        {
            Directory.CreateDirectory("C:\\Users\\lexre\\Desktop\\txt");
            Directory.CreateDirectory("C:\\Users\\lexre\\Desktop\\wordich");
            string[] allFiles = Directory.GetDirectories("C:\\Users\\lexre\\Desktop\\WordsandTXT");
            foreach (string filePath in allFiles)
            {
                Console.WriteLine("  " + filePath.Substring(filePath.LastIndexOf('\\') + 1) + "<->Время создания папки: " + Directory.GetCreationTime("C:\\Users\\lexre\\Desktop\\WordsandTXT") + "<->Время последней записи: " + Directory.GetLastWriteTime("C:\\Users\\lexre\\Desktop\\WordsandTXT"));
            }
        }
        strela U = new strela();
        U.strelka();
        goto lable;
    }
    private static string SizeConverter(double sSize)
    {
        double _size = sSize;
        int i = 0;
        string[] _vol = { "БТ", "КБ", "МБ", "ГБ", "ТБ" };
        while (_size > 1024)
        {
            _size /= 1024;
            i++;
        }
        return _size.ToString().Substring(0, 5) + " " + _vol[i];
    }
}