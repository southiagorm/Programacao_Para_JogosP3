using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Power_Up
{
    TRES_TIROS,
    ESCUDO,
    VELOCIDADE
}

public class PowerUp : MonoBehaviour
{
    [SerializeField]
    private Power_Up powerUp;
    [SerializeField]
    private float speed;

    private Rigidbody2D rb2dBody;

    void Start()
    {
        rb2dBody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        rb2dBody.MovePosition(rb2dBody.position + (new Vector2(0,speed*Time.deltaTime)));
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            switch (powerUp)
            {
                case Power_Up.TRES_TIROS:
                    NaveController nave = other.gameObject.GetComponent<NaveController>();
                    nave.IniciarCoroutinaTresTiros();
                    break;

            }
        }
    } 
}
