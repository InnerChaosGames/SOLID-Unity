using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.NoLiskovSubstitution
{
    public class Character : MonoBehaviour
    {
        [SerializeField]
        private int maxHealth = 100;

        private int currentHealth;

        // Start is called before the first frame update
        void Start()
        {
            currentHealth = maxHealth;
        }

        public void TakeDamage(int amount)
        {
            currentHealth -= amount;
            print(gameObject.name + " CurrentHealth: " + currentHealth);
        }
    }
}