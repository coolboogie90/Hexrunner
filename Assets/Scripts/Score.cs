using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
    
    void Update()
    {
        scoreText.text = score.ToString();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Hexagon"))
        {
        }
    }
}
