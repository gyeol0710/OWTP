using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    static public long money; // 돈
    public long moneyIncreaseAmount; // 클릭 시 돈 증가량
    static public long science; // 연구력
    public long scienceIncreaseAmount; // 클릭 시 연구력 증가량

    public long robotLevelUpPrice; // 로봇 레벨업 비용
    public long robotTierUpPrice; // 로봇 티어업 비용
    public Text robotTierAndLevel; // 로봇 업그레이드 패널 티어 및 레벨
    public Text robotInfo; // 로봇 현재 골드 획득 및 지식 획득 정보
    public Text robotLevelUpInfo;
    public Text robotTierUpInfo;
    public Button robotLevelUpButton; // 로봇 레벨업 버튼
    public Button robotTierUpButton; // 로봇 티어업 버튼

    static public int years; // 연도
    static public int robotLevel; // 로봇 레벨
    static public int robotTier; // 로봇 티어

    public int robotWidth; // 가로 로봇 수
    public float robotSpace; // 로봇 간격
    public GameObject prefabRobot; // 로봇 프리팹


    public Text textMoney;
    public Text textScience;
    public Text textYears;

    public GameObject prefabMoney;
    public GameObject prefabScience;

    void Start()
    {
        money = 0;
        science = 0;
        years = 1760;
        robotLevel = 1;
        robotTier = 1;
    }

    void Update()
    {
        ShowInfo();
        UpdateRobotPanelText();
        RobotLevelUpButtonActiveCheck();
        RobotTierUpButtonActiveCheck();
    }

    public void MoneyIncrease()
    {
        money += moneyIncreaseAmount; // 돈을 '클릭 시 돈 증가량'만큼 증가시킴
        float r1 = Random.Range(-0.4, 0.4);
        Vector2 MoneyPosition = (r1, -4);
        Instantiate(prefabMoney, MoneyPosition, Quaternion.identity);
    }

    public void ScienceIncrease()
    {
        float r2 = Random.Range(0, 50); // 0이상 50미만의 실수 랜덤 출력 [원래는 rand() 함수를 사용하려고 했으나 표본이 적으면 확률이 극단적이라 게임본질을 헤칠 위험 있음 = 실력겜]
        if (r2 <= robotLevel)
        {
            science += scienceIncreaseAmount; // 연구력을 '클릭 시 연구력 증가량'만큼 증가시킴
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(prefabScience, mousePosition, Quaternion.identity);
        }
    }

    void ShowInfo()
    {
        if (money == 0)
            textMoney.text = "0";
        else
            textMoney.text = money.ToString("###,###");

        if (science == 0)
            textScience.text = "0";
        else
            textScience.text = science.ToString("###,###");

        textYears.text = years.ToString("####");
    }

    void UpdateRobotPanelText()
    {
        if (robotLevel <= 50)
        {
            robotTierAndLevel.text = "Tier " + robotTier + "   Level " + robotLevel;
            robotInfo.text = "클릭 시 골드 획득\n" + moneyIncreaseAmount.ToString("###,###") + "\n\n"; ;
            robotInfo.text += "클릭 시 지식 획득\n" + scienceIncreaseAmount + "[획득 확률 " + robotLevel * 2 + "%]";
        }
    }

    public void RobotLevelUp()
    {
        if (robotLevel < 50)
        {
            if (robotTier == 1)
            {
                if (money >= robotLevelUpPrice)
                {
                    money -= robotLevelUpPrice;
                    robotLevel += 1;
                    moneyIncreaseAmount += robotLevel * 100;
                    robotLevelUpPrice += robotLevel * 500;
                }
                CreateRobot();
            }
            else if (robotTier == 2)
            {
                if (money >= robotLevelUpPrice)
                {
                    money -= robotLevelUpPrice;
                    robotLevel += 1;
                    moneyIncreaseAmount += robotLevel * 2000;
                    robotLevelUpPrice += robotLevel * 10000;
                }
                CreateRobot();
            }
            else
            {
                if (money >= robotLevelUpPrice)
                {
                    money -= robotLevelUpPrice;
                    robotLevel += 1;
                    moneyIncreaseAmount += robotLevel * 40000;
                    robotLevelUpPrice += robotLevel * 200000;
                }
                CreateRobot();
            }
        }
    }

    public void RobotTierUp()
    {
        {
            if (money >= robotTierUpPrice)
            {
                money -= robotTierUpPrice;
                robotTier += 1;
                robotLevel = 1;
                scienceIncreaseAmount += 9;
            }
        }
    }

    void RobotLevelUpButtonActiveCheck()
    {
        if (robotLevel < 50)
        {
            if (money >= robotLevelUpPrice)
                robotLevelUpButton.interactable = true;
            else
                robotLevelUpButton.interactable = false;
        }
        else
            robotLevelUpButton.interactable = false;
    }

    void RobotTierUpButtonActiveCheck()
    {
        if (robotLevel == 50)
        {
            if (money >= robotTierUpPrice)
                robotTierUpButton.interactable = true;
            else
                robotTierUpButton.interactable = false;
        }
        else
            robotTierUpButton.interactable = false;
    }

    void CreateRobot()
    {
        Vector2 RobotSpot = GameObject.Find("Robot").transform.position;
        float spotX = RobotSpot.x + (robotLevel % robotWidth) * robotSpace;
        float spotY = RobotSpot.y - (robotLevel / robotWidth) * robotSpace;

        Instantiate(prefabRobot, new Vector2(spotX, spotY), Quaternion.identity);
    }
}
