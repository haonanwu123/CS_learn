class Button
{
    public bool IsPressed { get; private set; }
    public int TimesPressed { get; private set; }
    public Button()
    {
        IsPressed = false;
        TimesPressed = 0;
    }

    public void Press()
    {
        IsPressed = !IsPressed;
        TimesPressed++;
    }

    public string Info()
    {
        string pressedStatus = IsPressed ? "pressed" : "not pressed";
        return $"Button is {pressedStatus}.\nPressed {TimesPressed} times.";
    }
}
