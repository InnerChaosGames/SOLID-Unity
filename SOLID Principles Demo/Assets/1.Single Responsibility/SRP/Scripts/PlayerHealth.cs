using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.SingleResponsibility
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField]
        private int maxHealth = 100;

        private int currentHealth;

        public event Action OnDeath;

        private void Awake()
        {
            currentHealth = maxHealth;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            var projectile = collision.GetComponent<Projectile>();
            if (projectile != null)
            {
                TakeDamage(projectile.Damage);
                print("Remaining Health: " + currentHealth);
            }
        }

        private void TakeDamage(int damage)
        {
            currentHealth -= damage;
            if (currentHealth <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            // Sends an event that is listened to by the particle system
            // If we don't have a particle system, we don't get null reference exception
            OnDeath?.Invoke();
            Destroy(gameObject);
        }
    }
}