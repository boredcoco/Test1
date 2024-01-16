using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript2D : MonoBehaviour
{
  [SerializeField] private int damageDealt = 1;
  [SerializeField] private HealthManager healthManager;

  private void OnCollisionEnter2D(Collision2D collider)
  {
    if (collider.gameObject.tag == "Player")
    {
      healthManager.LoseHealth(damageDealt);
    }
  }
}
