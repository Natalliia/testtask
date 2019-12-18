using System;

namespace DoorsLocksKeys.Locks
{
    public class PadLock
    {
        public void InsertKey()
        {
            Console.WriteLine("Key is inserted into the lock");
        }

        public void RotateKey()
        {
            Console.WriteLine("Key is rotated in the lock");
        }

        public void RemoveLock()
        {
            Console.WriteLine("Key is removed form the lock");
            Console.WriteLine("Door is opened");
        }
    }
}
