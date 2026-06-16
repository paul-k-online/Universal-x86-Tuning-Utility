#if !HAS_AUTOOC
namespace AutoOC.Monitors
{
    public class InstabilityMonitor
    {
        public void Stop() { }
    }
}

namespace AutoOC.Controllers
{
    public class AdaptiveUndervoltController : System.IDisposable
    {
        public AdaptiveUndervoltController(
            AutoOC.Monitors.InstabilityMonitor monitor,
            int minOffset = -50,
            int stepSize = 1,
            int stableThreshold = 8,
            int cooldownThreshold = 4,
            bool isIgpu = false)
        {
        }

        public int UpdateOffset() => 0;

        public void RecordAppliedOffset(int offset) { }

        public void Dispose() { }
    }
}
#endif
