using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float jumpForce;
    private Animator anim;
    private float h;

    [SerializeField]
    private bool isGround;
    [SerializeField]
    private Transform grounCheck;
    [SerializeField]
    private LayerMask groundLayer;

    private Rigidbody2D rb2dBody;

    private bool lookRight = true;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb2dBody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {

        isGround = Physics2D.OverlapCircle(grounCheck.position, 0.01f, groundLayer);

        h = Input.GetAxisRaw("Horizontal");

        if (h > 0 && !lookRight)
        {
            Flip();
        }

        if (h < 0 && lookRight)
        { 
            Flip();
        }


        Jump();

        anim.SetFloat("run", Mathf.Abs(h));
        anim.SetFloat("velocityY", rb2dBody.velocity.y);
        anim.SetBool("isGround", isGround);

        //print(rb2dBody.velocity.y);
    }

    void FixedUpdate()
    {
        rb2dBody.velocity = new Vector2(h * speed * Time.deltaTime, rb2dBody.velocity.y);
    }

    public void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGround)
        {
            rb2dBody.velocity = new Vector2(0, jumpForce);
        }
    }

    public void Flip()
    {
        lookRight = !lookRight;
        float tempX = transform.localScale.x * -1;
        transform.localScale = new Vector3(tempX, transform.localScale.y, transform.localScale.z);
    }
}
