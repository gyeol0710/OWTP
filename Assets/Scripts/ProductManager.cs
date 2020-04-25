using System.Collections;
using System.Collections.Generic;
using static System.Math;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ProductManager : MonoBehaviour
{
    static public long autoMoney; // 통합 1초당 획득 돈

    public float 업글비용배수;
    float UpTimes;
    

    //제품 업그레이드 비용
    public long pd1_뉴커멘엔진_업글비용;
    public static long Pd1; // 제품 업글비용 전역변수
    public long pd3_나는북_업글비용;
    public static long Pd3;
    public long pd4_뮬방적기_업글비용;
    public static long Pd4;
    public long pd5_실린더_업글비용;
    public static long Pd5;
    public long pd6_역직기_업글비용;
    public static long Pd6;
    public long pd7_기구_업글비용;
    public static long Pd7;
    public long pd8_개구리전지_업글비용;
    public static long Pd8;
    public long pd9_볼타전지_업글비용;
    public static long Pd9;
    public long pd10_가스등_업글비용;
    public static long Pd10;
    public long pd11_강철_업글비용;
    public static long Pd11;
    public long pd12_냉장고_업글비용;
    public static long Pd12;
    public long pd13_자석_업글비용;
    public static long Pd13;
    public long pd14_내연기관_업글비용;
    public static long Pd14;
    public long pd15_전신줄_업글비용;
    public static long Pd15;
    public long pd17_다이너마이트_업글비용;
    public static long Pd17;
    public long pd18_포노토그라프_업글비용;
    public static long Pd18;
    public long pd19_전화기_업글비용;
    public static long Pd19;
    public long pd20_백열등_업글비용;
    public static long Pd20;
    public long pd21_무선전신_업글비용;
    public static long Pd21;
    public long pd22_비행선_업글비용;
    public static long Pd22;

    //제품 1개당 골드 생산량
    public long pd1_뉴커멘엔진_생산량;
    public static long perOneAutoMoney1;
    public long pd3_나는북_생산량;
    public static long perOneAutoMoney3;
    public long pd4_뮬방적기_생산량;
    public static long perOneAutoMoney4;
    public long pd5_실린더_생산량;
    public static long perOneAutoMoney5;
    public long pd6_역직기_생산량;
    public static long perOneAutoMoney6;
    public long pd7_기구_생산량;
    public static long perOneAutoMoney7;
    public long pd8_개구리전지_생산량;
    public static long perOneAutoMoney8;
    public long pd9_볼타전지_생산량;
    public static long perOneAutoMoney9;
    public long pd10_가스등_생산량;
    public static long perOneAutoMoney10;
    public long pd11_강철_생산량;
    public static long perOneAutoMoney11;
    public long pd12_냉장고_생산량;
    public static long perOneAutoMoney12;
    public long pd13_자석_생산량;
    public static long perOneAutoMoney13;
    public long pd14_내연기관_생산량;
    public static long perOneAutoMoney14;
    public long pd15_전신줄_생산량;
    public static long perOneAutoMoney15;
    public long pd17_다이너마이트_생산량;
    public static long perOneAutoMoney17;
    public long pd18_포노토그라프_생산량;
    public static long perOneAutoMoney18;
    public long pd19_전화기_생산량;
    public static long perOneAutoMoney19;
    public long pd20_백열등_생산량;
    public static long perOneAutoMoney20;
    public long pd21_무선전신_생산량;
    public static long perOneAutoMoney21;
    public long pd22_비행선_생산량;
    public static long perOneAutoMoney22;

    //제품 레벨
    public int Prod_1_Level;
    public int Prod_3_Level;
    public int Prod_4_Level;
    public int Prod_5_Level;
    public int Prod_6_Level;
    public int Prod_7_Level;
    public int Prod_8_Level;
    public int Prod_9_Level;
    public int Prod_10_Level;
    public int Prod_11_Level;
    public int Prod_12_Level;
    public int Prod_13_Level;
    public int Prod_14_Level;
    public int Prod_15_Level;
    public int Prod_17_Level;
    public int Prod_18_Level;
    public int Prod_19_Level;
    public int Prod_20_Level;
    public int Prod_21_Level;
    public int Prod_22_Level;

    //패널 부분
    public Text title;
    public Text exp;
    public GameObject Icon;
    public Text ProdMoneyText;
    public Text TotalProdMoneyText;
    public Text UpPriceText;
    public Text Level;
    public GameObject ProdUpPanel; // 업그레이드 하는 패널
    public Button UpgradeProdButton;

    public GameObject MainProdPanel; // 제품 메인 패널
    public GameObject ScrollBar;
    Scrollbar SbProd;

    string paneltext1 = " 생산";
    string paneltext2 = " 생산 중";
    string paneltext3 = "0 생산 중";



    public short PanelNum;

    //제품 아이콘 버튼
    public GameObject ProdBtn1;
    public GameObject ProdBtn3;
    public GameObject ProdBtn4;
    public GameObject ProdBtn5;
    public GameObject ProdBtn6;
    public GameObject ProdBtn7;
    public GameObject ProdBtn8;
    public GameObject ProdBtn9;
    public GameObject ProdBtn10;
    public GameObject ProdBtn11;
    public GameObject ProdBtn12;
    public GameObject ProdBtn13;
    public GameObject ProdBtn14;
    public GameObject ProdBtn15;
    public GameObject ProdBtn17;
    public GameObject ProdBtn18;
    public GameObject ProdBtn19;
    public GameObject ProdBtn20;
    public GameObject ProdBtn21;
    public GameObject ProdBtn22;

    //제품 스프라이트
    public Sprite ProdIcon1;
    public Sprite ProdIcon3;
    public Sprite ProdIcon4;
    public Sprite ProdIcon5;
    public Sprite ProdIcon6;
    public Sprite ProdIcon7;
    public Sprite ProdIcon8;
    public Sprite ProdIcon9;
    public Sprite ProdIcon10;
    public Sprite ProdIcon11;
    public Sprite ProdIcon12;
    public Sprite ProdIcon13;
    public Sprite ProdIcon14;
    public Sprite ProdIcon15;
    public Sprite ProdIcon17;
    public Sprite ProdIcon18;
    public Sprite ProdIcon19;
    public Sprite ProdIcon20;
    public Sprite ProdIcon21;
    public Sprite ProdIcon22;

    void Awake()
    {
        MainProdPanel.SetActive(true);
        SbProd = ScrollBar.GetComponent<Scrollbar>();
        SbProd.value = 1;

        if (GameManager.RePlay == false)
        {
            Pd1 = pd1_뉴커멘엔진_업글비용;
            Pd3 = pd3_나는북_업글비용;
            Pd4 = pd4_뮬방적기_업글비용;
            Pd5 = pd5_실린더_업글비용;
            Pd6 = pd6_역직기_업글비용;
            Pd7 = pd7_기구_업글비용;
            Pd8 = pd8_개구리전지_업글비용;
            Pd9 = pd9_볼타전지_업글비용;
            Pd10 = pd10_가스등_업글비용;
            Pd11 = pd11_강철_업글비용;
            Pd12 = pd12_냉장고_업글비용;
            Pd13 = pd13_자석_업글비용;
            Pd14 = pd14_내연기관_업글비용;
            Pd15 = pd15_전신줄_업글비용;
            Pd17 = pd17_다이너마이트_업글비용;
            Pd18 = pd18_포노토그라프_업글비용;
            Pd19 = pd19_전화기_업글비용;
            Pd20 = pd20_백열등_업글비용;
            Pd21 = pd21_무선전신_업글비용;
            Pd22 = pd22_비행선_업글비용;
        }

        perOneAutoMoney1 = pd1_뉴커멘엔진_생산량;
        perOneAutoMoney3 = pd3_나는북_생산량;
        perOneAutoMoney4 = pd4_뮬방적기_생산량;
        perOneAutoMoney5 = pd5_실린더_생산량;
        perOneAutoMoney6 = pd6_역직기_생산량;
        perOneAutoMoney7 = pd7_기구_생산량;
        perOneAutoMoney8 = pd8_개구리전지_생산량;
        perOneAutoMoney9 = pd9_볼타전지_생산량;
        perOneAutoMoney10 = pd10_가스등_생산량;
        perOneAutoMoney11 = pd11_강철_생산량;
        perOneAutoMoney12 = pd12_냉장고_생산량;
        perOneAutoMoney13 = pd13_자석_생산량;
        perOneAutoMoney14 = pd14_내연기관_생산량;
        perOneAutoMoney15 = pd15_전신줄_생산량;
        perOneAutoMoney17 = pd17_다이너마이트_생산량;
        perOneAutoMoney18 = pd18_포노토그라프_생산량;
        perOneAutoMoney19 = pd19_전화기_생산량;
        perOneAutoMoney20 = pd20_백열등_생산량;
        perOneAutoMoney21 = pd21_무선전신_생산량;
        perOneAutoMoney22 = pd22_비행선_생산량;

        UpTimes = 업글비용배수;
    }
    void Start()
    {
        MainProdPanel.SetActive(false);
        StartCoroutine(AutoMoneyGo());
        SaveDataCheck_ProdUnlock();
    }

    void Update()
    {
        ProdUpButtonCheck();
    }

    public void Prod_1_Open() // 제품 아이콘 버튼에 대입
    {
        if (TechManager.Tech1Complete)
        {
            title.text = "뉴커멘엔진";
            exp.text = "영국과 유럽 전역에서 주로 새로운 광산 엔진이 광산에서 물을 펌핑하는 데 사용되었습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon1;
            Level.text = Prod_1_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney1.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney1 * Prod_1_Level).ToString("###,###") + paneltext2;
            if(Prod_1_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = Pd1.ToString("###,###");
            PanelNum = 1;
            ProdUpPanel.SetActive(true);
        }
    }
    public void Prod_3_Open()
    {
        if (TechManager.Tech3Complete)
        {
            title.text = "연구명";
            exp.text = "동민아 여기에 설명을 추가해줘";
            Icon.GetComponent<Image>().sprite = ProdIcon3;
            Level.text = Prod_3_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney3.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney3 * Prod_3_Level).ToString("###,###") + paneltext2;
            if (Prod_3_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = Pd3.ToString("###,###");
            PanelNum = 3;
            ProdUpPanel.SetActive(true);
        }
    }
    public void Prod_4_Open()
    {
        if (TechManager.Tech4Complete)
        {
            title.text = "연구명";
            exp.text = "동민아 여기에 설명을 추가해줘";
            Icon.GetComponent<Image>().sprite = ProdIcon4;
            Level.text = Prod_4_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney4.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney4 * Prod_4_Level).ToString("###,###") + paneltext2;
            if (Prod_4_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = Pd4.ToString("###,###");
            PanelNum = 4;
            ProdUpPanel.SetActive(true);
        }
    }
    public void Prod_5_Open()
    {
        if (TechManager.Tech5Complete)
        {
            title.text = "연구명";
            exp.text = "동민아 여기에 설명을 추가해줘";
            Icon.GetComponent<Image>().sprite = ProdIcon5;
            Level.text = Prod_5_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney5.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney5 * Prod_5_Level).ToString("###,###") + paneltext2;
            if (Prod_5_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = Pd5.ToString("###,###");
            PanelNum = 5;
            ProdUpPanel.SetActive(true);
        }
    }
    public void Prod_6_Open()
    {
        if (TechManager.Tech6Complete)
        {
            title.text = "연구명";
            exp.text = "동민아 여기에 설명을 추가해줘";
            Icon.GetComponent<Image>().sprite = ProdIcon6;
            Level.text = Prod_6_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney6.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney6 * Prod_6_Level).ToString("###,###") + paneltext2;
            if (Prod_6_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = Pd6.ToString("###,###");
            PanelNum = 6;
            ProdUpPanel.SetActive(true);
        }
    }
    public void Prod_7_Open()
    {
        if (TechManager.Tech7Complete)
        {
            title.text = "연구명";
            exp.text = "동민아 여기에 설명을 추가해줘";
            Icon.GetComponent<Image>().sprite = ProdIcon7;
            Level.text = Prod_7_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney7.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney7 * Prod_7_Level).ToString("###,###") + paneltext2;
            if (Prod_7_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = Pd7.ToString("###,###");
            PanelNum = 7;
            ProdUpPanel.SetActive(true);
        }
    }
    public void Prod_8_Open()
    {
        if (TechManager.Tech8Complete)
        {
            title.text = "연구명";
            exp.text = "동민아 여기에 설명을 추가해줘";
            Icon.GetComponent<Image>().sprite = ProdIcon8;
            Level.text = Prod_8_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney8.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney8 * Prod_8_Level).ToString("###,###") + paneltext2;
            if (Prod_8_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = Pd8.ToString("###,###");
            PanelNum = 8;
            ProdUpPanel.SetActive(true);
        }
    }
    public void Prod_9_Open()
    {
        if (TechManager.Tech9Complete)
        {
            title.text = "연구명";
            exp.text = "동민아 여기에 설명을 추가해줘";
            Icon.GetComponent<Image>().sprite = ProdIcon9;
            Level.text = Prod_9_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney9.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney9 * Prod_9_Level).ToString("###,###") + paneltext2;
            if (Prod_9_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = Pd9.ToString("###,###");
            PanelNum = 9;
            ProdUpPanel.SetActive(true);
        }
    }
    public void Prod_10_Open()
    {
        if (TechManager.Tech10Complete)
        {
            title.text = "연구명";
            exp.text = "동민아 여기에 설명을 추가해줘";
            Icon.GetComponent<Image>().sprite = ProdIcon10;
            Level.text = Prod_10_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney10.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney10 * Prod_10_Level).ToString("###,###") + paneltext2;
            if (Prod_10_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = Pd10.ToString("###,###");
            PanelNum = 10;
            ProdUpPanel.SetActive(true);
        }
    }
    public void Prod_11_Open()
    {
        if (TechManager.Tech11Complete)
        {
            title.text = "연구명";
            exp.text = "동민아 여기에 설명을 추가해줘";
            Icon.GetComponent<Image>().sprite = ProdIcon11;
            Level.text = Prod_11_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney11.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney11 * Prod_11_Level).ToString("###,###") + paneltext2;
            if (Prod_11_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = Pd11.ToString("###,###");
            PanelNum = 11;
            ProdUpPanel.SetActive(true);
        }
    }
    public void Prod_12_Open()
    {
        if (TechManager.Tech12Complete)
        {
            title.text = "연구명";
            exp.text = "동민아 여기에 설명을 추가해줘";
            Icon.GetComponent<Image>().sprite = ProdIcon12;
            Level.text = Prod_12_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney12.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney12 * Prod_12_Level).ToString("###,###") + paneltext2;
            if (Prod_12_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = Pd12.ToString("###,###");
            PanelNum = 12;
            ProdUpPanel.SetActive(true);
        }
    }
    public void Prod_13_Open()
    {
        if (TechManager.Tech13Complete)
        {
            title.text = "연구명";
            exp.text = "동민아 여기에 설명을 추가해줘";
            Icon.GetComponent<Image>().sprite = ProdIcon13;
            Level.text = Prod_13_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney13.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney13 * Prod_13_Level).ToString("###,###") + paneltext2;
            if (Prod_13_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = Pd13.ToString("###,###");
            PanelNum = 13;
            ProdUpPanel.SetActive(true);
        }
    }
    public void Prod_14_Open()
    {
        if (TechManager.Tech14Complete)
        {
            title.text = "연구명";
            exp.text = "동민아 여기에 설명을 추가해줘";
            Icon.GetComponent<Image>().sprite = ProdIcon14;
            Level.text = Prod_14_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney14.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney14 * Prod_14_Level).ToString("###,###") + paneltext2;
            if (Prod_14_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = Pd14.ToString("###,###");
            PanelNum = 14;
            ProdUpPanel.SetActive(true);
        }
    }
    public void Prod_15_Oepn()
    {
        if (TechManager.Tech15Complete)
        {
            title.text = "연구명";
            exp.text = "동민아 여기에 설명을 추가해줘";
            Icon.GetComponent<Image>().sprite = ProdIcon15;
            Level.text = Prod_15_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney15.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney15 * Prod_15_Level).ToString("###,###") + paneltext2;
            if (Prod_15_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = Pd15.ToString("###,###");
            PanelNum = 15;
            ProdUpPanel.SetActive(true);
        }
    }
    public void Prod_17_Oepn()
    {
        if (TechManager.Tech17Complete)
        {
            title.text = "연구명";
            exp.text = "동민아 여기에 설명을 추가해줘";
            Icon.GetComponent<Image>().sprite = ProdIcon17;
            Level.text = Prod_17_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney17.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney17 * Prod_17_Level).ToString("###,###") + paneltext2;
            if (Prod_17_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = Pd17.ToString("###,###");
            PanelNum = 17;
            ProdUpPanel.SetActive(true);
        }
    }
    public void Prod_18_Oepn()
    {
        if (TechManager.Tech18Complete)
        {
            title.text = "연구명";
            exp.text = "동민아 여기에 설명을 추가해줘";
            Icon.GetComponent<Image>().sprite = ProdIcon18;
            Level.text = Prod_18_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney18.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney18 * Prod_18_Level).ToString("###,###") + paneltext2;
            if (Prod_18_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = Pd18.ToString("###,###");
            PanelNum = 18;
            ProdUpPanel.SetActive(true);
        }
    }
    public void Prod_19_Oepn()
    {
        if (TechManager.Tech19Complete)
        {
            title.text = "연구명";
            exp.text = "동민아 여기에 설명을 추가해줘";
            Icon.GetComponent<Image>().sprite = ProdIcon19;
            Level.text = Prod_19_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney19.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney19 * Prod_19_Level).ToString("###,###") + paneltext2;
            if (Prod_19_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = Pd19.ToString("###,###");
            PanelNum = 19;
            ProdUpPanel.SetActive(true);
        }
    }
    public void Prod_20_Oepn()
    {
        if (TechManager.Tech20Complete)
        {
            title.text = "연구명";
            exp.text = "동민아 여기에 설명을 추가해줘";
            Icon.GetComponent<Image>().sprite = ProdIcon20;
            Level.text = Prod_20_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney20.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney20 * Prod_20_Level).ToString("###,###") + paneltext2;
            if (Prod_20_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = Pd20.ToString("###,###");
            PanelNum = 20;
            ProdUpPanel.SetActive(true);
        }
    }
    public void Prod_21_Oepn()
    {
        if (TechManager.Tech21Complete)
        {
            title.text = "연구명";
            exp.text = "동민아 여기에 설명을 추가해줘";
            Icon.GetComponent<Image>().sprite = ProdIcon21;
            Level.text = Prod_21_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney21.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney21 * Prod_21_Level).ToString("###,###") + paneltext2;
            if (Prod_21_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = Pd21.ToString("###,###");
            PanelNum = 21;
            ProdUpPanel.SetActive(true);
        }
    }
    public void Prod_22_Oepn()
    {
        if (TechManager.Tech22Complete)
        {
            title.text = "연구명";
            exp.text = "동민아 여기에 설명을 추가해줘";
            Icon.GetComponent<Image>().sprite = ProdIcon22;
            Level.text = Prod_22_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney22.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney22 * Prod_22_Level).ToString("###,###") + paneltext2;
            if (Prod_22_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = Pd22.ToString("###,###");
            PanelNum = 22;
            ProdUpPanel.SetActive(true);
        }
    }

    public void UpProd() // 제품 업그레이드 버튼에 대입, 제품업글을 눌렀을 때 나오는 반응
    {
        if(PanelNum == 1)
        {
            GameManager.money -= Pd1;
            Prod_1_Level++;
            Pd1 = (long)((float)Pd1 * UpTimes);

            Level.text = Prod_1_Level.ToString();
            TotalProdMoneyText.text = (perOneAutoMoney1 * Prod_1_Level).ToString("###,###") + paneltext2;
            UpPriceText.text = Pd1.ToString("###,###");
        }
        else if (PanelNum == 3)
        {
            GameManager.money -= Pd3;
            Prod_3_Level++;
            Pd3 = (long)((float)Pd3 * UpTimes);

            Level.text = Prod_3_Level.ToString();
            TotalProdMoneyText.text = (perOneAutoMoney3 * Prod_3_Level).ToString("###,###") + paneltext2;
            UpPriceText.text = Pd3.ToString("###,###");
        }
        else if (PanelNum == 4)
        {
            GameManager.money -= Pd4;
            Prod_4_Level++;
            Pd4 = (long)((float)Pd4 * UpTimes);

            Level.text = Prod_4_Level.ToString();
            TotalProdMoneyText.text = (perOneAutoMoney4 * Prod_4_Level).ToString("###,###") + paneltext2;
            UpPriceText.text = Pd4.ToString("###,###");
        }
        else if (PanelNum == 5)
        {
            GameManager.money -= Pd5;
            Prod_5_Level++;
            Pd5 = (long)((float)Pd5 * UpTimes);

            Level.text = Prod_5_Level.ToString();
            TotalProdMoneyText.text = (perOneAutoMoney5 * Prod_5_Level).ToString("###,###") + paneltext2;
            UpPriceText.text = Pd5.ToString("###,###");
        }
        else if (PanelNum == 6)
        {
            GameManager.money -= Pd6;
            Prod_6_Level++;
            Pd6 = (long)((float)Pd6 * UpTimes);

            Level.text = Prod_6_Level.ToString();
            TotalProdMoneyText.text = (perOneAutoMoney6 * Prod_6_Level).ToString("###,###") + paneltext2;
            UpPriceText.text = Pd6.ToString("###,###");
        }
        else if (PanelNum == 7)
        {
            GameManager.money -= Pd7;
            Prod_7_Level++;
            Pd7 = (long)((float)Pd7 * UpTimes);

            Level.text = Prod_7_Level.ToString();
            TotalProdMoneyText.text = (perOneAutoMoney7 * Prod_7_Level).ToString("###,###") + paneltext2;
            UpPriceText.text = Pd7.ToString("###,###");
        }
        else if (PanelNum == 8)
        {
            GameManager.money -= Pd8;
            Prod_8_Level++;
            Pd8 = (long)((float)Pd8 * UpTimes);

            Level.text = Prod_8_Level.ToString();
            TotalProdMoneyText.text = (perOneAutoMoney8 * Prod_8_Level).ToString("###,###") + paneltext2;
            UpPriceText.text = Pd8.ToString("###,###");
        }
        else if (PanelNum == 9)
        {
            GameManager.money -= Pd9;
            Prod_9_Level++;
            Pd9 = (long)((float)Pd9 * UpTimes);

            Level.text = Prod_9_Level.ToString();
            TotalProdMoneyText.text = (perOneAutoMoney9 * Prod_9_Level).ToString("###,###") + paneltext2;
            UpPriceText.text = Pd9.ToString("###,###");
        }
        else if (PanelNum == 10)
        {
            GameManager.money -= Pd10;
            Prod_10_Level++;
            Pd10 = (long)((float)Pd10 * UpTimes);

            Level.text = Prod_10_Level.ToString();
            TotalProdMoneyText.text = (perOneAutoMoney10 * Prod_10_Level).ToString("###,###") + paneltext2;
            UpPriceText.text = Pd10.ToString("###,###");
        }
        else if (PanelNum == 11)
        {
            GameManager.money -= Pd11;
            Prod_11_Level++;
            Pd11 = (long)((float)Pd11 * UpTimes);

            Level.text = Prod_11_Level.ToString();
            TotalProdMoneyText.text = (perOneAutoMoney11 * Prod_11_Level).ToString("###,###") + paneltext2;
            UpPriceText.text = Pd11.ToString("###,###");
        }
        else if (PanelNum == 12)
        {
            GameManager.money -= Pd12;
            Prod_12_Level++;
            Pd12 = (long)((float)Pd12 * UpTimes);

            Level.text = Prod_12_Level.ToString();
            TotalProdMoneyText.text = (perOneAutoMoney12 * Prod_12_Level).ToString("###,###") + paneltext2;
            UpPriceText.text = Pd12.ToString("###,###");
        }
        else if (PanelNum == 13)
        {
            GameManager.money -= Pd13;
            Prod_13_Level++;
            Pd13 = (long)((float)Pd13 * UpTimes);

            Level.text = Prod_13_Level.ToString();
            TotalProdMoneyText.text = (perOneAutoMoney13 * Prod_13_Level).ToString("###,###") + paneltext2;
            UpPriceText.text = Pd13.ToString("###,###");
        }
        else if (PanelNum == 14)
        {
            GameManager.money -= Pd14;
            Prod_14_Level++;
            Pd14 = (long)((float)Pd14 * UpTimes);

            Level.text = Prod_14_Level.ToString();
            TotalProdMoneyText.text = (perOneAutoMoney14 * Prod_14_Level).ToString("###,###") + paneltext2;
            UpPriceText.text = Pd14.ToString("###,###");
        }
        else if (PanelNum == 15)
        {
            GameManager.money -= Pd15;
            Prod_15_Level++;
            Pd15 = (long)((float)Pd15 * UpTimes);

            Level.text = Prod_15_Level.ToString();
            TotalProdMoneyText.text = (perOneAutoMoney15 * Prod_15_Level).ToString("###,###") + paneltext2;
            UpPriceText.text = Pd15.ToString("###,###");
        }
        else if (PanelNum == 17)
        {
            GameManager.money -= Pd17;
            Prod_17_Level++;
            Pd17 = (long)((float)Pd17 * UpTimes);

            Level.text = Prod_17_Level.ToString();
            TotalProdMoneyText.text = (perOneAutoMoney17 * Prod_17_Level).ToString("###,###") + paneltext2;
            UpPriceText.text = Pd17.ToString("###,###");
        }
        else if (PanelNum == 18)
        {
            GameManager.money -= Pd18;
            Prod_18_Level++;
            Pd18 = (long)((float)Pd18 * UpTimes);

            Level.text = Prod_18_Level.ToString();
            TotalProdMoneyText.text = (perOneAutoMoney18 * Prod_18_Level).ToString("###,###") + paneltext2;
            UpPriceText.text = Pd18.ToString("###,###");
        }
        else if (PanelNum == 19)
        {
            GameManager.money -= Pd19;
            Prod_19_Level++;
            Pd19 = (long)((float)Pd19 * UpTimes);

            Level.text = Prod_19_Level.ToString();
            TotalProdMoneyText.text = (perOneAutoMoney19 * Prod_19_Level).ToString("###,###") + paneltext2;
            UpPriceText.text = Pd19.ToString("###,###");
        }
        else if (PanelNum == 20)
        {
            GameManager.money -= Pd20;
            Prod_20_Level++;
            Pd20 = (long)((float)Pd20 * UpTimes);

            Level.text = Prod_20_Level.ToString();
            TotalProdMoneyText.text = (perOneAutoMoney20 * Prod_20_Level).ToString("###,###") + paneltext2;
            UpPriceText.text = Pd20.ToString("###,###");
        }
        else if (PanelNum == 21)
        {
            GameManager.money -= Pd21;
            Prod_21_Level++;
            Pd21 = (long)((float)Pd21 * UpTimes);

            Level.text = Prod_21_Level.ToString();
            TotalProdMoneyText.text = (perOneAutoMoney21 * Prod_21_Level).ToString("###,###") + paneltext2;
            UpPriceText.text = Pd21.ToString("###,###");
        }
        else if (PanelNum == 22)
        {
            GameManager.money -= Pd22;
            Prod_22_Level++;
            Pd22 = (long)((float)Pd22 * UpTimes);

            Level.text = Prod_22_Level.ToString();
            TotalProdMoneyText.text = (perOneAutoMoney22 * Prod_22_Level).ToString("###,###") + paneltext2;
            UpPriceText.text = Pd22.ToString("###,###");
        }
    }

    void ProdUpButtonCheck() // 업데이트 함수에 대입, 제품업글 버튼 활성화 여부 실시간으로 체크
    {
        if(PanelNum == 1)
        {
            if(GameManager.money >= Pd1)
            {
                UpgradeProdButton.interactable = true;
            }
            else
            {
                UpgradeProdButton.interactable = false;
            }
        }
        else if(PanelNum == 3)
        {
            if (GameManager.money >= Pd3)
            {
                UpgradeProdButton.interactable = true;
            }
            else
            {
                UpgradeProdButton.interactable = false;
            }
        }
        else if (PanelNum == 4)
        {
            if (GameManager.money >= Pd4)
            {
                UpgradeProdButton.interactable = true;
            }
            else
            {
                UpgradeProdButton.interactable = false;
            }
        }
        else if (PanelNum == 5)
        {
            if (GameManager.money >= Pd5)
            {
                UpgradeProdButton.interactable = true;
            }
            else
            {
                UpgradeProdButton.interactable = false;
            }
        }
        else if (PanelNum == 6)
        {
            if (GameManager.money >= Pd6)
            {
                UpgradeProdButton.interactable = true;
            }
            else
            {
                UpgradeProdButton.interactable = false;
            }
        }
        else if (PanelNum == 7)
        {
            if (GameManager.money >= Pd7)
            {
                UpgradeProdButton.interactable = true;
            }
            else
            {
                UpgradeProdButton.interactable = false;
            }
        }
        else if (PanelNum == 8)
        {
            if (GameManager.money >= Pd8)
            {
                UpgradeProdButton.interactable = true;
            }
            else
            {
                UpgradeProdButton.interactable = false;
            }
        }
        else if (PanelNum == 9)
        {
            if (GameManager.money >= Pd9)
            {
                UpgradeProdButton.interactable = true;
            }
            else
            {
                UpgradeProdButton.interactable = false;
            }
        }
        else if (PanelNum == 10)
        {
            if (GameManager.money >= Pd10)
            {
                UpgradeProdButton.interactable = true;
            }
            else
            {
                UpgradeProdButton.interactable = false;
            }
        }
        else if (PanelNum == 11)
        {
            if (GameManager.money >= Pd11)
            {
                UpgradeProdButton.interactable = true;
            }
            else
            {
                UpgradeProdButton.interactable = false;
            }
        }
        else if (PanelNum == 12)
        {
            if (GameManager.money >= Pd12)
            {
                UpgradeProdButton.interactable = true;
            }
            else
            {
                UpgradeProdButton.interactable = false;
            }
        }
        else if (PanelNum == 13)
        {
            if (GameManager.money >= Pd13)
            {
                UpgradeProdButton.interactable = true;
            }
            else
            {
                UpgradeProdButton.interactable = false;
            }
        }
        else if (PanelNum == 14)
        {
            if (GameManager.money >= Pd14)
            {
                UpgradeProdButton.interactable = true;
            }
            else
            {
                UpgradeProdButton.interactable = false;
            }
        }
        else if (PanelNum == 15)
        {
            if (GameManager.money >= Pd15)
            {
                UpgradeProdButton.interactable = true;
            }
            else
            {
                UpgradeProdButton.interactable = false;
            }
        }
        else if (PanelNum == 17)
        {
            if (GameManager.money >= Pd17)
            {
                UpgradeProdButton.interactable = true;
            }
            else
            {
                UpgradeProdButton.interactable = false;
            }
        }
        else if (PanelNum == 18)
        {
            if (GameManager.money >= Pd18)
            {
                UpgradeProdButton.interactable = true;
            }
            else
            {
                UpgradeProdButton.interactable = false;
            }
        }
        else if (PanelNum == 19)
        {
            if (GameManager.money >= Pd19)
            {
                UpgradeProdButton.interactable = true;
            }
            else
            {
                UpgradeProdButton.interactable = false;
            }
        }
        else if (PanelNum == 20)
        {
            if (GameManager.money >= Pd20)
            {
                UpgradeProdButton.interactable = true;
            }
            else
            {
                UpgradeProdButton.interactable = false;
            }
        }
        else if (PanelNum == 21)
        {
            if (GameManager.money >= Pd21)
            {
                UpgradeProdButton.interactable = true;
            }
            else
            {
                UpgradeProdButton.interactable = false;
            }
        }
        else if (PanelNum == 22)
        {
            if (GameManager.money >= Pd22)
            {
                UpgradeProdButton.interactable = true;
            }
            else
            {
                UpgradeProdButton.interactable = false;
            }
        }
        else
        {
            UpgradeProdButton.interactable = false;
        }
    }

    void SaveDataCheck_ProdUnlock()
    {
        if (TechManager.Tech1Complete == true)
        {
            ProdBtn1.SetActive(true);
        }
        if (TechManager.Tech3Complete == true)
        {
            ProdBtn3.SetActive(true);
        }
        if (TechManager.Tech4Complete == true)
        {
            ProdBtn4.SetActive(true);
        }
        if (TechManager.Tech5Complete == true)
        {
            ProdBtn5.SetActive(true);
        }
        if (TechManager.Tech6Complete == true)
        {
            ProdBtn6.SetActive(true);
        }
        if (TechManager.Tech7Complete == true)
        {
            ProdBtn7.SetActive(true);
        }
        if (TechManager.Tech8Complete == true)
        {
            ProdBtn8.SetActive(true);
        }
        if (TechManager.Tech9Complete == true)
        {
            ProdBtn9.SetActive(true);
        }
        if (TechManager.Tech10Complete == true)
        {
            ProdBtn10.SetActive(true);
        }
        if (TechManager.Tech11Complete == true)
        {
            ProdBtn11.SetActive(true);
        }
        if (TechManager.Tech12Complete == true)
        {
            ProdBtn12.SetActive(true);
        }
        if (TechManager.Tech13Complete == true)
        {
            ProdBtn13.SetActive(true);
        }
        if (TechManager.Tech14Complete == true)
        {
            ProdBtn14.SetActive(true);
        }
        if (TechManager.Tech15Complete == true)
        {
            ProdBtn15.SetActive(true);
        }
        if (TechManager.Tech17Complete == true)
        {
            ProdBtn17.SetActive(true);
        }
        if (TechManager.Tech18Complete == true)
        {
            ProdBtn18.SetActive(true);
        }
        if (TechManager.Tech19Complete == true)
        {
            ProdBtn19.SetActive(true);
        }
        if (TechManager.Tech20Complete == true)
        {
            ProdBtn20.SetActive(true);
        }
        if (TechManager.Tech21Complete == true)
        {
            ProdBtn21.SetActive(true);
        }
        if (TechManager.Tech22Complete == true)
        {
            ProdBtn22.SetActive(true);
        }
    }
    IEnumerator AutoMoneyGo()
    {
        while(true)
        {
            autoMoney = (perOneAutoMoney1 * Prod_1_Level) + (perOneAutoMoney3 * Prod_3_Level) + (perOneAutoMoney4 * Prod_4_Level) + (perOneAutoMoney5 * Prod_5_Level) + (perOneAutoMoney6 * Prod_6_Level) +
                    (perOneAutoMoney7 * Prod_7_Level) + (perOneAutoMoney8 * Prod_8_Level) + (perOneAutoMoney9 * Prod_9_Level) + (perOneAutoMoney10 * Prod_10_Level) + (perOneAutoMoney11 * Prod_11_Level) +
                    (perOneAutoMoney12 * Prod_12_Level) + (perOneAutoMoney13 * Prod_13_Level) + (perOneAutoMoney14 * Prod_14_Level) + (perOneAutoMoney15 * Prod_15_Level) + (perOneAutoMoney17 * Prod_17_Level) +
                    (perOneAutoMoney18 * Prod_18_Level) + (perOneAutoMoney19 * Prod_19_Level) + (perOneAutoMoney20 * Prod_20_Level) + (perOneAutoMoney21 * Prod_21_Level) + (perOneAutoMoney22 * Prod_22_Level);
            yield return new WaitForSeconds(0.3f);
        }
    }
}