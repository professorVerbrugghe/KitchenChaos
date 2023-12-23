using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour {


    public Vector2 GetMovementVectorNormalised() {
        //initialize input vector
        Vector2 inputVector = new Vector2(0, 0);

        //calculate input vector with input
        if (Input.GetKey(KeyCode.W)) {
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
        return inputVector;

    }
}