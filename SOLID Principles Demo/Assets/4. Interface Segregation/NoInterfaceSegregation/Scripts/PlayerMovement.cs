using SOLID.SingleResponsibility;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private IEntity entity;

    private PlayerInput input;

    // Start is called before the first frame update
    protected void Start()
    {
        input = GetComponent<PlayerInput>();
        entity = GetComponent<IEntity>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = input.Horizontal;
        float y = input.Vertical;
        Vector3 movement = new Vector2(x, y) * Time.deltaTime;

        entity.Move(movement);
    }
}
