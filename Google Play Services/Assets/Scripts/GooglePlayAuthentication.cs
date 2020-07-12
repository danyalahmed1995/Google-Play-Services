using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using UnityEngine.SceneManagement;

public class GooglePlayAuthentication : MonoBehaviour
{
    public static PlayGamesPlatform platform;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    void Start()
    {
        if (platform == null)
        {
            PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
            PlayGamesPlatform.InitializeInstance(config);
            PlayGamesPlatform.DebugLogEnabled = true;
            platform=PlayGamesPlatform.Activate();
        }

       // Social.Active.localUser.Authenticate(success =>
        //{

//            if (success)
  //          {
      //          print("Log in success full");
    //        }

//            else
  //          {
    //            print("Failed to log in");
      //      }

//        });
    }

    public void SIGNIN()
    {
        Social.Active.localUser.Authenticate(success =>
        {

            if (success)
            {
                print("Log in success full");
                SceneManager.LoadSceneAsync(1);
            }

            else
                print("Failed to log in");

        });
    }
}
