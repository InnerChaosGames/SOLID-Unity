using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IEntity
{
    public string Name { get; }

    public int Health { get; private set; }

    public int MaxHealth { get; }

    public float MoveSpeed { get; }

    private Vector2 pos;

    public void DealDamage(int damageToDeal)
    {
        Health -= damageToDeal;
    }

    public void Move(Vector2 position)
    {
        pos = position;
    }

    private void Update()
    {
        var step = MoveSpeed * Time.deltaTime;
        Vector2.MoveTowards(transform.position, pos, step);
    }
}
