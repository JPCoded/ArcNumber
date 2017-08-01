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
            foreach (var num in _numbers)
            {
               
                num.Foreground = (Brush)Application.Current.FindResource("NixieColorOff");
            }
            foreach (var arc in _arcs)
            {
                arc.Visibility = Visibility.Hidden;                                                                                   
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


        public void SetArc(int num)
        {
               _arcs[num].Visibility = Visibility.Visible;
            _numbers[num].Foreground = (Brush)Application.Current.FindResource("NixieColor"); 
        }

        public void IncreaseArc()
        {
            _arcs[_arcNum].Visibility = Visibility.Hidden;
            _numbers[_arcNum].Foreground = (Brush)Application.Current.FindResource("NixieColorOff");

            _arcNum = (_arcNum + 1 > 9) ? 0 : _arcNum + 1;
     

            _numbers[_arcNum].Foreground = (Brush)Application.Current.FindResource("NixieColor");
            _arcs[_arcNum].Visibility = Visibility.Visible;
            
        }
    }
}
                                                                                                                                                                                        