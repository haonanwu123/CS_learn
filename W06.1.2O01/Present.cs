class Present
{
    private object _contents;
    public bool IsWrapped { get; private set; }

    public Present(object contents)
    {
        _contents = contents;
        IsWrapped = true;
    }

    public void Unwrap() => IsWrapped = false;

    public object? GetContents()
    {
        if (IsWrapped)
            return null;
        return _contents;
    }

    public string Hint
    {
        get
        {
            if (!IsWrapped) return "It is already unwrapped.";
            if (_contents is Lego) return "It is a Lego set!";
            if (_contents is BoardGame game) return $"It is a board game by {game.Publisher}!";
            if (_contents is Toy) return "It is a toy!";
            if (_contents is Movie) return "It is a movie!";
            return "It is a surprise!";
        }
    }
}
