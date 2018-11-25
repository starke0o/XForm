using XForm.Fields.Bases;
using XForm.Forms;
using XForm.InputConverters;

namespace XForm.Fields
{
    public class DecimalInputFieldAttribute : FieldAttribute
    {
        public DecimalInputFieldAttribute(string name)
            : base(() => new DecimalInputField(name),
                   typeof(DecimalInputField).GetProperty(nameof(DecimalInputField.Value)))
        {
        }
    }
    
    public class DecimalInputField : InputField<double?>
    {
        public DecimalInputField(string title, double? value = null) : base(new DoubleInputConverter(), title, value)
        {
        }
    }
}