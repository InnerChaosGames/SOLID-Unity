using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.DependencyInversion
{
    public interface ICarInput
    {
        void ReadInput();
        float Rotation { get; }
        float Movement { get; }
    }
}