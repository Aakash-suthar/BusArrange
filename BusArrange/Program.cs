using System;
using System.Text;

namespace BusArrange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Seat[,] s = new Seat[10, 4];
            for (int p = 0; p < 10; p++)
                for (int k = 0; k < 4; k++)
                    s[p, k] = new Seat();
            int noofseats;
            int i = 0, j=0;
            char c='y';
            int seatscount = 40;
            StringBuilder ids = new StringBuilder();
            do{
                Console.WriteLine("Seats Available :  " + seatscount);
               
                for (int p = 0; p < 10; p++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (s[p, k].occupy)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(p+""+k +"  ");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(p + "" + k + "  ");
                        }
                        
                    }
                    Console.WriteLine();
                }
  
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter Number of seats to booked : Enter number 1 to " + seatscount + " : ");
                
                try
                {
                    noofseats = int.Parse(Console.ReadLine());
                    if (noofseats > 40)
                    {
                        Console.WriteLine("Cannot be more than 40");
                       
                    }
                    else if (noofseats > seatscount)
                    {
                        Console.WriteLine("Seats limit exceeds");

                    }
                    else if (noofseats < 0)
                    {
                        Console.WriteLine("Cannot be less than 0");
                    }
                    else 
                    {
                        Console.WriteLine("Enter Seat number : ");
                        try
                        {
                            int seatnumbner = int.Parse(Console.ReadLine());

                            j = seatnumbner % 10;
                            seatnumbner = seatnumbner / 10;
                            i = seatnumbner % 10;

                        }
                        catch{
                            Console.WriteLine("Incorrect seat number");
                            goto again;
                        }

                        for (; i < 10; i++)
                        {
                            for (j=0; j < 4; j++)
                            {
                                if (s[i, j].occupy != true)
                                {
                                    s[i, j].occupy = true;
                                    ids.Append(" ID:" + i + j + " ");
                                    noofseats--;
                                    seatscount--;
                                    
                                    if (noofseats == 0) { goto done; }
                                    if (i == 9 && j == 3 && noofseats != 0) { i = 0; j = 0; }
                                }
                            }
                            
                        }
                   
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Incorrect number entered or seat limit exceeds" + e.Message);
                }
                
                done:
                { Console.WriteLine("Seats booked" +ids); ids.Clear(); }
                again:
                Console.WriteLine("Booked More : y/n");
                try { c = Convert.ToChar(Console.ReadLine().ToLower());
                    if (c != 'y' && c != 'n') throw new Exception();
                }
                catch { Console.WriteLine("Wrong option try again"); goto again; }
                j = 0;i = 0;
            }
            while (c == 'y') ;
            
        }
    }

    public class Seat {
        public bool occupy = false;
    }
}
