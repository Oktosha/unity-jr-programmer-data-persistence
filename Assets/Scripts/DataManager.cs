using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    [System.Serializable]
    public class ScoreData
    {
        public string bestName;
        public int bestScore;
        public string currentName;
        public int currentScore;
    }

    public static DataManager Instance;
    public ScoreData scoreData;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadFromFile();
    }

    public void LoadFromFile()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            scoreData = JsonUtility.FromJson<ScoreData>(json);
        }
        else
        {
            scoreData = new ScoreData();
            scoreData.bestName = "";
            scoreData.bestScore = 0;
            scoreData.currentName = "";
            scoreData.currentScore = 0;
        }
    }

    public void SaveToFile()
    {
        string json = JsonUtility.ToJson(scoreData);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
}
