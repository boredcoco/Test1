using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [Header("Damage")]
    [SerializeField] private int damageDealt = 1;
    [SerializeField] private HealthManager healthManager;

    [Header("Movement")]
    private float min;
    private float max;
    [SerializeField] private float range = 10;
    [SerializeField] private float moveSpeed = 2;

    private void Start()
    {
      min=transform.position.x;
      max=transform.position.x+range;
    }

    private void OnTriggerEnter(Collider collider)
    {
      if (collider.tag == "Player")
      {
        healthManager.LoseHealth(damageDealt);
        gameObject.SetActive(false);
      }
    }

    private void Update ()
    {
      transform.position = new Vector3(Mathf.PingPong(Time.time*moveSpeed,max-min)+min, transform.position.y, transform.position.z);
    }

}
