using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ArcNumber
{
    /// <summary>
    /// Interaction logic for LiquidTube.xaml
    /// </summary>
    public partial class LiquidTube : UserControl
    {
        public LiquidTube()
        {
            InitializeComponent();
            AsyncUpdateLiquid();
        }

        private async void AsyncUpdateLiquid()
        {

      

            while (true)
            {   if(recLiquid.Height == 212.58)
                {
                    recLiquid.Height = 0;
                }

                if ((recLiquid.Height + 10) > 212)
                {
                    recLiquid.Height = 212.58;
                }
                else
                {
                    recLiquid.Height += 10;
                }

                await Task.Delay(500);
            }
        }
    }
    
}
