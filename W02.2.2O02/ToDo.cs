class ToDo
{
    public List<Task> TaskList { get; private set; }

    public ToDo()
    {
        TaskList = new List<Task>();
    }

    public void AddTask(string name)
    {
        TaskList.Add(new Task(name));
    }

    public Task? GetTask(string name)
    {
        return TaskList.FirstOrDefault(task => task.Name == name);
    }

    public string Report()
    {
        string report = "";
        foreach (Task task in TaskList)
        {
            report += task.Info() + "\n";
        }
        return report;
    }
}