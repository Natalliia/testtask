using DoorsLocksKeys.Interfaces;

namespace DoorsLocksKeys.Doors
{
    public class DoorWithCodeLock : IDoor
    {
        private ICodeLock _codeLock;

        public DoorWithCodeLock(ICodeLock codeLock)
        {
            _codeLock = codeLock;
        }

        public void Enter()
        {
            _codeLock.EnterCode();
        }
    }
}
