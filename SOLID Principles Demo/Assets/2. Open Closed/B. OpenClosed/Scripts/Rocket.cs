using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.OpenClosed
{
    public class Rocket : MonoBehaviour
    {
        [SerializeField]
        private float speed = 20;
        private Transform target;

        public void SetTarget(Transform target)
        {
            this.target = target;
        }

        private void Update()
        {
            var dirToTarget = (target.transform.position - transform.position).normalized;
            transform.position += dirToTarget * Time.deltaTime * speed;
        }
    }
}