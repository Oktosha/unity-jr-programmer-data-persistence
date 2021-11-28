using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuManager : MonoBehaviour
{
    public BestScoreText bestScoreText;

    private void Start()
    {
        bestScoreText.SetBestScore(DataManager.Instance.scoreData); 
    }

    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
