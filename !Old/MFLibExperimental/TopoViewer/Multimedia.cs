using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TopoViewer
{
    public static class Multimedia
    {
        public static TResult ExecuteMtaThreaded<TResult>(Func<TResult> action)
            where TResult : class
        {
            Contract.RequiresNotNull(action, "action");

            // If the current thread is already an MTA thread, no need to create a new thread.
            if (Thread.CurrentThread.GetApartmentState() == ApartmentState.MTA)
                return action();

            TResult result = null;
            Thread thread = new Thread(() => Volatile.Write(ref result, action()));

            // MUST BE MTA thread. All MF COM stuff is MTA!
            thread.SetApartmentState(ApartmentState.MTA);

            // Make it more debuggable.
            thread.Name = "Multimedia Helper Thread";

            // Start the worker thread.
            thread.Start();

            // Wait for the thread to start and finish.
            thread.Join();

            // Return the result. 
            TResult tmp = Volatile.Read(ref result);
            Volatile.Write(ref result, null);
            return tmp;
        }

        public static void ExecuteMtaThreaded(Action action)
        {
            Contract.RequiresNotNull(action, "action");
            Multimedia.ExecuteMtaThreaded<object>(() => { action(); return null; });
        }
    }
}
