using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class AdManager : MonoBehaviour
{
    private string rewardID = "ca-app-pub-8495930648368888/4941976587";
    // 테스트 광고 ID, 지금은 테스트를 사용

    private RewardedAd rewardedAd;

    private bool rewarded = false;

    private bool notReadyAD;

    public Image NRAD_img;
    public Text NRAD_text;

    void Start()
    {
        MobileAds.Initialize(initStatus => { });
        rewardedAd = new RewardedAd(rewardID);
        AdRequest request = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(request); // 광고 로드

        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        // 사용자가 광고를 끝까지 시청했을 때
        rewardedAd.OnAdClosed += HandleRewardedAdClosed;
        // 사용자가 광고를 중간에 닫았을 때
    }

    void Update()
    {
        if (rewarded)
        {
            GameManager.ClickCount_AD++;
            GameManager.AdBonus = 4f;
            StartCoroutine(GameManager.AdOn());
            rewarded = false;
        }
    }

    public void GoAD()
    {
        if (GoldRobotManager.ticket_AD > 0 && GameManager.Ading == false)
        {
            if(GameManager.InAppPur_AdSkip == true)
            {
                rewarded = true; // 변수 true
                GoldRobotManager.ticket_AD--;
            }
            else
            {
                UserChoseToWatchAd();
            }
        }
    }

    public void UserChoseToWatchAd()
    {
        if (rewardedAd.IsLoaded()) // 광고가 로드 되었을 때
        {
            rewardedAd.Show(); // 광고 보여주기
        }
        else
        {
            NotReadyAD(); // 광고가 준비되지 않았을 때
        }
    }

    public void CreateAndLoadRewardedAd() // 광고 다시 로드하는 함수
    {
        rewardedAd = new RewardedAd(rewardID);

        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        rewardedAd.OnAdClosed += HandleRewardedAdClosed;

        AdRequest request = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(request);
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {  // 사용자가 광고를 닫았을 때
        CreateAndLoadRewardedAd();  // 광고 다시 로드
    }

    private void HandleUserEarnedReward(object sender, Reward e)
    {  // 광고를 다 봤을 때
        rewarded = true; // 변수 true
        GoldRobotManager.ticket_AD--;
    }

    void NotReadyAD()
    {
        notReadyAD = true;
        StartCoroutine(NRAD_anim());
    }

    IEnumerator NRAD_anim()
    {
        yield return new WaitForSeconds(0.03f);

        notReadyAD = false;

        while (true)
        {
            if(notReadyAD == true)
            {
                yield break;
            }

            NRAD_img.color += new Color32(0, 0, 0, 10);
            NRAD_text.color += new Color32(0, 0, 0, 10);

            yield return new WaitForSeconds(0.02f);
        }
    }
}