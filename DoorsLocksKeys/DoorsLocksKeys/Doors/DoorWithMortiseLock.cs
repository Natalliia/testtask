using DoorsLocksKeys.Interfaces;
using DoorsLocksKeys.Locks;

namespace DoorsLocksKeys.Doors
{
    public class DoorWithMortiseLock : IDoor
    {
        private IMortiseLock _mortiseLock;

        public DoorWithMortiseLock(IMortiseLock mortiseLock)
        {
            _mortiseLock = mortiseLock;
        }

        public void Enter()
        {
            _mortiseLock.InsertKey();
            _mortiseLock.RotateKey();            
        }
    }
}
