using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.LiskovSubstitution
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField]
        private Transform projectileSpawnPosition;

        [SerializeField]
        private Bullet bulletPrefab;
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
            Bullet bullet = Instantiate(bulletPrefab, projectileSpawnPosition.position, projectileSpawnPosition.rotation);
            bullet.Launch(projectileSpawnPosition.right);
        }
    }
}