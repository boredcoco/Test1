using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectiblesScript : MonoBehaviour
{
    [SerializeField] private UIControl uiControl;

    private void OnTriggerEnter()
    {
      uiControl.UpdateScore();
      gameObject.SetActive(false);
    }
}
