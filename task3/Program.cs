Console.WriteLine("Введите текст для поиска: ");
string searchText = Console.ReadLine();
Console.WriteLine("Введите имя файла");
string filename = Console.ReadLine();

if (!File.Exists(filename))
{
    Console.WriteLine("ФАЙЛА НЕТ!!!!!!!!!!!!!!");
    return;
}

string[] lines = File.ReadAllLines(filename);

Console.WriteLine($"Строки файла '{filename}', содержание текста: {searchText}");

for (int i = 0; i < lines.Length; i++)
{
    Console.WriteLine($"Строка {i + 1}: {lines[i]}");
}
