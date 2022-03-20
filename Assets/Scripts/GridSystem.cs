using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu()]
public class GridSystem : ScriptableObject
{
    
    public List<GameObject> letters;
    public List<string> words = new List<string>();
    public int height;
    public int widht;
    public static int next;

    public void Grid()
    {
      
      //create grid system.
      for(int i=0; i < height; i++)
      {
        
        for(int j=0; j < widht; j++)
        {
          GameObject letter = Instantiate(letters[next],new Vector2(i,j),Quaternion.identity);
          next++;   
        }
      }
    }

}
