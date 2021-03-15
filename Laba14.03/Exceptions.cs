using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba14._03
{
    class Exceptions : Exception
    {
            public Exceptions()
            {
                Console.WriteLine("Вызвано моё исключение");
            }
    }
    class PersonException : Exception //Используем наследование
{
    //Принимает сообщение с описание ошибки, и код ошибки
    public PersonException(string aMessage, int aCode)
        : base(aMessage) //Вызываем конструктор базового класса
    {
        errorCode = aCode;
            Console.WriteLine(aMessage);

    }
 
    //Возвращает код ошибки
    public int ErrorCode { get { return errorCode; } }
 
    //Код ошибки
    private int errorCode;
}
}
