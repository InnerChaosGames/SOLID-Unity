using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.NoLiskovSubstitution
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField]
        private int damage = 10;
        [SerializeField]
        private float speed = 20;
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
            Character character = collision.GetComponent<Character>();

            if (character is Enemy)
            {
                character.TakeDamage(damage);
            }
            else if (character is NPC)
            {
                // NPC only take half the damage
                character.TakeDamage(damage / 2);
            }

            Destroy(gameObject);
        }
    }
}