using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TechManager : MonoBehaviour
{
    public Button SteamEngineButton;
    public Button Tech02Button;
    public Button Tech03Button;
    public Button Tech04Button;

    public long SteamEngineSciencePrice; // 전기 기술 필요 연구력 양
    public long Tech02Price;
    public long Tech03Price;
    public long Tech04Price;

    static public bool SteamEngineComplete; // 전기 기술 완료 판단
    static public bool Tech02Complete;
    static public bool Tech03Complete;
    static public bool Tech04Complete;

    public GameObject ScrollBar;
    public GameObject SBHandle;
    public GameObject L01;
    public GameObject Noti;

    Scrollbar SbTech; // AutoHidingHandle() 관련
    float CurrentHandleValue; // AutoHidingHandle() 관련

    void Start()
    {
        SbTech = ScrollBar.GetComponent<Scrollbar>();
        SbTech.value = 1;
        Color NotiC = Noti.GetComponent<Image>().color; // 알림 투명도 관련
        Noti.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
    }

    void Update()
    {
        SteamEngineButtonActiveCheck();
        Tech02ButtonActiveCheck();
        Tech03ButtonActiveCheck();
        Tech04ButtonActiveCheck();
        LineCompleteCheck();
        AutoHidingHandle();
    }

    void LineCompleteCheck()
    {
        if (SteamEngineComplete == true)
        {
            L01.GetComponent<Image>().color = new Color32(48, 114, 175, 255);
        }
    }

    public void ButtonNotiOff()
    {
        Noti.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
    }

    void AutoHidingHandle()
    {
        Image im = SBHandle.GetComponent<Image>();
        im.color = new Color(im.color.r, im.color.g, im.color.b, im.color.a - 0.02f);
        if (SbTech.value != CurrentHandleValue)
        {
            im.color = new Color32(255, 255, 255, 255);
            CurrentHandleValue = SbTech.value;
        }
    }

    public void SteamEngineResearch()
    {
        if (SteamEngineComplete == false)
        {
            if (GameManager.science >= SteamEngineSciencePrice)
            {
                GameManager.science -= SteamEngineSciencePrice;
                SteamEngineComplete = true;
                GameManager.years += 20;
            }
        }
    }

    void SteamEngineButtonActiveCheck()
    {
        if (SteamEngineComplete == false)
        {
            if (GameManager.science >= SteamEngineSciencePrice)
            {
                SteamEngineButton.interactable = true;
                Noti.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
            else
                SteamEngineButton.interactable = false;
        }
        else
            SteamEngineButton.interactable = false;
    }

    public void Tech02Research()
    {
        if (SteamEngineComplete == true)
        {
            if (Tech02Complete == false)
            {
                if (GameManager.science >= Tech02Price)
                {
                    GameManager.science -= Tech02Price;
                    Tech02Complete = true;
                    GameManager.years += 15;
                }
            }
        }
    }

    void Tech02ButtonActiveCheck()
    {
        if (SteamEngineComplete == true)
        {
            if (Tech02Complete == false)
            {
                if (GameManager.science >= Tech02Price)
                {
                    Tech02Button.interactable = true;
                }
                else
                    Tech02Button.interactable = false;
            }
            else
                Tech02Button.interactable = false;
        }
        else
            Tech02Button.interactable = false;
    }

    public void Tech03Research()
    {
        if (SteamEngineComplete == true)
        {
            if (Tech03Complete == false)
            {
                if (GameManager.science >= Tech03Price)
                {
                    GameManager.science -= Tech03Price;
                    Tech03Complete = true;
                    GameManager.years += 15;
                }
            }
        }
    }

    void Tech03ButtonActiveCheck()
    {
        if (SteamEngineComplete == true)
        {
            if (Tech03Complete == false)
            {
                if (GameManager.science >= Tech03Price)
                {
                    Tech03Button.interactable = true;
                }
                else
                    Tech03Button.interactable = false;
            }
            else
                Tech03Button.interactable = false;
        }
        else
            Tech03Button.interactable = false;
    }

    public void Tech04Research()
    {
        if (Tech02Complete == true)
        {
            if (Tech03Complete == true)
            {
                if (Tech04Complete == false)
                {
                    if (GameManager.science >= Tech04Price)
                    {
                        GameManager.science -= Tech04Price;
                        Tech04Complete = true;
                        GameManager.years += 10;
                    }
                }
            }
        }
    }

    void Tech04ButtonActiveCheck()
    {
        if (Tech02Complete == true)
        {
            if (Tech03Complete == true)
            {
                if (Tech04Complete == false)
                {
                    if (GameManager.science >= Tech04Price)
                    {
                        Tech04Button.interactable = true;
                    }
                    else
                        Tech04Button.interactable = false;
                }
                else
                    Tech04Button.interactable = false;
            }
            else
                Tech04Button.interactable = false;
        }
        else
            Tech04Button.interactable = false;
    }
}
