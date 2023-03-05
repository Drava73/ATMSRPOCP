using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSRPOCP
{
    /*public class ATM
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
    }*/
    public interface ATM
    {
        double money { get; set; }
        string numbercard { get; set; }
        string nameperson { get; set; }
        string number { get; set; }
    }

    public interface CreateCard
    {
        ATM CreateCard();
        void ShowCard(ATM card);
    }

    public interface ATMEv
    {
        void CardEv(int value);
    }

    public class CardEventHandler : ATMEv
    {
        public void CardEv(int value)
        {
            Console.WriteLine($"Событие с параметром {value} было вызвано");
        }
    }

    public class CardService : CreateCard
    {
        public ATMEv card1;

        public CardService(ATMEv card1)
        {
            this.card1 = card1;
        }

        public ATM CreateCard()
        {
            Console.Write("\nВведите желаемый номер карты:");
            string numbercard = Console.ReadLine();
            Console.Write("\nВведите имя:");
            string nameperson = Console.ReadLine();
            Console.Write("\nВведите номер телефона:");
            string number = Console.ReadLine();
            Console.Write("\nВведите сумму(гривны)");
            double money = Convert.ToDouble(Console.ReadLine());
            ATM card = new Card { money = money, numbercard = numbercard, nameperson = nameperson, number = number };
            int value = 42;
            card1.CardEv(value);
            return card;
        }

        public void ShowCard(ATM card)
        {
            Console.Write($"\nНомер карты:{card.numbercard}\nИмя владельца:{card.nameperson}\nНомер телефона:{card.number}\nСумма (гривны):{card.money}");
        }
    }

    public class Card : ATM
    {
        public double money { get; set; }
        public string numbercard { get; set; }
        public string nameperson { get; set; }
        public string number { get; set; }
    }
    public delegate void CardDelegateVoid(int value);
    public class SourceEventInt
    {
        public CardDelegateVoid ev;
        public void GenerateEvent(int value)
        {
            ev.Invoke(value);
        }
    }
}

