using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.SingleResponsibility
{
    // On top of this we can add animations, sound effects, UI, etc...
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private float speed = 3f;
        [SerializeField]
        private Transform gunPivot;
        [SerializeField]
        private Transform projectileSpawnPos;
        //[SerializeField]
        //private Transform projectileSpawnPos2;
        [SerializeField]
        private Rigidbody2D projectilePrefab;
        [SerializeField]
        private float projectileForce = 300;
        [SerializeField]
        private int maxHealth = 100;
        [SerializeField]
        private ParticleSystem deathParticlesPrefab;

        private int currentHealth;
        private Camera camera;

        private void Awake()
        {
            camera = Camera.main;
            currentHealth = maxHealth;
        }

        // Update is called once per frame
        void Update()
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");
            Vector3 movement = new Vector2(x, y);
            transform.position += movement * Time.deltaTime * speed;

            Vector2 dir = camera.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            gunPivot.rotation = rotation;

            if (Input.GetButtonDown("Fire1"))
            {
                FireGun();
            }
        }

        private void FireGun()
        {
            var newProjectile = Instantiate(projectilePrefab, projectileSpawnPos.position, projectileSpawnPos.transform.rotation);
            newProjectile.velocity = newProjectile.transform.right * projectileForce;
            //var newProjectile2 = Instantiate(projectilePrefab, projectileSpawnPos2.position, projectileSpawnPos2.transform.rotation);
            //newProjectile.velocity = newProjectile.transform.right * projectileForce;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            var projectile = collision.GetComponent<Projectile>();
            if (projectile != null)
            {
                TakeDamage(projectile.Damage);
                print("Remaining Health: " + currentHealth);
            }
        }

        private void TakeDamage(int damage)
        {
            currentHealth -= damage;
            if (currentHealth <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            Instantiate(deathParticlesPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}