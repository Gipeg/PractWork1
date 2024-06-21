Console.WriteLine("Подзапись завершится при слове 'end'");
Console.WriteLine("Введите имя файла");
string fileName = Console.ReadLine();

if (!File.Exists(fileName))
{
    Console.WriteLine($"Файл: {fileName} будет создан");
}
else
{
    Console.WriteLine($"Файл: {fileName} открыт на подзапись");
}

string userInput = "";
while (userInput != "end")
{
    userInput = Console.ReadLine();
    if (userInput != "end")
    {
        File.AppendAllText(fileName, userInput + Environment.NewLine);
    }
}
Console.WriteLine("Запись файла завершена");