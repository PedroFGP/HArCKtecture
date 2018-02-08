using System.Collections.Generic;
using System.Windows.Forms;

namespace HArCKtecture.Classes
{
    public static class ControlExtensions
    {
        public static void SetDictionaryDataSource<TKey, TValue>(this ComboBox value, Dictionary<TKey, TValue> source)
        {
            value.DataSource = new BindingSource(source, null);
            value.DisplayMember = "Key";
            value.ValueMember = "Value";
        }
    }
}
