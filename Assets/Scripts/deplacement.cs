using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class deplacement : MonoBehaviour
{
    public float moveSpeed = 5f;
    float xmin = -11f, xmax=11f, ymin = -4f, ymax = 4f;
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
        if(rb.position.x<xmin) rb.position = new Vector2(xmin, rb.position.y);
        if(rb.position.x>xmax) rb.position = new Vector2(xmax, rb.position.y);
        if(rb.position.y<ymin) rb.position = new Vector2(rb.position.x, ymin);
        if(rb.position.y>ymax) rb.position = new Vector2(rb.position.x, ymax);
    }

    void FixedUpdate()
    {
        rb.velocity = movement * moveSpeed;
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        movement = ctx.ReadValue<Vector2>();
    }

}
