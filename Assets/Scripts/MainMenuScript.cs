using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void Load3dScene()
    {
      SceneManager.LoadScene("3d");
    }

    public void Load2dScene()
    {
      SceneManager.LoadScene("2d");
    }

    public void LoadMainMenu()
    {
      SceneManager.LoadScene(0);
    }
}
