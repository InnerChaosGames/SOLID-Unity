using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.NoDependencyInversion
{
    public class CarControl : MonoBehaviour
    {
        [SerializeField]
        private float turnSpeed = 15;
        [SerializeField]
        private float moveSpeed = 10f;

        private CarInput carInput = null;

        private void Awake()
        {
            carInput = GetComponent<CarInput>();
        }

        private void Update()
        {
            float rot = carInput.Rotation;
            float move = carInput.Movement;

            transform.Rotate(Vector3.back * rot * Time.deltaTime * turnSpeed);
            transform.position += transform.up * move * Time.deltaTime * moveSpeed;
        }
    }
}