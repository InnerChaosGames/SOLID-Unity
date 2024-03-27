using SOLID.OpenClosed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.OpenClosed
{
    public interface ILauncher
    {
        public void Launch(WeaponOC weapon);
    }
}