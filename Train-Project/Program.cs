using Train_Project;

Work work = new();
void Menu()
{
    Console.WriteLine();
    Console.WriteLine($"1) Добавить пользователя оставевшего коментарий");
    Console.WriteLine($"2) Вывести список пользователей");
    Console.WriteLine();
}
void GetMenu()
{
    while (true)
    {
        Menu();
        string enter = Console.ReadLine();
        bool check = int.TryParse(enter, out var result);
        if (result == 1)
        {
            work.SetUsers();
        }
        else if (result == 2)
        {
            work.CheckingAvailabilityUsers();
        }
        else
        {
            Console.WriteLine($"Выберите пункт из меню");
        }                
    }
}
GetMenu();