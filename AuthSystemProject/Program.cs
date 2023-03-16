using AuthSystemProject;
using Title;

UsersDataBaseMock db = new(100);
Authorization authorization = new(db);
List<Person> people = new List<Person>(5);
people.Add(new Person() { Name = "Вася" });
people.Add(new Person() { Name = "Петя" });
people.Add(new Person() { Name = "Ваня" });
people.Add(new Person() { Name = "Гоша" });
people.Add(new Person() { Name = "Таня" });

Console.Write("Введите логин: ");
string login = Console.ReadLine();
Console.Write("Введите пароль: ");
string pass = Console.ReadLine();


authorization.Login(login.Trim(), pass.Trim());


if (authorization.IsAuth())
{
    Console.WriteLine("");
    Console.WriteLine("Успешно");
    Console.WriteLine("");
    if (authorization.GetRole() == User.Roles.ADMIN)
    {
        Console.WriteLine("Добро пожаловать, администратор!");
        start:
        Console.WriteLine("Ваши возможности: \n 1 - Вывод списка клиентов, \n 2 - Редактирование списка клиентов, \n 3 - Поиск клиентов по ID. ");
        Console.WriteLine("");
        int any;
        any = int.Parse(Console.ReadLine());
        Person[] peoples = people.ToArray();
        switch (any)
        {
            case 1:
                Console.WriteLine("Вывод списка...");

                foreach (Person person in people)
                {

                    Console.Write(person.Name);
                }
                goto start;
            case 2:
                Console.Write("Введите ID пользователя для его редактирования: ");
                int id_u = int.Parse(Console.ReadLine());
                if (id_u <= peoples.Length && id_u >= 0)
                {
                    Console.WriteLine(peoples[id_u - 1].Name.ToString() + " - текущее имя пользователя");
                    Console.Write("Введите новое имя пользователя: ");
                    string name = Console.ReadLine();
                    peoples[id_u - 1].Name = name;
                }
                else
                {
                    Console.WriteLine("Пользователя с таким ID не существует!");
                }
                goto start;
            case 3:
                Console.Write("Введите ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine(peoples[id - 1].Name.ToString());
                goto start;
            default:
                Console.WriteLine("Неверная команда!");
                goto start;
        }

    }
    else
    {
        int any;
        Console.WriteLine("Добро пожаловать, пользователь!");
        start1:
        Console.WriteLine("Ваши возможности: \n 1 - Вывод списка клиентов,\n 2 - Поиск клиентов по ID.");
        any = int.Parse(Console.ReadLine());
        switch (any)
        {
            case 1:
                Console.WriteLine("Вывод списка...");

                foreach (Person person in people)
                {

                    Console.WriteLine(person.Name);
                }
                goto start1;
            case 2:
                Console.Write("Введите ID: ");
                int id = int.Parse(Console.ReadLine());
                Person[] peoples = people.ToArray();
                Console.WriteLine(peoples[id - 1].Name.ToString());
                goto start1;
            default:
                Console.WriteLine("Неверная команда!");
                goto start1;
        }


    }

}
else
{

    Console.WriteLine("Данный пользователь не найден...");
}

Console.ReadKey();

