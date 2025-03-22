namespace DotNetForms.Input.Properties;

public class TextInputProperties : InputProperties<string> {

    public int MinLength = 0;
    public int MaxLength = int.MaxValue;
    public string? Pattern = null;
    public TextInputType Type = TextInputType.Text;

}