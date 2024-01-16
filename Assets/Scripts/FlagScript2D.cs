using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagScript2D : MonoBehaviour
{
    private void OnTriggerEnter2D()
    {
      SceneManager.LoadScene(0);
    }
}
