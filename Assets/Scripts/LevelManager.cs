using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GridSystem level;
    
    void Start()
    {
       level.Grid();
       
    }

    void Update()
    {
        //Debug.Log(LineLetters.isWordControl);
        foreach(string word in level.words)
       {
         
       }
    }
    
}
