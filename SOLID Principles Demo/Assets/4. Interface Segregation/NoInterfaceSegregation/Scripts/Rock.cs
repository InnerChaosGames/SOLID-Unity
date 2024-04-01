using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour, IEntity
{
    public string Name { get; }

    public int Health { get; private set; }

    public int MaxHealth { get; }

    public float MoveSpeed { get; }

    public void DealDamage(int damageToDeal)
    {
        throw new System.NotImplementedException();
    }

    public void Move(Vector2 position)
    {
        throw new System.NotImplementedException();
    }
}
