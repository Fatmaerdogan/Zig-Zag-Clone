using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreControl : MonoBehaviour
{
     TMP_Text ScoreText;
    private int ScoreSize=0;
    public int Score{ get { return ScoreSize; } set { ScoreSize++; ScoreText.text ="Score : "+ ScoreSize; } }
    private void Start()
    {
        ScoreText = GetComponent<TMP_Text>();
    }
}
