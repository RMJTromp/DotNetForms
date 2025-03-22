namespace DotNetForms.Input.Properties;

public class InputProperties<T> {

    public string Label = "";
    public string? Description = null;
    public T? DefaultValue = default(T);
    public string? Placeholder = null;
    public bool Nullable = false;
    public bool Required = false;

}