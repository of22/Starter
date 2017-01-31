using System;
using System.Diagnostics;


namespace ConsoleApplication1
{
    class Program
    {
        static int debt = 700;
        static int payedTotal = 0;

        static void Main(string[] args)
        {

            //3адание 2
            //Используя Visual Studio, создайте проект по шаблону Console Application.  
            //Представьте, что вы реализуете программу для банка, которая помогает определить, погасил ли клиент кредит или нет.Допустим, 
            // ежемесячная сумма платежа должна составлять 100 грн.Клиент должен выполнить 7 платежей, но может платить реже большими суммами. Т.е., может двумя платежами по 300 и 400 грн.Закрыть весь долг.
            //Создайте метод, который будет в качестве аргумента принимать сумму платежа, введенную экономистом банка.Метод выводит на экран информацию 
            //   о состоянии кредита (сумма задолженности, сумма переплаты, сообщение об отсутствии долга).
             
            while (payedTotal < debt)
            {
                Console.WriteLine("Enter payment");
                string input = Console.ReadLine();
                int payment = Convert.ToInt32(input);
                PaymentOperaions(payment);
            }

            Console.ReadLine();
        }

        private static void PaymentOperaions(int payment )
        {
            payedTotal += payment;
            Console.WriteLine($"User payed : {payment}, total payed - {payedTotal}" );
            if (payedTotal > debt)
            {
                Console.WriteLine( $"Payed over debt: {payedTotal - debt}");
            }
        }

    }
}
