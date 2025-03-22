using DotNetForms.Input.Properties;

namespace DotNetForms.Input;

public class NumberInput : BaseInput<NumberInput, int> {

    private int _minValue;
    private int _maxValue;
    private int _step;
    
    public int MinLength => _minValue;
    public int MaxLength => _maxValue;
    public int Step => _step;
    
    public NumberInput(NumberInputProperties properties) : base(properties) {
        _minValue = properties.MinValue;
        _maxValue = properties.MaxValue;
        _step = properties.Step;
    }
    
}