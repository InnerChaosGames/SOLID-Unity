using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.SingleResponsibility
{
    // If we have multiple input systems we can listen to all of them here 
    public class PlayerInput : MonoBehaviour
    {
        public float Horizontal { get; private set; }
        public float Vertical { get; private set; }
        public bool FireWeapons { get; private set; }
        public Vector2 MousePosition { get; private set; }

        public event Action OnFire;

        // Update is called once per frame
        void Update()
        {
            MousePosition = Input.mousePosition;
            Horizontal = Input.GetAxis("Horizontal");
            Vertical = Input.GetAxis("Vertical");
            FireWeapons = Input.GetButtonDown("Fire1");
            if (FireWeapons)
            {
                OnFire?.Invoke();
            }
        }
    }
}