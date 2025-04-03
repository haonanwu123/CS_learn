public class IDE
{
    public string BackGroundColor { get; }
    public string FontColor { get; }
    public string ButtonColor { get; }

    public IDE(string backGroundColor, string fontColor, string buttonColor)
    {
        BackGroundColor = backGroundColor;
        FontColor = fontColor;
        ButtonColor = buttonColor;
    }
}