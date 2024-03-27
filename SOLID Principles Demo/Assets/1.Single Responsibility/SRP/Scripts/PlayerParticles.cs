using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.SingleResponsibility
{
    public class PlayerParticles : MonoBehaviour
    {
        [SerializeField]
        private ParticleSystem deathParticlesPrefab;

        private PlayerHealth playerHealth;

        private void Awake()
        {
            playerHealth = GetComponent<PlayerHealth>();
            playerHealth.OnDeath += HandlePlayerDeath;
        }

        private void HandlePlayerDeath()
        {
            Instantiate(deathParticlesPrefab, transform.position, Quaternion.identity);
        }

    }
}