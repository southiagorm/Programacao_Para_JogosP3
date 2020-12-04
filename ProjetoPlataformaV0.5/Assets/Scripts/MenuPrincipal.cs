using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    public void IniciarJogo()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
