namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {//exercise 1
            //set favNum value
            int favNum = 93;
            //ask user
            Console.WriteLine("Guess my favorite number");
            //set value for loop command so it knows when to stop
            bool gussed = false;
            // loop command
            while (gussed == false) 
            { //decided to make a response if the entered vale is invalid
                int imput;
                try
                {
                    imput = int.Parse(Console.ReadLine());
                }
                catch (Exception )
                {
                    Console.WriteLine("Quit trying to find bugs in my code");
                    return;
                }
                //if else statements
                if (imput == favNum)
                {
                    Console.WriteLine("Yay you figured it out hears your prize :). Yes, it's the smiley face.");
                    gussed = true;
                }
                else if (imput > favNum)
                {
                    Console.WriteLine("Too high just a little lower.");

                }
                else
                {
                    Console.WriteLine("Too low try a little higher.");
                }
            }
            //exercise 2
            
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();
            
            switch(favoriteSubject)
            {
                case "math":
                    Console.WriteLine("What ever flots your boat, I hate numbers. ");
                    break;
                
                case "english":
                    Console.WriteLine("I would have to agree that is a good one, after all we all speak it.");
                    break;
                
                case "science":
                    Console.WriteLine("Oooooo me too I loved science.");
                    break;
                
                case "shop":
                    Console.WriteLine("Another favorite of mine I always like working with my hands.");
                break;
                
                case "music":
                    Console.WriteLine("Who doesn't like a good tune. ");
                    break;
                
                default:
                    Console.WriteLine("Interesting choice! What do you like about it?");
                break;
                    
                
                
                
            }
            











        }
    }
}
