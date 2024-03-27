using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.SingleResponsibility
{
    public class ProjectileLauncher : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody2D projectilePrefab;
        [SerializeField]
        private Transform projectileSpawnPos;
        [SerializeField]
        private float projectileForce = 300;

        private PlayerInput input;

        private void Awake()
        {
            input = GetComponent<PlayerInput>();
            input.OnFire += FireProjectile;
        }

        private void FireProjectile()
        {
            var newProjectile = Instantiate(projectilePrefab, projectileSpawnPos.position, projectileSpawnPos.transform.rotation);
            newProjectile.velocity = newProjectile.transform.right * projectileForce;
        }
    }
}