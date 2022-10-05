using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace left_to_do_emilgltz

{

    public class TaskManager
    {
        public List<Task> SimpleTasksList = new List<Task>();
        public List<Task> DeadlineTasksList = new List<Task>();
        public List<Task> ArchivedTasksList = new List<Task>();
        public List<Task> ChecklistTaskList = new List<Task>();

        public void SimpleTaskList()
        {
            Console.Clear();
            System.Console.WriteLine("Du har förnärvarande följande aktiva uppgifter:\n");

            if (SimpleTasksList.Count > 0)
            {
                System.Console.WriteLine("|Tidslösa uppgifter|");
                TaskPrinter(SimpleTasksList);
            }

            if (DeadlineTasksList.Count > 0)
            {
                System.Console.WriteLine("|Uppgifter med Deadline|");
                TaskPrinter(DeadlineTasksList);
            }

            if (ChecklistTaskList.Count > 0)
            {
                System.Console.WriteLine("|Uppgifter checklista|");
                TaskPrinter(ChecklistTaskList);
            }


            if (SimpleTasksList.Count == 0 && DeadlineTasksList.Count == 0 && ChecklistTaskList.Count == 0)
            {
                System.Console.WriteLine("Det finns inga uppgifter att visa för tillfället");
                Menu.ReturnFunction();
            }

            else
            {
                System.Console.WriteLine("Vill du markera en eller flera uppgifter som färdiga?" +
                " \nSkriv JA följt av \"enter\" för att markera uppgifter som färdiga." +
                " \nTryck endast på \"enter\" för att återgå till huvudmenyn.");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "JA":
                    case "ja":
                        TaskIsCompleted();
                        break;
                    default:
                        break;
                }
            }
        }

        public void TaskPrinter(List<Task> list)
        {
            int count = 1;
            foreach (Task task in list)
            {
                System.Console.WriteLine($"{count}: {task.ToString()}");
                count++;
            }
        }

        public int Parser()
        {
            int DlineInput = 0;
            bool inputAproved = false;
            while (!inputAproved)
            {
                Console.Write("Skriv in antal dagar i siffror:");
                inputAproved = int.TryParse(Console.ReadLine(), out DlineInput);
                if (!inputAproved)
                    System.Console.WriteLine("Error, talet måste vara i sifferform!");
            }
            return DlineInput;
        }

        public void SimpleTaskFunction()
        {
            Console.Clear();
            Console.WriteLine("Du har valt att skapa en tidlös uppgift");
            Console.Write("Beskriv din tidlösa uppgift:");
            var input = Console.ReadLine();
            SimpleTasksList.Add(new SimpleTask(input));

            System.Console.WriteLine($"Du har lagt till följande tidlösa uppgift" +
            $" till listan av uppgifter:\n{SimpleTasksList[SimpleTasksList.Count - 1].ToString()}");

            Menu.ReturnFunction();
        }

        public void DeadlineFunction()
        {
            Console.Clear();
            Console.WriteLine("Du har valt en uppgift med deadline.");
            Console.Write("Beskriv din uppgift:");
            var Description = Console.ReadLine();

            Console.WriteLine("Hur många dagar är det kvar till deadline?");

            int DaysLeft = Parser();
            DeadlineTasksList.Add(new DeadlineTask(Description, DaysLeft));

            Console.WriteLine($"\nDu har lagt till följande uppgift med en deadline:\n{DeadlineTasksList[DeadlineTasksList.Count - 1].ToString()}");
            Menu.ReturnFunction();
        }

        public void ArchiveCompletedTasks()
        {
            Console.Clear();
            MoveCompletedTasks(SimpleTasksList);
            DeleteCompletedTasks(SimpleTasksList);
            MoveCompletedTasks(DeadlineTasksList);
            DeleteCompletedTasks(DeadlineTasksList);
            MoveCompletedTasks(ChecklistTaskList);
            DeleteCompletedTasks(ChecklistTaskList);
            System.Console.WriteLine("Alla dina färdigauppgifter kommer nu att arkiveras!");
            Menu.ReturnFunction();
        }

        public void MoveCompletedTasks(List<Task> list)
        {
            foreach (var task in list.ToList())
            {
                if (task.Completed)
                    ArchivedTasksList.Add(task);
            }
        }

        public void DeleteCompletedTasks(List<Task> list)
        {
            foreach (var task in list.ToList())
            {
                if (task.Completed)
                    list.Remove(task);
            }
        }

        public void ArchivedTaskList()
        {
            Console.Clear();
            if (ArchivedTasksList.Count == 0)
            {
                System.Console.WriteLine("Du har för närvarande inga arkiverade uppgifter.");
                Menu.ReturnFunction();
            }
            else
            {
                System.Console.WriteLine("Arkiverade tidlösa uppgifter\n");
                int count = 1;
                foreach (Task task in ArchivedTasksList)
                {
                    if (task.GetType() == typeof(SimpleTask))
                    {
                        System.Console.WriteLine($"{count}: {task.ToString()}");
                        count++;
                    }
                }

                System.Console.WriteLine("Arkiverade uppgifter med deadline\n");
                count = 1;
                foreach (Task task in ArchivedTasksList)
                {
                    if (task.GetType() == typeof(DeadlineTask))
                    {
                        System.Console.WriteLine($"{count}: {task.ToString()}");
                        count++;
                    }
                }

                System.Console.WriteLine("Arkiverade uppgifter med checklista\n");
                count = 1;
                foreach (Task task in ArchivedTasksList)
                {
                    if (task.GetType() == typeof(ChecklistTask))
                    {
                        System.Console.WriteLine($"{count}: {task.ToString()}");
                        count++;
                    }
                }
                Menu.ReturnFunction();
            }
        }

        public void TaskIsCompleted()
        {
            bool CompletedTask = true;
            while (CompletedTask)
            {
                Console.Clear();
                System.Console.WriteLine("Vilken typ av uppgift vill du markera som färdig?");
                System.Console.WriteLine("[1] En tidlös uppgift");
                System.Console.WriteLine("[2] En uppgift med deadline");
                System.Console.WriteLine("[3] En uppgift med checklista");
                System.Console.WriteLine("[4] Huvudmeny");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        CompletedList(SimpleTasksList);
                        break;
                    case "2":
                        CompletedList(DeadlineTasksList);
                        break;
                    case "3":
                        CompletedList(ChecklistTaskList);
                        break;
                    case "4":
                        CompletedTask = false;
                        System.Console.WriteLine("Återgår till huvudmenyn");
                        Thread.Sleep(1400);
                        break;
                    default:
                        System.Console.WriteLine("Error, fel inmatning!");
                        Thread.Sleep(1400);
                        break;
                }
            }
        }

        public void CompletedList(List<Task> list)
        {
            if (list.Count == 0)
            {
                System.Console.WriteLine("Det finns inga aktiva uppgifter av den här sorten!");
                Thread.Sleep(1400);
            }
            else
            {
                var count = 1;
                foreach (Task task in list)
                {
                    
                    System.Console.WriteLine($"{count}: {task.ToString()}");
                    count++;

                    if (task.GetType() == typeof(ChecklistTask) && !task.Completed)
                    {

                        VerifyChecklistTask((ChecklistTask)task);

                    }
                    else if (!task.Completed)
                    {

                        CompletedCheck(task);
                    }

                    else
                    {
                        System.Console.WriteLine($"\"{task.TaskDescription}\" Är redan slutförd.");
                        Thread.Sleep(1400);
                    }
                }
            }
        }
        public void CompletedCheck(Task task)
        {
            System.Console.WriteLine($"Vill du markera \"{task.TaskDescription}\" som färdig? Skriv JA föjt av enter för att markera uppgiften som färdig, tryck endast enter för nej");
            var input = Console.ReadLine();
            switch (input)
            {
                case "JA":
                case "ja":
                    task.Completed = true;
                    System.Console.WriteLine($"\"{task.TaskDescription}\" är nu markerad som färdig!");
                    Thread.Sleep(1400);
                    break;
                default:
                    System.Console.WriteLine($"\"{task.TaskDescription}\" kommer inte markeras som färdig.");
                    Thread.Sleep(1400);
                    break;
            }
        }



        public int ParseInput()
        {
            int input = 0;
            bool inputSuccess = false;
            while (!inputSuccess)
            {
                Console.Write("Ange antalet deluppgifter med siffror:");
                inputSuccess = int.TryParse(Console.ReadLine(), out input);
                if (!inputSuccess)
                    System.Console.WriteLine("inmatning var inte en siffra!");
            }
            return input;
        }



        public void ChecklistFunction()
        {
            Console.Clear();
            Console.WriteLine("Du har valt att lägga till en uppgift med en checklista innehållandes deluppgifter.");


            Console.Write("Var vänlig och ange en beskrivning av huvuduppgiften:");
            string description = Console.ReadLine();


            System.Console.WriteLine("Hur många deluppgifter ska den innehålla?");
            int subTaskAmount = ParseInput();

            if (subTaskAmount < 1)
            {
                System.Console.WriteLine("Felaktig inmatning, checklistan kommer nu innehålla en deluppgift.");
                subTaskAmount = 1;
            }


            Task[] inputStorage = new Task[subTaskAmount];
            List<Task> inputList = CreateSubTaskList(inputStorage);
            CreateChecklistTask(description, inputList);


            Console.Clear();
            Console.WriteLine($"\nDu har lagt till följande deluppgifter:\n{ChecklistTaskList[ChecklistTaskList.Count - 1].ToString()}");
            Menu.ReturnFunction();
        }


        public List<Task> CreateSubTaskList(Task[] inputStorage)
        {
            List<Task> returnList = new List<Task>();
            int count = 1;
            while (count < inputStorage.Length + 1)
            {
                Console.Write($"Beskriv deluppgift nummer {count}:");
                string description = Console.ReadLine();
                returnList.Add(new SubTask(description));
                count++;
            }
            return returnList;
        }

        public void CreateChecklistTask(string description, List<Task> inputlist)
        {
            ChecklistTaskList.Add(new ChecklistTask(description, inputlist));
        }






        public void VerifyChecklistTask(ChecklistTask ChecklistTask)
        {
            foreach (Task subTask in ChecklistTask.SubTasks)
            {
                if (!subTask.Completed)
                {
                    CompletedCheck(subTask);
                }
                else
                {
                    System.Console.WriteLine($"\"{subTask.TaskDescription}\" Är redan färdig!");
                    Thread.Sleep(1500);
                }
            }


            bool allFinished = true;
            foreach (Task subTask in ChecklistTask.SubTasks)
            {
                if (!subTask.Completed)
                    allFinished = false;
            }
            if (allFinished)
            {
                Console.Clear();
                System.Console.WriteLine($"Alla deluppgifter är färdig!");
                System.Console.WriteLine($"Nu kommer {ChecklistTask.TaskDescription} att markeras som färdig.");
                ChecklistTask.Completed = true;
                System.Console.WriteLine("Tryck på valfri tangent för att gå tillbaka.");
                Console.ReadKey(true);
            }

        }
    }
}