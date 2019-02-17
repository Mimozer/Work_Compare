using System;
using System.IO;

namespace Compare
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите путь к передающему каталогу:");
            Way way_in = new Way;
            Console.WriteLine("Введите путь к принимающему каталогу:");
            Way way_out = new Way;
            // Необходимо встроить: 1) метод сравнения, 
            // 2)метод вывода списка не_совпадающих номеров,
            // 3) ввод номера стойки и преренос необходимых файлов из списка 2 во 2 каталог.
        }

        #region (Comp) Метод сравнения двух каталогов.
        static void Comp()
        {
            FileInfo nam_1.Name = new Fileinfo(way_in); // Nam_1 - переменная для работы с именами анализируемого каталога.
            Fileinfo nam_2.Name = new Fileinfo(way_out); // Nam_2 - переменная для работы с именами второго каталога.
            for (int i = 0; ; i++) // Необходимо задать условие окончания списка №2.
            {
                // Необходимо ввести перебор имени из каталога 1 относительно 2.
                // С последующим перебором до окончания каталога 1.
                // При совпадении необходимо также проверить совпадение времени создания.
                // Если число больше ? (1 суток), то выводить в список.

            }

        }
        #endregion

        #region (Trans) Метод передачи файла в каталог с изменением имени.
        static void Trans()
        {
            Console.WriteLine("Введите номер стойки:")


        int nom = Console.ReadLine();

            // Необходимо задать:
            // 1) прикрепление его к имени каждого члена списка не_совпадающих,
            // 2) перенос копии файлов с измененным номером в каталог 2.
        }
        #endregion

        #region (Way) Метод ввода пути к каталогу.
        static string Way(string way)
        {
            string way = Console.ReadLine(); // Way - переменная для хранения анализируемого каталога.
        }
        #endregion

        #region (List) Метод создания списка не_совпадающих в каталогах имен файлов и времен.
        static ? List()
        {
            // Принимает ? в файл/в массив (как экономнее хранить данные) имена и порядковый номер
            // не_совпадающих файлов из каталога 1, вводит по 1 на строку.

        }
        #endregion
    }

    //Не проще составить из имен каталогов массивы, с которыми работать?



{

namespace Compare2
}
class Program2
    {
        static void Main()
        {
            Console.WriteLine(Введите путь к передающему каталогу:);
        string way_in = Console.ReadLine();
        Console.WriteLine("Введите путь к принимающему каталогу:");
		string way_out = Console.ReadLine();
		
	!	FileInfo nam_1 = new Fileinfo(way_in.Name); //Правильность синтаксиса?
	!	FileInfo nam_2 = new Fileinfo(way_out / Name);//Правильность синтаксиса?
	!	for (int x = 0;  ; x++) //Задание условия окончания каталога_1
		{
			if (nam_1 = nam_2)
			{
				Fileinfo date_1 = new Fileinfo(way_in.LastWriteTime);
        Fileinfo date_2 = new Fileinfo(way_out.LastWriteTime);
				if (date_1 != date_2)
				{
	!				//Создание файла, в который будут приходить все не_совпадающие имена
	!				//И совпадающие с разным временем
	!				//Построчно
				}
				continue;
				x++;
			}
			else 
			{
	!			
				x++;
			}
		}
		
		
		
	}
}