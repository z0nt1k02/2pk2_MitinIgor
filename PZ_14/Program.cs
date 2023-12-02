namespace PZ_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Create(@"C:\C#\2pk2_MitinIgor\PZ_14\f1.txt");//создание файла
            File.Create(@"C:\C#\2pk2_MitinIgor\PZ_14\f2.txt");//создание файла
            File.Create(@"C:\C#\2pk2_MitinIgor\PZ_14\temp.txt");//создание файла

            string f1 = @"C:\C#\2pk2_MitinIgor\PZ_14\f1.txt";
            string f2 = @"C:\C#\2pk2_MitinIgor\PZ_14\f2.txt";
            string temp = @"C:\C#\2pk2_MitinIgor\PZ_14\temp.txt";

            string f1Content = File.ReadAllText(f1);//чтение f1
            File.WriteAllText(temp, f1Content);//перезапись файла f1 во временный

            string f2Content = File.ReadAllText(f2);//чтение f2
            File.WriteAllText(f1, f2Content);// перезапись  файла f1 содержимым файла f2           
            string f1_New = File.ReadAllText(f1);
            Console.WriteLine(f1_New);//вывод содержимого файла f1 с содержимым файла f2

            File.WriteAllText(f2, f1Content);// перезапись  файла f2 содержимым временного файла
            string f2_New = File.ReadAllText(f2);
            Console.WriteLine(f2_New);//вывод содержимого файла f2 с содержимым файла f1
            File.Delete(temp);// удаление временного файла
        }
    }
}