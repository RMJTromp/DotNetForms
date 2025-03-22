namespace DotNetForms.Input.Properties;

public class NumberInputProperties : InputProperties<int> {
    
    public int MinValue = int.MinValue;
    public int MaxValue = int.MaxValue;
    public int Step = 1;

}