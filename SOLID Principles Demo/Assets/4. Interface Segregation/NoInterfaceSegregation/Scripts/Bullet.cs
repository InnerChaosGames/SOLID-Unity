using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var entity = collision.GetComponent<IEntity>();
        entity.DealDamage(damage);
        Destroy(gameObject);
    }
}
