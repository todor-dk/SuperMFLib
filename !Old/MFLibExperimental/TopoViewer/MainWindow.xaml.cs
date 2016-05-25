using MediaFoundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TopoViewer.Descriptions;
using TopoViewer.Framework;

namespace TopoViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Multimedia.ExecuteMtaThreaded(() =>
            {
                using (MediaFoundation.Framework framework = MediaFoundation.Framework.Startup())
                {
                    string file = @"C:\Development\Customers\Atlas.ti\DirectShow\WikiLeaks _ Apache helicopter _ Attack _ Iraq.avi";
                    TopoViewer.Framework.SourceResolver sourceResolver = new UrlSourceResolver(new Uri(file));
                    SessionBuilder sessionBuilder = new SessionBuilder();
                    AudioStreamTopologyBuilder astb = new AudioStreamTopologyBuilder();
                    VideoStreamTopologyBuilder vstb = new VideoStreamTopologyBuilder();
                    TopologyBuilder topologyBuilder = new TopologyBuilder(astb, vstb);

                    using (MediaSession session = sessionBuilder.CreateSession())
                    {
                        using (MediaSource source = sourceResolver.ResolveSource())
                        {
                            using (Topology topology = topologyBuilder.CreateTopology(source))
                            {
                                TopologyInfo topoInfo = new TopologyInfo(topology);
                            }
                        }
                    }
                }
            });
        }
    }
}
