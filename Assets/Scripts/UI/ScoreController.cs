using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : GenericSingleton<ScoreController>
{
    public static ScoreController scoreController;
    private TextMeshProUGUI scoreText;
    private int score = 0;

    protected override void Awake()
    {
        scoreController = this;
        scoreText = GetComponent<TextMeshProUGUI>();

    }

    void Start()
    {
        RefreshUI();
    }

    public void IncreaseScore(int increment)
    {
        score = score + increment;
        RefreshUI();
    }

    public void RefreshUI()
    {
        scoreText.text = "Score: " + score;
    }
}
