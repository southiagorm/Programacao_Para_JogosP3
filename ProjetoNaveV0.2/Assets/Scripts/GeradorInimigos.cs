using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorInimigos : MonoBehaviour
{
    public GameObject prefabInimigo;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GerarInimigo", 1, 2);
    }

    public void GerarInimigo()
    {
        float x = Random.Range(-10,11);

        Vector2 newPosition = new Vector2(x,transform.position.y);

        Instantiate(prefabInimigo, newPosition, Quaternion.identity);
    }
}
