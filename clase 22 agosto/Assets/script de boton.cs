using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptdeboton : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);

      
    }

    public void Exit()
    {
        Application.Quit(1);
    }
}
