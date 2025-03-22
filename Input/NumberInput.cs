using DotNetForms.Input.Context;

namespace DotNetForms.Input;

public class NumberInput : BaseInput<NumberInput, int> {

    private int _minValue;
    private int _maxValue;
    private int _step;
    
    public int MinLength => _minValue;
    public int MaxLength => _maxValue;
    public int Step => _step;
    
    public NumberInput(NumberInputContext context) : base(context) {
        _minValue = context.MinValue;
        _maxValue = context.MaxValue;
        _step = context.Step;
    }
    
}