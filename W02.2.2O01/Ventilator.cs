class Ventilator
{
    public int Speed = 0;
    public List<Button> Buttons = [
        new Button(), new Button(), new Button(), new Button()
    ];

    public Ventilator() { }

    public void PressButton(int number)
    {
        if (number < 0 || number >= Buttons.Count())
        {
            return;
        }

        for (int i = 0; i < Buttons.Count; i++)
        {
            Buttons[i].IsPressed = false;
        }

        if (number != 0)
        {
            Buttons[number].IsPressed = true;
        }

        Speed = number;
    }

    public string Blow() => Speed switch
    {
        <= 0 => "Off",
        1 => "~~~",
        2 => "^^^",
        >= 3 => "===",
    };
}
