using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class fimdonivel : MonoBehaviour
{
    
    
    
    public void endOFgame()
    {
        Debug.Log("INDO PRA SALA");

        //Application.Quit();

        SceneManager.LoadScene("010");

    }
}
