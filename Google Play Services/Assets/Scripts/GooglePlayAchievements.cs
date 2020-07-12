using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;

public class GooglePlayAchievements : MonoBehaviour
{
    public void OpenAchievementPanel()
    {
        Social.ShowAchievementsUI();
    }

    public void UpdateIncrementalAchievement()
    {
        PlayGamesPlatform.Instance.IncrementAchievement(GPGSIds.achievement_incremental,1,null);
    }

    public void UnlockCasual()
    {
        Social.ReportProgress(GPGSIds.achievement_casual,100f,null);
    }

    public void RevealHiddenAchivements()
    {
        Social.ReportProgress(GPGSIds.achievement_hidden, 0f, null);
    }

    public void UnlockHiddenAchivements()
    {
        Social.ReportProgress(GPGSIds.achievement_hidden, 100f, null);
    }
}
