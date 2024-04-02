using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementf : MonoBehaviour
{
    [SerializeField]
    private float changeDirectionTime = 2;
    private IEntity entity;

    private bool goUp;
    private float currentTime = 0;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        entity = GetComponent<IEntity>();

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
        entity.Move(direction);
    }
}
