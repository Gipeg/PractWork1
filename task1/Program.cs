Console.WriteLine("Введите имя файла");
string fileName = Console.ReadLine();

if (File.Exists(fileName))
{
    string content = File.ReadAllText(fileName);
    Console.WriteLine($"Содержимое файла: {content}");
}
else
{
    Console.WriteLine("ФАЙЛА НЕТ!!!!!!!!!!!!!!");
}
