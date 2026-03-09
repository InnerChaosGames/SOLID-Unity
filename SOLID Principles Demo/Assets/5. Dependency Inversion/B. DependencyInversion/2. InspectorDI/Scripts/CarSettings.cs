using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.DependencyInversion.InspectorDI
{
    [CreateAssetMenu(menuName = "Car/SettingsSimple", fileName = "CarSettingsSimple")]
    public class CarSettings : ScriptableObject
    {
        [SerializeField]
        private float turnSpeed = 120;
        [SerializeField]
        private float moveSpeed = 10f;

        public float TurnSpeed => turnSpeed;
        public float MoveSpeed => moveSpeed;
    }
}