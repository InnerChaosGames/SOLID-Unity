using SOLID.OpenClosed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.OpenClosed
{
    public class RocketLauncher : MonoBehaviour, ILauncher
    {
        [SerializeField]
        private Rocket rocketPrefab;

        public void Launch(WeaponOC weapon)
        {
            Transform target = GameObject.FindGameObjectWithTag("Enemy").transform;
            var rocket = Instantiate(rocketPrefab, weapon.SpawnPos.position, weapon.SpawnPos.rotation);
            rocket.SetTarget(target);
        }
    }
}