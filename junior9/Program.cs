string input = "";
string exitProgram = "exit";

Console.WriteLine($"Если хотите выйти из программы, введите {exitProgram}");

while (input != exitProgram)
{
    Console.Write("Введите слово: ");
    input = Console.ReadLine();
    Console.WriteLine($"Ваше слово: {input}");
}

Console.WriteLine("Вы вышли из программы");