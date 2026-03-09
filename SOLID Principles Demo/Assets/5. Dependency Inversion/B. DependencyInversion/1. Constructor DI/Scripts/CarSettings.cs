using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.DependencyInversion.ConstructorDI
{
    [CreateAssetMenu(menuName = "Car/Settings", fileName = "CarSettings")]
    public class CarSettings : ScriptableObject
    {
        [SerializeField]
        private float turnSpeed = 120;
        [SerializeField]
        private float moveSpeed = 10f;

        [SerializeField]
        private bool constantController;

        public float TurnSpeed => turnSpeed;
        public float MoveSpeed => moveSpeed;
        public bool UseConstantInput => constantController;
    }
}