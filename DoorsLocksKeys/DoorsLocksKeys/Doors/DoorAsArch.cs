using DoorsLocksKeys.Interfaces;
using System;

namespace DoorsLocksKeys.Doors
{
    public class DoorAsArch : IDoor
    {
        public void Enter()
        {
            Console.WriteLine("No door. Free entry");
        }
    }
}
