using SOLID.NoOpenClosed;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace SOLID.OpenClosed
{
    public class WeaponOC : MonoBehaviour
    {
        [SerializeField]
        private int weapon;

        [SerializeField]
        private Transform projectileSpawnPosition;

        private List<ILauncher> launcher;

        public Transform SpawnPos { get => projectileSpawnPosition; }

        private void Awake()
        {
            launcher = GetComponents<ILauncher>().ToList();
        }

        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Fire();
            }
        }

        private void Fire()
        {
            if (weapon >= 0 && weapon < launcher.Count)
                launcher[weapon].Launch(this);
        }   
    }
}