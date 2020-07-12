using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardScore : MonoBehaviour
{
    public static int score = 0;
    [SerializeField]Text ScoreText;

    public void IncrementScore()
    {
        score++;
        ScoreText.text = score.ToString();
        PlayerPrefs.SetInt("ScoreToUpdate", PlayerPrefs.GetInt("ScoreToUpdate",0)+1);
    }

    public void OpenLeaderboardPanel()
    {
        Social.ShowLeaderboardUI();
    }                                                 

    public void UpdateLeaderBoardScore()
    {
        if(PlayerPrefs.GetInt("ScoreToUpdate",0)==0)
        {
            return;
        }

        Social.ReportScore(PlayerPrefs.GetInt("ScoreToUpdate", 1), GPGSIds.leaderboard_highscore, (bool success) => {

            if (success)
                PlayerPrefs.SetInt("ScoreToUpdate",0);
        
        });
    }
}
