using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.DependencyInversion
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

        public float TurnSpeed { get => turnSpeed; }
        public float MoveSpeed { get => moveSpeed; }
        public bool UseConstantInput { get => constantController; }
    }
}