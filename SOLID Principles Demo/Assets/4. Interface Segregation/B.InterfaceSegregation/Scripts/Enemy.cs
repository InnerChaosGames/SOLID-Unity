using SOLID.InterfaceSegregation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.InterfaceSegregation
{
    public class Enemy : MonoBehaviour, ICanTalk, IHaveHealth, ICanMove
    {
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
            Debug.Log("Enemy" + " Remaining Health: " + Health);

        }

        public void Move(Vector3 position)
        {
            transform.position += position;
        }

        public void Talk()
        {
            Debug.Log(Dialogue);
        }
    }
}