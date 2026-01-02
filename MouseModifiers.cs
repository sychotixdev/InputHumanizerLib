namespace InputHumanizer.Input
{
    [Flags]
    public enum MouseModifiers : byte
    {
        None = 0,
        Ctrl = 1 << 0,
        Shift = 1 << 1,
        Alt = 1 << 2
    }
}
