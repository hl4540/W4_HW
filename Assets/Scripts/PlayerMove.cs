using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f; //set a variable for movespeed

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move(KeyCode.W, 0, moveSpeed); //when W key is pressed, player move up
        Move(KeyCode.S, 0, -moveSpeed); //when S key is pressed, ...
        Move(KeyCode.A, -moveSpeed, 0); //...
        Move(KeyCode.D, moveSpeed, 0); //...

    }

    void Move(KeyCode key, float xMove, float yMove) //set a new function with 3 arguments: the key pressed, x velocity, y velocity
    {
        if(Input.GetKey(key)) //if the key pressed
        {
            GetComponent<Rigidbody>().velocity = new Vector3(xMove, yMove,0); //change the velocity llke this
        }
    }
}
