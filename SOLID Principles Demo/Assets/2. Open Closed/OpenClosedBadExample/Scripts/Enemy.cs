using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.OpenClosed
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField]
        private float upMax = 3f;
        [SerializeField]
        private float downMax = -3f;
        [SerializeField]
        private float moveSpeed;

        private bool goUp;

        // Update is called once per frame
        void Update()
        {
            if (goUp)
            {
                transform.position += Vector3.up * Time.deltaTime * moveSpeed;
                if (transform.position.y >= upMax)
                {
                    goUp = !goUp;
                }
            }
            else
            {
                transform.position += -Vector3.up * Time.deltaTime * moveSpeed;
                if (transform.position.y <= downMax)
                {
                    goUp = !goUp;
                }
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            Destroy(other.gameObject);
        }
    }
}