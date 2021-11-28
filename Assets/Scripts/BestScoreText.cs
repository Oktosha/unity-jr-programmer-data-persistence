using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BestScoreText : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;

    void Awake()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    public void SetBestScore(DataManager.ScoreData scoreData)
    {
        textMeshPro.text = "Best score: " + scoreData.bestScore;
        if (scoreData.bestName != "")
        {
            textMeshPro.text += " by " + scoreData.bestName;
        }
    }
}
