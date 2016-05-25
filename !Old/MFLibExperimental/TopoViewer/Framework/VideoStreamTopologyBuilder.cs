using MediaFoundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopoViewer.Framework
{
    public class VideoStreamTopologyBuilder : StreamTopologyBuilder
    {
        protected readonly IntPtr WindowHandle;

        public VideoStreamTopologyBuilder()
            : this(IntPtr.Zero)
        {
        }

        public VideoStreamTopologyBuilder(IntPtr windowHandle)
        {
            this.WindowHandle = windowHandle;
        }

        protected override Activate CreateMediaSinkActivate()
        {
            return Activate.CreateVideoRendererActivate(this.WindowHandle);
        }

        public override Guid MajorType
        {
            get { return MFMediaType.MajorType.Video; }
        }
    }
}
