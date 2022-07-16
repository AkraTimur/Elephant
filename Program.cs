using System;

namespace Elephant
{
    public class Elephant
    {
        public string Name;
        public int EarSize;
        public void WhoAmI()
        {
            Console.WriteLine("My name is " + Name);
            Console.WriteLine("My ears are " + EarSize + " inches tall");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">cообщение от другого объекта Elephant</param>
        /// <param name="whoSaidIt">передается объект Elephant, отправивший сообщение</param>
        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine(Name + " heard a message");
            Console.WriteLine(whoSaidIt.Name + " said this: " + message);
        }
        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage(message, this);
        }
        static void Main(string[] args)
        {
            
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            Elephant swapper = new Elephant();
            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            while (true)
            {
            Console.Write("You pressed ");
            string line = Console.ReadLine();
            if (!int.TryParse(line, out int userChoise))
            {
                Console.WriteLine("take right number");
            }
                switch (userChoise)
                {
                    case 1:
                        Console.WriteLine("Calling lloyd.WhoAmI");
                        lloyd.WhoAmI();
                        break;
                    case 2:
                        Console.WriteLine("Calling lucinda.WhoAmI");
                        lucinda.WhoAmI();
                        break;
                    case 3:
                        Console.WriteLine("References have been swapped");
                        swapper = lloyd;
                        lloyd = lucinda;
                        lucinda = swapper;
                        break;
                    case 4:
                        lloyd = lucinda;
                        lloyd.EarSize = 4321;
                        lloyd.WhoAmI();
                        break;
                    case 5:
                        lucinda.SpeakTo(lloyd, "Hi, lloyd!");
                        break;
                    default:
                        Console.WriteLine("Error! Try again");
                        break;
                }
            }

        }
    }
}
