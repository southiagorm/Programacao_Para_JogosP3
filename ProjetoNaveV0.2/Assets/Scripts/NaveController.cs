using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveController : MonoBehaviour
{
    public float speed = 1f;
    private float _h, _v;

    public GameObject prefabLaser;

    private Rigidbody2D _rb2dBody;

    // Start is called before the first frame update
    void Start()
    {
        _rb2dBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        _h = Input.GetAxisRaw("Horizontal");
        _v = Input.GetAxisRaw("Vertical");

        //print(Time.deltaTime);

        //transform.Translate(_h*speed*Time.deltaTime,_v*speed*Time.deltaTime,0);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(prefabLaser, (transform.position + new Vector3(0,1,0)), Quaternion.identity);
        }

    }

    void FixedUpdate()
    {
        print(Time.deltaTime);
        _rb2dBody.MovePosition(_rb2dBody.position + (new Vector2(_h,_v)*speed*Time.deltaTime));
    }
}
