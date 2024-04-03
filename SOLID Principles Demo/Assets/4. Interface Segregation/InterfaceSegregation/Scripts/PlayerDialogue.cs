using SOLID.InterfaceSegregation;
using SOLID.NoInterfaceSegregation;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDialogue : MonoBehaviour
{
    [SerializeField]
    private LayerMask layerMask;

    ICanTalk player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<ICanTalk>();
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
            ICanTalk other = collider.GetComponent<ICanTalk>();
            other?.Talk();
        }
    }
}

public class A
{ 
    public event Action bMethod;

    public void AMethod()
    {
        Console.WriteLine("A Method");
        bMethod?.Invoke();
    }
}

public class B
{
    public B(A a)
    {
        a.bMethod += BMethod;
    }

    public void BMethod() 
    {
        Console.WriteLine("B Method"); 
    }
}