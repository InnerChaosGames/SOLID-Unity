using SOLID.NoInterfaceSegregation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.InterfaceSegregation
{
    public class EnemyMovement : MonoBehaviour
    {
        [SerializeField]
        private float changeDirectionTime = 2;
        private ICanMove movingEntity;

        private bool goUp;
        private float currentTime = 0;

        // Start is called before the first frame update
        protected virtual void Start()
        {
            movingEntity = GetComponent<ICanMove>();

        }

        private void Update()
        {
            currentTime += Time.deltaTime;
            if (currentTime > changeDirectionTime)
            {
                goUp = !goUp;
                currentTime = 0;
            }

            Vector2 direction;
            if (goUp)
            {
                direction = Vector2.up * Time.deltaTime;
            }
            else
            {
                direction = Vector2.down * Time.deltaTime;
            }
            movingEntity.Move(direction);
        }
    }
}