using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Set IsWalking boolean for animator
/// </summary>

public class PlayerAnimator : MonoBehaviour {

    private Animator Animator;
    [SerializeField] private Player player;

    private const string IS_WALKING = "IsWalking";

    private void Awake() {
        //initialise animator
        Animator = GetComponent<Animator>();
    }

    private void Update() {
        //set value for IsWalking for animator
        Animator.SetBool(IS_WALKING, player.IsWalking());
    }
}
