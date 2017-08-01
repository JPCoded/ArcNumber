using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ArcNumber
{
    /// <summary>
    /// Interaction logic for ArcControl.xaml
    /// </summary>
    public partial class ArcControl : UserControl
    {
        private int _arcNum = 0;
        private readonly List<Path> _arcs;
        private readonly List<Label> _numbers;
        private readonly Random _rnd = new Random();
        

        public ArcControl()
        {
           
            InitializeComponent();

            _arcs = new List<Path> { arcZero,arcOne,arcTwo,arcThree,arcFour,arcFive,arcSix,arcSeven,arcEight,arcNine };
            _numbers = new List<Label> { lblZero, lblOne, lblTwo, lblThree, lblFour, lblFive, lblSix, lblSeven, lblEight, lblNine };

            for (var i = 0; i < 10; i++)
            {
                ArcOff(i);
            }


            AsyncUpdateNumbersBackground();
        }

        private async void AsyncUpdateNumbersBackground()
        {
            while (true)
            {
            // update the UI
                var newNumbers = "";
                for (var i = 0; i < 1536; i++)
                {
                    var rndNum = _rnd.Next(0, 3);
                    newNumbers += (rndNum == 2) ? " " : rndNum.ToString();
                }
                 txtNumbers.Text = newNumbers;

                // don't run again for at least 200 milliseconds
                await Task.Delay(1000);
            }
        }

        private void ArcOff(int num)
        {
            _arcs[num].Visibility = Visibility.Hidden;
            _numbers[num].Foreground = (Brush)Application.Current.FindResource("nixieColorOff");
        }

        private void ArcOn(int num)
        {
            _arcs[num].Visibility = Visibility.Visible;
            _numbers[num].Foreground = (Brush)Application.Current.FindResource("nixieColor");
           
        }

        internal void SetArc(int num)
        {
              ArcOn(num);
        }

        public void IncreaseArc()
        {
            ArcOff(_arcNum);

            _arcNum = (_arcNum + 1 > 9) ? 0 : _arcNum + 1;
     

       ArcOn(_arcNum);
            
        }
    }
}
                                                                                                                                                                                        