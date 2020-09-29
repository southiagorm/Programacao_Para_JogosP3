using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed;

    private Rigidbody2D _rb2dBody;
    // Start is called before the first frame update
    void Start()
    {
        _rb2dBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0,speed*Time.deltaTime,0);
    }

    void FixedUpdate()
    {
        _rb2dBody.MovePosition(_rb2dBody.position + (new Vector2(0,speed * Time.deltaTime)));
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);       
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        print("Acabou de Colidir!");
    }

    void OnCollisionStay2D(Collision2D other)
    {
        print("Stay Collision");
    }

    void OnCollisionExit2D(Collision2D other)
    {
        print("Exit Collision");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //print("Trigger Enter");
        if(other.tag == "EnemyBlack")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        print("Tigger Stay");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        print("Tigger Exit");
    }
}
