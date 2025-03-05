
namespace firstProject
{
    class TestProject
    {
        static void Main(string[] args)
        {
            //variables
            double balance = 1000, wdr, dep, amt;
            int pinUser = 1234, loopBreak=0;
            bool systemLoop = false;


            Console.WriteLine("Welcome to ATM!");
            Console.WriteLine("Enter your pin: ");
            short pinInput = Convert.ToInt16(Console.ReadLine());

            while (!systemLoop)
            {
                if (pinInput == pinUser)
                {
                    Console.WriteLine("Login successful!");
                } else
                {
                    Console.WriteLine("Invalid pin. Please try again.");
                    loopBreak++;
                }

                if (loopBreak == 3)
                {
                    Console.WriteLine("You have reached the maximum number of tries. Please try again later.");
                    loopBreak = 0;
                    break;
                }
            }


        }

    }
}
