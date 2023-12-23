using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// Player movement script
/// </summary>

public class Player : MonoBehaviour
    {
    [Tooltip("Multiplies with the transform.position to calculate the speed of the player. Normalized.")]
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotateSpeed;

    private void Update() {

        //initialize input vector
        Vector2 inputVector = new Vector2(0, 0); 

        //calculate input vector with input
        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y = +1;
        }
        if (Input.GetKey(KeyCode.S)) {
            inputVector.y = -1;
        }
        if (Input.GetKey(KeyCode.A)) { 
            inputVector.x = -1;
        }
        if (Input.GetKey(KeyCode.D)) {
            inputVector.x = 1;
        }

        //normalize vector
        inputVector = inputVector.normalized;
        //vector 2 --> vector 3
        Vector3 moveDir = new Vector3 (inputVector.x, 0, inputVector.y);
        //apply vector to position
        transform.position += moveDir * Time.deltaTime * moveSpeed;

        //rotation
        transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * rotateSpeed);
    }
}
