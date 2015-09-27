using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0;
            int number2 = 0;
            int number3 = 0;
            int number4 = 0;
            int number5 = 0;
            int number6 = 0;
            int number7 = 0;
            int number8 = 0;
            int number9 = 0;
            Random random = new Random();
            int target;

            //string w = "";
            //string a = "";
            //string s = "", d = "";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\chaos\Documents\Visual Studio 2013\Projects\2048 Projesi\dp.wav");
            player.Play();

            int decideNumber = random.Next(2, 3);

            int locationStart = random.Next(1, 10);
            if (locationStart == 1)
                number1 = decideNumber;
            else if (locationStart == 2)
                number2 = decideNumber;
            else if (locationStart == 3)
                number3 = decideNumber;
            else if (locationStart == 4)
                number4 = decideNumber;
            else if (locationStart == 5)
                number5 = decideNumber;
            else if (locationStart == 6)
                number6 = decideNumber;
            else if (locationStart == 7)
                number7 = decideNumber;
            else if (locationStart == 8)
                number8 = decideNumber;
            else if (locationStart == 9)
                number9 = decideNumber;







            string move;




            Console.WriteLine("Target number can be 16,32,64,128 or 256");
            Console.Write("Enter the target: ");
            target = Convert.ToInt32(Console.ReadLine());
            int turn = 0;
            bool winnerCase = true;
            while (winnerCase)
            {
                turn++;

                Console.SetCursorPosition(0, 2);

                Console.WriteLine(" ");
                Console.WriteLine("--- Round: " + turn);
                Console.WriteLine(" ");
                Console.WriteLine("   1   2   3  ");
                Console.WriteLine(" +--- --- ---+");
                Console.WriteLine("1|           |");
                Console.WriteLine("2|           |");
                Console.WriteLine("3|           |");
                Console.WriteLine(" +--- --- ---+");

                Console.SetCursorPosition(3, 7);
                Console.Write(number1);
                Console.SetCursorPosition(7, 7);
                Console.Write(number2);
                Console.SetCursorPosition(11, 7);
                Console.Write(number3);
                Console.SetCursorPosition(3, 8);
                Console.Write(number4);
                Console.SetCursorPosition(7, 8);
                Console.Write(number5);
                Console.SetCursorPosition(11, 8);
                Console.Write(number6);
                Console.SetCursorPosition(3, 9);
                Console.Write(number7);
                Console.SetCursorPosition(7, 9);
                Console.Write(number8);
                Console.SetCursorPosition(11, 9);
                Console.WriteLine(number9);
                Console.WriteLine();

                //---------------winning condition--------------
                if (number1 == target || number2 == target || number3 == target || number4 == target || number5 == target || number6 == target || number7 == target || number8 == target || number9 == target)
                {
                    Console.WriteLine("You Win!");
                    break;
                }
                else if ((number1 != 0 && number2 != 0 && number3 != 0 && number4 != 0 && number5 != 0 && number6 != 0 && number7 != 0 && number8 != 0 && number9 != 0) && (number1 != number2 && number2 != number3 && number4 != number5 && number5 != number6 && number7 != number8 && number8 != number9 && number1 != number4 && number4 != number7 && number2!= number5 && number5 != number8 && number3 != number6 && number6 != number9))
                {
                    Console.WriteLine("Game Over!");
                    break;
                }
                else
                {
                    winnerCase = true;
                }

                int decideNumberTurn = 1;

                bool isPlaced = false;
                do
                {
                    if (turn > 1)
                        decideNumberTurn = random.Next(1, 3);
                    else decideNumberTurn = 1;

                    int locationTurn = random.Next(1, 10);
                    
                    if (locationTurn == 1 && number1 == 0)
                    {
                        number1 = 2 * decideNumberTurn;
                        Console.SetCursorPosition(3, 7);
                        Console.Write(number1);
                        isPlaced = true;
                    }
                    else if (locationTurn == 2 && number2 == 0)
                    {
                        number2 = 2 * decideNumberTurn;
                        Console.SetCursorPosition(7, 7);
                        Console.Write(number2);
                        isPlaced = true;
                    }
                    else if (locationTurn == 3 && number3 == 0)
                    {
                        number3 = 2 * decideNumberTurn;
                        Console.SetCursorPosition(11, 7);
                        Console.Write(number3);
                        isPlaced = true;
                    }
                    else if (locationTurn == 4 && number4 == 0)
                    {
                        number4 = 2 * decideNumberTurn;
                        Console.SetCursorPosition(3, 8);
                        Console.Write(number4);
                        isPlaced = true;
                    }
                    else if (locationTurn == 5 && number5 == 0)
                    {
                        number5 = 2 * decideNumberTurn;
                        Console.SetCursorPosition(7, 8);
                        Console.Write(number5);
                        isPlaced = true;
                    }
                    else if (locationTurn == 6 && number6 == 0)
                    {
                        number6 = 2 * decideNumberTurn;
                        Console.SetCursorPosition(11, 8);
                        Console.Write(number6);
                        isPlaced = true;
                    }
                    else if (locationTurn == 7 && number7 == 0)
                    {
                        number7 = 2 * decideNumberTurn;
                        Console.SetCursorPosition(3, 9);
                        Console.Write(number7);
                        isPlaced = true;
                    }
                    else if (locationTurn == 8 && number8 == 0)
                    {
                        number8 = 2 * decideNumberTurn;
                        Console.SetCursorPosition(7, 9);
                        Console.Write(number8);
                        isPlaced = true;
                    }
                    else if (locationTurn == 9 && number9 == 0)
                    {
                        number9 = 2 * decideNumberTurn;
                        Console.SetCursorPosition(11, 9);
                        Console.WriteLine(number9);
                        isPlaced = true;
                    }
                }
                while (!isPlaced);




                

                int zeroRow1 = 0, zeroRow2 = 0, zeroRow3 = 0, zeroCol1 = 0, zeroCol2 = 0, zeroCol3 = 0;
                if (number1 == 0) { zeroCol1++; zeroRow1++; }
                if (number2 == 0) { zeroCol2++; zeroRow1++; }
                if (number3 == 0) { zeroCol3++; zeroRow1++; }
                if (number4 == 0) { zeroCol1++; zeroRow2++; }
                if (number5 == 0) { zeroCol2++; zeroRow2++; }
                if (number6 == 0) { zeroCol3++; zeroRow2++; }
                if (number7 == 0) { zeroCol1++; zeroRow3++; }
                if (number8 == 0) { zeroCol2++; zeroRow3++; }
                if (number9 == 0) { zeroCol3++; zeroRow3++; }

                Console.SetCursorPosition(0, 14);
                Console.Write("Your move (w,a,s,d) : ");
                move = Convert.ToString(Console.ReadLine());



                if (move == "w")
                {
                    //-----------first column of w-----------------
                    if (zeroCol1 == 3) // there are three 0 
                    {
                        number1 = 0;
                        number4 = 0;
                        number7 = 0;

                    }
                    else if (zeroCol1 == 2) //there are two 0 
                    {
                        if (number1 == 0 && number4 != 0 && number7 == 0)
                        {
                            number1 = number4;
                            number4 = 0;
                            number7 = 0;


                        }
                        else if (number1 == 0 && number4 == 0 && number7 != 0)
                        {
                            number1 = number7;
                            number4 = 0;
                            number7 = 0;
                        }
                        else if (number1 != 0 && number4 == 0 && number7 == 0)
                        {
                            number1 = number1;
                            number4 = 0;
                            number7 = 0;
                        }

                    }
                    else if (zeroCol1 == 1) // there is one 0 
                    {
                        if (number1 == 0 && number4 == number7)
                        {
                            number1 = number4 + number7;
                            number4 = 0;
                            number7 = 0;

                        }
                        else if (number1 == 0 && number4 != number7)
                        {
                            number1 = number4;
                            number4 = number7;
                            number7 = 0;


                        }
                        else if (number1 == number7 && number4 == 0)
                        {
                            number1 = number1 + number7;
                            number4 = 0;
                            number7 = 0;


                        }
                        else if (number1 != number7 && number4 == 0)
                        {
                            number1 = number1;
                            number4 = number7;
                            number7 = 0;

                        }
                        else if (number1 == number4 && number7 == 0)
                        {
                            number1 = number1 + number4;
                            number4 = 0;
                            number7 = 0;


                        }
                        else if (number1 != number4 && number7 == 0)
                        {
                            number1 = number1;
                            number4 = number4;
                            number7 = number7;

                        }

                    }
                    else if (zeroCol1 == 0)// there arent any 0
                    {
                        if (number1 != number4 && number4 != number7 && number1 != number7)
                        {
                            number1 = number1;
                            number4 = number4;
                            number7 = number7;
                        }
                        else if (number1 == number4 && number4 == number7)
                        {
                            number1 = number1;
                            number4 = number4 + number7;
                            number7 = 0;

                        }
                        else if (number1 != number4 && number4 == number7)
                        {
                            number1 = number1;
                            number4 = number4 + number7;
                            number7 = 0;
                        }
                        else if (number1 == number7 && number4 != number1)
                        {
                            number1 = number1;
                            number4 = number4;
                            number7 = number7;

                        }
                        else if (number1 == number4 && number4 != number7)
                        {
                            number1 = number1 + number4;
                            number4 = number7;
                            number7 = 0;

                        }
                    }
                    else
                    {
                        Console.Error.WriteLine("w1");
                    }


                    //------------ second column of w-----------
                    if (zeroCol2 == 3) //there are three 0
                    {
                        number2 = 0;
                        number5 = 0;
                        number8 = 0;

                    }
                    else if (zeroCol2 == 2) //there are two 0
                    {
                        if (number2 == 0 && number5 != 0 && number8 == 0)
                        {
                            number2 = number5;
                            number5 = 0;
                            number8 = 0;


                        }
                        else if (number2 == 0 && number5 == 0 && number8 != 0)
                        {
                            number2 = number8;
                            number5 = 0;
                            number8 = 0;
                        }
                        else if (number2 != 0 && number5 == 0 && number8 == 0)
                        {
                            number2 = number2;
                            number5 = 0;
                            number8 = 0;
                        }

                    }
                    else if (zeroCol2 == 1) // there is a 0
                    {
                        if (number2 == 0 && number5 == number8)
                        {
                            number2 = number5 + number8;
                            number5 = 0;
                            number8 = 0;

                        }
                        else if (number2 == 0 && number5 != number8)
                        {
                            number2 = number5;
                            number5 = number8;
                            number8 = 0;


                        }
                        else if (number2 == number8 && number5 == 0)
                        {
                            number2 = number2 + number8;
                            number5 = 0;
                            number8 = 0;


                        }
                        else if (number2 != number8 && number5 == 0)
                        {
                            number2 = number2;
                            number5 = number8;
                            number8 = 0;

                        }
                        else if (number2 == number5 && number8 == 0)
                        {
                            number2 = number2 + number5;
                            number5 = 0;
                            number8 = 0;


                        }
                        else if (number2 != number5 && number8 == 0)
                        {
                            number2 = number2;
                            number5 = number5;
                            number8 = number8;

                        }

                    }
                    else if (zeroCol2 == 0)//there arent any 0
                    {
                        if (number2 != number5 && number5 != number8 && number2 != number8)
                        {
                            number2 = number2;
                            number5 = number5;
                            number8 = number8;
                        }
                        else if (number2 == number5 && number5 == number8)
                        {
                            number2 = number2;
                            number5 = number5 + number8;
                            number8 = 0;

                        }
                        else if (number2 != number5 && number5 == number8)
                        {
                            number2 = number2;
                            number5 = number5 + number8;
                            number8 = 0;
                        }
                        else if (number2 == number8 && number5 != number2)
                        {
                            number2 = number2;
                            number5 = number5;
                            number8 = number8;

                        }
                        else if (number2 == number5 && number5 != number8)
                        {
                            number2 = number2 + number5;
                            number5 = number8;
                            number8 = 0;

                        }
                    }
                    else
                    {
                        Console.Error.WriteLine("w2");
                    }

                    //-----------third column of w--------------
                    if (zeroCol3 == 3) // there are three 0
                    {
                        number3 = 0;
                        number6 = 0;
                        number9 = 0;

                    }
                    else if (zeroCol3 == 2) //there are two 0
                    {
                        if (number3 == 0 && number6 != 0 && number9 == 0)
                        {
                            number3 = number6;
                            number6 = 0;
                            number9 = 0;


                        }
                        else if (number3 == 0 && number6 == 0 && number9 != 0)
                        {
                            number3 = number9;
                            number6 = 0;
                            number9 = 0;
                        }
                        else if (number3 != 0 && number6 == 0 && number9 == 0)
                        {
                            number3 = number3;
                            number6 = 0;
                            number9 = 0;
                        }

                    }
                    else if (zeroCol3 == 1) // there is a 0
                    {
                        if (number3 == 0 && number6 == number9)
                        {
                            number3 = number6 + number9;
                            number6 = 0;
                            number9 = 0;

                        }
                        else if (number3 == 0 && number6 != number9)
                        {
                            number3 = number6;
                            number6 = number9;
                            number9 = 0;


                        }
                        else if (number3 == number9 && number6 == 0)
                        {
                            number3 = number3 + number9;
                            number6 = 0;
                            number9 = 0;


                        }
                        else if (number3 != number9 && number6 == 0)
                        {
                            number3 = number3;
                            number6 = number9;
                            number9 = 0;

                        }
                        else if (number3 == number6 && number9 == 0)
                        {
                            number3 = number3 + number6;
                            number6 = 0;
                            number9 = 0;


                        }
                        else if (number3 != number6 && number9 == 0)
                        {
                            number3 = number3;
                            number6 = number6;
                            number9 = number9;

                        }

                    }
                    else if (zeroCol3 == 0)//there arant any 0
                    {
                        if (number3 != number6 && number6 != number9 && number3 != number9)
                        {
                            number3 = number3;
                            number6 = number6;
                            number9 = number9;
                        }
                        else if (number3 == number6 && number6 == number9)
                        {
                            number3 = number3;
                            number6 = number6 + number9;
                            number9 = 0;

                        }
                        else if (number3 != number6 && number6 == number9)
                        {
                            number3 = number3;
                            number6 = number6 + number9;
                            number9 = 0;
                        }
                        else if (number3 == number9 && number6 != number3)
                        {
                            number3 = number3;
                            number6 = number6;
                            number9 = number9;

                        }
                        else if (number3 == number6 && number6 != number9)
                        {
                            number3 = number3 + number6;
                            number6 = number9;
                            number9 = 0;

                        }
                    }
                    else
                    {
                        Console.Error.WriteLine("w3");
                    }

                }
                //--------------------------- W ------------------------------

                if (move == "s")
                {
                    // -----------first column of s-------

                    if (zeroCol1 == 3) //there ara three 0
                    {
                        number1 = 0;
                        number4 = 0;
                        number7 = 0;
                    }
                    else if (zeroCol1 == 2) // there ara two 0
                    {
                        if (number1 == 0 && number4 != 0 && number7 == 0)
                        {
                            number7 = number4;
                            number4 = 0;
                            number1 = 0;

                        }
                        else if (number7 != 0 && number1 == 0 && number4 == 0)
                        {
                            number1 = number1;
                            number4 = number4;
                            number7 = number7;


                        }
                        else if (number1 != 0 && number4 == 0 && number7 == 0)
                        {
                            number7 = number1;
                            number4 = 0;
                            number1 = 0;


                        }

                    }
                    else if (zeroCol1 == 1) // there is a 0
                    {
                        if (number1 == 0 && number4 == number7)
                        {
                            number1 = 0;
                            number7 = number7 + number4;
                            number4 = 0;


                        }
                        else if (number1 == 0 && number4 != number7)
                        {
                            number7 = number7;
                            number4 = number4;
                            number1 = 0;

                        }
                        else if (number4 == 0 && number1 == number7)
                        {
                            number7 = number7 + number1;
                            number1 = 0;
                            number4 = 0;


                        }
                        else if (number1 != number7 && number4 == 0)
                        {
                            number7 = number7;
                            number4 = number1;
                            number1 = 0;



                        }


                        else if (number1 == number4 && number7 == 0)
                        {
                            number7 = number1 + number4;
                            number4 = 0;
                            number1 = 0;

                        }

                        else if (number1 != number4 && number7 == 0)
                        {
                            number7 = number4;
                            number4 = number1;
                            number1 = 0;


                        }

                    }
                    else if (zeroCol1 == 0)//there arent any 0
                    {
                        if (number1 != number4 && number4 != number7)
                        {
                            number1 = number1;
                            number4 = number4;
                            number7 = number7;
                        }
                        else if (number1 == number4 && number7 == number4)
                        {
                            number7 = number7;
                            number4 = number4 + number1;
                            number1 = 0;


                        }
                        else if (number4 == number7 && number4 != number1)
                        {
                            number7 = number7 + number4;
                            number4 = number1;
                            number1 = 0;
                        }
                        else if (number1 == number7 && number1 != number4)
                        {
                            number7 = number7;
                            number4 = number4;
                            number1 = number1;

                        }
                        else if (number1 == number4 && number7 != number1)
                        {
                            number7 = number7;
                            number4 = number4 + number1;
                            number1 = 0;

                        }


                    }


                    else
                    {
                        Console.Error.WriteLine("s1");
                    }
                    //----------second column of s---------------

                    if (zeroCol2 == 3) //there are three 0
                    {
                        number2 = 0;
                        number5 = 0;
                        number8 = 0;
                    }
                    else if (zeroCol2 == 2) // there are two 0
                    {
                        if (number2 == 0 && number5 != 0 && number8 == 0)
                        {
                            number8 = number5;
                            number5 = 0;
                            number2 = 0;

                        }
                        else if (number8 != 0 && number2 == 0 && number5 == 0)
                        {
                            number2 = number2;
                            number5 = number5;
                            number8 = number8;


                        }
                        else if (number2 != 0 && number5 == 0 && number8 == 0)
                        {
                            number8 = number2;
                            number5 = 0;
                            number2 = 0;


                        }

                    }
                    else if (zeroCol2 == 1) // there is a 0
                    {
                        if (number2 == 0 && number5 == number8)
                        {
                            number2 = 0;
                            number8 = number8 + number5;
                            number5 = 0;


                        }
                        else if (number2 == 0 && number5 != number8)
                        {
                            number8 = number8;
                            number5 = number5;
                            number2 = 0;

                        }
                        else if (number5 == 0 && number2 == number8)
                        {
                            number8 = number8 + number2;
                            number2 = 0;
                            number5 = 0;


                        }
                        else if (number2 != number8 && number5 == 0)
                        {
                            number8 = number8;
                            number5 = number2;
                            number2 = 0;



                        }


                        else if (number2 == number5 && number8 == 0)
                        {
                            number8 = number2 + number5;
                            number5 = 0;
                            number2 = 0;

                        }

                        else if (number2 != number5 && number8 == 0)
                        {
                            number8 = number5;
                            number5 = number2;
                            number2 = 0;


                        }

                    }
                    else if (zeroCol2 == 0)//there arent any 0
                    {
                        if (number2 != number5 && number5 != number8)
                        {
                            number2 = number2;
                            number5 = number5;
                            number8 = number8;
                        }
                        else if (number2 == number5 && number8 == number5)
                        {
                            number8 = number8;
                            number5 = number5 + number2;
                            number2 = 0;


                        }
                        else if (number5 == number8 && number5 != number2)
                        {
                            number8 = number8 + number5;
                            number5 = number2;
                            number2 = 0;
                        }
                        else if (number2 == number8 && number2 != number5)
                        {
                            number8 = number8;
                            number5 = number5;
                            number2 = number2;

                        }
                        else if (number2 == number5 && number8 != number2)
                        {
                            number8 = number8;
                            number5 = number5 + number2;
                            number2 = 0;

                        }


                    }


                    else
                    {
                        Console.Error.WriteLine("s2");
                    }
                    //-------------third column of s---------------

                    if (zeroCol3 == 3) //there are three 0 
                    {
                        number3 = 0;
                        number6 = 0;
                        number9 = 0;
                    }

                    else if (zeroCol3 == 2) // there ara two 0
                    {
                        if (number3 == 0 && number6 != 0 && number9 == 0)
                        {
                            number9 = number6;
                            number6 = 0;
                            number3 = 0;

                        }
                        else if (number9 != 0 && number3 == 0 && number6 == 0)
                        {
                            number3 = number3;
                            number6 = number6;
                            number9 = number9;


                        }
                        else if (number3 != 0 && number6 == 0 && number9 == 0)
                        {
                            number9 = number3;
                            number6 = 0;
                            number3 = 0;


                        }

                    }

                    else if (zeroCol3 == 1) // there is a 0
                    {
                        if (number3 == 0 && number6 == number9)
                        {
                            number3 = 0;
                            number9 = number9 + number6;
                            number6 = 0;


                        }
                        else if (number3 == 0 && number6 != number9)
                        {
                            number9 = number9;
                            number6 = number6;
                            number3 = 0;

                        }
                        else if (number6 == 0 && number3 == number9)
                        {
                            number9 = number9 + number3;
                            number3 = 0;
                            number6 = 0;


                        }
                        else if (number3 != number9 && number6 == 0)
                        {
                            number9 = number9;
                            number6 = number3;
                            number3 = 0;



                        }


                        else if (number3 == number6 && number9 == 0)
                        {
                            number9 = number3 + number6;
                            number6 = 0;
                            number3 = 0;

                        }

                        else if (number3 != number6 && number9 == 0)
                        {
                            number9 = number6;
                            number6 = number3;
                            number3 = 0;


                        }

                    }

                    else if (zeroCol3 == 0)//there arent any 0
                    {
                        if (number3 != number6 && number6 != number9)
                        {
                            number3 = number3;
                            number6 = number6;
                            number9 = number9;
                        }
                        else if (number3 == number6 && number9 == number6)
                        {
                            number8 = number8;
                            number6 = number6 + number3;
                            number3 = 0;


                        }
                        else if (number6 == number9 && number6 != number3)
                        {
                            number9 = number9 + number6;
                            number6 = number3;
                            number3 = 0;
                        }
                        else if (number3 == number9 && number3 != number6)
                        {
                            number9 = number9;
                            number6 = number6;
                            number3 = number3;

                        }
                        else if (number3 == number6 && number9 != number3)
                        {
                            number9 = number9;
                            number6 = number6 + number3;
                            number3 = 0;

                        }


                    }
                    else
                    {
                        Console.Error.WriteLine("s3");
                    }

                }
                //------------------------------------------s----------------------------------------------

                if (move == "d")
                {
                    // ---------------------first row of d----------------

                    if (zeroRow1 == 3) // there are three 0
                    {
                        if (number1 == 0 && number2 == 0 && number3 == 0)
                            number1 = 0;
                        number2 = 0;
                        number3 = 0;
                    }
                    else if (zeroRow1 == 2) // there are two 0
                    {
                        if (number1 == 0 && number3 == 0)
                        {
                            number3 = number2;
                            number1 = 0;
                            number2 = 0;
                        }
                        else if (number1 == 0 && number2 == 0 && number3 != 0)
                        {
                            number3 = number3;
                            number1 = 0;
                            number2 = 0;
                        }
                        else if (number1 != 0 && number2 == 0 && number3 == 0)
                        {
                            number3 = number1;
                            number1 = 0;
                            number2 = 0;
                        }

                    }
                    else if (zeroRow1 == 1) // there is a 0
                    {
                        if (number1 == 0 && number2 == number3)
                        {
                            number3 = number3 + number2;
                            number2 = 0;
                            number1 = 0;
                        }
                        else if (number1 == 0 && number2 != number3)
                        {
                            number3 = number3;
                            number2 = number2;
                            number1 = 0;
                        }
                        else if (number1 == number3 && number2 == 0)
                        {
                            number3 = number3 + number1;
                            number2 = 0;
                            number1 = 0;

                        }
                        else if (number1 != number3 && number2 == 0)
                        {
                            number2 = number1;
                            number3 = number3;
                            number1 = 0;
                        }
                        else if (number1 == number2 && number3 == 0)
                        {
                            number3 = number1 + number2;
                            number1 = 0;
                            number2 = 0;
                        }
                        else if (number1 != number2 && number3 == 0)
                        {
                            number3 = number2;
                            number2 = number1;
                            number1 = 0;

                        }

                    }

                    else if (zeroRow1 == 0)//there arent any 0
                    {
                        if (number1 != number2 && number1 != number3 && number2 != number3)
                        {
                            number3 = number3;
                            number2 = number2;
                            number1 = number1;
                        }
                        else if (number1 == number2 && number2 == number3)
                        {
                            number3 = number3;
                            number2 = number2 + number1;
                            number1 = 0;
                        }
                        else if (number1 != number2 && number2 == number3)
                        {
                            number3 = number3 + number2;
                            number2 = number1;
                            number1 = 0;
                        }
                        else if (number1 == number3 && number2 != number3)
                        {
                            number1 = number1;
                            number2 = number2;
                            number3 = number3;

                        }
                        else if (number1 == number2 && number2 != number3)
                        {
                            number3 = number3;
                            number2 = number2 + number1;
                            number1 = 0;
                        }
                    }
                    else
                    {
                        Console.Error.WriteLine("d1");
                    }
                    //-----------second row of d-----------

                    if (zeroRow2 == 3) // there are three 0
                    {
                        if (number4 == 0 && number5 == 0 && number6 == 0)
                            number4 = 0;
                        number5 = 0;
                        number6 = 0;
                    }
                    else if (zeroRow2 == 2) // there ara two 0
                    {
                        if (number4 == 0 && number6 == 0)
                        {
                            number6 = number5;
                            number4 = 0;
                            number5 = 0;
                        }
                        else if (number4 == 0 && number5 == 0 && number6 != 0)
                        {
                            number6 = number6;
                            number4 = 0;
                            number5 = 0;
                        }
                        else if (number4 != 0 && number5 == 0 && number6 == 0)
                        {
                            number6 = number4;
                            number4 = 0;
                            number5 = 0;
                        }

                    }
                    else if (zeroRow2 == 1) // there is a 0
                    {
                        if (number4 == 0 && number5 == number6)
                        {
                            number6 = number6 + number5;
                            number5 = 0;
                            number4 = 0;
                        }
                        else if (number4 == 0 && number5 != number6)
                        {
                            number6 = number6;
                            number5 = number5;
                            number4 = 0;
                        }
                        else if (number4 == number6 && number5 == 0)
                        {
                            number6 = number6 + number4;
                            number5 = 0;
                            number4 = 0;

                        }
                        else if (number4 != number6 && number5 == 0)
                        {
                            number5 = number4;
                            number6 = number6;
                            number4 = 0;
                        }
                        else if (number4 == number5 && number6 == 0)
                        {
                            number6 = number4 + number5;
                            number4 = 0;
                            number5 = 0;
                        }
                        else if (number4 != number5 && number6 == 0)
                        {
                            number6 = number5;
                            number5 = number4;
                            number4 = 0;

                        }

                    }

                    else if (zeroRow2 == 0)//there arent any 0
                    {
                        if (number4 != number5 && number4 != number6 && number5 != number6)
                        {
                            number6 = number6;
                            number5 = number5;
                            number4 = number4;
                        }
                        else if (number4 == number5 && number5 == number6)
                        {
                            number6 = number6;
                            number5 = number5 + number4;
                            number4 = 0;
                        }
                        else if (number4 != number5 && number5 == number6)
                        {
                            number4 = number6 + number5;
                            number5 = number4;
                            number4 = 0;
                        }
                        else if (number4 == number6 && number5 != number6)
                        {
                            number4 = number4;
                            number5 = number5;
                            number6 = number6;

                        }
                        else if (number4 == number5 && number5 != number6)
                        {
                            number6 = number6;
                            number5 = number5 + number4;
                            number4 = 0;
                        }
                    }
                    else
                    {
                        Console.Error.WriteLine("d2");
                    }
                    //-------------third row of d--------

                    if (zeroRow3 == 3) // there are three 0
                    {
                        if (number7 == 0 && number8 == 0 && number9 == 0)
                            number7 = 0;
                        number8 = 0;
                        number9 = 0;
                    }
                    else if (zeroRow3 == 2) //there are two 0
                    {
                        if (number7 == 0 && number9 == 0)
                        {
                            number9 = number8;
                            number7 = 0;
                            number8 = 0;
                        }
                        else if (number7 == 0 && number8 == 0 && number9 != 0)
                        {
                            number9 = number9;
                            number7 = 0;
                            number8 = 0;
                        }
                        else if (number7 != 0 && number8 == 0 && number9 == 0)
                        {
                            number9 = number7;
                            number7 = 0;
                            number8 = 0;
                        }

                    }
                    else if (zeroRow3 == 1) // there is a 0
                    {
                        if (number7 == 0 && number8 == number9)
                        {
                            number9 = number9 + number8;
                            number8 = 0;
                            number7 = 0;
                        }
                        else if (number7 == 0 && number8 != number9)
                        {
                            number9 = number9;
                            number8 = number8;
                            number7 = 0;
                        }
                        else if (number7 == number9 && number8 == 0)
                        {
                            number9 = number9 + number7;
                            number8 = 0;
                            number7 = 0;

                        }
                        else if (number7 != number9 && number8 == 0)
                        {
                            number8 = number7;
                            number9 = number9;
                            number7 = 0;
                        }
                        else if (number7 == number8 && number9 == 0)
                        {
                            number9 = number7 + number8;
                            number7 = 0;
                            number8 = 0;
                        }
                        else if (number7 != number8 && number9 == 0)
                        {
                            number9 = number8;
                            number8 = number7;
                            number7 = 0;

                        }

                    }

                    else if (zeroRow3 == 0)//there arent any 0
                    {
                        if (number7 != number8 && number7 != number9 && number8 != number9)
                        {
                            number9 = number9;
                            number8 = number8;
                            number7 = number7;
                        }
                        else if (number7 == number8 && number8 == number9)
                        {
                            number9 = number9;
                            number8 = number8 + number7;
                            number7 = 0;
                        }
                        else if (number7 != number8 && number8 == number9)
                        {
                            number9 = number9 + number8;
                            number8 = number7;
                            number7 = 0;
                        }
                        else if (number7 == number9 && number8 != number9)
                        {
                            number7 = number7;
                            number8 = number8;
                            number9 = number9;

                        }
                        else if (number7 == number8 && number8 != number9)
                        {
                            number9 = number9;
                            number8 = number8 + number7;
                            number7 = 0;
                        }
                    }
                    else
                    {
                        Console.Error.WriteLine("d3");
                    }
                }



                //-------------------------D---------------------



                if (move == "a")
                {
                    // ---------first row of a------------

                    if (zeroRow1 == 3) // there are three 0
                    {
                        if (number1 == 0 && number2 == 0 && number3 == 0)
                        {
                            number1 = 0;
                            number2 = 0;
                            number3 = 0;
                        }
                    }
                    else if (zeroRow1 == 2) // there are two 0
                    {
                        if (number1 == 0 && number2 != 0 && number3 == 0)
                        {
                            number1 = number2;
                            number2 = 0;
                            number3 = 0;
                        }
                        else if (number1 == 0 && number2 == 0 && number3 != 0)
                        {
                            number1 = number3;
                            number2 = 0;
                            number3 = 0;
                        }
                        else if (number1 != 0 && number2 == 0 && number3 == 0)
                        {
                            number1 = number1;
                            number2 = 0;
                            number3 = 0;
                        }

                    }

                    else if (zeroRow1 == 1) // there is a 0
                    {
                        if (number1 == 0 && number2 == number3)
                        {
                            number1 = number2 + number3;
                            number2 = 0;
                            number3 = 0;
                        }
                        else if (number1 == 0 && number2 != number3)
                        {
                            number1 = number2;
                            number2 = number3;
                            number3 = 0;
                        }
                        else if (number1 == number3 && number2 == 0)
                        {
                            number1 = number1 + number3;
                            number2 = 0;
                            number3 = 0;
                        }
                        else if (number1 != number3 && number2 == 0)
                        {
                            number1 = number1;
                            number2 = number3;
                            number3 = 0;
                        }
                        else if (number1 == number2 && number3 == 0)
                        {
                            number1 = number1 + number2;
                            number2 = 0;
                            number3 = 0;
                        }
                        else if (number1 != number2 && number3 == 0)
                        {
                            number1 = number1;
                            number2 = number2;
                            number3 = 0;
                        }
                    }
                    else if (zeroRow1 == 0)//there arent any 0
                    {
                        if (number1 != number2 && number2 != number3 && number3 != number1)
                        {
                            number1 = number1;
                            number2 = number2;
                            number3 = number3;
                        }
                        else if (number1 == number2 && number2 == number3)
                        {
                            number1 = number1;
                            number2 = number2 + number3;
                            number3 = 0;
                        }
                        else if (number1 != number2 && number2 == number3)
                        {
                            number1 = number1;
                            number2 = number2 + number3;
                            number3 = 0;
                        }
                        else if (number1 == number3 && number1 != number2)
                        {
                            number1 = number1;
                            number2 = number2;
                            number3 = number3;


                        }
                        else if (number1 == number2 && number2 != number3)
                        {
                            number1 = number1 + number2;
                            number2 = number3;
                            number3 = 0;
                        }
                    }
                    else
                    {
                        Console.Error.WriteLine("a1");
                    }
                    //-----------second row of a-----------

                    if (zeroRow2 == 3) //there ara three 0 
                    {
                        if (number4 == 0 && number5 == 0 && number6 == 0)
                        {
                            number4 = 0;
                            number5 = 0;
                            number6 = 0;
                        }
                    }
                    else if (zeroRow2 == 2) // there are two 0
                    {
                        if (number4 == 0 && number5 != 0 && number6 == 0)
                        {
                            number4 = number5;
                            number5 = 0;
                            number6 = 0;
                        }
                        else if (number4 == 0 && number5 == 0 && number6 != 0)
                        {
                            number4 = number6;
                            number5 = 0;
                            number6 = 0;
                        }
                        else if (number4 != 0 && number5 == 0 && number6 == 0)
                        {
                            number4 = number4;
                            number5 = 0;
                            number6 = 0;
                        }

                    }

                    else if (zeroRow2 == 1) // there is a 0
                    {
                        if (number4 == 0 && number5 == number6)
                        {
                            number4 = number5 + number6;
                            number5 = 0;
                            number6 = 0;
                        }
                        else if (number4 == 0 && number5 != number6)
                        {
                            number4 = number5;
                            number5 = number6;
                            number6 = 0;
                        }
                        else if (number4 == number6 && number5 == 0)
                        {
                            number4 = number4 + number6;
                            number5 = 0;
                            number6 = 0;
                        }
                        else if (number4 != number6 && number5 == 0)
                        {
                            number4 = number4;
                            number5 = number5;
                            number6 = 0;
                        }
                        else if (number4 == number5 && number6 == 0)
                        {
                            number4 = number4 + number5;
                            number5 = 0;
                            number6 = 0;
                        }
                        else if (number4 != number5 && number6 == 0)
                        {
                            number4 = number4;
                            number5 = number5;
                            number6 = 0;
                        }
                    }
                    else if (zeroRow2 == 0)//there arent any 0
                    {
                        if (number4 != number5 && number5 != number6 && number6 != number4)
                        {
                            number4 = number4;
                            number5 = number5;
                            number6 = number6;
                        }
                        else if (number4 == number5 && number5 == number6)
                        {
                            number4 = number4;
                            number5 = number5 + number6;
                            number6 = 0;
                        }
                        else if (number4 != number5 && number5 == number6)
                        {
                            number4 = number4;
                            number5 = number5 + number6;
                            number6 = 0;
                        }
                        else if (number4 == number6 && number4 != number5)
                        {
                            number4 = number4;
                            number5 = number5;
                            number6 = number6;


                        }
                        else if (number4 == number5 && number5 != number6)
                        {
                            number4 = number4 + number5;
                            number5 = number6;
                            number6 = 0;
                        }
                    }
                    else
                    {
                        Console.Error.WriteLine("a2");
                    }
                    //--------third row of a-------------

                    if (zeroRow3 == 3) // there are three 0
                    {
                        if (number7 == 0 && number8 == 0 && number9 == 0)
                        {
                            number7 = 0;
                            number8 = 0;
                            number9 = 0;
                        }
                    }
                    else if (zeroRow3 == 2) // there are two 0
                    {
                        if (number7 == 0 && number8 != 0 && number9 == 0)
                        {
                            number7 = number8;
                            number8 = 0;
                            number9 = 0;
                        }
                        else if (number7 == 0 && number8 == 0 && number9 != 0)
                        {
                            number7 = number9;
                            number8 = 0;
                            number9 = 0;
                        }
                        else if (number7 != 0 && number8 == 0 && number9 == 0)
                        {
                            number7 = number7;
                            number8 = 0;
                            number9 = 0;
                        }

                    }

                    else if (zeroRow3 == 1) // there is a 0
                    {
                        if (number7 == 0 && number8 == number9)
                        {
                            number7 = number8 + number9;
                            number8 = 0;
                            number9 = 0;
                        }
                        else if (number7 == 0 && number8 != number9)
                        {
                            number7 = number8;
                            number8 = number9;
                            number9 = 0;
                        }
                        else if (number7 == number9 && number8 == 0)
                        {
                            number7 = number7 + number9;
                            number8 = 0;
                            number9 = 0;
                        }
                        else if (number7 != number9 && number8 == 0)
                        {
                            number7 = number7;
                            number8 = number9;
                            number9 = 0;
                        }
                        else if (number7 == number8 && number9 == 0)
                        {
                            number7 = number7 + number8;
                            number8 = 0;
                            number9 = 0;
                        }
                        else if (number7 != number8 && number9 == 0)
                        {
                            number7 = number7;
                            number8 = number8;
                            number9 = 0;
                        }
                    }

                    else if (zeroRow3 == 0)//there arent any 0
                    {
                        if (number7 != number8 && number8 != number9 && number9 != number7)
                        {
                            number7 = number7;
                            number8 = number8;
                            number9 = number9;
                        }
                        else if (number7 == number8 && number8 == number9)
                        {
                            number7 = number7;
                            number8 = number8 + number9;
                            number9 = 0;
                        }
                        else if (number7 != number8 && number8 == number9)
                        {
                            number7 = number7;
                            number8 = number8 + number9;
                            number9 = 0;
                        }
                        else if (number7 == number9 && number7 != number8)
                        {
                            number7 = number7;
                            number8 = number8;
                            number9 = number9;


                        }
                        else if (number7 == number8 && number8 != number9)
                        {
                            number7 = number7 + number8;
                            number8 = number9;
                            number9 = 0;
                        }
                    }
                    else
                    {
                        Console.Error.WriteLine("a3");
                    }
                }








            }

















            //replace writing





            Console.ReadLine();

        }
    }
}
