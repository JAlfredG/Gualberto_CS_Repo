
namespace firstProject
{
    class bankingSystem
    {
        static void Main(string[] args)
        {
            //variables
            double balance = 1000, wdr, dep, amt;
            int pinUser = 1234, loopBreak=0;
            bool systemLoop = false, loginLoop = false;

            Console.WriteLine("Welcome to ATM!");
            
            while (!systemLoop)
            {
                //get pin
                Console.WriteLine("Enter your pin: ");
                short pinInput = Convert.ToInt16(Console.ReadLine());

                //check pin
                if (pinInput == pinUser)
                {
                    Console.WriteLine("Login successful!");
                    while (!loginLoop)
                    {
                        //options
                        Console.WriteLine("""
                        Please select an option:
                        [1] View Balance
                        [2] Withdraw
                        [3] Deposit
                        [4] Exit
                        """);
                        byte userChoice = Convert.ToByte(Console.ReadLine());

                        switch (userChoice)
                        {
                            case 1:
                                Console.WriteLine($"Your balance is: {balance}");
                                break;
                            case 2:
                                Console.WriteLine("Enter amount to withdraw: ");
                                wdr = Convert.ToDouble(Console.ReadLine());
                                if (wdr > balance)
                                {
                                    Console.WriteLine("Insufficient balance.");
                                }
                                else
                                {
                                    balance -= wdr;
                                    Console.WriteLine($"You have withdrawn {wdr}. Your new balance is {balance}");
                                }
                                break;
                            case 3:
                                Console.WriteLine("Enter amount to deposit: ");
                                dep = Convert.ToDouble(Console.ReadLine());
                                balance += dep;
                                Console.WriteLine($"You have deposited {dep}. Your new balance is {balance}");
                                break;
                            case 4:
                                loginLoop = true;
                                break;
                            default:
                                Console.WriteLine("Invalid option. Please try again.");
                                break;
                        }
                    }                   

                } else
                {
                    Console.WriteLine("Invalid pin. Please try again.");
                    loopBreak++;
                }

                //breaking the loop
                if (loopBreak == 5)
                {
                    Console.WriteLine("You have reached the maximum number of tries. Please try again later.");
                    loopBreak = 0;
                    break;
                }
            }
        }
    }
}