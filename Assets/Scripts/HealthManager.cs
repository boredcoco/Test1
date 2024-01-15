using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField] private Slider slider;

    [SerializeField] private float maxHealth;

    private float currentHealth;

    private void Start()
    {
      currentHealth = maxHealth;
    }

    public void LoseHealth(int damage)
    {
      currentHealth -= damage;
      if (currentHealth <= 0)
      {
        Debug.Log("YOU ARE DEAD");
      }
      Debug.Log(currentHealth / maxHealth);
      slider.value = currentHealth / maxHealth;
    }
}
