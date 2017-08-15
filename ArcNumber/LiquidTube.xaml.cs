using System.Threading.Tasks;
using System.Windows.Controls;


namespace ArcNumber
{
    /// <summary>
    /// Interaction logic for LiquidTube.xaml
    /// </summary>
    public partial class LiquidTube : UserControl
    {
        private const double Heightinc = 1;
        public LiquidTube()
        {
            InitializeComponent();
            AsyncUpdateLiquid();
        }

        private async void AsyncUpdateLiquid()
        {

      

            while (true)
            {   if(recLiquid.Height >= 212)
                {
                    recLiquid.Height = 0;
                }


                if ((recLiquid.Height + Heightinc) > 212)
                {
                    recLiquid.Height = 212.58;
                }
                else
                {
                    recLiquid.Height += Heightinc;
                }

                await Task.Delay(100);
            }
        }
    }
    
}
