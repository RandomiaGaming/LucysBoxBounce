using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerS : MonoBehaviour
{
    public Vector2 JumpForce;
    private Rigidbody2D rb;
    public WallChecker bottom;
    public WallChecker left;
    public WallChecker right;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") == 1 && right.Walled)
        {
            if (rb.velocity.y < 2)
            {
                rb.velocity = new Vector2(JumpForce.x * -1, 2);
            }else
            {
                rb.velocity = new Vector2(JumpForce.x * -1, rb.velocity.y);
            }
        }else if (Input.GetAxisRaw("Horizontal") == -1 && left.Walled)
        {
            if (rb.velocity.y < 2)
            {
                rb.velocity = new Vector2(JumpForce.x, 2);
            }
            else
            {
                rb.velocity = new Vector2(JumpForce.x, rb.velocity.y);
            }
        }
        else if (Input.GetAxisRaw("Vertical") == -1 && bottom.Walled)
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpForce.y);
        }
    }
}
