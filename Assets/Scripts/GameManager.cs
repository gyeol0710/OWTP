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
    public Text robotPrice; // 로봇 업그레이드 패널 정보 텍스트
    public Button robotLevelUpButton; // 로봇 레벨업 버튼
    public Button robotTierUpButton; // 로봇 티어업 버튼

    static public int years; // 연도
    static public int robot; // 로봇 수 = 로봇 레벨
    static public int robotTier; // 로봇 티어

    public int robotWidth; // 가로 로봇 수
    public float robotSpace; // 로봇 간격
    public GameObject prefabRobot; // 로봇 프리팹


    public Text textMoney;
    public Text textScience;
    public Text textYears;
    public Text textRobot;

    public GameObject prefabMoney;
    public GameObject prefabScience;

    void Start()
    {
        money = 10000000;
        science = 100000;
        years = 1860;
        robot = 1;
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
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Instantiate(prefabMoney, mousePosition, Quaternion.identity);
    }

    public void ScienceIncrease()
    {
        float r = Random.Range(0, 50); // 0이상 50미만의 실수 랜덤 출력 [원래는 rand() 함수를 사용하려고 했으나 표본이 적으면 확률이 극단적이라 게임본질을 헤칠 위험 있음 = 실력겜]
        if (r <= robot)
        {
            science += scienceIncreaseAmount; // 연구력을 '클릭 시 연구력 증가량'만큼 증가시킴
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(prefabScience, mousePosition, Quaternion.identity);
        }
    }

    void ShowInfo()
    {
        if (money == 0)
            textMoney.text = "0원";
        else
            textMoney.text = money.ToString("###,###") + "원";

        if (science == 0)
            textScience.text = "0지식";
        else
            textScience.text = science.ToString("###,###") + "지식";

        textYears.text = years.ToString("####") + "년";

        textRobot.text = robot.ToString("##") + "기 ¤ Tier" + robotTier.ToString("#");
    }

    void UpdateRobotPanelText()
    {
        if (robot < 50)
        {
            robotPrice.text = "로봇 Level : " + robot + "\n\n";
            robotPrice.text += "현재 클릭 시 돈 획득량\n";
            robotPrice.text += moneyIncreaseAmount.ToString("###,###") + "원\n\n";
            robotPrice.text += "Level Up 비용\n";
            robotPrice.text += robotLevelUpPrice.ToString("###,###") + "원\n\n";
            robotPrice.text += "현재 클릭 시 지식 획득량 : " + scienceIncreaseAmount + " (획득 확률 " + robot * 2 + "%)";
        }
        else
        {
            robotPrice.text = "로봇 Tier 업그레이드가 가능합니다!\n\n";
            robotPrice.text += "현재 로봇 Tier : " + robotTier.ToString("#") + "\n\n";
            robotPrice.text += "Tier Up 비용\n";
            robotPrice.text += robotTierUpPrice.ToString("###,###") + "원\n\n";
            robotPrice.text += "지식 획득량 변화\n 1 (100%)   →   10 (2%)";
        }
    }

    public void RobotLevelUp()
    {
        if (robot < 50)
        {
            if (robotTier == 1)
            {
                if (money >= robotLevelUpPrice)
                {
                    money -= robotLevelUpPrice;
                    robot += 1;
                    moneyIncreaseAmount += robot * 100;
                    robotLevelUpPrice += robot * 500;
                }
                CreateRobot();
            }
            else if (robotTier == 2)
            {
                if (money >= robotLevelUpPrice)
                {
                    money -= robotLevelUpPrice;
                    robot += 1;
                    moneyIncreaseAmount += robot * 2000;
                    robotLevelUpPrice += robot * 10000;
                }
                CreateRobot();
            }
            else
            {
                if (money >= robotLevelUpPrice)
                {
                    money -= robotLevelUpPrice;
                    robot += 1;
                    moneyIncreaseAmount += robot * 40000;
                    robotLevelUpPrice += robot * 200000;
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
                robot = 1;
                scienceIncreaseAmount += 9;
            }
        }
    }

    void RobotLevelUpButtonActiveCheck()
    {
        if (robot < 50)
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
        if (robot == 50)
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
        float spotX = RobotSpot.x + (robot % robotWidth) * robotSpace;
        float spotY = RobotSpot.y - (robot / robotWidth) * robotSpace;

        Instantiate(prefabRobot, new Vector2(spotX, spotY), Quaternion.identity);
    }
}
