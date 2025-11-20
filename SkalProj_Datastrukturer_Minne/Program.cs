using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            List<string> theList = new List<string>();
       
            while (true)
            {
                Console.WriteLine("Please write a name to be added or removed from a list of your choice"
                    + "\n+Name"
                    + "\n-Name"
                    + "\n0. Exit back to the main menu");
                if (theList.Count > 0)
                {
                    
                    Console.WriteLine("All the people in the list thus far: "); 
                    foreach (string name in theList)
                    {
                    Console.WriteLine(name);
                    }
                    Console.WriteLine($"So that is about {theList.Count} amount of people. And the capacity is currently: {theList.Capacity}");
                    /* Capacity starts of at 4, then grows to 8 when you have reached 4 and add another one in the list.
                    then 16, then 32. There for 2x the previous capacity. 

                    What's interesting is that the capacity doesn't decrease after you have gone below capacity.
                    Now if you invited people to a party and you said they can only bring two people, having a fixed array would
                    be better than having a list as a list can add more and more.

                    Then as it pertains to why capacity doesn't grow in relation to count, I had to google that one. And what I learned 
                    was that it minimizes the amount of reallocations to memory, which makes sense, rather do it in leaps then again and again.
                    */
                }
                else
                {
                    Console.WriteLine("Currently no name exist.");
                }

            Console.Write("Write: ");
            string input = Console.ReadLine();
            char nav = input[0];
            string value = input.Substring(1);

            if (nav == '0')
            {
                    Console.WriteLine("Back to main menu");
                    break;
            }
            switch (nav)
                {
                case '+':
                        theList.Add(value);
                    break;
                case '-':
                    theList.Remove(value);
                    break;            
                case '0':   
                    return;    
                default:    
                    Console.WriteLine("Please enter some valid input (+Name, -Name, 0)");
                    break;
                 }
            }
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            Console.WriteLine("Welcome to ICA queue."
                    + "\nICA opens and the queue is empty.");


            Queue<string> theList = new Queue<string>();

            while (true)
            {
                Console.WriteLine("Please write '+' for enqueue or '-' from a dequeue of your choice"
                    + "\n+"
                    + "\n-"
                    + "\n0. Exit back to the main menu");

                Console.Write("Write: ");
                string input = Console.ReadLine();
                char nav = input[0];

                if (nav == '0')
                {
                    Console.WriteLine("Back to main menu");
                    break;
                }
                switch (nav)
                {
                    case '+':
                        Console.WriteLine("Add name: ");
                        string inputAdd = Console.ReadLine();
                        theList.Enqueue(inputAdd);
                        Console.WriteLine($"{inputAdd} just added.");
                        break;
                    case '-':
                        var nextUp = theList.Dequeue();
                        Console.WriteLine($"Next up: {nextUp.ToString()}");
                        break;
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Please enter some valid input.");
                        break;
                }
                if (theList.Count>0)
                {
                    Console.Write($"People in the queue: ");
                    foreach (var person in theList )
                    {
                        Console.Write($"{person.ToString()}, ");
                    }
                    Console.WriteLine("\n");
                }    
            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
             * Implementera en ReverseText-metod
            */

            while (true)
            {
                Console.WriteLine("All about stacks! Please make a choice 1 or 2."
                    + "\n1. Examine ICA's strange line"
                    + "\n2. Reverse a text"
                    + "\n0. Exit back to the main menu");

                Console.Write("Write: ");
                string input = Console.ReadLine();
                char nav = input[0];

                if (nav == '0')
                {
                    Console.WriteLine("Back to main menu");
                    break;
                }

                switch (nav)
                {
                    case '1':
                        Console.WriteLine("Welcome to strange ICA.");

                        Stack<string> theStack = new Stack<string>();

                        while (true)
                        {
                            Console.WriteLine("Please write '+' to push or '-' to pop"
                                + "\n+"
                                + "\n-");

                            Console.Write("Write: ");
                            string inputStack = Console.ReadLine();
                            char navStack = inputStack[0];

                            switch (navStack)
                            {
                                case '+':
                                    Console.WriteLine("Add name: ");
                                    string inputAdd = Console.ReadLine();
                                    theStack.Push(inputAdd);
                                    Console.WriteLine($"{inputAdd} just got added to the strange line.");
                                    break;
                                case '-':
                                    string beGone = theStack.Pop();
                                    Console.WriteLine($"{beGone} just got removed from the strange line. ");
                                    theStack.Pop();
                                    break;
                                case '0':
                                    return;
                                default:
                                    Console.WriteLine("Please enter some valid input.");
                                    break;
                            }

                            if (theStack.Count > 0)
                            {
                                Console.Write($"Names in the line: ");
                                foreach (var item in theStack)
                                {
                                    Console.Write($"{item.ToString()}, ");
                                }
                                Console.WriteLine("\n");
                            }
                        }

                    case '2':
                        Console.WriteLine("Please write a text that you want to see reversed:");
                        string textInput = Console.ReadLine();

                        Stack<char> charStack = new Stack<char>();

                        foreach (char letter in textInput)
                        {
                            charStack.Push(letter);
                        }

                        foreach (var item in charStack)
                        {
                            Console.Write(item);
                        }

                        break;

                    default:
                        Console.WriteLine("Please enter some valid input (1, 2, 0)");
                        break;
                }
            }
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            while (true)
            {
                Console.WriteLine("Welcome to the Parenthesis Checker!"
            + "\nPlease write text to check if the parenthesis are well formed. "
            + "\n(Example: (()), {}, [({})])"
            + "\n0. Exit back to the main menu");
                Console.Write("Write: ");
                string input = Console.ReadLine();
                char nav = input[0];

                string leftSide = "({[";
                string rightSide = ")}]";

                if (nav == '0')
                {
                    Console.WriteLine("Back to main menu");
                    break;
                }
                int count = 0;
                Stack<char> theStack = new Stack<char>();
                foreach (char symbole in input)
                {

                    if (leftSide.Contains(symbole))
                    {
                        int indexLeft = leftSide.IndexOf(symbole);
                        theStack.Push(rightSide[indexLeft]);
                        count++;
                    }
                    else
                    {
                        if ((rightSide.Contains(symbole)) && (theStack.Peek() == symbole))
                        {
                            theStack.Pop();
                        }

                    }
                }
                if ((count != 0) && theStack.Count == 0)
                {
                    Console.WriteLine("Correctly done!");
                }
                else
                {
                    Console.WriteLine("Wrongly done!");
                }

            }
        }

    }
}

