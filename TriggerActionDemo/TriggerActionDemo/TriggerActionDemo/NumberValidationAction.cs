using System;
using Xamarin.Forms;

namespace TriggerActionDemo
{
    public class NumberValidationAction : TriggerAction<Entry>
    {
        // 入力値が数値でなければ、色を赤に変える。
        protected override void Invoke(Entry sender)
        {
            double result;
            bool isValid = Double.TryParse(sender.Text, out result);
            sender.TextColor = isValid ? Color.Default : Color.Red;
        }
    }
}

