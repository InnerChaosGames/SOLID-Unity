using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.DependencyInversion.InspectorDI
{
    public class KeyboardInput : MonoBehaviour, ICarInput
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