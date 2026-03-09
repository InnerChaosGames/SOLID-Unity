using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.DependencyInversion.InspectorDI
{
    public interface ICarInput
    {
        void ReadInput();
        float Rotation { get; }
        float Movement { get; }
    }
}