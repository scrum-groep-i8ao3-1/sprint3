using System;
using System.Threading.Tasks;
using System.Reflection.Emit;
using System.Timers;
//gemaakt door danny lanssink
//nagekeken en werkt xx-jairo

public class Example
{
    private static System.Timers.Timer aTimer;
    public static void display(int x, int y, string s)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(s);
        return;
    }
    public static void Main()
    {
        SetTimer();
        Console.WriteLine("druk op enter om de aplicatie stop te zetten.");
        Console.Read();
        aTimer.Stop();
        aTimer.Dispose();

        Console.WriteLine("de aplicatie stop zetten");
    }

    private static void SetTimer()
    {
        // Create a timer with a two second interval.
        aTimer = new System.Timers.Timer(1);
        // Hook up the Elapsed event for the timer. 
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        Console.Clear();
        int[] output = gettime(); // 0 = uren 1 = minuten 2 = seconden
        string uur = Convert.ToString(output[0]);
        string min = Convert.ToString(output[1]);
        string sec = Convert.ToString(output[2]);
        if (sec == "40" && min == "59")
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("E:\\scrum\\sprint3\\sprint 3 tests\\sprint3\\s1-be-m06-functies\\6.9\\geluiden\\koek.wav");
            player.Play();
        }
        if (Convert.ToInt32(uur) <= 9)
        {
            uur = uur.Insert(0, "0");
        }
        int uur1 = int.Parse(uur[0].ToString());
        int uur2 = int.Parse(uur[1].ToString());
        if (Convert.ToInt32(min) <= 9)
        {
            min = min.Insert(0, "0");
        }
        int min1 = int.Parse(min[0].ToString());
        int min2 = int.Parse(min[1].ToString());
        if (Convert.ToInt32(sec) <= 9)
        {
            sec = sec.Insert(0, "0");
        }
        int sec1 = int.Parse(sec[0].ToString());
        int sec2 = int.Parse(sec[1].ToString());
        //Console.WriteLine(Convert.ToString(min));
        //Console.WriteLine(Convert.ToString(min1));
        //Console.WriteLine(Convert.ToString(min2));
        create(uur1, uur2, min1, min2, sec1, sec2);
        //12-30-12
    }
    public static int[] gettime()
    {
        //vraagt de tijd op.
        DateTime nu = DateTime.Now;
        int minuten = nu.Minute; //tijd in munten
        int seconden = nu.Second; //tijd in seconden
        int uren = nu.Hour; //tijd in uren
        int[] output = new int[3] { uren, minuten, seconden };
        return output;
    }
    public static void create(int uur1, int uur2, int min1, int min2, int sec1, int sec2)
    {
        Console.SetWindowSize(213, 50);
        //laatzien(hoogte,lengthe, icoontje);
        display(127, 25, "|");
        display(127, 26, "|");
        display(127, 27, "|");
        display(127, 28, "|");
        display(127, 29, "|");
        display(100, 25, "|");
        display(100, 26, "|");
        display(100, 27, "|");
        display(100, 28, "|");
        display(100, 29, "|");
        //65,51|39,24|12,0
        maakcijfers(uur1, 65);
        maakcijfers(uur2, 52);
        maakcijfers(min1, 39);
        maakcijfers(min2, 24);
        maakcijfers(sec1, 12);
        maakcijfers(sec2, 0);
        Console.Read();
    }
    public static void maakcijfers(int cijfer, int locatie)
    {
        //deze dingen laaten de cijfers zien - de locatie die ik eerder onderzocht heb
        if (cijfer == 0)
        {
            display(150 - locatie, 25, "*");
            display(150 - locatie, 26, "*");
            display(150 - locatie, 27, "*");
            display(150 - locatie, 28, "*");
            display(150 - locatie, 29, "*");
            display(145 - locatie, 25, "*");
            display(145 - locatie, 26, "*");
            display(145 - locatie, 27, "*");
            display(145 - locatie, 28, "*");
            display(145 - locatie, 29, "*");
            for (int i = 0; i < 5; i++)
            {
                display(149 - i - locatie, 25, "*");
                display(145 + i - locatie, 29, "*");
            }
        }
        if (cijfer == 1)
        {
            display(146 - locatie, 25, "*");
            display(146 - locatie, 26, "*");
            display(146 - locatie, 27, "*");
            display(146 - locatie, 28, "*");
            display(146 - locatie, 29, "*");
        }
        if (cijfer == 2)
        {
            for (int i = 0; i < 5; i++)
            {
                display(146 - locatie - i, 25, "*");
            }
            for (int i = 0; i < 5; i++)
            {
                display(146 - locatie - i, 29, "*");
            }
            display(144 - locatie, 28, "*");
            display(145 - locatie, 27, "*");
            display(146 - locatie, 26, "*");

        }
        if (cijfer == 3)
        {
            for (int i = 0; i < 6; i++)
            {
                display(150 - locatie, 25 + i, "*");
            }
            display(150 - locatie - 1, 25, "*");
            display(150 - locatie - 2, 25, "*");
            display(150 - locatie - 1, 27, "*");
            display(150 - locatie - 2, 27, "*");
            display(150 - locatie - 1, 29, "*");
            display(150 - locatie - 2, 29, "*");

        }
        if (cijfer == 4)
        {
            for (int i = 0; i < 4; i++)
            {
                display(150 - locatie, 29 - i, "*");
            }
            for (int i = 0; i < 4; i++)
            {
                display(150 - locatie - i, 28, "*");
            }
            display(148 - locatie, 27, "*");
        }
        if (cijfer == 5)
        {
            for (int i = 0; i < 4; i++)
            {
                display(150 - locatie - i, 29, "*");
                display(150 - locatie - i, 25, "*");
                display(150 - locatie - i, 27, "*");
            }
            display(150 - locatie, 28, "*");
            display(147 - locatie, 26, "*");
        }
        if (cijfer == 6)
        {
            for (int i = 0; i < 4; i++)
            {
                display(150 - locatie - i, 29, "*");
                display(150 - locatie - i, 25, "*");
                display(150 - locatie - i, 27, "*");
            }
            display(150 - locatie, 28, "*");
            display(147 - locatie, 26, "*");
            display(147 - locatie, 28, "*");
        }
        if (cijfer == 7)
        {
            for (int i = 0; i < 4; i++)
            {
                display(150 - locatie - i, 25, "*");
            }
            display(150 - locatie, 28, "*");
            display(150 - locatie, 26, "*");
            display(150 - locatie, 27, "*");
        }
        if (cijfer == 8)
        {
            for (int i = 0; i < 4; i++)
            {
                display(150 - locatie - i, 29, "*");
                display(150 - locatie - i, 25, "*");
                display(150 - locatie - i, 27, "*");
            }
            display(150 - locatie, 28, "*");
            display(147 - locatie, 26, "*");
            display(147 - locatie, 28, "*");
            display(150 - locatie, 26, "*");
        }
        if (cijfer == 9)
        {
            for (int i = 0; i < 4; i++)
            {
                display(150 - locatie - i, 25, "*");
                display(150 - locatie - i, 27, "*");
            }
            display(147 - locatie, 26, "*");
            display(150 - locatie, 26, "*");
            display(150 - locatie, 28, "*");
        }
    }
}