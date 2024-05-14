using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour

{
    public int score;
    public Text scoreText;
    void Start()
    {
        StartCoroutine(IncrementScoreCoroutine());
    }


    private void Update()
    {
        score = GlobalVariables.scorer;
        scoreText.text = score.ToString();
        GlobalVariables.scoreSayac = score;
    }

    public void AddScore()
    {
        GlobalVariables.scorer = GlobalVariables.scorer + GlobalVariables.tikArt;
        
    }

    private IEnumerator IncrementScoreCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f); // Her saniye bekleyin

            // Score'u artt�r
            GlobalVariables.scorer += GlobalVariables.otoTik;
            
        }
    }
}
