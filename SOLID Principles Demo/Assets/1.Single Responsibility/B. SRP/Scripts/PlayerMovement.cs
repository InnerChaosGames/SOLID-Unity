using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.SingleResponsibility
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField]
        private float speed = 3;

        private PlayerInput playerInput;

        private void Awake()
        {
            playerInput = GetComponent<PlayerInput>();
        }

        private void Update()
        {
            Vector3 movement = new Vector2(playerInput.Horizontal, playerInput.Vertical);
            transform.position += movement * Time.deltaTime * speed;
        }
    }
}