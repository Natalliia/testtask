using DoorsLocksKeys.Interfaces;

namespace DoorsLocksKeys.Doors
{
    public class DoorWithPadLock : IDoor
    {
        private IPadLock _padlock;

        public DoorWithPadLock(IPadLock padlock)
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
