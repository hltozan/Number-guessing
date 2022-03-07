namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int upperLimit = 100;
            int lowerLimit = 0;
            string answer;

            while (true){
                number = (upperLimit - lowerLimit) / 2 + lowerLimit;
                Console.WriteLine("Number is " + number.ToString());
                again1:
                Console.Write("If the number smaller than your number enter l, if it's greater enter g, if it's equal enter 'e': ");
                answer = Console.ReadLine();
                System.Console.WriteLine();
                if (answer == "l"){
                    lowerLimit = number;
                }
                else if (answer == "g"){
                    upperLimit = number;
                }
                else if (answer == "e"){
                    Console.WriteLine("I found!!");
                    again2:
                    Console.Write("If you want to play again enter 'p', enter e to exit the game: ");
                    answer = Console.ReadLine();
                    System.Console.WriteLine();
                    if (answer == "p")
                        continue;
                    else if(answer == "e")
                        break;
                    else
                        Console.WriteLine("Please enter a valid character...");
                        goto again2;
                }
                else{
                    Console.WriteLine("Please enter a valid character...");
                    goto again1;
                }
            }
        }
    }
}