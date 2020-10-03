using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingManager : MonoBehaviour
{
    public Transform Cam_tr;
    //bool CameraStop;
    public SpriteRenderer Black_sr;
    public Image creator;
    public GameObject NextGame_Button;
    public Text NextGame_Text;
    public GameObject Exit_Button;
    public Text Exit_Text;
    private bool onlyOne;

    void Start()
    {
        GameManager.Load();
        StartCoroutine(CameraMove());
        NextGame_Text.text = ((int)(GameManager.HowManyClear + 2)).ToString() + "회차 시작";
    }

    void Update()
    {

    }

    IEnumerator CameraMove()
    {
        float a = 0.03f;
        while (true)
        {
            Cam_tr.Translate(Vector3.up * a);
            a -= 0.00005f;
            if (Cam_tr.position.y > 8.3)
            {
                //CameraStop = true;
                StartCoroutine(Black_FadeIn());
                yield break;
            }

            yield return new WaitForSeconds(0.02f);
        }
    }

    IEnumerator Black_FadeIn()
    {
        int i = 0;
        while (true)
        {
            Black_sr.color += new Color32(0, 0, 0, 2);
            i++;
            if (i == 40)
            {
                StartCoroutine(Creator_FadeIn());
                yield break;
            }
            yield return new WaitForSeconds(0.02f);
        }
    }

    IEnumerator Creator_FadeIn()
    {
        while (true)
        {
            creator.fillAmount += 0.003f;

            if (creator.fillAmount >= 1)
            {
                StartCoroutine(Button_FadeIn());
                yield break;
            }

            yield return new WaitForSeconds(0.02f);
        }
    }

    IEnumerator Button_FadeIn()
    {
        Image NB_img = NextGame_Button.GetComponent<Image>();
        Image EB_img = Exit_Button.GetComponent<Image>();

        int i = 0;

        while (true)
        {
            NB_img.color += new Color32(0, 0, 0, 5);
            EB_img.color += new Color32(0, 0, 0, 5);
            NextGame_Text.color += new Color32(0, 0, 0, 5);
            Exit_Text.color += new Color32(0, 0, 0, 5);
            i++;

            if (i > 30)
            {
                NextGame_Button.GetComponent<Button>().interactable = true;
                Exit_Button.GetComponent<Button>().interactable = true;
            }

            if (i > 60)
            {
                yield break;
            }
            yield return new WaitForSeconds(0.02f);
        }
    }

    public void NextGame()
    {
        if(onlyOne == false)
        {
            onlyOne = true;
            GameManager.HowManyClear++;
            GameManager.GameClear = false;
            GameInitialization();
            GameManager.Save();
            LoadingManager.LoadScene("Intro");
        }
    }

    IEnumerator LoadIntro()
    {
        yield return new WaitForSeconds(2f);

        LoadingManager.LoadScene("Intro");
    }

    public void GameInitialization()
    {
        GameManager.money = 0;
        GameManager.moneyIncreaseAmount = 0;
        GameManager.science = 0;
        GameManager.scienceIncreaseAmount = 0;
        GameManager.years = 1700;
        GameManager.robotLevel = 0;
        GameManager.robotLevelUpPrice = 0;
        GameManager.SpaceshipGoldBonus = 1f;
        GameManager.ClickBonus = 1f;
        GameManager.SpaceshipScienceBonus = 1f;
        GameManager.eventOn = false;
        GameManager.ClickCount_Fuel2 = 0;
        GameManager.ClickCount_Cockpit2 = 0;
        GameManager.ClickCount_Ending = 0;
        GameManager.Story_Fuel2_Complete = false;
        GameManager.Story_Engine2_Complete = false;
        GameManager.Story_Cockpit2_Complete = false;
        GameManager.Story_Ending_Complete = false;
        GameManager.Engine2_RobotSpeed = 1;
        GameManager.Fuel2Debuff = 1f;
        GameManager.Engine2Debuff = 1f;
        GameManager.Cockpit2Debuff = 1f;
        GameManager.EndingDebuff = 1f;
        GameManager.Fuel2Bonus = 1f;
        GameManager.Engine2Bonus = 1f;
        GameManager.Cockpit2Bonus = 1f;
        GameManager.SSclickBonus = 1;
        GameManager.SStimer = 0;
        GameManager.ThisGamePlayTime = 0;

        TechManager.Tech1Complete = false;
        TechManager.Tech2Complete = false;
        TechManager.Tech3Complete = false;
        TechManager.Tech4Complete = false;
        TechManager.Tech5Complete = false;
        TechManager.Tech6Complete = false;
        TechManager.Tech7Complete = false;
        TechManager.Tech8Complete = false;
        TechManager.Tech9Complete = false;
        TechManager.Tech10Complete = false;
        TechManager.Tech11Complete = false;
        TechManager.Tech12Complete = false;
        TechManager.Tech13Complete = false;
        TechManager.Tech14Complete = false;
        TechManager.Tech15Complete = false;
        TechManager.Tech16Complete = false;
        TechManager.Tech17Complete = false;
        TechManager.Tech18Complete = false;
        TechManager.Tech19Complete = false;
        TechManager.Tech20Complete = false;
        TechManager.Tech21Complete = false;
        TechManager.Tech22Complete = false;
        TechManager.Tech23Complete = false;
        TechManager.Tech24Complete = false;
        TechManager.Tech25Complete = false;
        TechManager.Tech26Complete = false;
        TechManager.Tech27Complete = false;
        TechManager.Tech28Complete = false;
        TechManager.Tech29Complete = false;
        TechManager.Tech30Complete = false;
        TechManager.Tech31Complete = false;
        TechManager.Tech32Complete = false;
        TechManager.Tech33Complete = false;
        TechManager.Tech34Complete = false;
        TechManager.Tech35Complete = false;
        TechManager.Tech36Complete = false;
        TechManager.Tech37Complete = false;
        TechManager.Tech38Complete = false;
        TechManager.Tech39Complete = false;
        TechManager.Tech40Complete = false;
        TechManager.Tech41Complete = false;
        TechManager.Tech42Complete = false;
        TechManager.Tech43Complete = false;
        TechManager.Tech44Complete = false;
        TechManager.Tech45Complete = false;
        TechManager.Tech46Complete = false;
        TechManager.Tech47Complete = false;
        TechManager.Tech48Complete = false;
        TechManager.Tech49Complete = false;
        TechManager.Tech50Complete = false;
        TechManager.Tech51Complete = false;
        TechManager.Tech52Complete = false;
        TechManager.Tech53Complete = false;
        TechManager.Tech54Complete = false;
        TechManager.Tech55Complete = false;
        TechManager.Tech56Complete = false;
        TechManager.Tech57Complete = false;
        TechManager.Tech58Complete = false;
        TechManager.Tech59Complete = false;
        TechManager.Tech60Complete = false;
        TechManager.Tech61Complete = false;
        TechManager.Tech62Complete = false;
        TechManager.Tech63Complete = false;
        TechManager.Tech64Complete = false;
        TechManager.Tech65Complete = false;
        TechManager.Tech66Complete = false;
        TechManager.Tech67Complete = false;
        TechManager.Tech68Complete = false;
        TechManager.Tech69Complete = false;
        TechManager.Tech70Complete = false;

        TechManager.Tech1AnimC = false;
        TechManager.Tech2AnimC = false;
        TechManager.Tech3AnimC = false;
        TechManager.Tech4AnimC = false;
        TechManager.Tech5AnimC = false;
        TechManager.Tech6AnimC = false;
        TechManager.Tech7AnimC = false;
        TechManager.Tech8AnimC = false;
        TechManager.Tech9AnimC = false;
        TechManager.Tech10AnimC = false;
        TechManager.Tech11AnimC = false;
        TechManager.Tech12AnimC = false;
        TechManager.Tech13AnimC = false;
        TechManager.Tech14AnimC = false;
        TechManager.Tech15AnimC = false;
        TechManager.Tech16AnimC = false;
        TechManager.Tech17AnimC = false;
        TechManager.Tech18AnimC = false;
        TechManager.Tech19AnimC = false;
        TechManager.Tech20AnimC = false;
        TechManager.Tech21AnimC = false;
        TechManager.Tech22AnimC = false;
        TechManager.Tech23AnimC = false;
        TechManager.Tech24AnimC = false;
        TechManager.Tech25AnimC = false;
        TechManager.Tech26AnimC = false;
        TechManager.Tech27AnimC = false;
        TechManager.Tech28AnimC = false;
        TechManager.Tech29AnimC = false;
        TechManager.Tech30AnimC = false;
        TechManager.Tech31AnimC = false;
        TechManager.Tech32AnimC = false;
        TechManager.Tech33AnimC = false;
        TechManager.Tech34AnimC = false;
        TechManager.Tech35AnimC = false;
        TechManager.Tech36AnimC = false;
        TechManager.Tech37AnimC = false;
        TechManager.Tech38AnimC = false;
        TechManager.Tech39AnimC = false;
        TechManager.Tech40AnimC = false;
        TechManager.Tech41AnimC = false;
        TechManager.Tech42AnimC = false;
        TechManager.Tech43AnimC = false;
        TechManager.Tech44AnimC = false;
        TechManager.Tech45AnimC = false;
        TechManager.Tech46AnimC = false;
        TechManager.Tech47AnimC = false;
        TechManager.Tech48AnimC = false;
        TechManager.Tech49AnimC = false;
        TechManager.Tech50AnimC = false;
        TechManager.Tech51AnimC = false;
        TechManager.Tech52AnimC = false;
        TechManager.Tech53AnimC = false;
        TechManager.Tech54AnimC = false;
        TechManager.Tech55AnimC = false;
        TechManager.Tech56AnimC = false;
        TechManager.Tech57AnimC = false;
        TechManager.Tech58AnimC = false;
        TechManager.Tech59AnimC = false;
        TechManager.Tech60AnimC = false;
        TechManager.Tech61AnimC = false;
        TechManager.Tech62AnimC = false;
        TechManager.Tech63AnimC = false;
        TechManager.Tech64AnimC = false;
        TechManager.Tech65AnimC = false;
        TechManager.Tech66AnimC = false;
        TechManager.Tech67AnimC = false;
        TechManager.Tech68AnimC = false;
        TechManager.Tech69AnimC = false;
        TechManager.Tech70AnimC = false;

        TechManager.age_war = false;
        TechManager.age_elec = false;
        TechManager.age_modern = false;

        ProductManager.autoMoney = 0;
        ProductManager.autoScience = 0;

        ProductManager.Prod_1_Level = 0; // 2번 제품 없음
        ProductManager.Prod_3_Level = 0;
        ProductManager.Prod_4_Level = 0;
        ProductManager.Prod_5_Level = 0;
        ProductManager.Prod_6_Level = 0;
        ProductManager.Prod_7_Level = 0;
        ProductManager.Prod_8_Level = 0;
        ProductManager.Prod_9_Level = 0;
        ProductManager.Prod_10_Level = 0;
        ProductManager.Prod_11_Level = 0;
        ProductManager.Prod_12_Level = 0;
        ProductManager.Prod_13_Level = 0;
        ProductManager.Prod_14_Level = 0;
        ProductManager.Prod_15_Level = 0; // 16번 제품 없음
        ProductManager.Prod_17_Level = 0;
        ProductManager.Prod_18_Level = 0;
        ProductManager.Prod_19_Level = 0;
        ProductManager.Prod_20_Level = 0;
        ProductManager.Prod_21_Level = 0;
        ProductManager.Prod_22_Level = 0;
        ProductManager.Prod_23_Level = 0;
        ProductManager.Prod_24_Level = 0;
        ProductManager.Prod_25_Level = 0;
        ProductManager.Prod_26_Level = 0;
        ProductManager.Prod_27_Level = 0;
        ProductManager.Prod_28_Level = 0;
        ProductManager.Prod_29_Level = 0;
        ProductManager.Prod_30_Level = 0;
        ProductManager.Prod_31_Level = 0;
        ProductManager.Prod_32_Level = 0;
        ProductManager.Prod_33_Level = 0;
        ProductManager.Prod_34_Level = 0;
        ProductManager.Prod_35_Level = 0;
        ProductManager.Prod_36_Level = 0;
        ProductManager.Prod_37_Level = 0;
        ProductManager.Prod_38_Level = 0;
        ProductManager.Prod_39_Level = 0;
        ProductManager.Prod_40_Level = 0;
        ProductManager.Prod_41_Level = 0;
        ProductManager.Prod_42_Level = 0;
        ProductManager.Prod_43_Level = 0;
        ProductManager.Prod_44_Level = 0;
        ProductManager.Prod_45_Level = 0;
        ProductManager.Prod_46_Level = 0;
        ProductManager.Prod_47_Level = 0;
        ProductManager.Prod_48_Level = 0;
        ProductManager.Prod_49_Level = 0; // 50번 제품 없음
        ProductManager.Prod_51_Level = 0;
        ProductManager.Prod_52_Level = 0;
        ProductManager.Prod_53_Level = 0;
        ProductManager.Prod_54_Level = 0;
        ProductManager.Prod_55_Level = 0;
        ProductManager.Prod_56_Level = 0; // 57번 제품 없음
        ProductManager.Prod_58_Level = 0;
        ProductManager.Prod_59_Level = 0;
        ProductManager.Prod_60_Level = 0;
        ProductManager.Prod_61_Level = 0;
        ProductManager.Prod_62_Level = 0;
        ProductManager.Prod_63_Level = 0;
        ProductManager.Prod_64_Level = 0;
        ProductManager.Prod_65_Level = 0;
        ProductManager.Prod_66_Level = 0;
        ProductManager.Prod_67_Level = 0;
        ProductManager.Prod_68_Level = 0;
        ProductManager.Prod_69_Level = 0;
        ProductManager.Prod_70_Level = 0;
        ProductManager.Prod_S01_Level = 0;
        ProductManager.Prod_S02_Level = 0;
        ProductManager.Prod_S03_Level = 0;
        ProductManager.Prod_S04_Level = 0;

        ProductManager.PdS01Complete = false;
        ProductManager.PdS02Complete = false;
        ProductManager.PdS03Complete = false;
        ProductManager.PdS04Complete = false;

        ProductManager.JumpINDpossible = false;
        ProductManager.JumpWARpossible = false;
        ProductManager.JumpELECpossible = false;
        ProductManager.JumpMODERNpossible = false;

        for(int i = 0; i < 21; i++)
        {
            SpaceshipManager.SScomplete[i] = false;
        }

        SpaceshipManager.SSupNum = 1;
        SpaceshipManager.SSgauge = 0;

        for (int i = 0; i < 71; i++)
        {
            MessageManager.techMessage[i] = false;
        }

        for (int i = 0; i < 21; i++)
        {
            MessageManager.etcMessage[i] = false;
        }

        MessageManager.ageMessage_WAR = false;
        MessageManager.ageMessage_ELEC = false;
        MessageManager.ageMessage_MODERN = false;
    }
}
