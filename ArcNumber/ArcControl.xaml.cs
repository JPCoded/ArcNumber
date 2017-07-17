using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
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
        public ArcControl()
        {
            InitializeComponent();
            _arcs = new List<Path> { arcZero,arcOne,arcTwo,arcThree,arcFour,arcFive,arcSix,arcSeven,arcEight,arcNine };

        }

        public void SetArc(int num)
        {
            foreach(var arc in _arcs)
            {
                arc.Visibility = Visibility.Hidden;                                                                                   
            }

            _arcs[num].Visibility = Visibility.Visible;
        }

        public void IncreaseArc()
        {
            _arcs[_arcNum].Visibility = Visibility.Hidden;
            if (_arcNum + 1 > 9)
            {
                _arcNum = 0;
            }
            else
            {
                _arcNum++;
            }
      
           
            _arcs[_arcNum].Visibility = Visibility.Visible;
            
        }
    }
}
                                                                                                                                                                                        