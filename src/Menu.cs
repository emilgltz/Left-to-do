using System;
using System.Threading;

namespace left_to_do_emilgltz
{
    public class Menu
    {
        public void ToggleMenu()
        {
            TaskManager taskMananger = new TaskManager();
            bool Start = true;
            while (Start)
            {
                ShowMenu();
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        taskMananger.SimpleTaskFunction();
                        break;
                    case "2":
                        taskMananger.DeadlineFunction();
                        break;
                    case "3":
                        taskMananger.ChecklistFunction();
                        break;
                    case "4":
                        taskMananger.SimpleTaskList();
                        break;
                    case "5":
                        taskMananger.ArchiveCompletedTasks();
                        break;
                    case "6":
                        taskMananger.ArchivedTaskList();
                        break;

                    case "7":
                        Start = false;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Programmet har avslutats!");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fel vid inmatning, var god försök igen!");
                        Thread.Sleep(700);
                        Console.Clear();
                        continue;
                }
            }
        }
        private void ShowMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Välkommen till din ToDo lista");
            Console.WriteLine("Kom igång genom att trycka på en siffra från menyn och sedan\"enter\".\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[1] Lägg till en tidlös uppgift");
            Console.WriteLine("[2] Lägg till en uppgift med deadline");
            Console.WriteLine("[3] Lägg till en uppgift med checklista");
            Console.WriteLine("[4] Visa alla sparade uppgifter");
            Console.WriteLine("[5] Arkivera alla färdiga uppgifter");
            Console.WriteLine("[6] Visa alla arkiverade uppgifter\n");
            Console.WriteLine("[7] Avsluta programmet");
            Console.Write("\nGör ditt val här: ");
        }
        public static void ReturnFunction()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Tryck på valfri tangent för att återgå till huvudmenyn.");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}