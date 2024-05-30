public class Program
{
    private static List<Job> jobs = new List<Job>();
    private static List<Employee> employees = new List<Employee>();

    public static void Main(string[] args)
    {
        string command;

        while ((command = Console.ReadLine()) != "End")
        {
            string[] tokens = command.Split();

            switch (tokens[0])
            {
                case "Job":
                    Employee employee = employees.First(e => e.Name == tokens[3]);
                    AddJob(new Job(tokens[1], int.Parse(tokens[2]), employee));
                    break;
                case "StandardEmployee":
                    StandardEmployee standardEmployee = new StandardEmployee(tokens[1], 40);
                    employees.Add(standardEmployee);
                    break;
                case "PartTimeEmployee":
                    PartTimeEmployee partTimeEmployee = new PartTimeEmployee(tokens[1], 20);
                    employees.Add(partTimeEmployee);
                    break;
                case "Pass":
                    jobs.ToList().ForEach(j => j.Update());
                    break;
                case "Status":
                    jobs.ForEach(Console.WriteLine);
                    break;
            }
        }
    }

    public static void OnJobComplete(Job job)
    {
        jobs.Remove(job);
    }

    public static void AddJob(Job job)
    {
        jobs.Add(job);
        job.JobCompleted += OnJobComplete;
    }
}