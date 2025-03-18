class Button
{
    public string Text;
    private readonly object _sender;
    private readonly Action<object> _myAction;

    public Button(string text, object sender, Action<object> action)
    {
        Text = text;
        _sender = sender;
        _myAction = action;
    }

    public void Press() => _myAction(_sender);
}
