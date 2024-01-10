using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public int score;
    public int score1;


    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreText1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RiseScore(int amount)
    {
        score += amount;
        scoreText.text = score.ToString("0");
    }
    public void RiseScoreAutre(int amount)
    {
        score1 += amount;
        scoreText1.text = score1.ToString("0");
    }


}
