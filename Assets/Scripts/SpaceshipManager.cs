﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SpaceshipManager : MonoBehaviour
{
    public long body1_Gold; // 우주선 업글 필요 골드
    public long body2_Gold;
    public long body3_Gold;
    public long body4_Gold;
    public long fuel1_Gold;
    public long fuel2_Gold;
    public long fuel3_Gold;
    public long fuel4_Gold;
    public long engine1_Gold;
    public long engine2_Gold;
    public long engine3_Gold;
    public long engine4_Gold;
    public long cockpit1_Gold;
    public long cockpit2_Gold;
    public long cockpit3_Gold;
    public long cockpit4_Gold;

    public GameObject gauge1; // 우주선 업글 게이지
    public GameObject gauge2;
    public GameObject gauge3;
    public GameObject gauge4;

    public GameObject body; // 우주선 이미지 오브젝트
    public GameObject fuel;
    public GameObject engine;
    public GameObject cockpit;

    public Sprite body1; // 우주선 이미지들 소스
    public Sprite body2;
    public Sprite body3;
    public Sprite body4;
    public Sprite fuel1;
    public Sprite fuel2;
    public Sprite fuel3;
    public Sprite fuel4;
    public Sprite engine1;
    public Sprite engine2;
    public Sprite engine3;
    public Sprite engine4;
    public Sprite cockpit1;
    public Sprite cockpit2;
    public Sprite cockpit3;
    public Sprite cockpit4;

    static public bool Fuel2_Complete;

    public Button SpaceshipUp_Button; // 우주선 업글 버튼
    public Text SpaceshipUpNeedGold_Text; // 우주선 업글 비용 표시 텍스트

    public GameObject Age_pannel;
    public Image Age_banner;
    public Image AgeBlack;

    int SSupNum;

    void Start()
    {
        SSupNum = 1;
        StartCoroutine(SpaceshipUpdate());
    }

    void Update()
    {
        
    }

    public void SpaceshipUpgrade()
    {
        if (SSupNum == 1 && (GameManager.money >= body1_Gold))
        {
            GameManager.money -= body1_Gold;
            SSupNum++;
            body.GetComponent<Image>().sprite = body2; // 오프라인 수입 보류
        }
        else if (SSupNum == 2 && (GameManager.money >= body2_Gold))
        {
            GameManager.money -= body2_Gold;
            SSupNum++;
            body.GetComponent<Image>().sprite = body3; // 오프라인 수입 보류
        }
        else if (SSupNum == 3 && (GameManager.money >= body3_Gold))
        {
            GameManager.money -= body3_Gold;
            SSupNum++;
            body.GetComponent<Image>().sprite = body4;
            GameManager.SpaceshipGoldBonus = 1.1f;
        }
        else if (SSupNum == 4 && (GameManager.money >= body4_Gold) && ProductManager.JumpINDpossible == true)
        {
            GameManager.money -= body4_Gold;
            SSupNum++;
            TechManager.age_war = true;
            GameManager.SpaceshipScienceBonus = 1.1f;
            body.SetActive(false);
            fuel.SetActive(true);

            StartCoroutine(Age_Anim());
        }
        else if (SSupNum == 5 && (GameManager.money >= fuel1_Gold))
        {
            GameManager.money -= fuel1_Gold;
            SSupNum++;
            fuel.GetComponent<Image>().sprite = fuel2; // 100초 동안 클릭 골드 증가 일단 보류
        }
        else if (SSupNum == 6 && (GameManager.money >= fuel2_Gold))
        {
            GameManager.money -= fuel2_Gold;
            SSupNum++;
            fuel.GetComponent<Image>().sprite = fuel3;
            Fuel2_Complete = true;
            GameManager.Fuel2Debuff = 0.03f;
        }
        else if (SSupNum == 7 && (GameManager.money >= fuel3_Gold))
        {
            GameManager.money -= fuel3_Gold;
            SSupNum++;
            fuel.GetComponent<Image>().sprite = fuel4;
            GameManager.SpaceshipGoldBonus = 1.2f;
        }
        else if (SSupNum == 8 && (GameManager.money >= fuel4_Gold) && ProductManager.JumpWARpossible == true)
        {
            GameManager.money -= fuel4_Gold;
            SSupNum++;
            TechManager.age_elec = true;
            GameManager.SpaceshipScienceBonus = 1.2f;
            fuel.SetActive(false);
            engine.SetActive(true);
        }
        else if (SSupNum == 9 && (GameManager.money >= engine1_Gold))
        {
            GameManager.money -= engine1_Gold;
            SSupNum++;
            engine.GetComponent<Image>().sprite = engine2;
        }
        else if (SSupNum == 10 && (GameManager.money >= engine2_Gold))
        {
            GameManager.money -= engine2_Gold;
            SSupNum++;
            engine.GetComponent<Image>().sprite = engine3;
        }
        else if (SSupNum == 11 && (GameManager.money >= engine3_Gold))
        {
            GameManager.money -= engine3_Gold;
            SSupNum++;
            engine.GetComponent<Image>().sprite = engine4;
            GameManager.SpaceshipGoldBonus = 1.3f;
        }
        else if (SSupNum == 12 && (GameManager.money >= engine4_Gold) && ProductManager.JumpELECpossible == true)
        {
            GameManager.money -= engine4_Gold;
            SSupNum++;
            TechManager.age_modern = true;
            GameManager.SpaceshipScienceBonus = 1.3f;
            engine.SetActive(false);
            cockpit.SetActive(true);
        }
        else if (SSupNum == 13 && (GameManager.money >= cockpit1_Gold))
        {
            GameManager.money -= cockpit1_Gold;
            SSupNum++;
            cockpit.GetComponent<Image>().sprite = cockpit2;
        }
        else if (SSupNum == 14 && (GameManager.money >= cockpit2_Gold))
        {
            GameManager.money -= cockpit2_Gold;
            SSupNum++;
            cockpit.GetComponent<Image>().sprite = cockpit3;
        }
        else if (SSupNum == 15 && (GameManager.money >= cockpit3_Gold))
        {
            GameManager.money -= cockpit3_Gold;
            SSupNum++;
            cockpit.GetComponent<Image>().sprite = cockpit4;
            GameManager.SpaceshipGoldBonus = 1.4f;
        }
        else if (SSupNum == 16 && (GameManager.money >= cockpit4_Gold) && ProductManager.JumpMODERNpossible == true)
        {
            GameManager.money -= cockpit4_Gold;
        }
    }

    IEnumerator SpaceshipUpdate() // 실시간 골드텍스트 대입 및 버튼 접근 체크
    {
        while (true)
        {
            if (SSupNum == 1)
            {
                SpaceshipUpNeedGold_Text.text = UnitTransform(body1_Gold);
                if (GameManager.money >= body1_Gold)
                {
                    SpaceshipUp_Button.interactable = true;
                }
                else
                {
                    SpaceshipUp_Button.interactable = false;
                }
            }
            else if (SSupNum == 2)
            {
                SpaceshipUpNeedGold_Text.text = UnitTransform(body2_Gold);
                if (GameManager.money >= body2_Gold)
                {
                    SpaceshipUp_Button.interactable = true;
                }
                else
                {
                    SpaceshipUp_Button.interactable = false;
                }
            }
            else if (SSupNum == 3)
            {
                SpaceshipUpNeedGold_Text.text = UnitTransform(body3_Gold);
                if (GameManager.money >= body3_Gold)
                {
                    SpaceshipUp_Button.interactable = true;
                }
                else
                {
                    SpaceshipUp_Button.interactable = false;
                }
            }
            else if (SSupNum == 4)
            {
                SpaceshipUpNeedGold_Text.text = UnitTransform(body4_Gold);
                if (GameManager.money >= body4_Gold && ProductManager.JumpINDpossible == true)
                {
                    SpaceshipUp_Button.interactable = true;
                }
                else
                {
                    SpaceshipUp_Button.interactable = false;
                }
            }
            else if (SSupNum == 5)
            {
                SpaceshipUpNeedGold_Text.text = UnitTransform(fuel1_Gold);
                if (GameManager.money >= fuel1_Gold)
                {
                    SpaceshipUp_Button.interactable = true;
                }
                else
                {
                    SpaceshipUp_Button.interactable = false;
                }
            }
            else if (SSupNum == 6)
            {
                SpaceshipUpNeedGold_Text.text = UnitTransform(fuel2_Gold);
                if (GameManager.money >= fuel2_Gold)
                {
                    SpaceshipUp_Button.interactable = true;
                }
                else
                {
                    SpaceshipUp_Button.interactable = false;
                }
            }
            else if (SSupNum == 7)
            {
                SpaceshipUpNeedGold_Text.text = UnitTransform(fuel3_Gold);
                if (GameManager.money >= fuel3_Gold)
                {
                    SpaceshipUp_Button.interactable = true;
                }
                else
                {
                    SpaceshipUp_Button.interactable = false;
                }
            }
            else if (SSupNum == 8)
            {
                SpaceshipUpNeedGold_Text.text = UnitTransform(fuel4_Gold);
                if (GameManager.money >= fuel4_Gold && ProductManager.JumpWARpossible == true)
                {
                    SpaceshipUp_Button.interactable = true;
                }
                else
                {
                    SpaceshipUp_Button.interactable = false;
                }
            }
            else if (SSupNum == 9)
            {
                SpaceshipUpNeedGold_Text.text = UnitTransform(engine1_Gold);
                if (GameManager.money >= engine1_Gold)
                {
                    SpaceshipUp_Button.interactable = true;
                }
                else
                {
                    SpaceshipUp_Button.interactable = false;
                }
            }
            else if (SSupNum == 10)
            {
                SpaceshipUpNeedGold_Text.text = UnitTransform(engine2_Gold);
                if (GameManager.money >= engine2_Gold)
                {
                    SpaceshipUp_Button.interactable = true;
                }
                else
                {
                    SpaceshipUp_Button.interactable = false;
                }
            }
            else if (SSupNum == 11)
            {
                SpaceshipUpNeedGold_Text.text = UnitTransform(engine3_Gold);
                if (GameManager.money >= engine3_Gold)
                {
                    SpaceshipUp_Button.interactable = true;
                }
                else
                {
                    SpaceshipUp_Button.interactable = false;
                }
            }
            else if (SSupNum == 12)
            {
                SpaceshipUpNeedGold_Text.text = UnitTransform(engine4_Gold);
                if (GameManager.money >= engine4_Gold && ProductManager.JumpELECpossible == true)
                {
                    SpaceshipUp_Button.interactable = true;
                }
                else
                {
                    SpaceshipUp_Button.interactable = false;
                }
            }
            else if (SSupNum == 13)
            {
                SpaceshipUpNeedGold_Text.text = UnitTransform(cockpit1_Gold);
                if (GameManager.money >= cockpit1_Gold)
                {
                    SpaceshipUp_Button.interactable = true;
                }
                else
                {
                    SpaceshipUp_Button.interactable = false;
                }
            }
            else if (SSupNum == 14)
            {
                SpaceshipUpNeedGold_Text.text = UnitTransform(cockpit2_Gold);
                if (GameManager.money >= cockpit2_Gold)
                {
                    SpaceshipUp_Button.interactable = true;
                }
                else
                {
                    SpaceshipUp_Button.interactable = false;
                }
            }
            else if (SSupNum == 15)
            {
                SpaceshipUpNeedGold_Text.text = UnitTransform(cockpit3_Gold);
                if (GameManager.money >= cockpit3_Gold)
                {
                    SpaceshipUp_Button.interactable = true;
                }
                else
                {
                    SpaceshipUp_Button.interactable = false;
                }
            }
            else if (SSupNum == 16)
            {
                SpaceshipUpNeedGold_Text.text = UnitTransform(cockpit4_Gold);
                if (GameManager.money >= cockpit4_Gold && ProductManager.JumpMODERNpossible == true)
                {
                    SpaceshipUp_Button.interactable = true;
                }
                else
                {
                    SpaceshipUp_Button.interactable = false;
                }
            }
            else
            {
                SpaceshipUp_Button.interactable = false;
            }
            yield return new WaitForSeconds(0.2f);
        }
    }

    string UnitTransform(long a)
    {
        long b;
        string c = "";
        if (a <= 999999999)
        {
            c = a.ToString("###,###");
        }
        else if (a <= 999999999999)
        {
            b = a / 1000;
            c = b.ToString("###,###") + " k";
        }
        else if (a <= 999999999999999)
        {
            b = a / 1000000;
            c = b.ToString("###,###") + " m";
        }
        else if (a <= 999999999999999999)
        {
            b = a / 1000000000;
            c = b.ToString("###,###") + " b";
        }
        else if (a <= 9223372036854775807)
        {
            b = a / 1000000000000;
            c = b.ToString("###,###") + " t";
        }
        return c;
    }

    IEnumerator Age_Anim()
    {
        Age_pannel.SetActive(true);
        Age_banner.color = new Color32(255, 255, 255, 255);
        AgeBlack.color = new Color32(255, 255, 255, 0);
        Age_banner.fillAmount = 0f;
        int i = 0;
        int j = 0;
        int k = 0;
        while (true)
        {
            

            
            if(i < 30)
            {
                AgeBlack.color += new Color32(0, 0, 0, 5);
            }
            else if(i >= 150)
            {
                while(true)
                {
                    AgeBlack.color -= new Color32(0, 0, 0, 5);
                    Age_banner.color -= new Color32(0, 0, 0, 10);
                    k++;
                    if(k > 30)
                    {
                        Age_pannel.SetActive(false);
                        yield break;
                    }
                    yield return new WaitForSeconds(0.02f);
                }
            }

            if (j < 20)
            {
                Age_banner.fillAmount += 0.05f;
            }
            i++;
            j++;
            
            yield return new WaitForSeconds(0.02f);
        }
    }
}