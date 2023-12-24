using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour {

    private PlayerInputActions playerInputActions;

    private void Awake() {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
    }

    public Vector2 GetMovementVectorNormalised() {
        //initialize input vector
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();
        //calculate input vector with input

        //normalize vector
        inputVector = inputVector.normalized;
        return inputVector;

    }
}