using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour {

    private Animator Animator;
    [SerializeField] private Player player;

    private const string IS_WALKING = "IsWalking";

    private void Awake() {
        Animator = GetComponent<Animator>();
    }

    private void Update() {
        Animator.SetBool(IS_WALKING, player.IsWalking());
    }
}
