using System;
using System.Collections.Generic;
using Task_Manager;

List<Vazifa> vazifalar = new List<Vazifa>();

while (true)
{
    Console.WriteLine(" \t <<< Vazifalar menejeri >>> ");
    Console.WriteLine("1. Vazifalar ro'yxatini ko'rsatish");
    Console.WriteLine("2. Vazifani qo'shish");
    Console.WriteLine("3. Vazifani o'chirish");
    Console.WriteLine("4. Vazifani belgilash");
    Console.WriteLine("5. Chiqish");

    Console.Write(" \t Tanlang: ");
    try
    {
        int tanlov = Convert.ToInt32(Console.ReadLine());
        switch (tanlov)
        {
            case 1:
                foreach (Vazifa vazifa in vazifalar)
                {
                    Console.WriteLine($" \t {vazifa.Name} - {vazifa.Description} - {vazifa.Deadline} - {vazifa.IsCompleted}");
                }
                if (vazifalar.Count == 0)
                {
                    Console.WriteLine(" \t Vazifalar ro'yxati bo'sh!");
                }
                Console.WriteLine();
                break;

            case 2:
                Console.Write(" \t Vazifa nomi: ");
                string vazifaName = Console.ReadLine();

                Console.Write(" \t Vazifa tavsifi: ");
                string vazifaDescription = Console.ReadLine();

                Vazifa vazifa0 = new Vazifa(vazifaName, vazifaDescription);
                vazifalar.Add(vazifa0);
                Console.WriteLine();
                break;

            case 3:
                Console.Write(" \t Vazifa nomi: ");
                string vazifaNameToDelete = Console.ReadLine();

                foreach (Vazifa vazifa in vazifalar)
                {
                    if (vazifa.Name == vazifaNameToDelete)
                    {
                        vazifalar.Remove(vazifa);
                        break;
                    }
                }
                Console.WriteLine();
                break;

            case 4:
                Console.Write(" \t Vazifa nomi: ");
                string vazifaNameToMark = Console.ReadLine();

                foreach (Vazifa vazifa in vazifalar)
                {
                    if (vazifa.Name == vazifaNameToMark)
                    {
                        vazifa.MarkAsCompleted();
                        break;
                    }
                }
                Console.WriteLine();
                break;

            case 5:
                Console.WriteLine(" \t Dastur tugadi!");
                Console.WriteLine();
                return;
            
            default:
                Console.WriteLine(" \t Noto'g'ri ma'lumot!");
                Console.WriteLine();
                break;
        }
    }
    catch (Exception)
    {
        Console.WriteLine(" \t Noto'g'ri ma'lumot kiritdingiz!");
        Console.WriteLine();
    }
}