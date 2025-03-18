class ProgressPopup : Popup
{
    private int _progress = 0;
    private readonly string _progressBar = "";

    public ProgressPopup(string message) : base(message)
    {
        Display();
    }

    public void IncreaseProgress(int amount)
    {
        _progress += amount;
        if (_progress > 100) _progress = 100;
        Display();
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"{_progress}%\t{new string('|', _progress / 10)}");
    }

}
