class Task
{
    public string Name { get; private set; }
    public bool IsDone { get; private set; }

    public Task(string name)
    {
        Name = name;
        IsDone = false;
    }

    public void Done()
    {
        IsDone = true;
    }

    public string Info()
    {
        string status = IsDone ? "Done" : "Pending";
        return $"Task: {Name}, Status: {status}";
    }
}