namespace left_to_do_emilgltz
{
    public class SubTask : Task
    {

        public SubTask(string Description) : base(Description)
        {

        }

        public override string ToString()
        {
            string toString = $"Deluppgift, ";
            if (Completed)
            {
                toString += $"Färdig: ja \n";
            }
            else if (!Completed)
            {
                toString += $"Ej färdig: nej \n";
            }
            return toString;
        }
    }
}