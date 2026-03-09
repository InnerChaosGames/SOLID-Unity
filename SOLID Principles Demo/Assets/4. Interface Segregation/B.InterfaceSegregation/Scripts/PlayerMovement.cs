using SOLID.InterfaceSegregation;
using SOLID.NoInterfaceSegregation;
using SOLID.SingleResponsibility;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.InterfaceSegregation
{
    public class PlayerMovement : MonoBehaviour
    {
        private ICanMove movement;

        private PlayerInput input;

        // Start is called before the first frame update
        protected void Start()
        {
            input = GetComponent<PlayerInput>();
            movement = GetComponent<ICanMove>();
        }

        // Update is called once per frame
        void Update()
        {
            float x = input.Horizontal;
            float y = input.Vertical;
            Vector3 dir = new Vector2(x, y) * Time.deltaTime;

            movement.Move(dir);
        }
    }
}