using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu()]
public class GridSystem : ScriptableObject
{
    
    public List<GameObject> letters;
    public List<Text> searchWords;
    public int height;
    public int widht;
    private int next = 0;
    public void Grid()
    {
      for(int i=0; i < height; i++)
      {
        for(int j=0; j < widht; j++)
        {
          GameObject letter = Instantiate(letters[0],new Vector2(i,j),Quaternion.identity);
          
        }
      }
    }

}
