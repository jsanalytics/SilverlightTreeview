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
    public class SampleViewModel
    {
        public DataModelCollection Data { get; set; }

        public SampleViewModel()
        {
            Data = new DataModelCollection {
                new DataModel { NodeName = "Node 11", Children = new DataModelCollection {
                    new DataModel { NodeName = "Node 113" },
                    new DataModel { NodeName = "Node 123" },
                    new DataModel { NodeName = "Node 133" },
                } },
                new DataModel { NodeName = "Node 22", Children = new DataModelCollection {
                    new DataModel { NodeName = "Node 213" },
                    new DataModel { NodeName = "Node 223" },
                } },
                new DataModel { NodeName = "Node 33", Children = new DataModelCollection {
                    new DataModel { NodeName = "Node 313" },
                } },
            };
        }
    }
}
