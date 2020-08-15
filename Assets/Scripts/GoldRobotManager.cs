using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Advertisements;

public class GoldRobotManager : MonoBehaviour
{
    Transform tr;
    public float Speed;
    SpriteRenderer sr;
    public Animator Robot_anim;

    private bool RightOn;
    private bool DownOn;

    double MaxY;
    double MinY;

    void Start()
    {
        tr = GetComponent<Transform>();
        sr = GetComponent<SpriteRenderer>();
        Robot_anim = GetComponent<Animator>();
        LoadAge();
        StartCoroutine(RobotMoving());
        // StartCoroutine(Robot_Modern_Ymoving());
        StartCoroutine(Robot_Age());

        MaxY = tr.position.y + 0.05;
        MinY = tr.position.y - 0.05;
    }

    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject() == false)
        {
            ShowRewarded();
        }
    }

    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                {
                    Debug.Log("The ad was successfully shown.");
                    GameManager.AdBonus = 2f; // 여기에 보상 처리 
                }
                break;
            case ShowResult.Skipped:
                Debug.Log("The ad was skipped before reaching the end.");
                break;
            case ShowResult.Failed:
                Debug.LogError("The ad failed to be shown.");
                break;
        }
    }

    public void ShowRewarded()
    {
        if (Advertisement.IsReady())
        {
            var options = new ShowOptions { resultCallback = HandleShowResult };
            Advertisement.Show("rewardedVideo", options);
        }
        else
        {
            Debug.Log("AD FAIL");
        }
    }

void LoadAge()
    {
        if (TechManager.age_modern == true)
        {
            Robot_anim.SetBool("Age_Modern", true);
        }
        else if (TechManager.age_elec == true)
        {
            Robot_anim.SetBool("Age_Elec", true);
        }
        else if (TechManager.age_war == true)
        {
            Robot_anim.SetBool("Age_War", true);
        }
    }

    IEnumerator RobotMoving()
    {
        while (true)
        {
            if (RightOn == false)
            {
                sr.flipX = false;
                tr.Translate(Vector3.left * Speed * 0.01f);

                if (tr.position.x < -4.5)
                {
                    RightOn = true;
                }
            }
            else if (RightOn == true)
            {
                sr.flipX = true;
                tr.Translate(Vector3.right * Speed * 0.01f);

                if (tr.position.x > 4.5)
                {
                    RightOn = false;
                }
            }

            yield return new WaitForSeconds(0.02f);
        }
    }

    IEnumerator Robot_Modern_Ymoving()
    {
        while (true)
        {
            if (TechManager.age_modern == true)
            {
                break;
            }

            yield return new WaitForSeconds(2f);
        }

        while (true)
        {
            if (DownOn == false)
            {
                tr.Translate(Vector3.up * 0.007f);

                if (tr.position.y > MaxY)
                {
                    DownOn = true;
                }
            }
            else if (DownOn == true)
            {
                tr.Translate(Vector3.down * 0.007f);

                if (tr.position.y < MinY)
                {
                    DownOn = false;
                }
            }

            yield return new WaitForSeconds(0.04f);
        }
    }

    IEnumerator Robot_Age()
    {
        while (true)
        {
            if (TechManager.age_modern == true)
            {
                Robot_anim.SetBool("Age_Modern", true);
            }
            else if (TechManager.age_elec == true)
            {
                Robot_anim.SetBool("Age_Elec", true);
            }
            else if (TechManager.age_war == true)
            {
                Robot_anim.SetBool("Age_War", true);
            }

            yield return new WaitForSeconds(1.5f);
        }
    }

    void Update()
    {

    }
}