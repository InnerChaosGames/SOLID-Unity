using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEntity
{
    string Name { get; }
    int Health { get; }
    int MaxHealth { get; }
    float MoveSpeed { get; }

    void DealDamage(int damageToDeal);

    void Move(Vector2 position);
}