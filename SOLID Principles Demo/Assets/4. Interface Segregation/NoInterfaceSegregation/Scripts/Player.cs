using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.NoInterfaceSegregation
{
    public class Player : MonoBehaviour, IEntity
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
        }

        public void Move(Vector3 position)
        {
            transform.position += position * MoveSpeed;
        }

        public void Talk()
        {
            Debug.Log(Dialogue);
        }

    }
}