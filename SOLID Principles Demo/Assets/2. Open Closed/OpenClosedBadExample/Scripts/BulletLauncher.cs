using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.OpenClosed
{
    public class BulletLauncher : MonoBehaviour, ILauncher
    {
        [SerializeField]
        private Bullet bulletPrefab;

        public void Launch(WeaponOC weapon)
        {
            Bullet bullet = Instantiate(bulletPrefab, weapon.SpawnPos.position, weapon.SpawnPos.rotation);
            bullet.Launch(transform.right);
        }
    }
}