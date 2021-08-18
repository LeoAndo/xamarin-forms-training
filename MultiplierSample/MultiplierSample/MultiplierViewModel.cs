using System.ComponentModel;
using System.Diagnostics;

namespace MultiplierSample
{
    public class MultiplierViewModel : INotifyPropertyChanged
    {
        public MultiplierViewModel()
        {
        }

        double multiplicand, multiplier, product;
        public event PropertyChangedEventHandler PropertyChanged;

        public double Multiplicand
        {
            set
            {
                if (multiplicand != value)
                {
                    multiplicand = value;
                    OnPropertyChanged("Multiplicand", value);
                    UpdateProduct();
                }
            }
            get
            {
                return multiplicand;
            }
        }

        public double Multiplier
        {
            set
            {
                if (multiplier != value)
                {
                    multiplier = value;
                    OnPropertyChanged("Multiplier", value);
                    UpdateProduct();
                }
            }
            get
            {
                return multiplier;
            }
        }

        public double Product
        {
            private set
            {
                if (product != value)
                {
                    product = value;
                    OnPropertyChanged("Product", value);
                }
            }
            get
            {
                return product;
            }
        }

        private void UpdateProduct()
        {
            Product = Multiplicand * Multiplier;
        }

        private void OnPropertyChanged(string propertyName, double value)
        {
            Debug.WriteLine("OnPropertyChanged propertyName: " + propertyName + " value: " + value);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
