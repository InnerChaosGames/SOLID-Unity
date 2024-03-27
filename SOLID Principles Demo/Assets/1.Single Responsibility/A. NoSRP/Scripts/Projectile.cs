using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.SingleResponsibility
{
    public class Projectile : MonoBehaviour
    {
        [SerializeField]
        private int damage;

        public int Damage { get => damage; }
    }
}