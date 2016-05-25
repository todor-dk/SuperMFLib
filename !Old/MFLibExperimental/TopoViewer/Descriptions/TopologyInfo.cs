using MediaFoundation;
using MediaFoundation.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopoViewer.Descriptions
{
    public class TopologyInfo : AttributeInfo<IMFTopology>
    {
        public long TopologyId { get; private set; }

        public TopologyNodeInfo[] Nodes { get; private set; }

        public TopologyInfo(Topology topology)
            : base(topology)
        {
            this.TopologyId = topology.TopologyId;
            short cnt = topology.NodeCount;

            TopologyNodeInfo[] nodes = new TopologyNodeInfo[cnt];
            for (short i = 0; i < cnt; i++)
            {
                using(TopologyNode node = topology.GetNode(i))
                {
                    nodes[i] = new TopologyNodeInfo(node);
                }
            }
        }
    }
}
