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
}
