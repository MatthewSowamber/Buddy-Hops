using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame ()
    {
        Application.Quit();
    }

    public void Retry()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ActiveMenu (GameObject OBJ)
    {
        OBJ.SetActive(true);
    }
}
