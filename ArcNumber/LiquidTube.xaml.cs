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
     
            var LiquidBrush = new LinearGradientBrush()
            {
                StartPoint = new System.Windows.Point(0.5, 0),
                EndPoint = new System.Windows.Point(0.5, 1)
            };

            var Lime = new GradientStop()
            {
                Color = Colors.Lime,
                Offset = 1
            };
         
            var White = new GradientStop()
            {
                Color = Colors.White,
                Offset = 1
            };
      

            while (true)
            {
                White.Offset -= .10;
                Lime.Offset -= .10;
                LiquidBrush.GradientStops.Clear();
                LiquidBrush.GradientStops.Add(White);
                LiquidBrush.GradientStops.Add(Lime);

                recLiquid.Fill = LiquidBrush;

                if (White.Offset <= 0)
                { White.Offset = 1;
                    Lime.Offset = 1;
                }
                await Task.Delay(1000);
            }
        }
    }
    
}
