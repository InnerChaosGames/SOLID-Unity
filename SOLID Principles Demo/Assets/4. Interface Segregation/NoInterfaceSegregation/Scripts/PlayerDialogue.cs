using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.NoInterfaceSegregation
{
    public class PlayerDialogue : MonoBehaviour
    {
        [SerializeField]
        private LayerMask layerMask;

        IEntity player;

        // Start is called before the first frame update
        void Start()
        {
            player = GetComponent<IEntity>();
        }



        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Dialogue();
            }

        }

        public void Dialogue()
        {
            player.Talk();
            var collider = Physics2D.OverlapCircle(transform.position, 10, layerMask);
            //print(collider);
            if (collider != null)
            {
                IEntity entity = collider.GetComponent<IEntity>();
                entity.Talk();
            }
        }
    }
}