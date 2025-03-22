namespace DotNetForms.Input.Context;

public class NumberInputContext : InputContext<int> {
    
    public int MinValue = int.MinValue;
    public int MaxValue = int.MaxValue;
    public int Step = 1;

}