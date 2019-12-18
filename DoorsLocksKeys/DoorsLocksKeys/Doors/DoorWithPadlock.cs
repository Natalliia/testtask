using DoorsLocksKeys.Interfaces;
using DoorsLocksKeys.Locks;

namespace DoorsLocksKeys.Doors
{
    public class DoorWithPadLock : IDoor
    {
        private PadLock _padlock;

        public DoorWithPadLock(PadLock padlock)
        {
            _padlock = padlock;
        }

        public void Enter()
        {
            _padlock.InsertKey();
            _padlock.RotateKey();
            _padlock.RemoveLock();
        }
    }
}
