using System.Collections.Generic;
namespace left_to_do_emilgltz
{
    public class ChecklistTask : Task
    {
        private List<Task> subTasks = new List<Task>();

        public List<Task> SubTasks
        {
            set { subTasks = value; }
            get { return subTasks; }
        }

        public ChecklistTask(string Description, List<Task> subtasks) : base(Description)
        {

            subTasks = subtasks;
        }

        private string SubTaskList()
        {
            string output = "";
            int count = 1;
            foreach (Task subtask in subTasks)
            {
                output += $"Deluppgift {count}: {subtask.ToString()}";
                count++;
            }

            return output;
        }

        public override string ToString()
        {
            return base.ToString() + SubTaskList();
        }
    }
}