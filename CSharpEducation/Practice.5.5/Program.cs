//Создайте в папке проекта файл Account.cs, и создайте в нём новый public класс Account.Добавьте в класс поле _balance.
//Поле пометьте модификатором private. Добавьте и реализуйте три метода: AddMoney, TakeMoney, ShowBalance.
//Метод AddMoney увеличивает значение _balance на указанное значение. Метод TakeMoney уменьшает значение _balance на указанную сумму.
//Метод ShowBalance возвращает значение _balance. Учтите, что ни в одном из методов не должно быть работы с консолью.

//Задание аналогично предыдущему, но добавьте в метод TakeMoney проверку возможности снять деньги со счёта.
//Если значение _balance меньше указанного числа, то писать в консоль сообщение об ошибке. Значение _balance в таком случае не должно меняться.
namespace Practice._5._5;

class Program
{
    static void Main(string[] args)
    {
        Account account = new Account();

        account.AddMoney(20);
        account.TakeMoney(25);
        account.ShowBalance();
    }
}

