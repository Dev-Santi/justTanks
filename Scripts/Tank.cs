using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Tank : MonoBehaviour
{
    private Rigidbody2D tank;

    private void Start()
    {
        tank = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        GetInputsAndMoveTank();
    }

    private void GetInputsAndMoveTank()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            tank.velocity = new Vector2Int(2, 0);
            tank.SetRotation(-90);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            tank.velocity = new Vector2Int(-2, 0);
            tank.SetRotation(90);
        }
        else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            tank.velocity = new Vector2Int(0, 2);
            tank.SetRotation(0);
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            tank.velocity = new Vector2Int(0, -2);
            tank.SetRotation(-180);
        }
        else
        {
            tank.velocity = new Vector2(0, 0);
        }
    }
}
