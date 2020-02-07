using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TechManager : MonoBehaviour
{
    public Button ElectricityButton;
    public Button Tech02Button;
    public Button Tech03Button;
    public Button Tech04Button;

    public long ElectricitySciencePrice; // 전기 기술 필요 연구력 양
    public long Tech02Price;
    public long Tech03Price;
    public long Tech04Price;

    static public bool ElectricityComplete; // 전기 기술 완료 판단
    static public bool Tech02Complete;
    static public bool Tech03Complete;
    static public bool Tech04Complete;

    void Start()
    {
        
    }

    void Update()
    {
        ElectricityButtonActiveCheck();
        Tech02ButtonActiveCheck();
        Tech03ButtonActiveCheck();
        Tech04ButtonActiveCheck();
    }

    public void ElectricityResearch()
    {
        if (ElectricityComplete == false)
        {
            if (GameManager.science >= ElectricitySciencePrice)
            {
                GameManager.science -= ElectricitySciencePrice;
                ElectricityComplete = true;
                GameManager.years += 20;
            }
        }
    }

    void ElectricityButtonActiveCheck()
    {
        if (ElectricityComplete == false)
        {
            if (GameManager.science >= ElectricitySciencePrice)
            {
                ElectricityButton.interactable = true;
            }
            else
                ElectricityButton.interactable = false;
        }
        else
            ElectricityButton.interactable = false;
    }

    public void Tech02Research()
    {
        if (ElectricityComplete == true)
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
        if (ElectricityComplete == true)
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
        if (ElectricityComplete == true)
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
        if (ElectricityComplete == true)
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
