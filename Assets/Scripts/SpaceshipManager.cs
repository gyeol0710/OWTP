using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SpaceshipManager : MonoBehaviour
{
    public long body1_Gold;
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

    public GameObject gauge1;
    public GameObject gauge2;
    public GameObject gauge3;
    public GameObject gauge4;

    public GameObject body;
    public GameObject fuel;
    public GameObject engine;
    public GameObject cockpit;

    public Sprite body1;
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

    public Button SpaceshipUp_Button;

    int SSupNum;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void SpaceshipUpgrade()
    {
        if (SSupNum == 1 && (GameManager.money >= body1_Gold))
        {
            SSupNum++;
            body.GetComponent<Image>().sprite = body2; // 오프라인 수입 보류
        }
        else if (SSupNum == 2 && (GameManager.money >= body2_Gold))
        {
            SSupNum++;
            body.GetComponent<Image>().sprite = body3; // 오프라인 수입 보류
        }
        else if (SSupNum == 3 && (GameManager.money >= body3_Gold))
        {
            SSupNum++;
            body.GetComponent<Image>().sprite = body4;
            GameManager.SpaceshipGoldBonus = 1.1f;
        }
        else if (SSupNum == 4 && (GameManager.money >= body4_Gold))
        {
            SSupNum++;
            body.GetComponent<Image>().sprite = fuel1;
            TechManager.age_war = true;
            GameManager.SpaceshipScienceBonus = 1.1f;
        }
        else if (SSupNum == 5 && (GameManager.money >= fuel1_Gold))
        {
            SSupNum++;
            body.GetComponent<Image>().sprite = fuel1; // 100초 동안 클릭 골드 증가 일단 보류
        }
    }

    IEnumerator SpaceshipUpCheck()
    {
        yield return null;
    }
}