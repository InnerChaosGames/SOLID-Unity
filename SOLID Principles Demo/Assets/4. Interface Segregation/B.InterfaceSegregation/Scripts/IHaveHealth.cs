using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.InterfaceSegregation
{
    public interface IHaveHealth
    {
        int Health { get; }
        int MaxHealth { get; }

        void TakeDamage(int damageToDeal);
    }
}