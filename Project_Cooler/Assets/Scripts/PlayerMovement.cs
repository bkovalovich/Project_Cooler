using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;    
    private Vector2 moveDirection = Vector2.zero;
    private PlayerInputActions playerInputActions;//Unity generated script
    private InputAction move;//function from PlayerInputActions

    public Animator animator;

    private void Awake() {
        playerInputActions = new PlayerInputActions();
    }
    private void OnEnable() {
        move = playerInputActions.Player.Move;//Sets move to the Move function in PlayerInputActions
        move.Enable();
    }
    private void OnDisable() {
        move.Disable(); 
    }
    private void Update() {
        moveDirection = move.ReadValue<Vector2>();//Automatically reads inputs 

        animator.SetFloat("Horizontal", moveDirection.x);
        animator.SetFloat("Vertical", moveDirection.y);
        animator.SetFloat("Speed", moveDirection.sqrMagnitude); 
    }
    private void FixedUpdate() {
        //KINEMATIC: rb.velocity = new Vector2(moveDirection.x * moveSpeed * Time.fixedDeltaTime, moveDirection.y * moveSpeed * Time.fixedDeltaTime);
        //DYNAMIC
        rb.AddForce(moveDirection * moveSpeed * Time.deltaTime);
    }
    private void LateUpdate() {
        if (moveDirection.sqrMagnitude > 0) {
            animator.SetFloat("LastHorizontal", moveDirection.x);
            animator.SetFloat("LastVertical", moveDirection.y);
        }
    }
}
