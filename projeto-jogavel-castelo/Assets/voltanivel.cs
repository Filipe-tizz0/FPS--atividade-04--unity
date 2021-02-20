using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.SceneManagement;

public class voltanivel : MonoBehaviour
{


    public void voltando()
    {
        Debug.Log("VOLTANDO PARA O CORREDOR");
        //Application.Quit();

        SceneManager.LoadScene("castelo");

    }
}