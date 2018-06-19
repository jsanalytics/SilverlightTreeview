using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightApplication6
{
    public partial class SilverlightControl1 : UserControl
    {
        SampleViewModel vm;

        public SilverlightControl1()
        {
            InitializeComponent();

            vm = new SampleViewModel();
            DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataModel dm = (DataModel)trv1.SelectedItem;

            if (dm == null)
                vm.Data.Add(new DataModel { NodeName = txt1.Text });
            else dm.Children.Add(new DataModel { NodeName = txt1.Text });
        }
    }
}
