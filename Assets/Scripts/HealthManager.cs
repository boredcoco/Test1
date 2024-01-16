using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene(0);
      }
      slider.value = currentHealth / maxHealth;
    }
}
