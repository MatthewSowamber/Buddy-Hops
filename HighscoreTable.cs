using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class HighscoreTable : MonoBehaviour
{
    private Transform entryContainer;
    private Transform entryTemplate;
    private List<Transform> highscoreEntryTransformList;

    private void Awake()
    {
        entryContainer = transform.Find("HighscoreEntryContainer");
        entryTemplate = entryContainer.Find("HighscoreEntryTemplate");

        //entryTemplate.gameObject.SetActive(false);

        entryTemplate.Find("ScoreText").GetComponent<Text>().text = Load();

    //    AddHighscoreEntry(10000);

    //    string jsonString = PlayerPrefs.GetString("highscoreTable");
    //    Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);
    //    for (int i = 0; i < highscores.highscoreEntryList.Count; i++)
    //    {
    //        for (int j = i + 1; j < highscores.highscoreEntryList.Count; j++)
    //        {
    //            if (highscores.highscoreEntryList[j].score > highscores.highscoreEntryList[i].score)
    //            {
    //                HighscoreEntry tmp = highscores.highscoreEntryList[i];
    //                highscores.highscoreEntryList[i] = highscores.highscoreEntryList[j];
    //                highscores.highscoreEntryList[j] = tmp;
    //            }
    //        }
    //    }

    //    highscoreEntryTransformList = new List<Transform>();
    //    foreach (HighscoreEntry highscoreEntry in highscores.highscoreEntryList)
    //    {
    //        CreateHighScoreEntryTransform(highscoreEntry, entryContainer, highscoreEntryTransformList);
    //    }

    }

    public void Save(string score)
    {
        string jsonString = score;
        File.WriteAllText(Application.persistentDataPath + "/scoreboard.json", jsonString);
    }

    public string Load()
    {
        return File.ReadAllText(Application.persistentDataPath + "/scoreboard.json");
    }

    //private void CreateHighScoreEntryTransform(HighscoreEntry highscoreEntry, Transform container, List<Transform> transformList)
    //{
    //    float templateHeight = 50f;
    //    Transform entryTransform = Instantiate(entryTemplate, container);
    //    RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
    //    entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);
    //    entryTransform.gameObject.SetActive(true);

    //    int rank = transformList.Count + 1;
    //    string rankString;
    //    switch (rank)
    //    {
    //        default: rankString = "TH"; break;


    //        case 1: rankString = "1ST"; break;
    //        case 2: rankString = "2ND"; break;
    //        case 3: rankString = "3RD"; break;
    //        case 4: rankString = "4TH"; break;
    //        case 5: rankString = "5TH"; break;
    //        case 6: rankString = "6TH"; break;
    //        case 7: rankString = "7TH"; break;
    //        case 8: rankString = "8TH"; break;
    //    }
    //    entryTransform.Find("PosText").GetComponent<Text>().text = rankString;

    //    int score = highscoreEntry.score;

    //    entryTransform.Find("ScoreText").GetComponent<Text>().text = score.ToString();

    //    transformList.Add(entryTransform);
    //}

    //private void AddHighscoreEntry(int score )
    //{
    //    //Create Highscores
    //    HighscoreEntry highscoreEntry = new HighscoreEntry { score = score };

    //    //Load Saved Highscores
    //    string jsonString = PlayerPrefs.GetString("highscoreTable");
    //    Highscores highscores = JsonUtility.FromJson<Highscores>(jsonString);

    //    Debug.Log(highscores);

    //    //Add New Entry to Highscores
    //    highscores.highscoreEntryList.Add(highscoreEntry);

    //    //Save Updated Highscores
    //    string json = JsonUtility.ToJson(highscores);
    //    PlayerPrefs.SetString("highscoreTable", json);
    //    PlayerPrefs.Save();
    //}

    //private class Highscores
    //{
    //    public List<HighscoreEntry> highscoreEntryList;
    //}

    //[System.Serializable]
    //private class HighscoreEntry
    //{
    //    public int score;
    //}
}
