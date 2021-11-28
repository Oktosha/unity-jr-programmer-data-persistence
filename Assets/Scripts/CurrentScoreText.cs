using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentScoreText : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;

    void Awake()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    public void SetCurrentScore(DataManager.ScoreData scoreData)
    {
        string name = (scoreData.currentName != "") ? (" (" + scoreData.currentName + ") ") : " ";
        textMeshPro.text = "You" + name + "scored " + scoreData.currentScore;
    }
}
