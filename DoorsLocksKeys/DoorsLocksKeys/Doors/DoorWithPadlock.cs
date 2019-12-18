using DoorsLocksKeys.Interfaces;
using DoorsLocksKeys.Locks;

namespace DoorsLocksKeys.Doors
{
    public class DoorWithPadlock : IDoor
    {
        private PadLock _padlock;

        public DoorWithPadlock(PadLock padlock)
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
