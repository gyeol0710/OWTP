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

    public void MoneyPlus1000000()
    {
        GameManager.money += 1000000;
    }

    public void SciencePlus10000()
    {
        GameManager.science += 10000;
    }
}
