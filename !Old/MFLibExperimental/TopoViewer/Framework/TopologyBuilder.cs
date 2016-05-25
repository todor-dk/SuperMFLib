using MediaFoundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopoViewer.Framework
{
    public class TopologyBuilder
    {
        public IReadOnlyDictionary<Guid, StreamTopologyBuilder> StreamBuilders { get; private set; }

        public TopologyBuilder(params StreamTopologyBuilder[] streamTopologyBuilders)
        {
            Dictionary<Guid, StreamTopologyBuilder> builders = new Dictionary<Guid, StreamTopologyBuilder>();
            if (streamTopologyBuilders != null)
            {
                foreach (StreamTopologyBuilder builder in streamTopologyBuilders)
                {
                    if (builder != null)
                        builders[builder.MajorType] = builder;
                }
            }
            this.StreamBuilders = builders;
        }

        public Topology CreateTopology(MediaSource source)
        {
            // ** Create a topology that connects the media source to the EVR and SAR. **

            // Get the media source's presentation descriptor.
            using (PresentationDescriptor presentationDescriptor = source.CreatePresentationDescriptor())
            {
                

                // Create an empty topology. 
                Topology topology = Topology.Create();

                // Use the presentation descriptor to enumerate the stream descriptors. 
                // For each stream, create the topology nodes and add them to the topology.
                for (int i = 0; i < presentationDescriptor.StreamDescriptorCount; i++)
                    this.AddBranchToPartialTopology(source, presentationDescriptor, topology, i);

                return topology;
            }
        }

        private void AddBranchToPartialTopology(MediaSource source, PresentationDescriptor presentationDescriptor, Topology topology, int streamIndex)
        {
            // Retrieves a stream descriptor for a stream in the presentation. 
            // The stream descriptor contains information about the stream.
            bool selected;
            using (StreamDescriptor streamDescriptor = presentationDescriptor.GetStreamDescriptor(streamIndex, out selected))
            {
                if (!selected)
                    return;

                // Get the media type handler for the stream.
                using (MediaTypeHandler handler = streamDescriptor.GetMediaTypeHandler())
                {
                    // Get the major media type.
                    Guid majorType = handler.MajorType;
                    this.AddBranchToPartialTopology(topology, source, presentationDescriptor, streamDescriptor, majorType);
                }
            }
        }

        private void AddBranchToPartialTopology(Topology topology, MediaSource source, PresentationDescriptor presentationDescriptor, StreamDescriptor streamDescriptor, Guid majorType)
        {
            // Based on the media type, create the topology for the stream.
            StreamTopologyBuilder builder;
            this.StreamBuilders.TryGetValue(majorType, out builder);
            if (builder == null)
                return;
            builder.AddBranchToPartialTopology(topology, source, presentationDescriptor, streamDescriptor);
        }
    }
}
