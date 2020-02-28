using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneySlotAnimation : MonoBehaviour
{
    RectTransform Rtr;

    void Start()
    {
        Rtr = GetComponent<RectTransform>();
    }

    void Update()
    {
        Rtr.anchoredPosition -= new Vector2(0, 5);
    }
}
