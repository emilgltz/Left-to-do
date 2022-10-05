namespace left_to_do_emilgltz
{
    public abstract class Task
    {
        public bool Completed { get; set; }
        public string TaskDescription { get; set; }
         public Task(string Description)
        {
            TaskDescription = Description;
            Completed  = false;
        }
        public override string ToString()
        {
            string toString = $"Beskrivning: {TaskDescription} \n";
            if (Completed )
            {
                toString += $"Färdig: ja \n";
            }
            else if (!Completed)
            {
                toString += $"Färdig: nej \n";
            }
            return toString;
        }
        
    }
}

