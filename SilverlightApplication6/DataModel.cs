using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace SilverlightApplication6
{
    public class DataModel
    {
        public string NodeName { get; set; }
        public DataModelCollection Children { get; set; }

        public DataModel()
        {
            Children = new DataModelCollection();
        }
    }
}
