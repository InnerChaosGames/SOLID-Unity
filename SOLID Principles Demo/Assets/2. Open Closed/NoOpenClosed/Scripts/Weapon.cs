using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.NoOpenClosed
{
    public enum ProjectileType { Bullet, Rocket }

    public class Weapon : MonoBehaviour
    {
        [SerializeField]
        private Transform projectileSpawnPosition;

        [SerializeField]
        private Bullet bulletPrefab;
        [SerializeField]
        private Rocket rocketPrefab;

        [SerializeField]
        ProjectileType projectileType;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Fire();
            }
        }

        private void Fire()
        {
            if (projectileType == ProjectileType.Bullet)
            {
                Bullet bullet = Instantiate(bulletPrefab, projectileSpawnPosition.position, projectileSpawnPosition.rotation);
                bullet.Launch(transform.right);
            }
            else if (projectileType == ProjectileType.Rocket)
            {
                Transform target = GameObject.FindGameObjectWithTag("Enemy").transform;
                var rocket = Instantiate(rocketPrefab, projectileSpawnPosition.position, projectileSpawnPosition.rotation);
                rocket.SetTarget(target);
            }
        }
    }
}