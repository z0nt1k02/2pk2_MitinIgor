namespace PZ_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;// переменная для определения латинских символов в названии файла
            Console.Write("Введите путь к каталогу: ");
            string dirName = Console.ReadLine();//ввод пути к каталогу
            if (Directory.Exists(dirName)) // проверка на существование
            {
                Console.WriteLine("Файлы на латинице:");
                string[] files = Directory.GetFiles(dirName); // массив файлов каталога
                if (files.Length == 0) 
                    Console.WriteLine("В этом каталоге нет файлов");
                foreach (string c in files)//цикл для определния файлов
                {
                    foreach(char f in c) //цикл,который проверяет каждую букву имени файла на латиницу
                    {
                        if (f >= 'A' && f <= 'Z' || f>='a' && f<='z')//условие для проверки на латиницу
                        {
                            a++;
                        }
                        if(a == c.Length)
                        {
                          Console.WriteLine(c);
                          a = 0;
                        }
                    }
                    
                }
            }
        }
    }
}