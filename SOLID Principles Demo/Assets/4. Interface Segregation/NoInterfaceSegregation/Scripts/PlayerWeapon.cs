using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.InterfaceSegregation
{
    public class PlayerWeapon : MonoBehaviour
    {
        [SerializeField]
        private Transform projectileSpawnPosition;

        [SerializeField]
        private Bullet bulletPrefab;

        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Fire();
            }
        }

        private void Fire()
        {
            Bullet bullet = Instantiate(bulletPrefab, projectileSpawnPosition.position, projectileSpawnPosition.rotation);
            bullet.Launch(projectileSpawnPosition.right);
        }
    }
}