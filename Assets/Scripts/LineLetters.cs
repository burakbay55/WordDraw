using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LineLetters : MonoBehaviour
{
  private int currentLetterId = 0;
  private List<GameObject> letterObject = new List<GameObject>();
  public Text wordText;
  public static string isWordControl;
  private SpriteRenderer letterColor;

  void Update()
  {
      if(Input.GetMouseButton(0))
      {
          RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);
          
          
          if(hit.transform.CompareTag("letter"))
          {
            
            if(currentLetterId != hit.transform.GetInstanceID())
            {
             currentLetterId = hit.transform.GetInstanceID();
             wordText.text += hit.transform.GetComponentInChildren<TextMeshPro>().text;
             letterColor = hit.transform.GetComponentInChildren<SpriteRenderer>();
             letterColor.color = Color.grey;
             letterObject.Add(hit.transform.gameObject);
            }      
          }
          
      }
      
      if(Input.GetMouseButtonUp(0))
      {
        isWordControl = wordText.text;
        //Debug.Log(isWordControl);
      }
  }
  
}






 /*foreach(GameObject letter in letterObject)
          {
            letter.gameObject.GetComponentInChildren<SpriteRenderer>().color = new Color32(66,154,145,255);
            wordText.text = "";
          }*/