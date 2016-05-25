using MediaFoundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopoViewer.Framework
{
    public class SessionBuilder
    {
        public MediaSession CreateSession()
        {
            // Create a new instance of the Media Session. 
            // NB: We could create the configuration and set MF_SESSION_GLOBAL_TIME, MF_SESSION_QUALITY_MANAGER,
            // MF_SESSION_TOPOLOADER and MF_LOW_LATENCY, but currently, we are happy with the defaults.
            using (Attributes configuration = null)
            {
                return MediaSession.Create(configuration);
            }
        }
    }
}
