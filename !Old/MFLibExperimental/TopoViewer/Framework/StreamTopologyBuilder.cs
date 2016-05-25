using MediaFoundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopoViewer.Framework
{
    public abstract class StreamTopologyBuilder
    {
        public void AddBranchToPartialTopology(Topology topology, MediaSource source, PresentationDescriptor presentationDescriptor, StreamDescriptor streamDescriptor)
        {
            // Create the media sink activation object.
            using (Activate activate = this.CreateMediaSinkActivate())
            {
                // Add a source node for this stream.
                using (TopologyNode sourceNode = this.AddSourceNode(topology, source, presentationDescriptor, streamDescriptor))
                {
                    // Create the output node for the renderer.
                    using (TopologyNode outputNode = this.AddOutputNode(topology, activate, 0))
                    {
                        // Connect the source node to the output node.
                        sourceNode.ConnectOutput(0, outputNode, 0);
                    }
                }
            }
        }

        private TopologyNode AddSourceNode(Topology topology, MediaSource source, PresentationDescriptor presentationDescriptor, StreamDescriptor streamDescriptor)
        {
            // Call MFCreateTopologyNode with the MF_TOPOLOGY_SOURCESTREAM_NODE flag to create the source node. 
            TopologyNode sourceNode = TopologyNode.Create(MFTopologyType.SourcestreamNode);

            // Set the MF_TOPONODE_SOURCE attribute on the node, with a pointer to the media source. 
            sourceNode.SetObject(MFAttribute.TopologyNode.SourceNodes.MF_TOPONODE_SOURCE, source);

            // Set the MF_TOPONODE_PRESENTATION_DESCRIPTOR attribute on the node, with a pointer to the presentation descriptor of the media source. 
            sourceNode.SetObject(MFAttribute.TopologyNode.SourceNodes.MF_TOPONODE_PRESENTATION_DESCRIPTOR, presentationDescriptor);

            // Set the MF_TOPONODE_STREAM_DESCRIPTOR attribute on the node, with a pointer to the stream descriptor for the stream. 
            sourceNode.SetObject(MFAttribute.TopologyNode.SourceNodes.MF_TOPONODE_STREAM_DESCRIPTOR, streamDescriptor);

            // Add the node to the topology.
            topology.AddNode(sourceNode);

            return sourceNode;
        }

        private TopologyNode AddOutputNode(Topology topology, Activate activate, int id)
        {
            // Call MFCreateTopologyNode with the MF_TOPOLOGY_OUTPUT_NODE flag to create the output node. 
            TopologyNode outputNode = TopologyNode.Create(MFTopologyType.OutputNode);

            outputNode.SetInt32(MFAttribute.TopologyNode.OutputNodes.MF_TOPONODE_STREAMID, id);

            // Set the MF_TOPONODE_NOSHUTDOWN_ON_REMOVE attribute to TRUE (optional but recommended).
            outputNode.SetBoolean(MFAttribute.TopologyNode.OutputNodes.MF_TOPONODE_NOSHUTDOWN_ON_REMOVE, true);

            // Call IMFTopologyNode::SetObject and pass in the IMFActivate pointer. 
            outputNode.SetObject(activate);

            // Add the node to the topology.
            topology.AddNode(outputNode);

            return outputNode;
        }

        protected abstract Activate CreateMediaSinkActivate();

        public abstract Guid MajorType { get; }
    }
}
