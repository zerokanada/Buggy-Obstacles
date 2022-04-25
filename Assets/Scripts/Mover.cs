using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mover : MonoBehaviour
{


    
    [SerializeField] float moveSpeed=6f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions ();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions () {
        Debug.Log("Welcome to the Game.");
        Debug.Log("Move with the arrow keys or WASD.");
        Debug.Log("Circle the circuit avoiding the obstacles.");
    }

    void MovePlayer(){
        //get user input
        //multiply by Time.deltaTime to make framerate independent.
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);    
    }
}
