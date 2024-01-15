using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIControl : MonoBehaviour
{
    [SerializeField] private TMP_Text score;

    private int currentScore = 0;

    public void UpdateScore()
    {
      currentScore++;
      score.text = $"Score: {currentScore.ToString()}";
    }
}
