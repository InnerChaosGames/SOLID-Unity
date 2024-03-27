using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.NoOpenClosed
{
    public class Bullet : MonoBehaviour
    {
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
    }
}