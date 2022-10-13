using System;

namespace left_to_do_emilgltz
{
    public class DeadlineTask : Task
    {
        public int Days { get; set; }
        private string EstimateDeadline()
        {
            DateTime DeadlineInput = DateTime.Today.AddDays(Days); 
            string Deadline = DeadlineInput.ToString("dd MMM yyyy"); 
            return Deadline;
        }

        public override string ToString()
        {
            return base.ToString()
            + $"Deadline: {EstimateDeadline()}\n"
            + $"Days left: {Days}\n";
        }
        public DeadlineTask(string Description, int Daysleft) : base(Description)
        {
            if (Daysleft > 999999 || Daysleft < 0)
            {
                Days = 0;
            }
            else
            {
                Days = Daysleft;
            }
        }
    }
}