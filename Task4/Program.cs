using System.Buffers;
using System.IO;

Console.WriteLine("Введите путь к файлу: ");
string pathFolder = Console.ReadLine();
Console.WriteLine("Введите часть файла: ");
string pattern = Console.ReadLine();

if (Directory.Exists(pathFolder))
{
    SearchFiles(pathFolder, pattern);
}
else
{
    Console.WriteLine("Указанная директория не существует");
}

static void SearchFiles(string pathFolder, string pattern)
{
    string[] files = Directory.GetFiles(pathFolder, "*" + pattern + "*");
    foreach (string file in files)
    {
        FileInfo fileInfo = new FileInfo(file);
        Console.WriteLine($"Имя файла: {fileInfo.FullName}, Размер: {fileInfo.Length}");
    }
    string[] subderictories = Directory.GetDirectories(pathFolder);

    foreach (string subderictory in subderictories)
    {
        SearchFiles(subderictory, pattern);
    }

}