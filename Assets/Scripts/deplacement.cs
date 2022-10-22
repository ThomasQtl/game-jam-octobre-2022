using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class deplacement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    Vector2 movement;

    // Start is called before the first frame update
    void Start() 
    {
        movement = new Vector2();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        rb.velocity = movement * moveSpeed;
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        movement = ctx.ReadValue<Vector2>();
        print("test");
    }
}
