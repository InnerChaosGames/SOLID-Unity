using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.NoDependencyInversion
{
    public class CarInput : MonoBehaviour
    {
        public float Rotation { get; private set; }
        public float Movement { get; private set; }

        private void Update()
        {
            Rotation = Input.GetAxis("Horizontal");
            Movement = Input.GetAxis("Vertical");
        }

    }
}