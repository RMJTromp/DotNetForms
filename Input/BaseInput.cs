using DotNetForms.Input.Context;
namespace DotNetForms.Input;

public abstract class BaseInput<Instance, T>(InputContext<T> ctx)
    where Instance : BaseInput<Instance, T> {

    public string Label => ctx.Label;
    public T? DefaultValue => ctx.DefaultValue;
    public string? Placeholder => ctx.Placeholder;
    public bool Nullable => ctx.Nullable;
    public bool Required => ctx.Required;
    public virtual string DisplayValue => Value?.ToString() ?? "";
    
    private T? _value = ctx.DefaultValue;
    public T? Value {
        get {
            if (typeof(T) == typeof(string) && _value is string strValue && string.IsNullOrEmpty(strValue)) 
                return DefaultValue;
            return _value ?? DefaultValue;
        }
        set {
            if (EqualityComparer<T>.Default.Equals(_value, value)) return;
            if (value == null && !Nullable) return;

            _value = value;
            OnChange?.Invoke((Instance) this);
        }
    }
    
    public event Action<Instance>? OnChange;
    public event Action<Instance>? OnFocus;
    public event Action<Instance>? OnBlur;
    public event Action<Instance, ConsoleKeyInfo>? OnKeyPress;

    public void TriggerFocus() {
        OnFocus?.Invoke((Instance) this);
    }

    public void TriggerBlur() {
        OnBlur?.Invoke((Instance) this);
    }

    public void TriggerKeyPress(ConsoleKeyInfo key) {
        OnKeyPress?.Invoke((Instance) this, key);
    }

}