using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;
using System.Runtime.InteropServices;
using System.Diagnostics;
using MediaFoundation.Core.Interfaces;
using MediaFoundation.Core.Enums;
using MediaFoundation.Core;
using MediaFoundation.Misc.Classes;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="TopologyNode"/> class implements a wrapper around the
    /// <see cref="IMFTopologyNode"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFTopologyNode"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFTopologyNode"/>:
    /// Represents a node in a topology. The following node types are supported:
    /// <para/>
    /// To create a new node, call the <see cref="MFExtern.MFCreateTopologyNode"/> function.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/01D7EB7C-A3D3-4924-A8EC-A67E9DC17424(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/01D7EB7C-A3D3-4924-A8EC-A67E9DC17424(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class TopologyNode : Attributes<IMFTopologyNode>
    {
        #region Construction

        private TopologyNode(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="TopologyNode"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the TopologyNode's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be concidered void.
        /// </param>
        /// <returns>
        /// A new <see cref="TopologyNode"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static TopologyNode FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            TopologyNode result = new TopologyNode(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Creates a topology node.
        /// </summary>
        /// <param name="nodeType">
        /// The type of node to create, specified as a member of the <see cref="MFTopologyType"/> enumeration.
        /// </param>
        /// <returns>
        /// The new topology node. The caller must release the instance.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/67C32232-09CB-4098-B80B-4B93EE121190(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/67C32232-09CB-4098-B80B-4B93EE121190(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static TopologyNode Create(MFTopologyType nodeType)
        {
            IntPtr ppNode;
            int hr = MFExtern.MFCreateTopologyNode(nodeType, out ppNode);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppNode);
            Debug.Assert(ppNode != IntPtr.Zero);
            return TopologyNode.FromUnknown(ref ppNode);
        }

        /// <summary>
        /// Sets the object associated with this node.
        /// </summary>
        /// <param name="value">
        /// The object to set. Use the value <strong>null</strong> to clear an object that was previous set.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/BBEF706D-A4A0-4FF3-BFDB-8BA39D70617C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BBEF706D-A4A0-4FF3-BFDB-8BA39D70617C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetObject(object value)
        {
            COM com = value as COM;
            object pObject = (com != null) ? com.AccessInterface() : value;
            int hr = this.Interface.SetObject(pObject);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Gets the object associated with this node.
        /// </summary>
        /// <returns>
        /// Returns object associated with this node. The object may need to be cast to the desired interface
        /// and then to a desired wrapper class. The caller must release the instance.
        /// <para/>
        /// Null is returned if there is no object associated with this node.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/039D8009-5E5A-4503-9908-7317BC2BF412(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/039D8009-5E5A-4503-9908-7317BC2BF412(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public ComObject GetObject()
        {
            IntPtr ppObject = IntPtr.Zero;
            int hr = this.Interface.GetObject(out ppObject);
            // E_FAIL: There is no object associated with this node.
            if (hr == COM.E_Fail)
            {
                if (ppObject != IntPtr.Zero)
                    Marshal.Release(ppObject);
                return null;
            }

            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppObject);
            return ComObject.FromUnknown(ref ppObject);
        }

        /// <summary>
        /// Retrieves the node type.
        /// </summary>
        /// <returns>
        /// Returns the node type, specified as a member of the <see cref="MFTopologyType"/> enumeration.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/64B2D2B4-1F00-412D-8188-FA361DC317A1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/64B2D2B4-1F00-412D-8188-FA361DC317A1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MFTopologyType NodeType
        {
            get
            {
                MFTopologyType pType;
                int hr = this.Interface.GetNodeType(out pType);
                COM.ThrowIfNotOK(hr);
                return pType;
            }
        }

        /// <summary>
        /// Retrieves or sets the identifier of the node.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/9C0E5BE9-6481-4132-AD5B-9DB13FB07391(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9C0E5BE9-6481-4132-AD5B-9DB13FB07391(v=VS.85,d=hv.2).aspx</a> and
        /// <a href="http://msdn.microsoft.com/en-US/library/80EFA004-D739-4F9A-9EA3-8BF7D97F0A7D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/80EFA004-D739-4F9A-9EA3-8BF7D97F0A7D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public long TopologyNodeId
        {
            get
            {
                long pID;
                int hr = this.Interface.GetTopoNodeID(out pID);
                COM.ThrowIfNotOK(hr);
                return pID;
            }

            set
            {
                int hr = this.Interface.SetTopoNodeID(value);
                COM.ThrowIfNotOK(hr);
            }
        }

        /// <summary>
        /// Retrieves the number of input streams that currently exist on this node.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/84C079DA-5DE6-4C33-B0C7-5FFD017D5513(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/84C079DA-5DE6-4C33-B0C7-5FFD017D5513(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int InputCount
        {
            get
            {
                int pcInputs;
                int hr = this.Interface.GetInputCount(out pcInputs);
                COM.ThrowIfNotOK(hr);
                return pcInputs;
            }
        }

        /// <summary>
        /// Retrieves the number of output streams that currently exist on this node.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/DC964C38-9DAC-491F-9D70-B1BA7B7001AD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DC964C38-9DAC-491F-9D70-B1BA7B7001AD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int OutputCount
        {
            get
            {
                int pcOutputs;
                int hr = this.Interface.GetOutputCount(out pcOutputs);
                COM.ThrowIfNotOK(hr);
                return pcOutputs;
            }
        }

        /// <summary>
        /// Connects an output stream from this node to the input stream of another node.
        /// </summary>
        /// <param name="outputIndex">
        /// Zero-based index of the output stream on this node.
        /// </param>
        /// <param name="downstreamNode">
        /// The node to connect to.
        /// </param>
        /// <param name="inputIndexOnDownstreamNode">
        /// Zero-based index of the input stream on the other node.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/2340FD87-27EA-4F98-97E3-48B9506251A9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2340FD87-27EA-4F98-97E3-48B9506251A9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void ConnectOutput(int outputIndex, TopologyNode downstreamNode, int inputIndexOnDownstreamNode)
        {
            int hr = this.Interface.ConnectOutput(outputIndex, downstreamNode.AccessInterface(), inputIndexOnDownstreamNode);
            // IMPROVE: May need to handle: E_FAIL - The method failed. ...
            // An output node cannot have any output connections. If you call this method on an output node, the method returns E_FAIL.
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Disconnects an output stream on this node.
        /// </summary>
        /// <param name="outputIndex">
        /// Zero-based index of the output stream to disconnect.
        /// </param>
        /// <returns>
        /// True of the stream was disconnected or false if the specified output stream is not connected to another node.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/77B91797-D9A7-40DA-827D-6E2A347112DC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/77B91797-D9A7-40DA-827D-6E2A347112DC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public bool DisconnectOutput(int outputIndex)
        {
            int hr = this.Interface.DisconnectOutput(outputIndex);
            // MF_E_NOT_FOUND: The specified output stream is not connected to another node.
            if (hr == MFError.MF_E_NOT_FOUND)
                return false;
            COM.ThrowIfNotOK(hr);
            return true;
        }

        /// <summary>
        /// Retrieves the node that is connected to a specified input stream on this node.
        /// </summary>
        /// <param name="inputIndex">
        /// Zero-based index of an input stream on this node.
        /// </param>
        /// <param name="outputIndexOnUpstreamNode">
        /// Receives the index of the output stream that is connected to this node's input stream.
        /// </param>
        /// <returns>
        /// Returns the node that is connected to the specified input stream
        /// or null if the specified input stream is not connected to another node.
        /// The caller must release the interface.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/49969E6D-C893-4F6F-8C1D-87D32405A65D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/49969E6D-C893-4F6F-8C1D-87D32405A65D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public TopologyNode GetInput(int inputIndex, out int outputIndexOnUpstreamNode)
        {
            IntPtr ppUpstreamNode = IntPtr.Zero;
            int hr = this.Interface.GetInput(inputIndex, out ppUpstreamNode, out outputIndexOnUpstreamNode);
            // MF_E_NOT_FOUND: The specified input stream is not connected to another node.
            if (hr == MFError.MF_E_NOT_FOUND)
            {
                if (ppUpstreamNode != IntPtr.Zero)
                    Marshal.Release(ppUpstreamNode);
                return null;
            }

            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppUpstreamNode);
            return TopologyNode.FromUnknown(ref ppUpstreamNode);
        }

        /// <summary>
        /// Retrieves the node that is connected to a specified input stream on this node.
        /// </summary>
        /// <param name="inputIndex">
        /// Zero-based index of an input stream on this node.
        /// </param>
        /// <returns>
        /// Returns the node that is connected to the specified input stream
        /// or null if the specified input stream is not connected to another node.
        /// The caller must release the interface.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/49969E6D-C893-4F6F-8C1D-87D32405A65D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/49969E6D-C893-4F6F-8C1D-87D32405A65D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public TopologyNode GetInput(int inputIndex)
        {
            int na;
            return this.GetInput(inputIndex, out na);
        }

        /// <summary>
        /// Retrieves the node that is connected to a specified output stream on this node.
        /// </summary>
        /// <param name="outputIndex">
        /// Zero-based index of an output stream on this node.
        /// </param>
        /// <param name="inputIndexOnDownstreamNode">
        /// Receives the index of the input stream that is connected to this node's output stream.
        /// </param>
        /// <returns>
        /// Returns the node that is connected to the specified output stream
        /// or null if the specified output stream is not connected to another node.
        /// The caller must release the interface.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/0D947D92-4669-4857-BD61-10FA8EBD2598(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0D947D92-4669-4857-BD61-10FA8EBD2598(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public TopologyNode GetOutput(int outputIndex, out int inputIndexOnDownstreamNode)
        {
            IntPtr ppDownstreamNode = IntPtr.Zero;
            int hr = this.Interface.GetOutput(outputIndex, out ppDownstreamNode, out inputIndexOnDownstreamNode);
            // MF_E_NOT_FOUND: The specified output stream is not connected to another node.
            if (hr == MFError.MF_E_NOT_FOUND)
            {
                if (ppDownstreamNode != IntPtr.Zero)
                    Marshal.Release(ppDownstreamNode);
                return null;
            }

            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppDownstreamNode);
            return TopologyNode.FromUnknown(ref ppDownstreamNode);
        }

        /// <summary>
        /// Retrieves the node that is connected to a specified output stream on this node.
        /// </summary>
        /// <param name="outputIndex">
        /// Zero-based index of an output stream on this node.
        /// </param>
        /// <returns>
        /// Returns the node that is connected to the specified output stream
        /// or null if the specified output stream is not connected to another node.
        /// The caller must release the interface.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/0D947D92-4669-4857-BD61-10FA8EBD2598(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0D947D92-4669-4857-BD61-10FA8EBD2598(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public TopologyNode GetOutput(int outputIndex)
        {
            int na;
            return this.GetOutput(outputIndex, out na);
        }

        /// <summary>
        /// Sets the preferred media type for an output stream on this node.
        /// </summary>
        /// <param name="outputIndex">
        /// Zero-based index of the output stream.
        /// </param>
        /// <param name="type">
        /// The media type.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/948FD64D-E3D8-45DE-AAAB-B052D9F0B9D8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/948FD64D-E3D8-45DE-AAAB-B052D9F0B9D8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetOutputPreferredType(int outputIndex, MediaType type)
        {
            int hr = this.Interface.SetOutputPrefType(outputIndex, type.AccessInterface());
            // E_NOTIMPL: This node is an output node.
            if (hr == COM.E_NotImplemented)
                throw new MediaFoundationException("This node is an output node.", hr);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Retrieves the preferred media type for an output stream on this node.
        /// </summary>
        /// <param name="outputIndex">
        /// Zero-based index of the output stream.
        /// </param>
        /// <returns>
        /// The media type. The caller must release the instance.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/972052CA-1D87-4FA4-ABEB-6E74BA6C9368(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/972052CA-1D87-4FA4-ABEB-6E74BA6C9368(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MediaType GetOutputPreferredType(int outputIndex)
        {
            IntPtr ppType;
            int hr = this.Interface.GetOutputPrefType(outputIndex, out ppType);
            // E_FAIL: This node does not have a preferred output type.
            if (hr == COM.E_Fail)
                return null;
            // E_NOTIMPL: This node is an output node.
            if (hr == COM.E_NotImplemented)
                throw new MediaFoundationException("This node is an output node.", hr);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppType);
            return MediaType.FromUnknown(ref ppType);
        }

        /// <summary>
        /// Sets the preferred media type for an input stream on this node.
        /// </summary>
        /// <param name="inputIndex">
        /// Zero-based index of the input stream.
        /// </param>
        /// <param name="type">
        /// The media type.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/348B3CBA-8C8C-4DF9-8CB9-B69CD140CFFB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/348B3CBA-8C8C-4DF9-8CB9-B69CD140CFFB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetInputPreferredType(int inputIndex, MediaType type)
        {
            int hr = this.Interface.SetInputPrefType(inputIndex, type.AccessInterface());
            if (hr == COM.E_NotImplemented)
                throw new MediaFoundationException("This node is a source node.", hr);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Retrieves the preferred media type for an input stream on this node.
        /// </summary>
        /// <param name="inputIndex">
        /// Zero-based index of the input stream.
        /// </param>
        /// <returns>
        /// The media type or null if this node does not have a preferred input type The caller must release the instace.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/34849803-2B56-457A-920B-B5F2E208CE2E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/34849803-2B56-457A-920B-B5F2E208CE2E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MediaType GetInputPreferredType(int inputIndex)
        {
            IntPtr ppType;
            int hr = this.Interface.GetInputPrefType(inputIndex, out ppType);
            // E_FAIL: This node does not have a preferred input type.
            if (hr == COM.E_Fail)
                return null;
            // E_NOTIMPL: This node is a source node.
            if (hr == COM.E_NotImplemented)
                throw new MediaFoundationException("This node is a source node.", hr);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppType);
            return MediaType.FromUnknown(ref ppType);
        }

        /// <summary>
        /// Copies the data from another topology node into this node.
        /// </summary>
        /// <param name="node">
        /// The node to copy into this node.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/90322FBC-E3DE-4801-B10B-63CE538FC83F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/90322FBC-E3DE-4801-B10B-63CE538FC83F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void CloneFrom(TopologyNode node)
        {
            int hr = this.Interface.CloneFrom(node.AccessInterface());
            // MF_E_INVALIDREQUEST: The node types do not match.
            if (hr == MFError.MF_E_INVALIDREQUEST)
                throw new MediaFoundationException("The node types do not match.", hr);
            COM.ThrowIfNotOK(hr);
        }
    }
}
