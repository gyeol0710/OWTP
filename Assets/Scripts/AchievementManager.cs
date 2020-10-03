using GooglePlayGames;
using GooglePlayGames.BasicApi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementManager : MonoBehaviour
{
    [SerializeField] Text txtLog = null;

    void Awake()
    {
        PlayGamesPlatform.InitializeInstance(new PlayGamesClientConfiguration.Builder().Build());
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
    }

    void Start()
    {
        if (Social.localUser.authenticated)
        {
            Debug.Log(Social.localUser.userName);
            txtLog.text = "name : " + Social.localUser.userName + "\n";
        }
        else
            Social.localUser.Authenticate((bool success) =>
            {
                if (success)
                {
                    Debug.Log(Social.localUser.userName);
                    txtLog.text = "name : " + Social.localUser.userName + "\n";
                }
                else
                {
                    Debug.Log("Login Fail");
                    txtLog.text = "Login Fail\n";
                }
            });

        Achi();
        StartCoroutine(Achie());
    }

    public void AchievementOn()
    {
        Social.ShowAchievementsUI();
    }

    public void OnBtnLogoutClicked()
    {
        ((PlayGamesPlatform)Social.Active).SignOut();
    }

    public void OnBtnShowAchievementClicked()
    {
        Social.ShowAchievementsUI();
    }

    public void AchiTest()
    {
        Social.ReportProgress(GPGSIds.achievement, 100.0f, null);
    }

    static public void Achi()
    {
        if (TutorialManager.T07c == true)
        {
            Social.ReportProgress(GPGSIds.achievement, 100.0f, null); // 업적 1
        }

        if (TechManager.Tech1Complete == true)
        {
            Social.ReportProgress(GPGSIds.achievement_2, 100.0f, null); // 업적 2
        }

        if (GameManager.robotLevel > 1)
        {
            Social.ReportProgress(GPGSIds.achievement_3, 100.0f, null); // 업적 3
        }

        if (ProductManager.Prod_5_Level > 0)
        {
            Social.ReportProgress(GPGSIds.achievement_4, 100.0f, null); // 업적 4
        }

        if (SpaceshipManager.SScomplete[4] == true)
        {
            Social.ReportProgress(GPGSIds.achievement_5, 100.0f, null); // 업적 5
        }

        if (TechManager.Tech8Complete == true)
        {
            Social.ReportProgress(GPGSIds.achievement_6, 100.0f, null); // 업적 6
        }

        if (GameManager.ClickCount >= 10000)
        {
            Social.ReportProgress(GPGSIds.achievement_7, 100.0f, null); // 업적 7
        }

        if (ProductManager.Prod_1_Level >= 50)
        {
            Social.ReportProgress(GPGSIds.achievement_8, 100.0f, null); // 업적 8
        }

        if (GameManager.Story_Fuel2_Complete == true)
        {
            Social.ReportProgress(GPGSIds.achievement_9, 100.0f, null); // 업적 9
        }

        if (TechManager.age_modern == true)
        {
            Social.ReportProgress(GPGSIds.achievement_10, 100.0f, null); // 업적 10
        }

        if (GameManager.money >= 1000000000000000)
        {
            Social.ReportProgress(GPGSIds.achievement_11, 100.0f, null); // 업적 11
        }

        if (GameManager.ClickCount >= 100000)
        {
            Social.ReportProgress(GPGSIds.achievement_12, 100.0f, null); // 업적 12
        }

        if (GameManager.ClickCount >= 1000000)
        {
            Social.ReportProgress(GPGSIds.achievement_13, 100.0f, null); // 업적 13
        }

        if (MessageManager.etcMessage[20] == true)
        {
            Social.ReportProgress(GPGSIds.achievement_14, 100.0f, null); // 업적 14
        }

        if (GameManager.HowManyClear >= 1)
        {
            Social.ReportProgress(GPGSIds.achievement_15, 100.0f, null); // 업적 15
        }

        if (GameManager.HowManyClear >= 2)
        {
            Social.ReportProgress(GPGSIds.achievement_16, 100.0f, null); // 업적 16
        }

        if (ProductManager.Prod_S01_Level > 0)
        {
            Social.ReportProgress(GPGSIds.achievement_17, 100.0f, null); // 업적 17
        }

        if (ProductManager.Prod_S02_Level > 0)
        {
            Social.ReportProgress(GPGSIds.achievement_18, 100.0f, null); // 업적 18
        }

        if (ProductManager.Prod_S03_Level > 0)
        {
            Social.ReportProgress(GPGSIds.achievement_19, 100.0f, null); // 업적 19
        }

        if (ProductManager.Prod_S04_Level > 0)
        {
            Social.ReportProgress(GPGSIds.achievement_20, 100.0f, null); // 업적 20
        }

        if (GameManager.ClickCount_Joke >= 50)
        {
            Social.ReportProgress(GPGSIds.achievement_21, 100.0f, null); // 업적 21
        }

        if (GameManager.ClickCount_AD > 0)
        {
            Social.ReportProgress(GPGSIds.achievement_22, 100.0f, null); // 업적 22
        }

        if (GameManager.ClickCount_AD >= 50)
        {
            Social.ReportProgress(GPGSIds.achievement_tv, 100.0f, null); // 업적 23
        }

        if (ProductManager.Prod_37_Level > 0)
        {
            Social.ReportProgress(GPGSIds.achievement_23, 100.0f, null); // 업적 24
        }

        if (GameManager.ClickCount_Frog >= 50)
        {
            Social.ReportProgress(GPGSIds.achievement_24, 100.0f, null); // 업적 25
        }

        if (GameManager.Story_Engine2_Complete == true)
        {
            Social.ReportProgress(GPGSIds.achievement_25, 100.0f, null); // 업적 26
        }

        /*
            Social.ReportProgress(GPGSIds.achievement_, 100.0f, null); // 업적 
        */
    }

    IEnumerator Achie()
    {
        while(true)
        {
            yield return new WaitForSeconds(2.1f);

            Achi();
        }
    }
}
