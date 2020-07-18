using System.Collections;
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
        else if (SSupNum == 4 && (GameManager.money >= body4_Gold) && ProductManager.Prod_5_Level > 0 && ProductManager.Prod_6_Level > 0 && ProductManager.Prod_12_Level > 0 && ProductManager.Prod_18_Level > 0 && ProductManager.Prod_19_Level > 0 && ProductManager.Prod_21_Level > 0 && ProductManager.Prod_22_Level > 0)
        {
            GameManager.money -= body4_Gold;
            SSupNum++;
            TechManager.age_war = true;
            GameManager.SpaceshipScienceBonus = 1.1f;
            body.SetActive(false);
            fuel.SetActive(true);
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
            GameManager.Fuel2GoldDebuff = 0.3f;
        }
        else if (SSupNum == 7 && (GameManager.money >= fuel3_Gold))
        {
            GameManager.money -= fuel3_Gold;
            SSupNum++;
            fuel.GetComponent<Image>().sprite = fuel4;
            GameManager.SpaceshipGoldBonus = 1.2f;
        }
        else if (SSupNum == 8 && (GameManager.money >= fuel4_Gold) && ProductManager.Prod_37_Level > 0)
        {
            GameManager.money -= fuel4_Gold;
            SSupNum++;
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
        else if (SSupNum == 12 && (GameManager.money >= engine4_Gold) && ProductManager.Prod_39_Level > 0 && ProductManager.Prod_44_Level > 0 && ProductManager.Prod_46_Level > 0 && ProductManager.Prod_49_Level > 0 && ProductManager.Prod_51_Level > 0 && ProductManager.Prod_54_Level > 0 && ProductManager.Prod_55_Level > 0)
        {
            GameManager.money -= engine4_Gold;
            SSupNum++;
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
        else if (SSupNum == 16 && (GameManager.money >= cockpit4_Gold))
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
                SpaceshipUpNeedGold_Text.text = body1_Gold.ToString("###,###");
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
                SpaceshipUpNeedGold_Text.text = body2_Gold.ToString("###,###");
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
                SpaceshipUpNeedGold_Text.text = body3_Gold.ToString("###,###");
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
                SpaceshipUpNeedGold_Text.text = body4_Gold.ToString("###,###");
                if (GameManager.money >= body4_Gold && ProductManager.Prod_5_Level > 0 && ProductManager.Prod_6_Level > 0 && ProductManager.Prod_12_Level > 0 && ProductManager.Prod_18_Level > 0 && ProductManager.Prod_19_Level > 0 && ProductManager.Prod_21_Level > 0 && ProductManager.Prod_22_Level > 0)
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
                SpaceshipUpNeedGold_Text.text = fuel1_Gold.ToString("###,###");
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
                SpaceshipUpNeedGold_Text.text = fuel2_Gold.ToString("###,###");
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
                SpaceshipUpNeedGold_Text.text = fuel3_Gold.ToString("###,###");
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
                SpaceshipUpNeedGold_Text.text = fuel4_Gold.ToString("###,###");
                if (GameManager.money >= fuel4_Gold && ProductManager.Prod_37_Level > 0)
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
                SpaceshipUpNeedGold_Text.text = engine1_Gold.ToString("###,###");
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
                SpaceshipUpNeedGold_Text.text = engine2_Gold.ToString("###,###");
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
                SpaceshipUpNeedGold_Text.text = engine3_Gold.ToString("###,###");
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
                SpaceshipUpNeedGold_Text.text = engine4_Gold.ToString("###,###");
                if (GameManager.money >= engine4_Gold && ProductManager.Prod_39_Level > 0 && ProductManager.Prod_44_Level > 0 && ProductManager.Prod_46_Level > 0 && ProductManager.Prod_49_Level > 0 && ProductManager.Prod_51_Level > 0 && ProductManager.Prod_54_Level > 0 && ProductManager.Prod_55_Level > 0)
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
                SpaceshipUpNeedGold_Text.text = cockpit1_Gold.ToString("###,###");
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
                SpaceshipUpNeedGold_Text.text = cockpit2_Gold.ToString("###,###");
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
                SpaceshipUpNeedGold_Text.text = cockpit3_Gold.ToString("###,###");
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
                SpaceshipUpNeedGold_Text.text = cockpit4_Gold.ToString("###,###");
                if (GameManager.money >= cockpit4_Gold)
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
}