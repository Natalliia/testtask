using DoorsLocksKeys.Doors;
using DoorsLocksKeys.Locks;
using System;

namespace DoorsLocksKeys
{
    class Program
    {
        static void Main(string[] args)
        {            
            DoorWithCodeLock doorHavingCodeLock = new DoorWithCodeLock(new CodeLock());
            doorHavingCodeLock.Enter();
                        
            DoorWithMortiseLock doorHavingMortiseLock = new DoorWithMortiseLock(new MortiseLock());
            doorHavingMortiseLock.Enter();
                        
            DoorWithPadLock doorHavingPadLock = new DoorWithPadLock(new PadLock());
            doorHavingPadLock.Enter();
                        
            DoorAsArch noDoor = new DoorAsArch();
            noDoor.Enter();

            Console.ReadKey();
        }
    }
}
