namespace lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator user = new Calculator();
            int userchoice = 0;

            do
            {
                user.usermenu();
                try
                {
                    userchoice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    user.useroutput();
                }

                switch (userchoice)
                {
                    case 1:
                        user.userinput();
                        user.add();
                        break;

                    case 2:
                        user.userinput();
                        user.subtract();
                        break;
                    case 3:
                        user.userinput();
                        user.multiply();
                        break;
                    case 4:
                        user.userinput();
                        user.divide();
                        break;
                    case 5:
                        break;

                    default:

                        user.useroutput();
                        break;
                }
            }
            while (userchoice != 5);
        }   
    }
}