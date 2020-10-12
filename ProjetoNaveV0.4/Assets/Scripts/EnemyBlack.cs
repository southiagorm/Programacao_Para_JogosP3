using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlack : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private Vector2 _direction;

    private Rigidbody2D _rb2dBody;
    
    void Start()
    {
        _rb2dBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(transform.position.y <= 0){
            _direction.x = 1;
        }
    }

    void FixedUpdate()
    {
        _rb2dBody.MovePosition(_rb2dBody.position + (_direction*_speed*Time.deltaTime));    
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
