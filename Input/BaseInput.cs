using DotNetForms.Input.Properties;

namespace DotNetForms.Input;

public abstract class BaseInput<TInstance, T>(InputProperties<T> ctx)
    where TInstance : BaseInput<TInstance, T> {

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
            OnChange?.Invoke((TInstance) this);
        }
    }
    
    public event Action<TInstance>? OnChange;
    public event Action<TInstance>? OnFocus;
    public event Action<TInstance>? OnBlur;
    public event Action<TInstance, ConsoleKeyInfo>? OnKeyPress;

    public void TriggerFocus() {
        OnFocus?.Invoke((TInstance) this);
    }

    public void TriggerBlur() {
        OnBlur?.Invoke((TInstance) this);
    }

    public void TriggerKeyPress(ConsoleKeyInfo key) {
        OnKeyPress?.Invoke((TInstance) this, key);
    }

}