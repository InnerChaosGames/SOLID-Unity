using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.DependencyInversion.ConstructorDI
{
    public interface ICarInput
    {
        void ReadInput();
        float Rotation { get; }
        float Movement { get; }
    }
}