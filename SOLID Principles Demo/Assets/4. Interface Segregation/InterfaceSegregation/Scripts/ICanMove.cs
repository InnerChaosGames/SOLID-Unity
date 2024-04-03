using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.InterfaceSegregation
{
    public interface ICanMove 
    {
        float MoveSpeed { get; }

        void Move(Vector3 position);
    }
}