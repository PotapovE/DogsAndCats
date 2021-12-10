Console.Clear();
Random random = new Random();
int left = 0, top = 0;
for (int i = 0; i < 101; i++)
{
    Console.SetCursorPosition(i, top);
    System.Console.WriteLine("_");
}

for (int i = 0; i < 101; i++)
{
    Console.SetCursorPosition(i, top + 11);
    System.Console.WriteLine("`");
}

for (int i = 0; i < 10; i++)
{
    Console.SetCursorPosition(left, i + 1);
    System.Console.WriteLine("|");
}

for (int i = 0; i < 10; i++)
{
    Console.SetCursorPosition(left + 101, i + 1);
    System.Console.WriteLine("|");
}

Random randomAnimal = new Random();
int count = 0;
while (count < 10000)
{
    left = random.Next(1, 101);
    top = random.Next(1, 11);
    Console.SetCursorPosition(left, top);

    if (randomAnimal.Next(1, 3) == 1)
    {
        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
        System.Console.WriteLine("@");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет
        System.Console.WriteLine("@");
    }

    // Console.ResetColor(); // сбрасываем в стандартный
    left = random.Next(1, 101);
    top = random.Next(1, 11);
    Console.SetCursorPosition(left, top);

    if (randomAnimal.Next(3, 5) == 3)
    {
        Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
        System.Console.WriteLine("^");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow; // устанавливаем цвет
        System.Console.WriteLine("^");
    }

    Thread.Sleep(1000);
    count++;
}

Console.ReadKey();