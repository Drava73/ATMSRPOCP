using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSRPOCP
{
    public class ATM
    {

        public double money { get; set; }
        public string numbercard { get; set; }
        public string nameperson { get; set; }
        public string number { get; set; }
        public ATM()
        {
            money = 0;
            numbercard = "None";
            nameperson = "None";
            number = "None";
        }
        public ATM(double money, string numbercard, string nameperson, string number)
        {
            this.money=money;
            this.numbercard=numbercard;
            this.nameperson=nameperson;
            this.number=number;
        }
    }
    public class AddCard : ATM {
        public static ATM Create(double money, string numbercard, string nameperson, string number)
        {
            Console.Write("\nВведите желаемый номер карты:");
            numbercard = Console.ReadLine();
            Console.Write("\nВведите имя:");
            nameperson = Console.ReadLine();
            Console.Write("\nВведите номер телефона:");
            number = Console.ReadLine();
            Console.Write("\nВведите сумму(гривны)");
            money = Convert.ToDouble(Console.ReadLine());
            return new ATM(money, numbercard, nameperson, number);
        }
        public class ShowATM : ATM
        {
            public void Show() {
                Console.Write($"\nНомер карты:{numbercard}\nИмя владельца:{nameperson}\nНомер телефона:{number}\nСумма (гривны):{money}");
            }
        }

    }
    public delegate void CardDelegateVoid(int value);
    public class SourceEventInt : ATM
    {
        public CardDelegateVoid ev;
        public void GenerateEvent(int value)
        {
            ev.Invoke(value);
        }
    }
}
