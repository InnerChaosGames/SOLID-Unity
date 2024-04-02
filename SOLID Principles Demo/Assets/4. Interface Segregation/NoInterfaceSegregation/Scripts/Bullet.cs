using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;
    [SerializeField]
    private int damage;

    private Vector3 direction;

    public void Launch(Vector3 direction)
    {
        this.direction = direction;
    }

    private void Update()
    {
        transform.position += direction * Time.deltaTime * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var entity = collision.GetComponent<IEntity>();
        entity.TakeDamage(damage);
        Destroy(gameObject);
    }
}
