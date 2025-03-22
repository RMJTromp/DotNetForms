using DotNetForms.Input.Properties;

namespace DotNetForms.Input;

public class Input {
    
    public static TextInput Text(
        string label, 
        string? description = null, 
        string? placeholder = null,
        string? pattern = null, 
        string? defaultValue = null, 
        int minLength = 0,
        int maxLength = int.MaxValue,
        bool nullable = false,
        bool required = false
    ) => new(new TextInputProperties {
        Label = label,
        Description = description,
        Placeholder = placeholder,
        Pattern = pattern,
        MinLength = minLength,
        MaxLength = maxLength,
        Nullable = nullable,
        DefaultValue = defaultValue,
        Required = required,
        Type = TextInputType.Text
    });
    
    public static TextInput Email(
        string label = "E-mail", 
        string? description = null, 
        string? placeholder = null,
        string? pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", 
        string? defaultValue = null, 
        int minLength = 0,
        int maxLength = int.MaxValue,
        bool nullable = false,
        bool required = false
    ) => new(new TextInputProperties {
        Label = label,
        Description = description,
        Placeholder = placeholder,
        Pattern = pattern,
        MinLength = minLength,
        MaxLength = maxLength,
        Nullable = nullable,
        DefaultValue = defaultValue,
        Required = required,
        Type = TextInputType.Email
    });
    
    public static TextInput Password(
        string label = "Password", 
        string? description = null, 
        string? placeholder = null,
        string? pattern = null, 
        string? defaultValue = null, 
        int minLength = 8,
        int maxLength = int.MaxValue,
        bool nullable = false,
        bool required = false
    ) => new(new TextInputProperties {
        Label = label,
        Description = description,
        Placeholder = placeholder,
        Pattern = pattern,
        MinLength = minLength,
        MaxLength = maxLength,
        Nullable = nullable,
        DefaultValue = defaultValue,
        Required = required,
        Type = TextInputType.Password
    });

    public static NumberInput Number(Action<NumberInputProperties> action) {
        var ctx = new NumberInputProperties();
        ctx.DefaultValue = 0;
        action(ctx);
        ctx.Nullable = false;
        return new NumberInput(ctx);
    }

}