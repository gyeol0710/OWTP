using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ProductManager : MonoBehaviour
{
    public Button LightBulbButton;
    public Button Product02Button;
    public Button Product03Button;
    public Button Product04Button;

    public Text LightBulbLevelText;
    public Text Product02LevelText;
    public Text Product03LevelText;
    public Text Product04LevelText;

    long AutoMoneyIncreaseAmount; // 통합 1초당 획득 돈

    public long LightBulbPrice; // 전구 개발 비용
    public long LightBulbMoneyIncreaseAmount; // 전구 연구 시 1초당 획득 돈
    public long Product02Price;
    public long Product02MoneyIncreaseAmount;
    public long Product03Price;
    public long Product03MoneyIncreaseAmount;
    public long Product04Price;
    public long Product04MoneyIncreaseAmount;

    bool LightBulbComplete;
    bool Product02Complete;
    bool Product03Complete;
    bool Product04Complete;

    void Start()
    {
        StartCoroutine(MoneyAutoIncrease());
    }

    void Update()
    {
        LightBulbButtonActiveCheck();
        Product02ButtonActiveCheck();
        Product03ButtonActiveCheck();
        Product04ButtonActiveCheck();
    }

    public void LightBulb()
    {
        if (TechManager.SteamEngineComplete == true)
        {
            if (LightBulbComplete == false)
            {
                if (GameManager.money >= LightBulbPrice)
                {
                    GameManager.money -= LightBulbPrice;
                    AutoMoneyIncreaseAmount += LightBulbMoneyIncreaseAmount;
                    LightBulbComplete = true;
                    LightBulbLevelText.text = "전구 Lv. 1";
                }
            }
        }
    }

    void LightBulbButtonActiveCheck()
    {
        if (TechManager.SteamEngineComplete == true)
        {
            if (LightBulbComplete == false)
            {
                if (GameManager.money >= LightBulbPrice)
                {
                    LightBulbButton.interactable = true;
                }
                else
                    LightBulbButton.interactable = false;
            }
            else
                LightBulbButton.interactable = false;
        }
        else
            LightBulbButton.interactable = false;
    }

    public void Product02()
    {
        if (TechManager.Tech02Complete == true)
        {
            if (Product02Complete == false)
            {
                if (GameManager.money >= Product02Price)
                {
                    GameManager.money -= Product02Price;
                    AutoMoneyIncreaseAmount += Product02MoneyIncreaseAmount;
                    Product02Complete = true;
                    Product02LevelText.text = "제품2 Lv. 1";
                }
            }
        }
    }

    void Product02ButtonActiveCheck()
    {
        if (TechManager.Tech02Complete == true)
        {
            if (Product02Complete == false)
            {
                if (GameManager.money >= Product02Price)
                {
                    Product02Button.interactable = true;
                }
                else
                    Product02Button.interactable = false;
            }
            else
                Product02Button.interactable = false;
        }
        else
            Product02Button.interactable = false;
    }

    public void Product03()
    {
        if (TechManager.Tech03Complete == true)
        {
            if (Product03Complete == false)
            {
                if (GameManager.money >= Product03Price)
                {
                    GameManager.money -= Product03Price;
                    AutoMoneyIncreaseAmount += Product03MoneyIncreaseAmount;
                    Product03Complete = true;
                    Product03LevelText.text = "제품3 Lv. 1";
                }
            }
        }
    }

    void Product03ButtonActiveCheck()
    {
        if (TechManager.Tech03Complete == true)
        {
            if (Product03Complete == false)
            {
                if (GameManager.money >= Product03Price)
                {
                    Product03Button.interactable = true;
                }
                else
                    Product03Button.interactable = false;
            }
            else
                Product03Button.interactable = false;
        }
        else
            Product03Button.interactable = false;
    }

    public void Product04()
    {
        if (TechManager.Tech04Complete == true)
        {
            if (Product04Complete == false)
            {
                if (GameManager.money >= Product04Price)
                {
                    GameManager.money -= Product04Price;
                    AutoMoneyIncreaseAmount += Product04MoneyIncreaseAmount;
                    Product04Complete = true;
                    Product04LevelText.text = "제품4 Lv. 1";
                }
            }
        }
    }

    void Product04ButtonActiveCheck()
    {
        if (TechManager.Tech04Complete == true)
        {
            if (Product04Complete == false)
            {
                if (GameManager.money >= Product04Price)
                {
                    Product04Button.interactable = true;
                }
                else
                    Product04Button.interactable = false;
            }
            else
                Product04Button.interactable = false;
        }
        else
            Product04Button.interactable = false;
    }

    IEnumerator MoneyAutoIncrease()
    {
        while(true)
        {
            GameManager.money += AutoMoneyIncreaseAmount;

            yield return new WaitForSeconds(1); // 1초 대기
        }
    }
}
