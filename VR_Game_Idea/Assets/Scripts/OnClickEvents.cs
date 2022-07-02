using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickEvents : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene("TronGame");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
