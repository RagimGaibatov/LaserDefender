using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIDisplay : MonoBehaviour
{
    // [SerializeField] private TextMeshProUGUI scoreText;
    // private Health health;
    // private ScoreKeeper scoreKeeper;
    //
    // void Start()
    // {
    //     scoreText.text = scoreKeeper.GetScore().ToString();
    // }
    //
    // void Update()
    // {
    //     scoreText.text = scoreKeeper.GetScore().ToString();
    // }

    [Header("Health")] [SerializeField] private Slider healthSlider;
    [SerializeField] private Health playerHealth;

    [Header("Score")] [SerializeField] private TextMeshProUGUI scoreText;
    private ScoreKeeper scoreKeeper;

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    void Start()
    {
        healthSlider.maxValue = playerHealth.GetHealth();
    }

    private void Update()
    {
        healthSlider.value = playerHealth.GetHealth();
        scoreText.text = scoreKeeper.GetScore().ToString("00000000000");
    }
}