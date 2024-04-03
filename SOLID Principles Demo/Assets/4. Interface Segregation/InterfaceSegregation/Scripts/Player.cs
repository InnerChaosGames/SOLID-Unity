using SOLID.InterfaceSegregation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.InterfaceSegregation
{
    public class Player : MonoBehaviour, ICanTalk, IHaveHealth, ICanMove
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