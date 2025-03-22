namespace DotNetForms.Input.Context;

public class TextInputContext : InputContext<string> {

    public int MinLength = 0;
    public int MaxLength = int.MaxValue;
    public string? Pattern = null;
    public TextInputType Type = TextInputType.Text;

}