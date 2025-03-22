namespace DotNetForms.Input.Context;

public class InputContext<T> {

    public string Label = "";
    public string? Description = null;
    public T? DefaultValue = default(T);
    public string? Placeholder = null;
    public bool Nullable = false;
    public bool Required = false;

}