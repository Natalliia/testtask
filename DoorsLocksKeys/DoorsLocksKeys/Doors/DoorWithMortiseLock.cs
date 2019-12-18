using DoorsLocksKeys.Interfaces;
using DoorsLocksKeys.Locks;

namespace DoorsLocksKeys.Doors
{
    public class DoorWithMortiseLock : IDoor
    {
        private MortiseLock _mortiseLock;

        public DoorWithMortiseLock(MortiseLock mortiseLock)
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
