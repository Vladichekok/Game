using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }

    [SerializeField]private float moveSpeed = 5f;

    private Rigidbody2D rb;

    private float minMoveSpeed = 0.1f;
    private bool isRunning;

    private void Awake()
    {
        Instance = this;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
      
        HandleMovement();
    }
    private void HandleMovement()
    {
        Vector2 inputVector = GameInput.Instance.GetMovementVector();
        inputVector = inputVector.normalized;
        rb.MovePosition(rb.position + inputVector * (moveSpeed * Time.fixedDeltaTime));
        if (Mathf.Abs(inputVector.x) > minMoveSpeed || Mathf.Abs(inputVector.y) > minMoveSpeed) 
        {
            isRunning = true;
        } else {
            isRunning = false;
        }
    }
    public bool IsRunning()
    {
        return isRunning;
    }

    public Vector3 GetPlayerScreenPosition()
    {
        Vector3 playerScreenPosition = Camera.main.WorldToScreenPoint(transform.position);
        return playerScreenPosition;
    }
}
