using MediaFoundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopoViewer.Framework
{
    public class AudioStreamTopologyBuilder : StreamTopologyBuilder
    {
        protected override Activate CreateMediaSinkActivate()
        {
            return Activate.CreateAudioRendererActivate();
        }

        public override Guid MajorType
        {
            get { return MFMediaType.MajorType.Audio; }
        }
    }
}
