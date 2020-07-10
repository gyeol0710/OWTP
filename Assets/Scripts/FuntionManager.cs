using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FuntionManager : MonoBehaviour
{
    public GameObject Panel_ind_Tech;
    public GameObject Panel_war_Tech;
    public GameObject Panel_elec_Tech;
    public GameObject Panel_modern_Tech;

    public GameObject Panel_ind_Prod;
    public GameObject Panel_war_Prod;
    public GameObject Panel_elec_Prod;
    public GameObject Panel_modern_Prod;

    public void OpenTap_Ind_Tech() // 연구창 산업시대탭 열기 및 다른시대탭 닫기
    {
        Panel_ind_Tech.SetActive(true);
        Panel_war_Tech.SetActive(false);
        Panel_elec_Tech.SetActive(false);
        Panel_modern_Tech.SetActive(false);
    }

    public void OpenTap_War_Tech() // 연구창 전쟁시대탭 열기 및 다른시대탭 닫기
    {
        if (TechManager.age_war == true)
        {
            Panel_ind_Tech.SetActive(false);
            Panel_war_Tech.SetActive(true);
            Panel_elec_Tech.SetActive(false);
            Panel_modern_Tech.SetActive(false);
        }
    }

    public void OpenTap_Elec_Tech() // 연구창 전자시대탭 열기 및 다른시대탭 닫기
    {
        if (TechManager.age_elec == true)
        {
            Panel_ind_Tech.SetActive(false);
            Panel_war_Tech.SetActive(false);
            Panel_elec_Tech.SetActive(true);
            Panel_modern_Tech.SetActive(false);
        }
    }

    public void OpenTap_Modern_Tech() // 연구창 현대시대탭 열기 및 다른시대탭 닫기
    {
        if (TechManager.age_modern == true)
        {
            Panel_ind_Tech.SetActive(false);
            Panel_war_Tech.SetActive(false);
            Panel_elec_Tech.SetActive(false);
            Panel_modern_Tech.SetActive(true);
        }
    }

    public void OpenTap_Ind_Prod() // 제품창 산업시대탭 열기 및 다른시대탭 닫기
    {
            Panel_ind_Prod.SetActive(true);
            Panel_war_Prod.SetActive(false);
            Panel_elec_Prod.SetActive(false);
            Panel_modern_Prod.SetActive(false);
    }

    public void OpenTap_War_Prod() // 제품창 전쟁시대탭 열기 및 다른시대탭 닫기
    {
        if (TechManager.age_war == true)
        {
            Panel_ind_Prod.SetActive(false);
            Panel_war_Prod.SetActive(true);
            Panel_elec_Prod.SetActive(false);
            Panel_modern_Prod.SetActive(false);
        }
    }

    public void OpenTap_Elec_Prod() // 제품창 전자시대탭 열기 및 다른시대탭 닫기
    {
        if (TechManager.age_elec == true)
        {
            Panel_ind_Prod.SetActive(false);
            Panel_war_Prod.SetActive(false);
            Panel_elec_Prod.SetActive(true);
            Panel_modern_Prod.SetActive(false);
        }
    }

    public void OpenTap_Modern_Prod() // 제품창 현대시대탭 열기 및 다른시대탭 닫기
    {
        if (TechManager.age_modern == true)
        {
            Panel_ind_Prod.SetActive(false);
            Panel_war_Prod.SetActive(false);
            Panel_elec_Prod.SetActive(false);
            Panel_modern_Prod.SetActive(true);
        }
    }
}