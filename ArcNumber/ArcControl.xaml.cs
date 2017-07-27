using System.Collections.Generic;
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
        int _arcNum = 0;
        private readonly List<Path> _arcs;
        private readonly List<Label> _numbers;
        

        public ArcControl()
        {
            InitializeComponent();

           
            _arcs = new List<Path> { arcZero,arcOne,arcTwo,arcThree,arcFour,arcFive,arcSix,arcSeven,arcEight,arcNine };
            _numbers = new List<Label> { lblZero, lblOne, lblTwo, lblThree, lblFour, lblFive, lblSix, lblSeven, lblEight, lblNine };
            foreach (var num in _numbers)
            {
                num.Foreground = Brushes.Gray;
            }
            foreach (var arc in _arcs)
            {
                arc.Visibility = Visibility.Hidden;                                                                                   
            }  
        }

        public void SetArc(int num)
        {
               _arcs[num].Visibility = Visibility.Visible;
            _numbers[num].Foreground = Brushes.Red;
        }

        public void IncreaseArc()
        {
            _arcs[_arcNum].Visibility = Visibility.Hidden;
            _numbers[_arcNum].Foreground = Brushes.Gray;

            _arcNum = (_arcNum + 1 > 9) ? 0 : _arcNum + 1;
     

            _numbers[_arcNum].Foreground = Brushes.Red;
            _arcs[_arcNum].Visibility = Visibility.Visible;
            
        }
    }
}
                                                                                                                                                                                        