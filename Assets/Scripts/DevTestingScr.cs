using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DevTestingScr : MonoBehaviour
{
    public Button Click;
    public Button Robot;
    public Button Product;
    public Button Tech;
    public Button Offer;

    public Text Dev_money_IF;
    public Text Dev_science_IF;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void AllPanelUnlock()
    {
        Click.interactable = true;
        Robot.interactable = true;
        Product.interactable = true;
        Tech.interactable = true;
        Offer.interactable = true;
    }

    public void DevMoney()
    {
        string dev_money_IF = Dev_money_IF.GetComponent<Text>().text;
        GameManager.money = long.Parse(dev_money_IF);
    }

    public void DevScience()
    {
        string dev_science_IF = Dev_science_IF.GetComponent<Text>().text;
        GameManager.science = long.Parse(dev_science_IF);
    }
}
