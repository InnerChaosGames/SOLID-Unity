using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.DependencyInversion
{
    public class KeyboardInput : ICarInput
    {
        public float Rotation { get; private set; }

        public float Movement { get; private set; }

        public void ReadInput()
        {
            Rotation = Input.GetAxis("Horizontal");
            Movement = Input.GetAxis("Vertical");
        }
    }
}