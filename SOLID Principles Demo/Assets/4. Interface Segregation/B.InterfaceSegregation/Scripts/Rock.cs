using SOLID.InterfaceSegregation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.InterfaceSegregation
{
    public class Rock : MonoBehaviour, IHaveHealth
    {
        [field: SerializeField]
        public int Health { get; private set; }

        [field: SerializeField]
        public int MaxHealth { get; private set; }

        public void TakeDamage(int damageToDeal)
        {
            Health -= damageToDeal;
            Debug.Log("Rock" + " Remaining Health: " + Health);
        }
    }
}