using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public List<GridSystem> level;
    private int levelNumber = 0;
    public static List<string> levelWords = new List<string>();
    void Awake()
    {
      level[levelNumber].Grid();

      foreach(string word in level[levelNumber].words)
      {
        levelWords.Add(word);
      }
      
    }

}
