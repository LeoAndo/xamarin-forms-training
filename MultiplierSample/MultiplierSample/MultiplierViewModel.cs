namespace MultiplierSample
{
    public class MultiplierViewModel : ViewModelBase
    {
        public MultiplierViewModel()
        {
        }

        double multiplicand, multiplier, product;

        public double Multiplicand
        {
            set
            {
                if (SetProperty(ref multiplicand, value))
                {
                    UpdateProduct();
                }
            }
            get => multiplicand;
        }

        public double Multiplier
        {
            set
            {
                if (SetProperty(ref multiplier, value))
                {
                    UpdateProduct();
                }
            }
            get => multiplier;
        }

        public double Product
        {
            private set => SetProperty(ref product, value);
            get => product;
        }

        private void UpdateProduct()
        {
            Product = Multiplicand * Multiplier;
        }
    }
}
