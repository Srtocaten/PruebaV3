using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadScene(string EscenaPrincipal)
    {
        SceneManager.LoadScene(EscenaPrincipal);
    }

    public void salir()
    {
        Application.Quit();
    }
}