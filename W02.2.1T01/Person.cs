class Person
{
    public string Name { get; private set; }
    public Job? DayJob { get; set; }

    public Person(string name, Job dayJob)
    {
        Name = name;
        DayJob = dayJob;
    }

    public string Info()
    {
        if (DayJob != null)
        {
            return $"{Name} works as a {DayJob.Name}";
        }
        else
        {
            return $"{Name} is in between jobs";
        }
    }
}