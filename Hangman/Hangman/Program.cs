using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            int falseguesses = 11;
            string falseguessl = "";
            int i = 1;
            int pos;
            string word2 = "";
            string word;
            int guesses = 0;
            var words = new List<string>();
            words.Add("protest");
            words.Add("battle");
            words.Add("admission");
            words.Add("satisfaction");
            words.Add("house");
            words.Add("staff");
            words.Add("spray");
            words.Add("horizon");
            words.Add("ignore");
            words.Add("scream");
            words.Add("pain");
            words.Add("grandmother");
            words.Add("advertising");
            words.Add("endure");
            words.Add("memory");
            words.Add("biology");
            words.Add("account");
            words.Add("aware");
            words.Add("pen");
            words.Add("cheese");
            words.Add("mathematics");


            Console.WriteLine("Welcome to Hangman. Press 1 to start.");

            if (Console.ReadLine() == "1")
            {
                Random randNum = new Random();
                int aRandomPos = randNum.Next(words.Count);

                string wordoriginal = words[aRandomPos];
                Console.WriteLine("Please only write in lower case letters.");
                int length = wordoriginal.Length;
                word = wordoriginal;

                Console.WriteLine("");
                while(length != 0)
                {
                    word2 += "_";
                    length -= 1;
                }
                string word3 = word2;
                Console.WriteLine(word2);
                Console.WriteLine("False guesses left:" + falseguesses);
                Console.WriteLine("False guessed letters:" + falseguessl);

                while(i == 1)
                {
                    string input = Console.ReadLine();
                    if(input == "q" || input == "w" || input == "e" || input == "r" || input == "t" || input == "z" || input == "u" || input == "i" || input == "o" || input == "p" || input == "a" || input == "s" || input == "d" || input == "f" || input == "g" || input == "h" || input == "j" || input == "k" || input == "l" || input == "y" || input == "x" || input == "c" || input == "v" || input == "b" || input == "n" || input == "m")
                    {                
                        if(word.Contains(input))
                        {
                            guesses += 1;
                            pos = 0;
                            while(pos != -1)
                            {
                                pos = word.IndexOf(input);

                                if(pos != -1)
                                {
                                    word = word.Remove(pos, 1);
                                    word = word.Insert(pos, "_");
                                    word2 = word2.Remove(pos, 1);
                                    word2 = word2.Insert(pos, input);                                
                                }
                            }

                            Console.WriteLine(word2);
                            Console.WriteLine("False guesses left:" + falseguesses);
                            Console.WriteLine("False guessed letter:" + falseguessl);
                        }
                        else if(word2.Contains(input) || falseguessl.Contains(input))
                        {
                            Console.WriteLine("You have already tried this letter.");
                        }
                        else
                        {
                            guesses += 1;
                            Console.WriteLine("Wrong!");
                            falseguesses -= 1;
                            falseguessl += input;
                            falseguessl += ", ";
                            Console.WriteLine(word2);
                            Console.WriteLine("False guesses left:" + falseguesses);
                            Console.WriteLine("False guessed letter:" + falseguessl);
                            if(falseguesses == 0)
                            {
                                i = 0;
                            }
                        }
                    }

                    else if(input == wordoriginal)
                    {
                        guesses += 1;
                        Console.WriteLine("You Won!");
                        Console.WriteLine("You needed " + guesses + " guesses.");
                        Environment.Exit(0);
                    }

                    else
                    {
                        Console.WriteLine("Please don't type upper case letters, symbols or numbers. Choose again.");
                    }

                    if(word2.IndexOf("_") == -1)
                    {
                        Console.WriteLine("You Won!");
                        Console.WriteLine("You needed " + guesses + " guesses.");
                        Environment.Exit(0);
                    }
                }

            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
