using MediaFoundation;
using MediaFoundation.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopoViewer.Descriptions
{
    public class TopologyNodeInfo : AttributeInfo<IMFTopologyNode>
    {
        public TopologyNodeInfo(TopologyNode node)
            : base(node)
        {
            node
        }
    }
}
