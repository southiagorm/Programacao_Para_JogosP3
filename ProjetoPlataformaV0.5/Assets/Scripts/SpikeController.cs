using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //other.GetComponent<LifeController>().DecrementarLife(1);
            LifeController.instance.DecrementarLife(1);
        }
    }
}
