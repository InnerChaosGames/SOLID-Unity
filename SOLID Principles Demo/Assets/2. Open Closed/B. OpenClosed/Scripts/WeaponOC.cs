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
        private Transform projectileSpawnPosition;

        private ILauncher launcher;

        public Transform SpawnPos { get => projectileSpawnPosition; }

        private void Awake()
        {
            launcher = GetComponent<ILauncher>();
        }

        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
                Fire();
        }

        private void Fire()
        {
            launcher.Launch(this);
        }   
    }
}