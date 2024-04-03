using SOLID.InterfaceSegregation;
using SOLID.NoInterfaceSegregation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.InterfaceSegregation
{
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
            var healthEntity = collision.GetComponent<IHaveHealth>();
            healthEntity.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}