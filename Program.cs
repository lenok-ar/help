
namespace help
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ФИО: ");
            string fio = Console.ReadLine();

            Console.Write("Введите Серию паспортa: ");
            int series = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер паспортa: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите дату рождения: ");
            string dateOfBirth = Console.ReadLine();

            Console.Write("В браке вы или нет? (да/нет): ");
            string merriage = Console.ReadLine();

            Console.Write($"\nФИ0: {fio}\nСерия паспорта: {series}\nНомер паспорта: {number}\nДата рождения: {dateOfBirth}\nВ браке: {merriage}\n");

            Console.Write("\nХотите сменить ФИО? (да - 1/нет - 0): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Введите новое фио: ");
                string fio2 = Console.ReadLine();
                Console.Write("Данные обновлены\n");
                Console.Write($"\nФИ0: {fio2}\nСерия паспорта: {series}\nНомер паспорта: {number}\nДата рождения: {dateOfBirth}\nВ браке: {merriage}");
            }
            else
            {
                Console.Write($"\nФИ0: {fio}\nСерия паспорта: {series}\nНомер паспорта: {number}\nДата рождения: {dateOfBirth}\nВ браке: {merriage}");
            }
        }
    }
}
