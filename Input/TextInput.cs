using DotNetForms.Input.Context;

namespace DotNetForms.Input;

public class TextInput(TextInputContext context) : BaseInput<TextInput, string>(context) {

    public int MinLength => context.MinLength;
    public int MaxLength => context.MaxLength;
    public string? Pattern => context.Pattern;
    public TextInputType Type => context.Type;

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