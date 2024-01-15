using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public int score;
    public int score1;
    public int score2;
    public int score3;


    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreText1;
    public TextMeshProUGUI scoreText2;
    public TextMeshProUGUI scoreText3;

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
    public void RiseScoreAutreEncore(int amount)
    {
        score2 += amount;
        scoreText2.text = score2.ToString("0");
    }
    public void RiseScoreAutreEncoreAgain(int amount)
    {
        score3 += amount;
        scoreText2.text = score3.ToString("0");
    }


}
