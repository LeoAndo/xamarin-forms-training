using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace CommandInterfaceSample
{
    public class PowersViewModel : ViewModelBase
    {
        double exponent, power;

        public PowersViewModel(double baseValue)
        {
            // プロパティを初期化
            BaseValue = baseValue;
            Exponent = 1;

            // ICommand型のプロパティを初期化
            IncreaseExponentCommand = new Command(() => // ラムダで書くパターン
            {
                Exponent++;
            });

            DecreaseExponentCommand = new Command(ExecuteDecreaseExponent);
        }

        private void ExecuteDecreaseExponent()
        {
            Exponent--;
        }

        public double BaseValue { private set; get; }
        public double Exponent
        {
            private set
            {
                if (SetProperty(ref exponent, value))
                {
                    Power = Math.Pow(BaseValue, exponent);
                }
            }
            get => exponent;
        }
        public double Power
        {
            private set => SetProperty(ref power, value);
            get => power;
        }

        public ICommand IncreaseExponentCommand { private set; get; }
        public ICommand DecreaseExponentCommand { private set; get; }
    }
}
