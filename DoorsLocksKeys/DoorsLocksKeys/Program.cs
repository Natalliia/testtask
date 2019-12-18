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
            Console.WriteLine("---------------------");

            DoorWithMortiseLock doorHavingMortiseLock = new DoorWithMortiseLock(new MortiseLock());
            doorHavingMortiseLock.Enter();
            Console.WriteLine("---------------------");

            DoorWithPadLock doorHavingPadLock = new DoorWithPadLock(new PadLock());
            //DoorWithPadLock doorHavingPadLock = new DoorWithPadLock(new MortiseLock());
            doorHavingPadLock.Enter();
            Console.WriteLine("---------------------");

            DoorAsArch noDoor = new DoorAsArch();
            noDoor.Enter();

            Console.ReadKey();
        }
    }
}
