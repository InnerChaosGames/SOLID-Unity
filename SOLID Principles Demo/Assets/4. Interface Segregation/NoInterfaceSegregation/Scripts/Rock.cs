using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.NoInterfaceSegregation
{
    public class Rock : MonoBehaviour, IEntity
    {
        [field: SerializeField]
        public string Name { get; private set; }
        [field: SerializeField]
        public int Health { get; private set; }
        [field: SerializeField]
        public int MaxHealth { get; private set; }
        [field: SerializeField]
        public float MoveSpeed { get; private set; }
        [field: SerializeField]
        public string Dialogue { get; private set; }

        public void TakeDamage(int damageToDeal)
        {
            Health -= damageToDeal;
            Debug.Log(Name + " Remaining Health: " + Health);
        }

        public void Move(Vector3 position)
        {
            // Rock doesn't move
        }

        public void Talk()
        {
            // Rock doesn't Talk
        }
    }
}