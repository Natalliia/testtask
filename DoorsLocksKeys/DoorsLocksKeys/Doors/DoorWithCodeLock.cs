using DoorsLocksKeys.Interfaces;
using DoorsLocksKeys.Locks;

namespace DoorsLocksKeys.Doors
{
    public class DoorWithCodeLock : IDoor
    {
        private CodeLock _codeLock;

        public DoorWithCodeLock(CodeLock codeLock)
        {
            _codeLock = codeLock;
        }

        public void Enter()
        {
            _codeLock.EnterCode();
        }
    }
}
