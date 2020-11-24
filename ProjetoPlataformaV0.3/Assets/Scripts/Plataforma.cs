using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    [SerializeField]
    private Transform pointA, pointB;
    [SerializeField]
    private float speed;

    private Transform pointAux;
    void Start()
    {
        transform.position = pointA.position;
        pointAux = pointB;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,pointAux.position, speed*Time.deltaTime);

        if(transform.position.y <= pointB.position.y)
        {
            pointAux = pointA;
        }else if(transform.position.y >= pointA.position.y)
        {
            pointAux = pointB;
        }
    }
}
