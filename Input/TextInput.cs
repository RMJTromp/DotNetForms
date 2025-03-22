using DotNetForms.Input.Properties;

namespace DotNetForms.Input;

public class TextInput(TextInputProperties properties) : BaseInput<TextInput, string>(properties) {

    public int MinLength => properties.MinLength;
    public int MaxLength => properties.MaxLength;
    public string? Pattern => properties.Pattern;
    public TextInputType Type => properties.Type;

    public override string DisplayValue {
        get {
            if (Value is not {Length: > 0}) return "";
            
            return Type switch {
                TextInputType.Password => new string('*', Value.Length),
                TextInputType.Email => Value.ToLower(),
                TextInputType.Telephone => Value.Replace(" ", ""), // TODO: format phone number
                _ => Value
            };
        }
    }

}