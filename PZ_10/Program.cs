namespace PZ_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text1 = Console.ReadLine();//ВВОД СТРОКИ
            string text2 = Console.ReadLine();//ввод строки
            string text3 = Console.ReadLine();//ввод строки
            string newText = text1 + " " + text2 + " " + text3;//конкатенация
            newText = newText.Trim();
            string[] words = newText.Split(' ');//разделение строки на слова
            for (int i = 0; i < words.Length; i++) // цикл для определения одинаковых слов
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i] == words[j])
                    {
                        words[j] = "";
                    }
                }
            }
            foreach (string word in words)//вывод массива без лишних пробелов
            {
                if (word.All(Char.IsWhiteSpace))// если элемент сосотоит из пробела
                    continue;
                else
                    Console.Write(word + " ");//вывод массива
            }
        }
    }
}