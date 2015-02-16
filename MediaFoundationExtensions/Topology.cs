using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;
using System.Diagnostics;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="Topology"/> class implements a wrapper arround the
    /// <see cref="IMFTopology"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFTopology"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFTopology"/>: 
    /// Represents a topology. A <em>topology</em> describes a collection of media sources, sinks, and
    /// transforms that are connected in a certain order. These objects are represented within the topology
    /// by <em>topology nodes</em>, which expose the <see cref="IMFTopologyNode"/> interface. A topology
    /// describes the path of multimedia data through these nodes. 
    /// <para/>
    /// To create a topology, call <see cref="MFExtern.MFCreateTopology"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/F293E9EE-9BD2-4B3E-A4FF-53457EE910F6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F293E9EE-9BD2-4B3E-A4FF-53457EE910F6(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class Topology : Attributes<IMFTopology>
    {
        #region Construction

        internal Topology(IMFTopology comInterface)
            : base(comInterface)
        {
        }

        #endregion

        /// <summary>
        /// Creates a topology object.
        /// </summary>
        /// <returns>
        /// The topology object. The caller must release the instance. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9811ECA7-E822-4FF7-93E4-2EB6245D4490(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9811ECA7-E822-4FF7-93E4-2EB6245D4490(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static Topology Create()
        {
            IMFTopology topology;
            int hr = MFExtern.MFCreateTopology(out topology);
            COM.ThrowIfNotOK(hr);
            Debug.Assert(topology != null);
            return topology.ToTopology();
        }

        /// <summary>
        /// Gets the identifier of the topology.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F7D33D20-1B58-4B88-9A98-1004A5C42DFA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F7D33D20-1B58-4B88-9A98-1004A5C42DFA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public long GetTopologyId
        {
            get
            {
                long pId;
                int hr = this.Interface.GetTopologyID(out pId);
                COM.ThrowIfNotOK(hr);
                return pId;
            }
        }

        /// <summary>
        /// Adds a node to the topology.
        /// </summary>
        /// <param name="node">
        /// The note to add.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5E519524-F5C5-4D4D-922F-166F9E616631(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5E519524-F5C5-4D4D-922F-166F9E616631(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void AddNode(TopologyNode node)
        {
            int hr = this.Interface.AddNode(node.GetInterface());
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Removes a node from the topology.
        /// </summary>
        /// <param name="node">
        /// The note to remove.
        /// </param>
        /// <returns>
        /// True if the node was removed, otherwise false.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0DBAFD3F-315B-4135-AECD-AD46F2C19886(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0DBAFD3F-315B-4135-AECD-AD46F2C19886(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public bool RemoveNode(TopologyNode node)
        {
            int hr = this.Interface.RemoveNode(node.GetInterface());
            if (hr == COMBase.E_InvalidArgument)
                return false; // E_INVALIDARG: The specified node is not a member of this topology.
            COM.ThrowIfNotOK(hr);
            return true;
        }

        /// <summary>
        /// Gets the number of nodes in the topology. 
        /// </summary>
        /// <returns>
        /// The number of nodes. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/87378088-1D7A-4AD7-942F-69B6CFC4E573(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/87378088-1D7A-4AD7-942F-69B6CFC4E573(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public short NodeCount
        {
            get
            {
                short pwNodes;
                int hr = this.Interface.GetNodeCount(out pwNodes);
                COM.ThrowIfNotOK(hr);
                return pwNodes;
            }
        }

        /// <summary>
        /// Gets a node in the topology, specified by index. 
        /// </summary>
        /// <param name="index">
        /// The zero-based index of the node. To get the number of nodes in the topology, call 
        /// <see cref="NodeCount"/>. 
        /// </param>
        /// <returns>
        /// The node at the given index.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/97053D10-5AC7-40C0-B46B-77D401284D58(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/97053D10-5AC7-40C0-B46B-77D401284D58(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public TopologyNode GetNode(short index)
        {
            IMFTopologyNode ppNode;
            int hr = this.Interface.GetNode(index, out ppNode);
            COM.ThrowIfNotOK(hr);
            return ppNode.ToTopologyNode();
        }

        /// <summary>
        /// Removes all nodes from the topology.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/919A712F-3F1B-4681-9EEB-958AC349D8F6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/919A712F-3F1B-4681-9EEB-958AC349D8F6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void Clear()
        {
            int hr = this.Interface.Clear();
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Converts this topology into a copy of another topology. 
        /// </summary>
        /// <param name="sourceTopology">
        /// The topology to clone from (into this topology). 
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B455AA57-9785-4741-BC3B-1F99CBF4E3D9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B455AA57-9785-4741-BC3B-1F99CBF4E3D9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void CloneFrom(Topology sourceTopology)
        {
            int hr = this.Interface.CloneFrom(sourceTopology.GetInterface());
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Gets a node in the topology, specified by node identifier.
        /// </summary>
        /// <param name="topologyNodeId">
        /// The identifier of the node to retrieve. To get a node's identifier, call 
        /// <see cref="TopologyNode.TopologyNodeId"/>. 
        /// </param>
        /// <returns>
        /// Topology node with the given identifier or null if the topology does not contain a node with this identifier. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/34C8326F-BD34-4BF6-9171-A1ED3191B85E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/34C8326F-BD34-4BF6-9171-A1ED3191B85E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public TopologyNode GetNodeById(long topologyNodeId)
        {
            IMFTopologyNode ppNode;
            int hr = this.Interface.GetNodeByID(topologyNodeId, out ppNode);
            if (hr == MFError.MF_E_NOT_FOUND)
                return null; // MF_E_NOT_FOUND: The topology does not contain a node with this identifier. 
            COM.ThrowIfNotOK(hr);
            return ppNode.ToTopologyNode();
        }

        /// <summary>
        /// Gets the source nodes in the topology. 
        /// </summary>
        /// <returns>
        /// A collection with the source nodes in the topology. The caller must release the collection.
        /// The collection might be empty. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9DA7D4CD-AD83-4D64-9773-699F39625056(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9DA7D4CD-AD83-4D64-9773-699F39625056(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Collection<TopologyNode> GetSourceNode()
        {
            IMFCollection ppCollection;
            int hr = this.Interface.GetSourceNodeCollection(out ppCollection);
            COM.ThrowIfNotOK(hr);
            return ppCollection.ToCollection(e => ((IMFTopologyNode)e).ToTopologyNode(), e => e.GetInterface());
        }

        /// <summary>
        /// Gets the output nodes in the topology. 
        /// </summary>
        /// <returns>
        /// A collection with the output nodes in the topology. The caller must release the collection.
        /// The collection might be empty. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0862CD4A-4D22-4D8D-A754-0CD376D44B22(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0862CD4A-4D22-4D8D-A754-0CD376D44B22(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Collection<TopologyNode> GetOutputNode()
        {
            IMFCollection ppCollection;
            int hr = this.Interface.GetOutputNodeCollection(out ppCollection);
            COM.ThrowIfNotOK(hr);
            return ppCollection.ToCollection(e => ((IMFTopologyNode)e).ToTopologyNode(), e => e.GetInterface());
        }
    }
}
