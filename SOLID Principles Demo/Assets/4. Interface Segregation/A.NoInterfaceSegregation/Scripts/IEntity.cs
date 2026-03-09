using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.NoInterfaceSegregation
{
    public interface IEntity
    {
        string Name { get; }
        int Health { get; }
        int MaxHealth { get; }
        float MoveSpeed { get; }
        string Dialogue { get; }

        void TakeDamage(int damageToDeal);

        void Move(Vector3 position);

        void Talk();
    }
}