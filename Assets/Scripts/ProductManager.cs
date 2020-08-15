using System.Collections;
using System.Collections.Generic;
using static System.Math;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Data.Common;

public class ProductManager : MonoBehaviour
{
    static public long autoMoney; // 통합 1초당 획득 돈
    static public long autoScience; // 통합 1초당 획득 연구력

    public float 업글비용배수;
    float UpTimes;
    

    //제품 업그레이드 비용
    public long pd1_뉴커멘엔진_업글비용;
    public static long Pd1; // 제품 업글비용 전역변수, 2번 제품 없음
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
    public static long Pd15; // 16번 제품 없음
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
    public long pd23_총신크랭크_업글비용;
    public static long Pd23;
    public long pd24_라디오_업글비용;
    public static long Pd24;
    public long pd25_룰러_업글비용;
    public static long Pd25;
    public long pd26_에어컨_업글비용;
    public static long Pd26;
    public long pd27_모스부호기_업글비용;
    public static long Pd27;
    public long pd28_운송폭탄_업글비용;
    public static long Pd28;
    public long pd29_자동차_업글비용;
    public static long Pd29;
    public long pd30_독가스_업글비용;
    public static long Pd30;
    public long pd31_에니그마_업글비용;
    public static long Pd31;
    public long pd32_무한궤도_업글비용;
    public static long Pd32;
    public long pd33_냉동식품_업글비용;
    public static long Pd33;
    public long pd34_페니실린_업글비용;
    public static long Pd34;
    public long pd35_터보제트_업글비용;
    public static long Pd35;
    public long pd36_스타킹_업글비용;
    public static long Pd36;
    public long pd37_우라늄_업글비용;
    public static long Pd37;
    public long pd38_컬러TV_업글비용;
    public static long Pd38;
    public long pd39_전자레인지_업글비용;
    public static long Pd39;
    public long pd40_트랜지스터플러스_업글비용;
    public static long Pd40;
    public long pd41_레이저포인트_업글비용;
    public static long Pd41;
    public long pd42_아스피린_업글비용;
    public static long Pd42;
    public long pd43_하드드라이브_업글비용;
    public static long Pd43;
    public long pd44_카세트_업글비용;
    public static long Pd44;
    public long pd45_LED_업글비용;
    public static long Pd45;
    public long pd46_다이제팜_업글비용;
    public static long Pd46;
    public long pd47_RAM_업글비용;
    public static long Pd47;
    public long pd48_계산기_업글비용;
    public static long Pd48;
    public long pd49_CPU_업글비용;
    public static long Pd49; // 50번 제품 없음
    public long pd51_LCD_업글비용;
    public static long Pd51;
    public long pd52_랜선_업글비용;
    public static long Pd52;
    public long pd53_MRI_업글비용;
    public static long Pd53;
    public long pd54_휴대폰_업글비용;
    public static long Pd54;
    public long pd55_휴대용게임기_업글비용;
    public static long Pd55;
    public long pd56_JAVA_업글비용;
    public static long Pd56; // 57번 제품 없음
    public long pd58_WIFI_업글비용;
    public static long Pd58;
    public long pd59_GPS_업글비용;
    public static long Pd59;
    public long pd60_대왕감자_업글비용;
    public static long Pd60;
    public long pd61_인터넷_업글비용;
    public static long Pd61;
    public long pd62_시험관_업글비용;
    public static long Pd62;
    public long pd63_GPU_업글비용;
    public static long Pd63;
    public long pd64_비트코인_업글비용;
    public static long Pd64;
    public long pd65_딥러닝_업글비용;
    public static long Pd65;
    public long pd66_10G_업글비용;
    public static long Pd66;
    public long pd67_VR_업글비용;
    public static long Pd67;
    public long pd68_AR_업글비용;
    public static long Pd68;
    public long pd69_유전자칩_업글비용;
    public static long Pd69;
    public long pd70_차원관문_업글비용;
    public static long Pd70;

    public long pdS01_영화개구리_구매비용;
    public static long PdS01;
    public long pdS02_음식보급기_구매비용;
    public static long PdS02;
    public long pdS03_컴퓨터_구매비용;
    public static long PdS03;
    public long pdS04_황제감자_구매비용;
    public static long PdS04;

    //제품 1개당 골드 생산량
    public long pd1_뉴커멘엔진_생산량;
    public static long perOneAutoMoney1; // 2번 제품 없음
    public long pd3_나는북_생산량;
    public static long perOneAutoMoney3;
    public long pd4_뮬방적기_생산량;
    public static long perOneAutoMoney4;
    public long pd7_기구_생산량;
    public static long perOneAutoMoney7;
    public long pd8_개구리전지_생산량;
    public static long perOneAutoMoney8;
    public long pd10_가스등_생산량;
    public static long perOneAutoMoney10;
    public long pd11_강철_생산량;
    public static long perOneAutoMoney11;
    public long pd12_냉장고_생산량;
    public static long perOneAutoMoney12;
    public long pd14_내연기관_생산량;
    public static long perOneAutoMoney14; // 16번 제품 없음
    public long pd17_다이너마이트_생산량;
    public static long perOneAutoMoney17;
    public long pd19_전화기_생산량;
    public static long perOneAutoMoney19;
    public long pd20_백열등_생산량;
    public static long perOneAutoMoney20;
    public long pd21_무선전신_생산량;
    public static long perOneAutoMoney21;
    public long pd23_총신크랭크_생산량;
    public static long perOneAutoMoney23;
    public long pd25_룰러_생산량;
    public static long perOneAutoMoney25;
    public long pd26_에어컨_생산량;
    public static long perOneAutoMoney26;
    public long pd28_운송폭탄_생산량;
    public static long perOneAutoMoney28;
    public long pd29_자동차_생산량;
    public static long perOneAutoMoney29;
    public long pd30_독가스_생산량;
    public static long perOneAutoMoney30;
    public long pd32_무한궤도_생산량;
    public static long perOneAutoMoney32;
    public long pd33_냉동식품_생산량;
    public static long perOneAutoMoney33;
    public long pd35_터보제트_생산량;
    public static long perOneAutoMoney35;
    public long pd36_스타킹_생산량;
    public static long perOneAutoMoney36;
    public long pd37_우라늄_생산량;
    public static long perOneAutoMoney37;
    public long pd38_컬러TV_생산량;
    public static long perOneAutoMoney38;
    public long pd39_전자레인지_생산량;
    public static long perOneAutoMoney39;
    public long pd41_레이저포인트_생산량;
    public static long perOneAutoMoney41;
    public long pd42_아스피린_생산량;
    public static long perOneAutoMoney42;
    public long pd44_카세트_생산량;
    public static long perOneAutoMoney44;
    public long pd45_LED_생산량;
    public static long perOneAutoMoney45;
    public long pd46_다이제팜_생산량;
    public static long perOneAutoMoney46;
    public long pd48_계산기_생산량;
    public static long perOneAutoMoney48; // 50번 제품 없음
    public long pd51_LCD_생산량;
    public static long perOneAutoMoney51;
    public long pd53_MRI_생산량;
    public static long perOneAutoMoney53;
    public long pd55_휴대용게임기_생산량;
    public static long perOneAutoMoney55;
    public long pd56_JAVA_생산량;
    public static long perOneAutoMoney56; // 57번 제품 없음
    public long pd59_GPS_생산량;
    public static long perOneAutoMoney59;
    public long pd61_인터넷_생산량;
    public static long perOneAutoMoney61;
    public long pd62_시험관_생산량;
    public static long perOneAutoMoney62;
    public long pd64_비트코인_생산량;
    public static long perOneAutoMoney64;
    public long pd65_딥러닝_생산량;
    public static long perOneAutoMoney65;
    public long pd67_VR_생산량;
    public static long perOneAutoMoney67;
    public long pd68_AR_생산량;
    public static long perOneAutoMoney68;
    public long pd70_차원관문_생산량;
    public static long perOneAutoMoney70;

    //제품 1개당 연구력 생산량
    public long pd5_실린더_연구생산량;
    public static long perOneAutoScience5;
    public long pd6_역직기_연구생산량;
    public static long perOneAutoScience6;
    public long pd9_볼타전지_연구생산량;
    public static long perOneAutoScience9;
    public long pd13_자석_연구생산량;
    public static long perOneAutoScience13;
    public long pd15_전신줄_연구생산량;
    public static long perOneAutoScience15;
    public long pd18_포노토그라프_연구생산량;
    public static long perOneAutoScience18;
    public long pd22_비행선_연구생산량;
    public static long perOneAutoScience22;
    public long pd24_라디오_연구생산량;
    public static long perOneAutoScience24;
    public long pd27_모스부호기_연구생산량;
    public static long perOneAutoScience27;
    public long pd31_에니그마_연구생산량;
    public static long perOneAutoScience31;
    public long pd34_페니실린_연구생산량;
    public static long perOneAutoScience34;
    public long pd37_우라늄_연구생산량;
    public static long perOneAutoScience37;
    public long pd40_트랜지스터플러스_연구생산량;
    public static long perOneAutoScience40;
    public long pd43_하드드라이브_연구생산량;
    public static long perOneAutoScience43;
    public long pd47_RAM_연구생산량;
    public static long perOneAutoScience47;
    public long pd49_CPU_연구생산량;
    public static long perOneAutoScience49;
    public long pd52_랜선_연구생산량;
    public static long perOneAutoScience52;
    public long pd54_휴대폰_연구생산량;
    public static long perOneAutoScience54;
    public long pd58_WIFI_연구생산량;
    public static long perOneAutoScience58;
    public long pd60_대왕감자_연구생산량;
    public static long perOneAutoScience60;
    public long pd63_GPU_연구생산량;
    public static long perOneAutoScience63;
    public long pd66_10G_연구생산량;
    public static long perOneAutoScience66;
    public long pd69_유전자칩_연구생산량;
    public static long perOneAutoScience69;

    //제품 레벨
    static public int Prod_1_Level; // 2번 제품 없음
    static public int Prod_3_Level;
    static public int Prod_4_Level;
    static public int Prod_5_Level;
    static public int Prod_6_Level;
    static public int Prod_7_Level;
    static public int Prod_8_Level;
    static public int Prod_9_Level;
    static public int Prod_10_Level;
    static public int Prod_11_Level;
    static public int Prod_12_Level;
    static public int Prod_13_Level;
    static public int Prod_14_Level;
    static public int Prod_15_Level; // 16번 제품 없음
    static public int Prod_17_Level;
    static public int Prod_18_Level;
    static public int Prod_19_Level;
    static public int Prod_20_Level;
    static public int Prod_21_Level;
    static public int Prod_22_Level;
    static public int Prod_23_Level;
    static public int Prod_24_Level;
    static public int Prod_25_Level;
    static public int Prod_26_Level;
    static public int Prod_27_Level;
    static public int Prod_28_Level;
    static public int Prod_29_Level;
    static public int Prod_30_Level;
    static public int Prod_31_Level;
    static public int Prod_32_Level;
    static public int Prod_33_Level;
    static public int Prod_34_Level;
    static public int Prod_35_Level;
    static public int Prod_36_Level;
    static public int Prod_37_Level;
    static public int Prod_38_Level;
    static public int Prod_39_Level;
    static public int Prod_40_Level;
    static public int Prod_41_Level;
    static public int Prod_42_Level;
    static public int Prod_43_Level;
    static public int Prod_44_Level;
    static public int Prod_45_Level;
    static public int Prod_46_Level;
    static public int Prod_47_Level;
    static public int Prod_48_Level;
    static public int Prod_49_Level; // 50번 제품 없음
    static public int Prod_51_Level;
    static public int Prod_52_Level;
    static public int Prod_53_Level;
    static public int Prod_54_Level;
    static public int Prod_55_Level;
    static public int Prod_56_Level; // 57번 제품 없음
    static public int Prod_58_Level;
    static public int Prod_59_Level;
    static public int Prod_60_Level;
    static public int Prod_61_Level;
    static public int Prod_62_Level;
    static public int Prod_63_Level;
    static public int Prod_64_Level;
    static public int Prod_65_Level;
    static public int Prod_66_Level;
    static public int Prod_67_Level;
    static public int Prod_68_Level;
    static public int Prod_69_Level;
    static public int Prod_70_Level;
    static public int Prod_S01_Level;
    static public int Prod_S02_Level;
    static public int Prod_S03_Level;
    static public int Prod_S04_Level;

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



    /* 우라늄 전용 패널 */
    public Text ProdMoneyText_U;
    public Text ProdScienceText_U;
    public Text TotalProdMoneyText_U;
    public Text UpPriceText_U;
    public Text Level_U;
    public GameObject ProdUpPanel_U; // 업그레이드 하는 패널
    public Button UpgradeProdButton_U;
    /* 우라늄 전용 패널 */



    public GameObject MainProdPanel; // 제품 메인 패널

    public GameObject ScrollBar_IND; // 제품 시대별 스크롤바
    public GameObject ScrollBar_WAR;
    public GameObject ScrollBar_ELEC;
    public GameObject ScrollBar_MODERN;

    public GameObject ProdPanel_IND; // 제품 시대별 패널
    public GameObject ProdPanel_WAR;
    public GameObject ProdPanel_ELEC;
    public GameObject ProdPanel_MODERN;

    string paneltext1 = " 생산";
    string paneltext2 = " 생산 중";
    string paneltext3 = "0 생산 중";
    string paneltext4 = "최대 레벨";




    public short PanelNum;

    //제품 아이콘 버튼
    public GameObject ProdBtn1; // 2번 제품 없음
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
    public GameObject ProdBtn15; // 16번 제품 없음
    public GameObject ProdBtn17;
    public GameObject ProdBtn18;
    public GameObject ProdBtn19;
    public GameObject ProdBtn20;
    public GameObject ProdBtn21;
    public GameObject ProdBtn22;
    public GameObject ProdBtn23;
    public GameObject ProdBtn24;
    public GameObject ProdBtn25;
    public GameObject ProdBtn26;
    public GameObject ProdBtn27;
    public GameObject ProdBtn28;
    public GameObject ProdBtn29;
    public GameObject ProdBtn30;
    public GameObject ProdBtn31;
    public GameObject ProdBtn32;
    public GameObject ProdBtn33;
    public GameObject ProdBtn34;
    public GameObject ProdBtn35;
    public GameObject ProdBtn36;
    public GameObject ProdBtn37;
    public GameObject ProdBtn38;
    public GameObject ProdBtn39;
    public GameObject ProdBtn40;
    public GameObject ProdBtn41;
    public GameObject ProdBtn42;
    public GameObject ProdBtn43;
    public GameObject ProdBtn44;
    public GameObject ProdBtn45;
    public GameObject ProdBtn46;
    public GameObject ProdBtn47;
    public GameObject ProdBtn48;
    public GameObject ProdBtn49; // 50번 제품 없음
    public GameObject ProdBtn51;
    public GameObject ProdBtn52;
    public GameObject ProdBtn53;
    public GameObject ProdBtn54;
    public GameObject ProdBtn55;
    public GameObject ProdBtn56; // 57번 제품 없음
    public GameObject ProdBtn58;
    public GameObject ProdBtn59;
    public GameObject ProdBtn60;
    public GameObject ProdBtn61;
    public GameObject ProdBtn62;
    public GameObject ProdBtn63;
    public GameObject ProdBtn64;
    public GameObject ProdBtn65;
    public GameObject ProdBtn66;
    public GameObject ProdBtn67;
    public GameObject ProdBtn68;
    public GameObject ProdBtn69;
    public GameObject ProdBtn70;
    public GameObject ProdBtnS01; // 혁신제품
    public GameObject ProdBtnS02;
    public GameObject ProdBtnS03;
    public GameObject ProdBtnS04;

    //제품탭 외부에 표시되는 제품 갯수(레벨)
    public Text ProdLevel_01; // 2번 제품 없음
    public Text ProdLevel_03;
    public Text ProdLevel_04;
    public Text ProdLevel_05;
    public Text ProdLevel_06;
    public Text ProdLevel_07;
    public Text ProdLevel_08;
    public Text ProdLevel_09;
    public Text ProdLevel_10;
    public Text ProdLevel_11;
    public Text ProdLevel_12;
    public Text ProdLevel_13;
    public Text ProdLevel_14;
    public Text ProdLevel_15; // 16번 제품 없음
    public Text ProdLevel_17;
    public Text ProdLevel_18;
    public Text ProdLevel_19;
    public Text ProdLevel_20;
    public Text ProdLevel_21;
    public Text ProdLevel_22;
    public Text ProdLevel_23;
    public Text ProdLevel_24;
    public Text ProdLevel_25;
    public Text ProdLevel_26;
    public Text ProdLevel_27;
    public Text ProdLevel_28;
    public Text ProdLevel_29;
    public Text ProdLevel_30;
    public Text ProdLevel_31;
    public Text ProdLevel_32;
    public Text ProdLevel_33;
    public Text ProdLevel_34;
    public Text ProdLevel_35;
    public Text ProdLevel_36;
    public Text ProdLevel_37;
    public Text ProdLevel_38;
    public Text ProdLevel_39;
    public Text ProdLevel_40;
    public Text ProdLevel_41;
    public Text ProdLevel_42;
    public Text ProdLevel_43;
    public Text ProdLevel_44;
    public Text ProdLevel_45;
    public Text ProdLevel_46;
    public Text ProdLevel_47;
    public Text ProdLevel_48;
    public Text ProdLevel_49; // 50번 제품 없음
    public Text ProdLevel_51;
    public Text ProdLevel_52;
    public Text ProdLevel_53;
    public Text ProdLevel_54;
    public Text ProdLevel_55;
    public Text ProdLevel_56; // 57번 제품 없음
    public Text ProdLevel_58;
    public Text ProdLevel_59;
    public Text ProdLevel_60;
    public Text ProdLevel_61;
    public Text ProdLevel_62;
    public Text ProdLevel_63;
    public Text ProdLevel_64;
    public Text ProdLevel_65;
    public Text ProdLevel_66;
    public Text ProdLevel_67;
    public Text ProdLevel_68;
    public Text ProdLevel_69;
    public Text ProdLevel_70;

    //제품 스프라이트
    public Sprite ProdIcon1; // 2번 제품 없음
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
    public Sprite ProdIcon15; // 16번 제품 없음
    public Sprite ProdIcon17;
    public Sprite ProdIcon18;
    public Sprite ProdIcon19;
    public Sprite ProdIcon20;
    public Sprite ProdIcon21;
    public Sprite ProdIcon22;
    public Sprite ProdIcon23;
    public Sprite ProdIcon24;
    public Sprite ProdIcon25;
    public Sprite ProdIcon26;
    public Sprite ProdIcon27;
    public Sprite ProdIcon28;
    public Sprite ProdIcon29;
    public Sprite ProdIcon30;
    public Sprite ProdIcon31;
    public Sprite ProdIcon32;
    public Sprite ProdIcon33;
    public Sprite ProdIcon34;
    public Sprite ProdIcon35;
    public Sprite ProdIcon36;
    public Sprite ProdIcon37;
    public Sprite ProdIcon38;
    public Sprite ProdIcon39;
    public Sprite ProdIcon40;
    public Sprite ProdIcon41;
    public Sprite ProdIcon42;
    public Sprite ProdIcon43;
    public Sprite ProdIcon44;
    public Sprite ProdIcon45;
    public Sprite ProdIcon46;
    public Sprite ProdIcon47;
    public Sprite ProdIcon48;
    public Sprite ProdIcon49; // 50번 제품 없음
    public Sprite ProdIcon51;
    public Sprite ProdIcon52;
    public Sprite ProdIcon53;
    public Sprite ProdIcon54;
    public Sprite ProdIcon55;
    public Sprite ProdIcon56; // 57번 제품 없음
    public Sprite ProdIcon58;
    public Sprite ProdIcon59;
    public Sprite ProdIcon60;
    public Sprite ProdIcon61;
    public Sprite ProdIcon62;
    public Sprite ProdIcon63;
    public Sprite ProdIcon64;
    public Sprite ProdIcon65;
    public Sprite ProdIcon66;
    public Sprite ProdIcon67;
    public Sprite ProdIcon68;
    public Sprite ProdIcon69;
    public Sprite ProdIcon70;
    public Sprite ProdIconS01;
    public Sprite ProdIconS02;
    public Sprite ProdIconS03;
    public Sprite ProdIconS04;

    /* 제품 변화 요소 관련 */
    public GameObject Product_Reward01_06;
    public GameObject Product_Reward02_07;
    public GameObject Product_Reward04_18;
    public GameObject Product_Reward05_24;
    public GameObject Product_Reward06_33;
    public GameObject Product_Reward08_37;
    public GameObject Product_Reward09_42;
    public GameObject Product_Reward10_44;
    public GameObject Product_Reward12_S03;
    public GameObject Product_Reward14_60;

    public GameObject Product_Reward_라디오;
    public GameObject Product_Reward_카세트;
    public GameObject Product_Reward_컴퓨터;

    Transform tr_airship;
    // ------------------


    /* 혁신제품 생산가능 판단변수 */
    static public bool PdS01Complete;
    static public bool PdS02Complete;
    static public bool PdS03Complete;
    static public bool PdS04Complete;

    public Image infoPanel_icon;
    public Sprite infoPanel_icon_Gold;
    public Sprite infoPanel_icon_Science;
    public Sprite infoPanel_icon_Special;

    static public bool JumpINDpossible;
    static public bool JumpWARpossible;
    static public bool JumpELECpossible;
    static public bool JumpMODERNpossible;
    // -----------------------------------


    /* 제품탭 시대버튼 관련 */
    public Button indTap_WarButton;
    public Button indTap_ElecButton;
    public Button indTap_ModernButton;
    public Text indTap_WarText;
    public Text indTap_ElecText;
    public Text indTap_ModernText;
    public Image indTap_WarImage;
    public Image indTap_ElecImage;
    public Image indTap_ModernImage;

    public Button warTap_ElecButton;
    public Button warTap_ModernButton;
    public Text warTap_ElecText;
    public Text warTap_ModernText;
    public Image warTap_ElecImage;
    public Image warTap_ModernImage;

    public Button elecTap_ModernButton;
    public Text elecTap_ModernText;
    public Image elecTap_ModernImage;

    public Sprite ProductTap_unlockTap;
    // --------------------------------

    public long MaxPrice;



    void Awake()
    {
        MainProdPanel.SetActive(true);
        ProdPanel_IND.SetActive(true);
        ProdPanel_WAR.SetActive(true);
        ProdPanel_ELEC.SetActive(true);
        ProdPanel_MODERN.SetActive(true);
        ScrollBar_IND.GetComponent<Scrollbar>().value = 1;
        ScrollBar_WAR.GetComponent<Scrollbar>().value = 1;
        ScrollBar_ELEC.GetComponent<Scrollbar>().value = 1;
        ScrollBar_MODERN.GetComponent<Scrollbar>().value = 1;

        if (GameManager.RePlay == false)
        {
            Pd1 = pd1_뉴커멘엔진_업글비용; // 2번 제품 없음
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
            Pd15 = pd15_전신줄_업글비용; // 16번 제품 없음
            Pd17 = pd17_다이너마이트_업글비용;
            Pd18 = pd18_포노토그라프_업글비용;
            Pd19 = pd19_전화기_업글비용;
            Pd20 = pd20_백열등_업글비용;
            Pd21 = pd21_무선전신_업글비용;
            Pd22 = pd22_비행선_업글비용;
            Pd23 = pd23_총신크랭크_업글비용;
            Pd24 = pd24_라디오_업글비용;
            Pd25 = pd25_룰러_업글비용;
            Pd26 = pd26_에어컨_업글비용;
            Pd27 = pd27_모스부호기_업글비용;
            Pd28 = pd28_운송폭탄_업글비용;
            Pd29 = pd29_자동차_업글비용;
            Pd30 = pd30_독가스_업글비용;
            Pd31 = pd31_에니그마_업글비용;
            Pd32 = pd32_무한궤도_업글비용;
            Pd33 = pd33_냉동식품_업글비용;
            Pd34 = pd34_페니실린_업글비용;
            Pd35 = pd35_터보제트_업글비용;
            Pd36 = pd36_스타킹_업글비용;
            Pd37 = pd37_우라늄_업글비용;
            Pd38 = pd38_컬러TV_업글비용;
            Pd39 = pd39_전자레인지_업글비용;
            Pd40 = pd40_트랜지스터플러스_업글비용;
            Pd41 = pd41_레이저포인트_업글비용;
            Pd42 = pd42_아스피린_업글비용;
            Pd43 = pd43_하드드라이브_업글비용;
            Pd44 = pd44_카세트_업글비용;
            Pd45 = pd45_LED_업글비용;
            Pd46 = pd46_다이제팜_업글비용;
            Pd47 = pd47_RAM_업글비용;
            Pd48 = pd48_계산기_업글비용;
            Pd49 = pd49_CPU_업글비용; // 50번 제품 없음
            Pd51 = pd51_LCD_업글비용;
            Pd52 = pd52_랜선_업글비용;
            Pd53 = pd53_MRI_업글비용;
            Pd54 = pd54_휴대폰_업글비용;
            Pd55 = pd55_휴대용게임기_업글비용;
            Pd56 = pd56_JAVA_업글비용; // 57번 제품 없음
            Pd58 = pd58_WIFI_업글비용;
            Pd59 = pd59_GPS_업글비용;
            Pd60 = pd60_대왕감자_업글비용;
            Pd61 = pd61_인터넷_업글비용;
            Pd62 = pd62_시험관_업글비용;
            Pd63 = pd63_GPU_업글비용;
            Pd64 = pd64_비트코인_업글비용;
            Pd65 = pd65_딥러닝_업글비용;
            Pd66 = pd66_10G_업글비용;
            Pd67 = pd67_VR_업글비용;
            Pd68 = pd68_AR_업글비용;
            Pd69 = pd69_유전자칩_업글비용;
            Pd70 = pd70_차원관문_업글비용;
            PdS01 = pdS01_영화개구리_구매비용;
            PdS02 = pdS02_음식보급기_구매비용;
            PdS03 = pdS03_컴퓨터_구매비용;
            PdS04 = pdS04_황제감자_구매비용;
        }

        perOneAutoMoney1 = pd1_뉴커멘엔진_생산량; // 2번 제품 없음
        perOneAutoMoney3 = pd3_나는북_생산량;
        perOneAutoMoney4 = pd4_뮬방적기_생산량;
        perOneAutoScience5 = pd5_실린더_연구생산량;
        perOneAutoScience6 = pd6_역직기_연구생산량;
        perOneAutoMoney7 = pd7_기구_생산량;
        perOneAutoMoney8 = pd8_개구리전지_생산량;
        perOneAutoScience9 = pd9_볼타전지_연구생산량;
        perOneAutoMoney10 = pd10_가스등_생산량;
        perOneAutoMoney11 = pd11_강철_생산량;
        perOneAutoMoney12 = pd12_냉장고_생산량;
        perOneAutoScience13 = pd13_자석_연구생산량;
        perOneAutoMoney14 = pd14_내연기관_생산량;
        perOneAutoScience15 = pd15_전신줄_연구생산량; // 16번 제품 없음
        perOneAutoMoney17 = pd17_다이너마이트_생산량;
        perOneAutoScience18 = pd18_포노토그라프_연구생산량;
        perOneAutoMoney19 = pd19_전화기_생산량;
        perOneAutoMoney20 = pd20_백열등_생산량;
        perOneAutoMoney21 = pd21_무선전신_생산량;
        perOneAutoScience22 = pd22_비행선_연구생산량;
        perOneAutoMoney23 = pd23_총신크랭크_생산량;
        perOneAutoScience24 = pd24_라디오_연구생산량;
        perOneAutoMoney25 = pd25_룰러_생산량;
        perOneAutoMoney26 = pd26_에어컨_생산량;
        perOneAutoScience27 = pd27_모스부호기_연구생산량;
        perOneAutoMoney28 = pd28_운송폭탄_생산량;
        perOneAutoMoney29 = pd29_자동차_생산량;
        perOneAutoMoney30 = pd30_독가스_생산량;
        perOneAutoScience31 = pd31_에니그마_연구생산량;
        perOneAutoMoney32 = pd32_무한궤도_생산량;
        perOneAutoMoney33 = pd33_냉동식품_생산량;
        perOneAutoScience34 = pd34_페니실린_연구생산량;
        perOneAutoMoney35 = pd35_터보제트_생산량;
        perOneAutoMoney36 = pd36_스타킹_생산량;
        perOneAutoMoney37 = pd37_우라늄_생산량;
        perOneAutoScience37 = pd37_우라늄_연구생산량;
        perOneAutoMoney38 = pd38_컬러TV_생산량;
        perOneAutoMoney39 = pd39_전자레인지_생산량;
        perOneAutoScience40 = pd40_트랜지스터플러스_연구생산량;
        perOneAutoMoney41 = pd41_레이저포인트_생산량;
        perOneAutoMoney42 = pd42_아스피린_생산량;
        perOneAutoScience43 = pd43_하드드라이브_연구생산량;
        perOneAutoMoney44 = pd44_카세트_생산량;
        perOneAutoMoney45 = pd45_LED_생산량;
        perOneAutoMoney46 = pd46_다이제팜_생산량;
        perOneAutoScience47 = pd47_RAM_연구생산량;
        perOneAutoMoney48 = pd48_계산기_생산량;
        perOneAutoScience49 = pd49_CPU_연구생산량; // 50번 제품 없음
        perOneAutoMoney51 = pd51_LCD_생산량;
        perOneAutoScience52 = pd52_랜선_연구생산량;
        perOneAutoMoney53 = pd53_MRI_생산량;
        perOneAutoScience54 = pd54_휴대폰_연구생산량;
        perOneAutoMoney55 = pd55_휴대용게임기_생산량;
        perOneAutoMoney56 = pd56_JAVA_생산량; // 57번 제품 없음
        perOneAutoScience58 = pd58_WIFI_연구생산량;
        perOneAutoMoney59 = pd59_GPS_생산량;
        perOneAutoScience60 = pd60_대왕감자_연구생산량;
        perOneAutoMoney61 = pd61_인터넷_생산량;
        perOneAutoMoney62 = pd62_시험관_생산량;
        perOneAutoScience63 = pd63_GPU_연구생산량;
        perOneAutoMoney64 = pd64_비트코인_생산량;
        perOneAutoMoney65 = pd65_딥러닝_생산량;
        perOneAutoScience66 = pd66_10G_연구생산량;
        perOneAutoMoney67 = pd67_VR_생산량;
        perOneAutoMoney68 = pd68_AR_생산량;
        perOneAutoScience69 = pd69_유전자칩_연구생산량;
        perOneAutoMoney70 = pd70_차원관문_생산량;

        UpTimes = 업글비용배수;

        Product_Reward01_06.SetActive(false);
        Product_Reward02_07.SetActive(false);
        Product_Reward04_18.SetActive(false);
        Product_Reward05_24.SetActive(false);
        Product_Reward06_33.SetActive(false);
        Product_Reward08_37.SetActive(false);
        Product_Reward09_42.SetActive(false);
        Product_Reward10_44.SetActive(false);
        Product_Reward12_S03.SetActive(false);
        Product_Reward14_60.SetActive(false);

        tr_airship = Product_Reward02_07.GetComponent<Transform>();
    }
    void Start()
    {
        MainProdPanel.SetActive(false);
        ProdPanel_WAR.SetActive(false);
        ProdPanel_ELEC.SetActive(false);
        ProdPanel_MODERN.SetActive(false);
        StartCoroutine(AutoMoneyGo());
        StartCoroutine(AutoScienceGo());
        SaveDataCheck_ProdUnlock();
        StartCoroutine(ProdUpButtonCheck());
        StartCoroutine(SpecialProductIconCheck());
        StartCoroutine(NextERApossible());
        StartCoroutine(Airship_moving());
        StartCoroutine(ProductAgeTapCheck());
    }

    void Update()
    {

    }

    IEnumerator NextERApossible() // 우주선4번째 업글 판단을 위한 파서블변수
    {
        while(true)
        {
            if (JumpINDpossible == false && Prod_1_Level > 0 && Prod_3_Level > 0 && Prod_4_Level > 0 && Prod_5_Level > 0 && Prod_6_Level > 0 && Prod_7_Level > 0 && Prod_8_Level > 0 && Prod_9_Level > 0 && Prod_10_Level > 0 && Prod_11_Level > 0
                && Prod_12_Level > 0 && Prod_13_Level > 0 && Prod_14_Level > 0 && Prod_15_Level > 0 && Prod_17_Level > 0 && Prod_18_Level > 0 && Prod_19_Level > 0 && Prod_20_Level > 0 && Prod_21_Level > 0 && Prod_22_Level > 0 && Prod_S01_Level > 0)
            {
                JumpINDpossible = true;
            }

            if (JumpWARpossible == false && Prod_23_Level > 0 && Prod_24_Level > 0 && Prod_25_Level > 0 && Prod_26_Level > 0 && Prod_27_Level > 0 && Prod_28_Level > 0 && Prod_29_Level > 0 && Prod_30_Level > 0 && Prod_31_Level > 0
                && Prod_32_Level > 0 && Prod_33_Level > 0 && Prod_34_Level > 0 && Prod_35_Level > 0 && Prod_36_Level > 0 && Prod_37_Level > 0 && Prod_S02_Level > 0)
            {
                JumpWARpossible = true;
            }

            if (JumpELECpossible == false && Prod_38_Level > 0 && Prod_39_Level > 0 && Prod_40_Level > 0 && Prod_41_Level > 0 && Prod_42_Level > 0 && Prod_43_Level > 0 && Prod_44_Level > 0 && Prod_45_Level > 0 && Prod_46_Level > 0
                && Prod_47_Level > 0 && Prod_48_Level > 0 && Prod_49_Level > 0 && Prod_51_Level > 0 && Prod_52_Level > 0 && Prod_53_Level > 0 && Prod_54_Level > 0 && Prod_55_Level > 0 && Prod_S03_Level > 0)
            {
                JumpELECpossible = true;
            }

            if (JumpMODERNpossible == false && Prod_56_Level > 0 && Prod_58_Level > 0 && Prod_59_Level > 0 && Prod_60_Level > 0 && Prod_61_Level > 0 && Prod_62_Level > 0 && Prod_63_Level > 0 && Prod_64_Level > 0 && Prod_65_Level > 0
                && Prod_66_Level > 0 && Prod_67_Level > 0 && Prod_68_Level > 0 && Prod_69_Level > 0 && Prod_70_Level > 0 && Prod_S04_Level > 0)
            {
                JumpMODERNpossible = true;
            }

            yield return new WaitForSeconds(1f);
        }
    }

    public void Prod_1_Open() // 제품 아이콘 버튼에 대입
    {
        if (TechManager.Tech1Complete)
        {
            title.text = "뉴커멘엔진";
            exp.text = "영국과 유럽 전역에서 주로 새로운 광산 엔진이 광산에서 물을 펌핑하는 데 사용되었습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon1;
            Level.text = Prod_1_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney1) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney1 * Prod_1_Level) + paneltext2;
            if(Prod_1_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd1);
            PanelNum = 1;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_3_Open()
    {
        if (TechManager.Tech3Complete)
        {
            title.text = "나는북";
            exp.text = "기존 수직기의 능률을 크게 향상시킨 제품입니다. 북이 좌우로 흔들리며 섬유를 재단합니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon3;
            Level.text = Prod_3_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney3) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney3 * Prod_3_Level) + paneltext2;
            if (Prod_3_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd3);
            PanelNum = 3;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_4_Open()
    {
        if (TechManager.Tech4Complete)
        {
            title.text = "뮬방적기";
            exp.text = "이전의 모든 방적기를 뛰어넘는 방적기 입니다. 빠른 속도로 실을 뽑아냅니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon4;
            Level.text = Prod_4_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney4) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney4 * Prod_4_Level) + paneltext2;
            if (Prod_4_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd4);
            PanelNum = 4;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;

        }
    }
    public void Prod_5_Open()
    {
        if (TechManager.Tech5Complete)
        {
            title.text = "실린더";
            exp.text = "증기기관과 내연기관의 주요한 부품입니다. 내부에서 피스톤을 압력에 의해 왕복 운동시킵니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon5;
            Level.text = Prod_5_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoScience5) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience5 * Prod_5_Level) + paneltext2;
            if (Prod_5_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd5);
            PanelNum = 5;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_6_Open()
    {
        if (TechManager.Tech6Complete)
        {
            title.text = "역직기";
            exp.text = "인간의 힘이 아닌 다른 동력원으로도 베를 짤 수 있습니다. 인간의 삶의 질을 향상시킵니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon6;
            Level.text = Prod_6_Level.ToString();
            ProdMoneyText.text = perOneAutoScience6.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoScience6 * Prod_6_Level).ToString("###,###") + paneltext2;
            if (Prod_6_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd6);
            PanelNum = 6;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_7_Open()
    {
        if (TechManager.Tech7Complete)
        {
            title.text = "기구";
            exp.text = "원하는 만큼은 아니지만 인간이 공중을 돌아다닐 수 있습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon7;
            Level.text = Prod_7_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney7.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney7 * Prod_7_Level).ToString("###,###") + paneltext2;
            if (Prod_7_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd7);
            PanelNum = 7;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_8_Open()
    {
        if (TechManager.Tech8Complete)
        {
            title.text = "개구리전지";
            exp.text = "개구리 뒷다리로 전지를 만들었습니다. 실용성은 없지만 신기해서 잘 팔립니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon8;
            Level.text = Prod_8_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney8.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney8 * Prod_8_Level).ToString("###,###") + paneltext2;
            if (Prod_8_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd8);
            PanelNum = 8;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_9_Open()
    {
        if (TechManager.Tech9Complete)
        {
            title.text = "볼타전지";
            exp.text = "전류를 지속적으로 발생 할 수 있습니다. 아직은 미약합니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon9;
            Level.text = Prod_9_Level.ToString();
            ProdMoneyText.text = perOneAutoScience9.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoScience9 * Prod_9_Level).ToString("###,###") + paneltext2;
            if (Prod_9_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd9);
            PanelNum = 9;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_10_Open()
    {
        if (TechManager.Tech10Complete)
        {
            title.text = "가스등";
            exp.text = "석탄 가스를 도관에 흐르게 해서 밤을 밝힙니다. 인간이 활동할 수 있는 시간적 범위가 늘어납니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon10;
            Level.text = Prod_10_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney10.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney10 * Prod_10_Level).ToString("###,###") + paneltext2;
            if (Prod_10_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd10);
            PanelNum = 10;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_11_Open()
    {
        if (TechManager.Tech11Complete)
        {
            title.text = "강철";
            exp.text = "산업을 이끄는 더 단단한 물질을 만들 수 있습니다. 많은 기계에 이 재료가 필요합니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon11;
            Level.text = Prod_11_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney11.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney11 * Prod_11_Level).ToString("###,###") + paneltext2;
            if (Prod_11_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd11);
            PanelNum = 11;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_12_Open()
    {
        if (TechManager.Tech12Complete)
        {
            title.text = "냉장고";
            exp.text = "음식을 서늘한 곳에서 더 오래 보관할 수 있습니다. 음식이 상하는 것을 방지합니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon12;
            Level.text = Prod_12_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney12.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney12 * Prod_12_Level).ToString("###,###") + paneltext2;
            if (Prod_12_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd12);
            PanelNum = 12;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_13_Open()
    {
        if (TechManager.Tech13Complete)
        {
            title.text = "자석";
            exp.text = "자성을 띈 광물로 만든 물건입니다. 같은 극이면 밀어내고, 다른 극이면 달라붙습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon13;
            Level.text = Prod_13_Level.ToString();
            ProdMoneyText.text = perOneAutoScience13.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoScience13 * Prod_13_Level).ToString("###,###") + paneltext2;
            if (Prod_13_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd13);
            PanelNum = 13;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_14_Open()
    {
        if (TechManager.Tech14Complete)
        {
            title.text = "내연기관";
            exp.text = "연소를 시켜 동력을 얻는 기관입니다. 각종 에너지를 운동으로 바꿔줍니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon14;
            Level.text = Prod_14_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney14.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney14 * Prod_14_Level).ToString("###,###") + paneltext2;
            if (Prod_14_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd14);
            PanelNum = 14;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_15_Oepn()
    {
        if (TechManager.Tech15Complete)
        {
            title.text = "전신줄";
            exp.text = "전기가 흐를 수 있는 도체로 연결한 선입니다. 이 선 하나로 세상 어디든 전기를 보낼 수 있습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon15;
            Level.text = Prod_15_Level.ToString();
            ProdMoneyText.text = perOneAutoScience15.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoScience15 * Prod_15_Level).ToString("###,###") + paneltext2;
            if (Prod_15_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd15);
            PanelNum = 15;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_17_Oepn()
    {
        if (TechManager.Tech17Complete)
        {
            title.text = "다이너마이트";
            exp.text = "안정성을 늘린 폭탄입니다. 구멍을 팔때는 뚫기보다는 부수는게 쉽다는 것을 알아냈습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon17;
            Level.text = Prod_17_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney17.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney17 * Prod_17_Level).ToString("###,###") + paneltext2;
            if (Prod_17_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd17);
            PanelNum = 17;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_18_Oepn()
    {
        if (TechManager.Tech18Complete)
        {
            title.text = "포노토그라프";
            exp.text = "음의 진동을 음향 패턴의 형태로 볼 수 있습니다. 소리를 눈으로 볼 수 있는 제품입니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon18;
            Level.text = Prod_18_Level.ToString();
            ProdMoneyText.text = perOneAutoScience18.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoScience18 * Prod_18_Level).ToString("###,###") + paneltext2;
            if (Prod_18_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd18);
            PanelNum = 18;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_19_Oepn()
    {
        if (TechManager.Tech19Complete)
        {
            title.text = "전화기";
            exp.text = "음성을 전기신호로 바꾸어 먼 곳으로 전송하고, 신호를 다시 음성으로 재생합니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon19;
            Level.text = Prod_19_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney19.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney19 * Prod_19_Level).ToString("###,###") + paneltext2;
            if (Prod_19_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd19);
            PanelNum = 19;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_20_Oepn()
    {
        if (TechManager.Tech20Complete)
        {
            title.text = "백열등";
            exp.text = "전구 내부의 필라멘트를 가열해 빛을 내는 조명장치 입니다. 집에서도 밤에 활동이 가능합니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon20;
            Level.text = Prod_20_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney20.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney20 * Prod_20_Level).ToString("###,###") + paneltext2;
            if (Prod_20_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd20);
            PanelNum = 20;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_21_Oepn()
    {
        if (TechManager.Tech21Complete)
        {
            title.text = "무선전신기";
            exp.text = "전파를 맞추고 송신기를 통해 통신할 수 있습니다. 주파수를 통해 연결합니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon21;
            Level.text = Prod_21_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney21.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney21 * Prod_21_Level).ToString("###,###") + paneltext2;
            if (Prod_21_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd21);
            PanelNum = 21;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_22_Oepn()
    {
        if (TechManager.Tech22Complete)
        {
            title.text = "비행선";
            exp.text = "하늘에서 원하는 방향으로 이동할 수 있는 도구입니다. 활동 반경이 넓어집니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon22;
            Level.text = Prod_22_Level.ToString();
            ProdMoneyText.text = perOneAutoScience22.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoScience22 * Prod_22_Level).ToString("###,###") + paneltext2;
            if (Prod_22_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd22);
            PanelNum = 22;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_23_Oepn()
    {
        if (TechManager.Tech23Complete)
        {
            title.text = "총신크랭크";
            exp.text = "총에다 끼우는 크랭크 축입니다. 총을 연속적으로 사용할 수 있도록 돕습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon23;
            Level.text = Prod_23_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney23.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney23 * Prod_23_Level).ToString("###,###") + paneltext2;
            if (Prod_23_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd23);
            PanelNum = 23;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_24_Oepn()
    {
        if (TechManager.Tech24Complete)
        {
            title.text = "라디오";
            exp.text = "주파수를 통해 방송합니다. 정보의 전파 속도가 더욱 빨라집니다. ";
            Icon.GetComponent<Image>().sprite = ProdIcon24;
            Level.text = Prod_24_Level.ToString();
            ProdMoneyText.text = perOneAutoScience24.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoScience24 * Prod_24_Level).ToString("###,###") + paneltext2;
            if (Prod_24_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd24);
            PanelNum = 24;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_25_Oepn()
    {
        if (TechManager.Tech25Complete)
        {
            title.text = "룰러";
            exp.text = "회전하는 원통형의 물건입니다. 인쇄술 등 다양한 분야에 활용됩니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon25;
            Level.text = Prod_25_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney25.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney25 * Prod_25_Level).ToString("###,###") + paneltext2;
            if (Prod_25_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd25);
            PanelNum = 25;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_26_Oepn()
    {
        if (TechManager.Tech26Complete)
        {
            title.text = "에어컨";
            exp.text = "일정한 공간을 시원하게 하는 도구입니다. 자연을 극복하고 일의 능률을 올립니다";
            Icon.GetComponent<Image>().sprite = ProdIcon26;
            Level.text = Prod_26_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney26.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney26 * Prod_26_Level).ToString("###,###") + paneltext2;
            if (Prod_26_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd26);
            PanelNum = 26;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_27_Oepn()
    {
        if (TechManager.Tech27Complete)
        {
            title.text = "모스부호기";
            exp.text = "전신용 기호를 통해 통신합니다. 발신전류 만을 가지고 문장을 구성하고 전달합니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon27;
            Level.text = Prod_27_Level.ToString();
            ProdMoneyText.text = perOneAutoScience27.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoScience27 * Prod_27_Level).ToString("###,###") + paneltext2;
            if (Prod_27_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd27);
            PanelNum = 27;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_28_Oepn()
    {
        if (TechManager.Tech28Complete)
        {
            title.text = "운송폭탄";
            exp.text = "운반할 수 있는 폭발하는 물질입니다. 폭발 시 파괴, 화재, 붕괴 그리고 공포심을 유발합니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon28;
            Level.text = Prod_28_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney28.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney28 * Prod_28_Level).ToString("###,###") + paneltext2;
            if (Prod_28_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd28);
            PanelNum = 28;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_29_Oepn()
    {
        if (TechManager.Tech29Complete)
        {
            title.text = "자동차";
            exp.text = "땅 위를 일정한 속도로 달릴 수 있는 도구입니다. 원하는 것을 태우고 빠르게 이동할 수 있습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon29;
            Level.text = Prod_29_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney29.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney29 * Prod_29_Level).ToString("###,###") + paneltext2;
            if (Prod_29_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd29);
            PanelNum = 29;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_30_Oepn()
    {
        if (TechManager.Tech30Complete)
        {
            title.text = "독가스";
            exp.text = "들이마시거나 노출 시 해를 끼치는 독성 기체입니다. 수 많은 인구수를 빠르게 줄입니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon30;
            Level.text = Prod_30_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney30.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney30 * Prod_30_Level).ToString("###,###") + paneltext2;
            if (Prod_30_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd30);
            PanelNum = 30;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_31_Oepn()
    {
        if (TechManager.Tech31Complete)
        {
            title.text = "에니그마";
            exp.text = "전기적 암호 기계입니다. 정보를 숨길 수 있고, 기밀을 유지할 때 유용합니다";
            Icon.GetComponent<Image>().sprite = ProdIcon31;
            Level.text = Prod_31_Level.ToString();
            ProdMoneyText.text = perOneAutoScience31.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoScience31 * Prod_31_Level).ToString("###,###") + paneltext2;
            if (Prod_31_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd31);
            PanelNum = 31;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_32_Oepn()
    {
        if (TechManager.Tech32Complete)
        {
            title.text = "무한궤도";
            exp.text = "탱크의 바퀴가 되는 부분입니다. 험한 지형에서도 무리없이 이동할 수 있습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon32;
            Level.text = Prod_32_Level.ToString();
            ProdMoneyText.text = perOneAutoMoney32.ToString("###,###") + paneltext1;
            TotalProdMoneyText.text = (perOneAutoMoney32 * Prod_32_Level).ToString("###,###") + paneltext2;
            if (Prod_32_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd32);
            PanelNum = 32;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_33_Oepn()
    {
        if (TechManager.Tech33Complete)
        {
            title.text = "냉동식품";
            exp.text = "조리 혹은 가공한 제품을 냉동시켜 보관하는 형태입니다. 더 오랜기간 제품을 보관할 수 있습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon33;
            Level.text = Prod_33_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney33) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney33 * Prod_33_Level) + paneltext2;
            if (Prod_33_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd33);
            PanelNum = 33;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_34_Oepn()
    {
        if (TechManager.Tech34Complete)
        {
            title.text = "페니실린";
            exp.text = "세균과 강제적으로 결합하여 세균의 기능을 상실시킵니다. 세균의 증식을 억제합니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon34;
            Level.text = Prod_34_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoScience34) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience34 * Prod_34_Level) + paneltext2;
            if (Prod_34_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd34);
            PanelNum = 34;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_35_Oepn()
    {
        if (TechManager.Tech35Complete)
        {
            title.text = "스타킹";
            exp.text = "발과 다리를 감싸는 긴 양말류입니다. 군사용 복장으로 강한 재질이 피부를 긁는 것을 막습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon35;
            Level.text = Prod_35_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney35) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney35 * Prod_35_Level) + paneltext2;
            if (Prod_35_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd35);
            PanelNum = 35;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_36_Oepn()
    {
        if (TechManager.Tech36Complete)
        {
            title.text = "터보제트";
            exp.text = "유입된 공기를 압축시켜 고온 고압의 압축공기를 이용하여 분사하는 강력한 엔진입니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon36;
            Level.text = Prod_36_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney36) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney36 * Prod_36_Level) + paneltext2;
            if (Prod_36_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd36);
            PanelNum = 36;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_37_Oepn()
    {
        if (TechManager.Tech37Complete)
        {
            Level_U.text = Prod_37_Level.ToString();
            ProdMoneyText_U.text = UnitTransform(perOneAutoMoney37) + paneltext1;
            ProdScienceText_U.text = UnitTransform(perOneAutoScience37) + paneltext1;
            TotalProdMoneyText_U.text = UnitTransform(perOneAutoMoney37 * Prod_37_Level) + " / " + UnitTransform(perOneAutoScience37 * Prod_37_Level) + paneltext2;
            if (Prod_37_Level == 0)
            {
                TotalProdMoneyText_U.text = paneltext3;
            }
            UpPriceText_U.text = UnitTransform(Pd37);
            PanelNum = 37;
            ProdUpPanel_U.SetActive(true);
        }
    }
    public void Prod_38_Oepn()
    {
        if (TechManager.Tech38Complete)
        {
            title.text = "컬러TV";
            exp.text = "통신을 통해서 카메라를 통해 찍은 영상을 보여줄 수 있는 장치입니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon38;
            Level.text = Prod_38_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney38) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney38 * Prod_38_Level) + paneltext2;
            if (Prod_38_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            UpPriceText.text = UnitTransform(Pd38);
            if (Pd38 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            PanelNum = 38;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_39_Oepn()
    {
        if (TechManager.Tech39Complete)
        {
            title.text = "전자레인지";
            exp.text = "수분을 통해 음식을 빠르게 데우는 장치입니다. 고주파를 이용하여 전자를 빠르게 진동시킵니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon39;
            Level.text = Prod_39_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney39) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney39 * Prod_39_Level) + paneltext2;
            if (Prod_39_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd39 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd39);
            PanelNum = 39;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_40_Oepn()
    {
        if (TechManager.Tech40Complete)
        {
            title.text = "트랜지스터+";
            exp.text = "전자 신호 및 전력을 증폭하거나 스위칭하는 데 사용되는 반도체소자입니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon40;
            Level.text = Prod_40_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoScience40) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience40 * Prod_40_Level) + paneltext2;
            if (Prod_40_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd40 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd40);
            PanelNum = 40;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_41_Oepn()
    {
        if (TechManager.Tech41Complete)
        {
            title.text = "레이저포인트";
            exp.text = "눈에 보이는 가시광선을 통해 물체를 지목할 수 있습니다. 눈에 안좋은 영향을 미칩니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon41;
            Level.text = Prod_41_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney41) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney41 * Prod_41_Level) + paneltext2;
            if (Prod_41_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd41 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd41);
            PanelNum = 41;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_42_Oepn()
    {
        if (TechManager.Tech42Complete)
        {
            title.text = "아스피린";
            exp.text = "진통제, 해열제로 사용되는 약품입니다. 인류의 생명을 증가시킵니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon42;
            Level.text = Prod_42_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney42) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney42 * Prod_42_Level) + paneltext2;
            if (Prod_42_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd42 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd42);
            PanelNum = 42;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_43_Oepn()
    {
        if (TechManager.Tech43Complete)
        {
            title.text = "하드드라이브";
            exp.text = "자성을 이용하여 데이터를 저장합니다. 저장한 데이터를 다시 불러올 수 있습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon43;
            Level.text = Prod_43_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoScience43) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience43 * Prod_43_Level) + paneltext2;
            if (Prod_43_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd43 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd43);
            PanelNum = 43;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_44_Oepn()
    {
        if (TechManager.Tech44Complete)
        {
            title.text = "카세트";
            exp.text = "소리를 녹음시키고 재생할 수 있는 장치입니다. 소리를 상태 그대로 저장할 수 있습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon44;
            Level.text = Prod_44_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney44) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney44 * Prod_44_Level) + paneltext2;
            if (Prod_44_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd44 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd44);
            PanelNum = 44;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_45_Oepn()
    {
        if (TechManager.Tech45Complete)
        {
            title.text = "LED";
            exp.text = "전기에너지를 빛에너지로 변환시켜주는 광반도체입니다. 더 효율적인 밝은 빛을 쓸 수 있습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon45;
            Level.text = Prod_45_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney45) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney45 * Prod_45_Level) + paneltext2;
            if (Prod_45_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd45 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd45);
            PanelNum = 45;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_46_Oepn()
    {
        if (TechManager.Tech46Complete)
        {
            title.text = "다이제팜";
            exp.text = "정신적인 장애나 경련 발작등을 치료할 수 있는 약품입니다. 인간의 건강을 늘려줍니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon46;
            Level.text = Prod_46_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney46) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney46 * Prod_46_Level) + paneltext2;
            if (Prod_46_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd46 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd46);
            PanelNum = 46;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_47_Oepn()
    {
        if (TechManager.Tech47Complete)
        {
            title.text = "RAM";
            exp.text = "원하는 데이터를 바로 찾을 수 있는 장치입니다. 주소를 기록하고 바로 일을 수행합니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon47;
            Level.text = Prod_47_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoScience47) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience47 * Prod_47_Level) + paneltext2;
            if (Prod_47_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd47 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd47);
            PanelNum = 47;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_48_Oepn()
    {
        if (TechManager.Tech48Complete)
        {
            title.text = "계산기";
            exp.text = "간단한 수학적 계산을 할 수 있는 장치입니다. 휴대가 가능할 정도로 크기가 작아졌습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon48;
            Level.text = Prod_48_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney48) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney48 * Prod_48_Level) + paneltext2;
            if (Prod_48_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd48 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd48);
            PanelNum = 48;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_49_Oepn()
    {
        if (TechManager.Tech49Complete)
        {
            title.text = "CPU";
            exp.text = "기계가 작업을 수행할 수 있게 하는 두뇌입니다. 명령을 해석하고 연산 가능한 총체적인 장치입니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon49;
            Level.text = Prod_49_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoScience49) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience49 * Prod_49_Level) + paneltext2;
            if (Prod_49_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd49 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd49);
            PanelNum = 49;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_51_Oepn()
    {
        if (TechManager.Tech51Complete)
        {
            title.text = "LCD";
            exp.text = "액정을 핵심 소재로 한 평판 디스플레이입니다. 전기 자극의 조절을 통해 실용화 가능합니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon51;
            Level.text = Prod_51_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney51) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney51 * Prod_51_Level) + paneltext2;
            if (Prod_51_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd51 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd51);
            PanelNum = 51;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_52_Oepn()
    {
        if (TechManager.Tech52Complete)
        {
            title.text = "랜선";
            exp.text = "전자세계에 연결할 수 있도록 돕는 연결선입니다. 이 선 하나로 전세계와 만날 수 있습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon52;
            Level.text = Prod_52_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoScience52) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience52 * Prod_52_Level) + paneltext2;
            if (Prod_52_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd52 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd52);
            PanelNum = 52;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_53_Oepn()
    {
        if (TechManager.Tech53Complete)
        {
            title.text = "MRI";
            exp.text = "자기공명장치 입니다. 기계의 자기장을 통해 물체의 내부 겹 단위로 볼 수 있습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon53;
            Level.text = Prod_53_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney53) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney53 * Prod_53_Level) + paneltext2;
            if (Prod_53_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd53 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd53);
            PanelNum = 53;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_54_Oepn()
    {
        if (TechManager.Tech54Complete)
        {
            title.text = "휴대폰";
            exp.text = "선이 없이 통화를 할 수 있는 장치입니다. 더 이상 정보의 전달은 공간과 시간에 구애받지 않습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon54;
            Level.text = Prod_54_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoScience54) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience54 * Prod_54_Level) + paneltext2;
            if (Prod_54_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd54 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd54);
            PanelNum = 54;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_55_Oepn()
    {
        if (TechManager.Tech55Complete)
        {
            title.text = "휴대용게임기";
            exp.text = "데이터 조각들을 모아 유기적으로 움직이는 게임기입니다. 사람들은 이것에 열광합니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon55;
            Level.text = Prod_55_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney55) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney55 * Prod_55_Level) + paneltext2;
            if (Prod_55_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd55 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd55);
            PanelNum = 55;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_56_Oepn()
    {
        if (TechManager.Tech56Complete)
        {
            title.text = "JAVA";
            exp.text = "컴퓨터와 대화할 수 있는 하나의 수단입니다. 일반 사람들도 이용할 수 있습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon56;
            Level.text = Prod_56_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney56) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney56 * Prod_56_Level) + paneltext2;
            if (Prod_56_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd56 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd56);
            PanelNum = 56;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_58_Oepn()
    {
        if (TechManager.Tech58Complete)
        {
            title.text = "WI-FI";
            exp.text = "다른 사람과 서버를 무선으로 공유할 수 있습니다. 어디서든 전자세계를 이용할 수 있습니다";
            Icon.GetComponent<Image>().sprite = ProdIcon58;
            Level.text = Prod_58_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoScience58) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience58 * Prod_58_Level) + paneltext2;
            if (Prod_58_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd58 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd58);
            PanelNum = 58;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_59_Oepn()
    {
        if (TechManager.Tech59Complete)
        {
            title.text = "GPS";
            exp.text = "위치를 추적할 수 있습니다. 현실세계의 모든 조작이 전자세계에서 추적이 가능합니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon59;
            Level.text = Prod_59_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney59) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney59 * Prod_59_Level) + paneltext2;
            if (Prod_59_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd59 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd59);
            PanelNum = 59;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_60_Oepn()
    {
        if (TechManager.Tech60Complete)
        {
            title.text = "대왕감자";
            exp.text = "정말 큰 감자입니다. 정말 큽니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon60;
            Level.text = Prod_60_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoScience60) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience60 * Prod_60_Level) + paneltext2;
            if (Prod_60_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd60 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd60);
            PanelNum = 60;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_61_Oepn()
    {
        if (TechManager.Tech61Complete)
        {
            title.text = "인터넷";
            exp.text = "모든 정보와 의견이 존재하는 공간입니다. 인터넷을 할 수 있는 3평의 공간이면, 공간은 의미없어집니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon61;
            Level.text = Prod_61_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney61) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney61 * Prod_61_Level) + paneltext2;
            if (Prod_61_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd61 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd61);
            PanelNum = 61;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_62_Oepn()
    {
        if (TechManager.Tech62Complete)
        {
            title.text = "시험관";
            exp.text = "출산을 돕는 기구입니다. 고도의 기술이 들어가지만, 인구수를 증가시킬 수 있습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon62;
            Level.text = Prod_62_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney62) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney62 * Prod_62_Level) + paneltext2;
            if (Prod_62_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd62 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd62);
            PanelNum = 62;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_63_Oepn()
    {
        if (TechManager.Tech63Complete)
        {
            title.text = "GPU";
            exp.text = "전자세계를 좀 더 현실에 가깝게 보이도록 도와주는 전자부품입니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon63;
            Level.text = Prod_63_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoScience63) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience63 * Prod_63_Level) + paneltext2;
            if (Prod_63_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd63 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd63);
            PanelNum = 63;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_64_Oepn()
    {
        if (TechManager.Tech64Complete)
        {
            title.text = "비트코인";
            exp.text = "아무도 수정, 대체 불가능한 가상화폐입니다. 종이와 같은 현물을 대체할 수 있습니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon64;
            Level.text = Prod_64_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney64) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney64 * Prod_64_Level) + paneltext2;
            if (Prod_64_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd64 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd64);
            PanelNum = 64;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_65_Oepn()
    {
        if (TechManager.Tech65Complete)
        {
            title.text = "딥러닝";
            exp.text = "AI가 스스로 학습합니다. 인터넷을 통해 수많은 정보를 받아드리고 인간의 생각을 복사합니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon65;
            Level.text = Prod_65_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney65) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney65 * Prod_65_Level) + paneltext2;
            if (Prod_65_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd65 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd65);
            PanelNum = 65;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_66_Oepn()
    {
        if (TechManager.Tech66Complete)
        {
            title.text = "10G";
            exp.text = "가장 빠른 통신 기술입니다. 정보를 주고 받는 시간을 단축합니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon66;
            Level.text = Prod_66_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoScience66) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience66 * Prod_66_Level) + paneltext2;
            if (Prod_66_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd66 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd66);
            PanelNum = 66;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_67_Oepn()
    {
        if (TechManager.Tech67Complete)
        {
            title.text = "VR";
            exp.text = "실제와 유사하게 꾸민 인공환경입니다. 오감을 사용할 수 있게 합니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon67;
            Level.text = Prod_67_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney67) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney67 * Prod_67_Level) + paneltext2;
            if (Prod_67_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd67 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd67);
            PanelNum = 67;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_68_Oepn()
    {
        if (TechManager.Tech68Complete)
        {
            title.text = "AR";
            exp.text = "현실에 전자의 세계를 도입하여 확장시킵니다. 현실세계와 가상세계과 합쳐집니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon68;
            Level.text = Prod_68_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoMoney68) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney68 * Prod_68_Level) + paneltext2;
            if (Prod_68_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd68 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd68);
            PanelNum = 68;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_69_Oepn()
    {
        if (TechManager.Tech69Complete)
        {
            title.text = "유전자칩";
            exp.text = "생물의 몸 속에 심어놓습니다. 질병을 처리함은 물론 전자세계의 일들은 본인의 신체에서 해결 가능합니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon69;
            Level.text = Prod_69_Level.ToString();
            ProdMoneyText.text = UnitTransform(perOneAutoScience69) + paneltext1;
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience69 * Prod_69_Level) + paneltext2;
            if (Prod_69_Level == 0)
            {
                TotalProdMoneyText.text = paneltext3;
            }
            if (Pd69 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd69);
            PanelNum = 69;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Science;
        }
    }
    public void Prod_70_Oepn()
    {
        if (TechManager.Tech70Complete)
        {
            title.text = "차원관문";
            exp.text = "차원을 이동하는 관문입니다. 공간을 무시합니다.";
            Icon.GetComponent<Image>().sprite = ProdIcon70;
            Level.text = Prod_70_Level.ToString();
            ProdMoneyText.text = "";
            TotalProdMoneyText.text = "";
            if (Prod_70_Level > 0)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            UpPriceText.text = UnitTransform(Pd70);
            PanelNum = 70;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Gold;
        }
    }
    public void Prod_S01_Oepn()
    {
        if (PdS01Complete == true)
        {
            title.text = "영화개구리";
            exp.text = "산업시대의 기술을 총 집약한 개구리형 바이탈스코프입니다. 영화를 상영하는 기능 외에도 여러가지 기능이 장착되어 있습니다.";
            Icon.GetComponent<Image>().sprite = ProdIconS01;
            Level.text = Prod_S01_Level.ToString();
            ProdMoneyText.text = "오프라인 상태일 때에도 6시간 자원 비축기능 지원";
            TotalProdMoneyText.text = "";
            UpPriceText.text = UnitTransform(PdS01);
            if (Prod_S01_Level > 0)
            {
                UpPriceText.text = "기능 적용 중";
                UpgradeProdButton.interactable = false;
            }
            PanelNum = 71;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Special;
        }
    }
    public void Prod_S02_Oepn()
    {
        if (PdS02Complete == true)
        {
            title.text = "음식보급기";
            exp.text = "전쟁 중에 요긴하게 식량을 보급할 수 있는 탱크입니다. 동료에겐 냉동식품을 적에게는 뜨거운 포격을 선사할 수 있습니다.";
            Icon.GetComponent<Image>().sprite = ProdIconS02;
            Level.text = Prod_S02_Level.ToString();
            ProdMoneyText.text = "광고의 효과가 1분 더 지속";
            TotalProdMoneyText.text = "";
            UpPriceText.text = UnitTransform(PdS02);
            if (Prod_S02_Level > 0)
            {
                UpPriceText.text = "기능 적용 중";
                UpgradeProdButton.interactable = false;
            }
            PanelNum = 72;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Special;
        }
    }
    public void Prod_S03_Oepn()
    {
        if (PdS03Complete == true)
        {
            title.text = "컴퓨터";
            exp.text = "전자시대를 대표하는 제품입니다. 이 제품으로 인해 미래가 어떻게 바뀔지는 아무도 예상하지 못합니다.";
            Icon.GetComponent<Image>().sprite = ProdIconS03;
            Level.text = Prod_S03_Level.ToString();
            ProdMoneyText.text = "[!] 버튼 클릭 시 모든 제품 생산량 1.2배 증가";
            TotalProdMoneyText.text = "";
            UpPriceText.text = UnitTransform(PdS03);
            if (Prod_S03_Level > 0)
            {
                UpPriceText.text = "기능 적용 중";
                UpgradeProdButton.interactable = false;
            }
            PanelNum = 73;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Special;
        }
    }
    public void Prod_S04_Oepn()
    {
        if (PdS04Complete == true)
        {
            title.text = "황제감자";
            exp.text = "최신 AI기능을 탑재한 감자입니다. 사용자가 먹지만 않는다면 모든 의사결정을 도와줄 것입니다.";
            Icon.GetComponent<Image>().sprite = ProdIconS04;
            Level.text = Prod_S04_Level.ToString();
            ProdMoneyText.text = "[!] 버튼 클릭 시 모든 제품 생산량 1.5배 증가";
            TotalProdMoneyText.text = "";
            UpPriceText.text = UnitTransform(PdS04);
            if (Prod_S04_Level > 0)
            {
                UpPriceText.text = "기능 적용 중";
                UpgradeProdButton.interactable = false;
            }
            PanelNum = 74;
            ProdUpPanel.SetActive(true);
            infoPanel_icon.GetComponent<Image>().sprite = infoPanel_icon_Special;
        }
    }

    string UnitTransform(long a)
    {
        long b;
        string c = "";
        if (a <= 999999999)
        {
            c = a.ToString("###,###");
        }
        else if (a <= 999999999999)
        {
            b = a / 1000;
            c = b.ToString("###,###") + " k";
        }
        else if (a <= 999999999999999)
        {
            b = a / 1000000;
            c = b.ToString("###,###") + " m";
        }
        else if (a <= 999999999999999999)
        {
            b = a / 1000000000;
            c = b.ToString("###,###") + " b";
        }
        else if (a <= 9223372036854775807)
        {
            b = a / 1000000000000;
            c = b.ToString("###,###") + " t";
        }
        return c;
    }

    public void UpProd() // 제품 업그레이드 버튼에 대입, 제품업글을 눌렀을 때 나오는 반응
    {
        if (PanelNum == 1 && GameManager.money >= Pd1 && Prod_1_Level < 99)
        {
            GameManager.money -= Pd1;
            Prod_1_Level++;
            Pd1 = (long)((float)Pd1 * UpTimes);

            Level.text = Prod_1_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney1 * Prod_1_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd1);
            ProdLevel_01.text = Prod_1_Level.ToString();
        }
        else if (PanelNum == 3 && GameManager.money >= Pd3 && Prod_3_Level < 99)
        {
            GameManager.money -= Pd3;
            Prod_3_Level++;
            Pd3 = (long)((float)Pd3 * UpTimes);

            Level.text = Prod_3_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney3 * Prod_3_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd3);
            ProdLevel_03.text = Prod_3_Level.ToString();
        }
        else if (PanelNum == 4 && GameManager.money >= Pd4 && Prod_4_Level < 99)
        {
            GameManager.money -= Pd4;
            Prod_4_Level++;
            Pd4 = (long)((float)Pd4 * UpTimes);

            Level.text = Prod_4_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney4 * Prod_4_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd4);
            ProdLevel_04.text = Prod_4_Level.ToString();
        }
        else if (PanelNum == 5 && GameManager.money >= Pd5 && Prod_5_Level < 99)
        {
            GameManager.money -= Pd5;
            Prod_5_Level++;
            Pd5 = (long)((float)Pd5 * UpTimes);

            Level.text = Prod_5_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience5 * Prod_5_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd5);
            ProdLevel_05.text = Prod_5_Level.ToString();
        }
        else if (PanelNum == 6 && GameManager.money >= Pd6 && Prod_6_Level < 99)
        {
            GameManager.money -= Pd6;
            Prod_6_Level++;
            Pd6 = (long)((float)Pd6 * UpTimes);

            Level.text = Prod_6_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience6 * Prod_6_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd6);
            ProdLevel_06.text = Prod_6_Level.ToString();
            Product_Reward01_06.SetActive(true);
        }
        else if (PanelNum == 7 && GameManager.money >= Pd7 && Prod_7_Level < 99)
        {
            GameManager.money -= Pd7;
            Prod_7_Level++;
            Pd7 = (long)((float)Pd7 * UpTimes);

            Level.text = Prod_7_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney7 * Prod_7_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd7);
            ProdLevel_07.text = Prod_7_Level.ToString();
            Product_Reward02_07.SetActive(true);
        }
        else if (PanelNum == 8 && GameManager.money >= Pd8 && Prod_8_Level < 99)
        {
            GameManager.money -= Pd8;
            Prod_8_Level++;
            Pd8 = (long)((float)Pd8 * UpTimes);

            Level.text = Prod_8_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney8 * Prod_8_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd8);
            ProdLevel_08.text = Prod_8_Level.ToString();
        }
        else if (PanelNum == 9 && GameManager.money >= Pd9 && Prod_9_Level < 99)
        {
            GameManager.money -= Pd9;
            Prod_9_Level++;
            Pd9 = (long)((float)Pd9 * UpTimes);

            Level.text = Prod_9_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience9 * Prod_9_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd9);
            ProdLevel_09.text = Prod_9_Level.ToString();
        }
        else if (PanelNum == 10 && GameManager.money >= Pd10 && Prod_10_Level < 99)
        {
            GameManager.money -= Pd10;
            Prod_10_Level++;
            Pd10 = (long)((float)Pd10 * UpTimes);

            Level.text = Prod_10_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney10 * Prod_10_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd10);
            ProdLevel_10.text = Prod_10_Level.ToString();
        }
        else if (PanelNum == 11 && GameManager.money >= Pd11 && Prod_11_Level < 99)
        {
            GameManager.money -= Pd11;
            Prod_11_Level++;
            Pd11 = (long)((float)Pd11 * UpTimes);

            Level.text = Prod_11_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney11 * Prod_11_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd11);
            ProdLevel_11.text = Prod_11_Level.ToString();
        }
        else if (PanelNum == 12 && GameManager.money >= Pd12 && Prod_12_Level < 99)
        {
            GameManager.money -= Pd12;
            Prod_12_Level++;
            Pd12 = (long)((float)Pd12 * UpTimes);

            Level.text = Prod_12_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney12 * Prod_12_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd12);
            ProdLevel_12.text = Prod_12_Level.ToString();
        }
        else if (PanelNum == 13 && GameManager.money >= Pd13 && Prod_13_Level < 99)
        {
            GameManager.money -= Pd13;
            Prod_13_Level++;
            Pd13 = (long)((float)Pd13 * UpTimes);

            Level.text = Prod_13_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience13 * Prod_13_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd13);
            ProdLevel_13.text = Prod_13_Level.ToString();
        }
        else if (PanelNum == 14 && GameManager.money >= Pd14 && Prod_14_Level < 99)
        {
            GameManager.money -= Pd14;
            Prod_14_Level++;
            Pd14 = (long)((float)Pd14 * UpTimes);

            Level.text = Prod_14_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney14 * Prod_14_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd14);
            ProdLevel_14.text = Prod_14_Level.ToString();
        }
        else if (PanelNum == 15 && GameManager.money >= Pd15 && Prod_15_Level < 99)
        {
            GameManager.money -= Pd15;
            Prod_15_Level++;
            Pd15 = (long)((float)Pd15 * UpTimes);

            Level.text = Prod_15_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience15 * Prod_15_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd15);
            ProdLevel_15.text = Prod_15_Level.ToString();
        }
        else if (PanelNum == 17 && GameManager.money >= Pd17 && Prod_17_Level < 99)
        {
            GameManager.money -= Pd17;
            Prod_17_Level++;
            Pd17 = (long)((float)Pd17 * UpTimes);

            Level.text = Prod_17_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney17 * Prod_17_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd17);
            ProdLevel_17.text = Prod_17_Level.ToString();
        }
        else if (PanelNum == 18 && GameManager.money >= Pd18 && Prod_18_Level < 99)
        {
            GameManager.money -= Pd18;
            Prod_18_Level++;
            Pd18 = (long)((float)Pd18 * UpTimes);

            Level.text = Prod_18_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience18 * Prod_18_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd18);
            ProdLevel_18.text = Prod_18_Level.ToString();
            Product_Reward04_18.SetActive(true);
        }
        else if (PanelNum == 19 && GameManager.money >= Pd19 && Prod_19_Level < 99)
        {
            GameManager.money -= Pd19;
            Prod_19_Level++;
            Pd19 = (long)((float)Pd19 * UpTimes);

            Level.text = Prod_19_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney19 * Prod_19_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd19);
            ProdLevel_19.text = Prod_19_Level.ToString();
        }
        else if (PanelNum == 20 && GameManager.money >= Pd20 && Prod_20_Level < 99)
        {
            GameManager.money -= Pd20;
            Prod_20_Level++;
            Pd20 = (long)((float)Pd20 * UpTimes);

            Level.text = Prod_20_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney20 * Prod_20_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd20);
            ProdLevel_20.text = Prod_20_Level.ToString();
        }
        else if (PanelNum == 21 && GameManager.money >= Pd21 && Prod_21_Level < 99)
        {
            GameManager.money -= Pd21;
            Prod_21_Level++;
            Pd21 = (long)((float)Pd21 * UpTimes);

            Level.text = Prod_21_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney21 * Prod_21_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd21);
            ProdLevel_21.text = Prod_21_Level.ToString();
        }
        else if (PanelNum == 22 && GameManager.money >= Pd22 && Prod_22_Level < 99)
        {
            GameManager.money -= Pd22;
            Prod_22_Level++;
            Pd22 = (long)((float)Pd22 * UpTimes);

            Level.text = Prod_22_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience22 * Prod_22_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd22);
            ProdLevel_22.text = Prod_22_Level.ToString();
        }
        else if (PanelNum == 23 && GameManager.money >= Pd23 && Prod_23_Level < 99)
        {
            GameManager.money -= Pd23;
            Prod_23_Level++;
            Pd23 = (long)((float)Pd23 * UpTimes);

            Level.text = Prod_23_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney23 * Prod_23_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd23);
            ProdLevel_23.text = Prod_23_Level.ToString();
        }
        else if (PanelNum == 24 && GameManager.money >= Pd24 && Prod_24_Level < 99)
        {
            GameManager.money -= Pd24;
            Prod_24_Level++;
            Pd24 = (long)((float)Pd24 * UpTimes);

            Level.text = Prod_24_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience24 * Prod_24_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd24);
            ProdLevel_24.text = Prod_24_Level.ToString();
            Product_Reward05_24.SetActive(true);
        }
        else if (PanelNum == 25 && GameManager.money >= Pd25 && Prod_25_Level < 99)
        {
            GameManager.money -= Pd25;
            Prod_25_Level++;
            Pd25 = (long)((float)Pd25 * UpTimes);

            Level.text = Prod_25_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney25 * Prod_25_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd25);
            ProdLevel_25.text = Prod_25_Level.ToString();
        }
        else if (PanelNum == 26 && GameManager.money >= Pd26 && Prod_26_Level < 99)
        {
            GameManager.money -= Pd26;
            Prod_26_Level++;
            Pd26 = (long)((float)Pd26 * UpTimes);

            Level.text = Prod_26_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney26 * Prod_26_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd26);
            ProdLevel_26.text = Prod_26_Level.ToString();
        }
        else if (PanelNum == 27 && GameManager.money >= Pd27 && Prod_27_Level < 99)
        {
            GameManager.money -= Pd27;
            Prod_27_Level++;
            Pd27 = (long)((float)Pd27 * UpTimes);

            Level.text = Prod_27_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience27 * Prod_27_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd27);
            ProdLevel_27.text = Prod_27_Level.ToString();
        }
        else if (PanelNum == 28 && GameManager.money >= Pd28 && Prod_28_Level < 99)
        {
            GameManager.money -= Pd28;
            Prod_28_Level++;
            Pd28 = (long)((float)Pd28 * UpTimes);

            Level.text = Prod_28_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney28 * Prod_28_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd28);
            ProdLevel_28.text = Prod_28_Level.ToString();
        }
        else if (PanelNum == 29 && GameManager.money >= Pd29 && Prod_29_Level < 99)
        {
            GameManager.money -= Pd29;
            Prod_29_Level++;
            Pd29 = (long)((float)Pd29 * UpTimes);

            Level.text = Prod_29_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney29 * Prod_29_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd29);
            ProdLevel_29.text = Prod_29_Level.ToString();
        }
        else if (PanelNum == 30 && GameManager.money >= Pd30 && Prod_30_Level < 99)
        {
            GameManager.money -= Pd30;
            Prod_30_Level++;
            Pd30 = (long)((float)Pd30 * UpTimes);

            Level.text = Prod_30_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney30 * Prod_30_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd30);
            ProdLevel_30.text = Prod_30_Level.ToString();
        }
        else if (PanelNum == 31 && GameManager.money >= Pd31 && Prod_31_Level < 99)
        {
            GameManager.money -= Pd31;
            Prod_31_Level++;
            Pd31 = (long)((float)Pd31 * UpTimes);

            Level.text = Prod_31_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience31 * Prod_31_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd31);
            ProdLevel_31.text = Prod_31_Level.ToString();
        }
        else if (PanelNum == 32 && GameManager.money >= Pd32 && Prod_32_Level < 99)
        {
            GameManager.money -= Pd32;
            Prod_32_Level++;
            Pd32 = (long)((float)Pd32 * UpTimes);

            Level.text = Prod_32_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney32 * Prod_32_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd32);
            ProdLevel_32.text = Prod_32_Level.ToString();
        }
        else if (PanelNum == 33 && GameManager.money >= Pd33 && Prod_33_Level < 99)
        {
            GameManager.money -= Pd33;
            Prod_33_Level++;
            Pd33 = (long)((float)Pd33 * UpTimes);

            Level.text = Prod_33_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney33 * Prod_33_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd33);
            ProdLevel_33.text = Prod_33_Level.ToString();
            Product_Reward06_33.SetActive(true);
        }
        else if (PanelNum == 34 && GameManager.money >= Pd34 && Prod_34_Level < 99)
        {
            GameManager.money -= Pd34;
            Prod_34_Level++;
            Pd34 = (long)((float)Pd34 * UpTimes);

            Level.text = Prod_34_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience34 * Prod_34_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd34);
            ProdLevel_34.text = Prod_34_Level.ToString();
        }
        else if (PanelNum == 35 && GameManager.money >= Pd35 && Prod_35_Level < 99)
        {
            GameManager.money -= Pd35;
            Prod_35_Level++;
            Pd35 = (long)((float)Pd35 * UpTimes);

            Level.text = Prod_35_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney35 * Prod_35_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd35);
            ProdLevel_35.text = Prod_35_Level.ToString();
        }
        else if (PanelNum == 36 && GameManager.money >= Pd36 && Prod_36_Level < 99)
        {
            GameManager.money -= Pd36;
            Prod_36_Level++;
            Pd36 = (long)((float)Pd36 * UpTimes);

            Level.text = Prod_36_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney36 * Prod_36_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd36);
            ProdLevel_36.text = Prod_36_Level.ToString();
        }
        else if (PanelNum == 37 && GameManager.money >= Pd37 && Prod_37_Level < 99)
        {
            GameManager.money -= Pd37;
            Prod_37_Level++;
            Pd37 = (long)((float)Pd37 * UpTimes);

            Level_U.text = Prod_37_Level.ToString();
            TotalProdMoneyText_U.text = UnitTransform(perOneAutoMoney37 * Prod_37_Level) + " / " + UnitTransform(perOneAutoScience37 * Prod_37_Level) + paneltext2;
            UpPriceText_U.text = UnitTransform(Pd37);
            ProdLevel_37.text = Prod_37_Level.ToString();
            Product_Reward08_37.SetActive(true);
        }
        else if (PanelNum == 38 && GameManager.money >= Pd38 && Prod_38_Level < 99)
        {
            GameManager.money -= Pd38;
            Prod_38_Level++;
            Pd38 = (long)((float)Pd38 * UpTimes);

            Level.text = Prod_38_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney38 * Prod_38_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd38);
            if (Pd38 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_38.text = Prod_38_Level.ToString();
        }
        else if (PanelNum == 39 && GameManager.money >= Pd39 && Prod_39_Level < 99)
        {
            GameManager.money -= Pd39;
            Prod_39_Level++;
            Pd39 = (long)((float)Pd39 * UpTimes);

            Level.text = Prod_39_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney39 * Prod_39_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd39);
            if (Pd39 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_39.text = Prod_39_Level.ToString();
        }
        else if (PanelNum == 40 && GameManager.money >= Pd40 && Prod_40_Level < 99)
        {
            GameManager.money -= Pd40;
            Prod_40_Level++;
            Pd40 = (long)((float)Pd40 * UpTimes);

            Level.text = Prod_40_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience40 * Prod_40_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd40);
            if (Pd40 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_40.text = Prod_40_Level.ToString();
        }
        else if (PanelNum == 41 && GameManager.money >= Pd41 && Prod_41_Level < 99)
        {
            GameManager.money -= Pd41;
            Prod_41_Level++;
            Pd41 = (long)((float)Pd41 * UpTimes);

            Level.text = Prod_41_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney41 * Prod_41_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd41);
            if (Pd41 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_41.text = Prod_41_Level.ToString();
        }
        else if (PanelNum == 42 && GameManager.money >= Pd42 && Prod_42_Level < 99)
        {
            GameManager.money -= Pd42;
            Prod_42_Level++;
            Pd42 = (long)((float)Pd42 * UpTimes);

            Level.text = Prod_42_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney42 * Prod_42_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd42);
            if (Pd42 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_42.text = Prod_42_Level.ToString();
            Product_Reward09_42.SetActive(true);
        }
        else if (PanelNum == 43 && GameManager.money >= Pd43 && Prod_43_Level < 99)
        {
            GameManager.money -= Pd43;
            Prod_43_Level++;
            Pd43 = (long)((float)Pd43 * UpTimes);

            Level.text = Prod_43_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience43 * Prod_43_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd43);
            if (Pd43 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_43.text = Prod_43_Level.ToString();
        }
        else if (PanelNum == 44 && GameManager.money >= Pd44 && Prod_44_Level < 99)
        {
            GameManager.money -= Pd44;
            Prod_44_Level++;
            Pd44 = (long)((float)Pd44 * UpTimes);

            Level.text = Prod_44_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney44 * Prod_44_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd44);
            if (Pd44 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_44.text = Prod_44_Level.ToString();
            Product_Reward10_44.SetActive(true);
        }
        else if (PanelNum == 45 && GameManager.money >= Pd45 && Prod_45_Level < 99)
        {
            GameManager.money -= Pd45;
            Prod_45_Level++;
            Pd45 = (long)((float)Pd45 * UpTimes);

            Level.text = Prod_45_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney45 * Prod_45_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd45);
            if (Pd45 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_45.text = Prod_45_Level.ToString();
        }
        else if (PanelNum == 46 && GameManager.money >= Pd46 && Prod_46_Level < 99)
        {
            GameManager.money -= Pd46;
            Prod_46_Level++;
            Pd46 = (long)((float)Pd46 * UpTimes);

            Level.text = Prod_46_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney46 * Prod_46_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd46);
            if (Pd46 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_46.text = Prod_46_Level.ToString();
        }
        else if (PanelNum == 47 && GameManager.money >= Pd47 && Prod_47_Level < 99)
        {
            GameManager.money -= Pd47;
            Prod_47_Level++;
            Pd47 = (long)((float)Pd47 * UpTimes);

            Level.text = Prod_47_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience47 * Prod_47_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd47);
            if (Pd47 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_47.text = Prod_47_Level.ToString();
        }
        else if (PanelNum == 48 && GameManager.money >= Pd48 && Prod_48_Level < 99)
        {
            GameManager.money -= Pd48;
            Prod_48_Level++;
            Pd48 = (long)((float)Pd48 * UpTimes);

            Level.text = Prod_48_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney48 * Prod_48_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd48);
            if (Pd48 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_48.text = Prod_48_Level.ToString();
        }
        else if (PanelNum == 49 && GameManager.money >= Pd49 && Prod_49_Level < 99)
        {
            GameManager.money -= Pd49;
            Prod_49_Level++;
            Pd49 = (long)((float)Pd49 * UpTimes);

            Level.text = Prod_49_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience49 * Prod_49_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd49);
            if (Pd49 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_49.text = Prod_49_Level.ToString();
        }
        else if (PanelNum == 51 && GameManager.money >= Pd51 && Prod_51_Level < 99)
        {
            GameManager.money -= Pd51;
            Prod_51_Level++;
            Pd51 = (long)((float)Pd51 * UpTimes);

            Level.text = Prod_51_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney51 * Prod_51_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd51);
            if (Pd51 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_51.text = Prod_51_Level.ToString();
        }
        else if (PanelNum == 52 && GameManager.money >= Pd52 && Prod_52_Level < 99)
        {
            GameManager.money -= Pd52;
            Prod_52_Level++;
            Pd52 = (long)((float)Pd52 * UpTimes);

            Level.text = Prod_52_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience52 * Prod_52_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd52);
            if (Pd52 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_52.text = Prod_52_Level.ToString();
        }
        else if (PanelNum == 53 && GameManager.money >= Pd53 && Prod_53_Level < 99)
        {
            GameManager.money -= Pd53;
            Prod_53_Level++;
            Pd53 = (long)((float)Pd53 * UpTimes);

            Level.text = Prod_53_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney53 * Prod_53_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd53);
            if (Pd53 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_53.text = Prod_53_Level.ToString();
        }
        else if (PanelNum == 54 && GameManager.money >= Pd54 && Prod_54_Level < 99)
        {
            GameManager.money -= Pd54;
            Prod_54_Level++;
            Pd54 = (long)((float)Pd54 * UpTimes);

            Level.text = Prod_54_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience54 * Prod_54_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd54);
            if (Pd54 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_54.text = Prod_54_Level.ToString();
        }
        else if (PanelNum == 55 && GameManager.money >= Pd55 && Prod_55_Level < 99)
        {
            GameManager.money -= Pd55;
            Prod_55_Level++;
            Pd55 = (long)((float)Pd55 * UpTimes);

            Level.text = Prod_55_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney55 * Prod_55_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd55);
            if (Pd55 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_55.text = Prod_55_Level.ToString();
        }
        else if (PanelNum == 56 && GameManager.money >= Pd56 && Prod_56_Level < 99)
        {
            GameManager.money -= Pd56;
            Prod_56_Level++;
            Pd56 = (long)((float)Pd56 * UpTimes);

            Level.text = Prod_56_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney56 * Prod_56_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd56);
            if (Pd56 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_56.text = Prod_56_Level.ToString();
        }
        else if (PanelNum == 58 && GameManager.money >= Pd58 && Prod_58_Level < 99)
        {
            GameManager.money -= Pd58;
            Prod_58_Level++;
            Pd58 = (long)((float)Pd58 * UpTimes);

            Level.text = Prod_58_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience58 * Prod_58_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd58);
            if (Pd58 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_58.text = Prod_58_Level.ToString();
        }
        else if (PanelNum == 59 && GameManager.money >= Pd59 && Prod_59_Level < 99)
        {
            GameManager.money -= Pd59;
            Prod_59_Level++;
            Pd59 = (long)((float)Pd59 * UpTimes);

            Level.text = Prod_59_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney59 * Prod_59_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd59);
            if (Pd59 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_59.text = Prod_59_Level.ToString();
        }
        else if (PanelNum == 60 && GameManager.money >= Pd60 && Prod_60_Level < 99)
        {
            GameManager.money -= Pd60;
            Prod_60_Level++;
            Pd60 = (long)((float)Pd60 * UpTimes);

            Level.text = Prod_60_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience60 * Prod_60_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd60);
            if (Pd60 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_60.text = Prod_60_Level.ToString();
            Product_Reward14_60.SetActive(true);
        }
        else if (PanelNum == 61 && GameManager.money >= Pd61 && Prod_61_Level < 99)
        {
            GameManager.money -= Pd61;
            Prod_61_Level++;
            Pd61 = (long)((float)Pd61 * UpTimes);

            Level.text = Prod_61_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney61 * Prod_61_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd61);
            if (Pd61 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_61.text = Prod_61_Level.ToString();
        }
        else if (PanelNum == 62 && GameManager.money >= Pd62 && Prod_62_Level < 99)
        {
            GameManager.money -= Pd62;
            Prod_62_Level++;
            Pd62 = (long)((float)Pd62 * UpTimes);

            Level.text = Prod_62_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney62 * Prod_62_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd62);
            if (Pd62 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_62.text = Prod_62_Level.ToString();
        }
        else if (PanelNum == 63 && GameManager.money >= Pd63 && Prod_63_Level < 99)
        {
            GameManager.money -= Pd63;
            Prod_63_Level++;
            Pd63 = (long)((float)Pd63 * UpTimes);

            Level.text = Prod_63_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience63 * Prod_63_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd63);
            if (Pd63 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_63.text = Prod_63_Level.ToString();
        }
        else if (PanelNum == 64 && GameManager.money >= Pd64 && Prod_64_Level < 99)
        {
            GameManager.money -= Pd64;
            Prod_64_Level++;
            Pd64 = (long)((float)Pd64 * UpTimes);

            Level.text = Prod_64_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney64 * Prod_64_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd64);
            if (Pd64 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_64.text = Prod_64_Level.ToString();
        }
        else if (PanelNum == 65 && GameManager.money >= Pd65 && Prod_65_Level < 99)
        {
            GameManager.money -= Pd65;
            Prod_65_Level++;
            Pd65 = (long)((float)Pd65 * UpTimes);

            Level.text = Prod_65_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney65 * Prod_65_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd65);
            if (Pd65 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_65.text = Prod_65_Level.ToString();
        }
        else if (PanelNum == 66 && GameManager.money >= Pd66 && Prod_66_Level < 99)
        {
            GameManager.money -= Pd66;
            Prod_66_Level++;
            Pd66 = (long)((float)Pd66 * UpTimes);

            Level.text = Prod_66_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience66 * Prod_66_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd66);
            if (Pd66 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_66.text = Prod_66_Level.ToString();
        }
        else if (PanelNum == 67 && GameManager.money >= Pd67 && Prod_67_Level < 99)
        {
            GameManager.money -= Pd67;
            Prod_67_Level++;
            Pd67 = (long)((float)Pd67 * UpTimes);

            Level.text = Prod_67_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney67 * Prod_67_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd67);
            if (Pd67 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_67.text = Prod_67_Level.ToString();
        }
        else if (PanelNum == 68 && GameManager.money >= Pd68 && Prod_68_Level < 99)
        {
            GameManager.money -= Pd68;
            Prod_68_Level++;
            Pd68 = (long)((float)Pd68 * UpTimes);

            Level.text = Prod_68_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoMoney68 * Prod_68_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd68);
            if (Pd68 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_68.text = Prod_68_Level.ToString();
        }
        else if (PanelNum == 69 && GameManager.money >= Pd69 && Prod_69_Level < 99)
        {
            GameManager.money -= Pd69;
            Prod_69_Level++;
            Pd69 = (long)((float)Pd69 * UpTimes);

            Level.text = Prod_69_Level.ToString();
            TotalProdMoneyText.text = UnitTransform(perOneAutoScience69 * Prod_69_Level) + paneltext2;
            UpPriceText.text = UnitTransform(Pd69);
            if (Pd69 > MaxPrice)
            {
                UpPriceText.text = paneltext4;
                UpgradeProdButton.interactable = false;
            }
            ProdLevel_69.text = Prod_69_Level.ToString();
        }
        else if (PanelNum == 70 && GameManager.money >= Pd70 && Prod_70_Level < 1)
        {
            GameManager.money -= Pd70;
            Prod_70_Level++;

            Level.text = Prod_70_Level.ToString();
            UpPriceText.text = paneltext4;
            ProdLevel_70.text = Prod_70_Level.ToString();

            UpgradeProdButton.interactable = false;
        }
        else if (PanelNum == 71 && GameManager.money >= PdS01 && Prod_S01_Level < 1)
        {
            GameManager.money -= PdS01;
            Prod_S01_Level++;
            Level.text = Prod_S01_Level.ToString();
            UpPriceText.text = "기능 적용 중";

            UpgradeProdButton.interactable = false;
        }
        else if (PanelNum == 72 && GameManager.money >= PdS02 && Prod_S02_Level < 1)
        {
            GameManager.money -= PdS02;
            Prod_S02_Level++;
            Level.text = Prod_S02_Level.ToString();
            UpPriceText.text = "기능 적용 중";

            UpgradeProdButton.interactable = false;
        }
        else if (PanelNum == 73 && GameManager.money >= PdS03 && Prod_S03_Level < 1)
        {
            GameManager.money -= PdS03;
            Prod_S03_Level++;
            Level.text = Prod_S03_Level.ToString();
            UpPriceText.text = "기능 적용 중";
            Product_Reward12_S03.SetActive(true);

            UpgradeProdButton.interactable = false;
        }
        else if (PanelNum == 74 && GameManager.money >= PdS04 && Prod_S04_Level < 1)
        {
            GameManager.money -= PdS04;
            Prod_S04_Level++;
            Level.text = Prod_S04_Level.ToString();
            UpPriceText.text = "기능 적용 중";

            UpgradeProdButton.interactable = false;
        }

    }

    IEnumerator ProdUpButtonCheck() // 코루틴 반복함수, 제품업글 버튼 활성화 여부 0.2초 단위로 체크
    {
        while(true)
        {
            if (PanelNum == 1)
            {
                if (GameManager.money >= Pd1 && Prod_1_Level < 99)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 3)
            {
                if (GameManager.money >= Pd3 && Prod_3_Level < 99)
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
                if (GameManager.money >= Pd4 && Prod_4_Level < 99)
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
                if (GameManager.money >= Pd5 && Prod_5_Level < 99)
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
                if (GameManager.money >= Pd6 && Prod_6_Level < 99)
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
                if (GameManager.money >= Pd7 && Prod_7_Level < 99)
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
                if (GameManager.money >= Pd8 && Prod_8_Level < 99)
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
                if (GameManager.money >= Pd9 && Prod_9_Level < 99)
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
                if (GameManager.money >= Pd10 && Prod_10_Level < 99)
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
                if (GameManager.money >= Pd11 && Prod_11_Level < 99)
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
                if (GameManager.money >= Pd12 && Prod_12_Level < 99)
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
                if (GameManager.money >= Pd13 && Prod_13_Level < 99)
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
                if (GameManager.money >= Pd14 && Prod_14_Level < 99)
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
                if (GameManager.money >= Pd15 && Prod_15_Level < 99)
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
                if (GameManager.money >= Pd17 && Prod_17_Level < 99)
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
                if (GameManager.money >= Pd18 && Prod_18_Level < 99)
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
                if (GameManager.money >= Pd19 && Prod_19_Level < 99)
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
                if (GameManager.money >= Pd20 && Prod_20_Level < 99)
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
                if (GameManager.money >= Pd21 && Prod_21_Level < 99)
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
                if (GameManager.money >= Pd22 && Prod_22_Level < 99)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 23)
            {
                if (GameManager.money >= Pd23 && Prod_23_Level < 99)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 24)
            {
                if (GameManager.money >= Pd24 && Prod_24_Level < 99)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 25)
            {
                if (GameManager.money >= Pd25 && Prod_25_Level < 99)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 26)
            {
                if (GameManager.money >= Pd26 && Prod_26_Level < 99)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 27)
            {
                if (GameManager.money >= Pd27 && Prod_27_Level < 99)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 28)
            {
                if (GameManager.money >= Pd28 && Prod_28_Level < 99)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 29)
            {
                if (GameManager.money >= Pd29 && Prod_29_Level < 99)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 30)
            {
                if (GameManager.money >= Pd30 && Prod_30_Level < 99)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 31)
            {
                if (GameManager.money >= Pd31 && Prod_31_Level < 99)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 32)
            {
                if (GameManager.money >= Pd32 && Prod_32_Level < 99)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 33)
            {
                if (GameManager.money >= Pd33 && Prod_33_Level < 99)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 34)
            {
                if (GameManager.money >= Pd34 && Prod_34_Level < 99)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 35)
            {
                if (GameManager.money >= Pd35 && Prod_35_Level < 99)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 36)
            {
                if (GameManager.money >= Pd36 && Prod_36_Level < 99)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 37)
            {
                if (GameManager.money >= Pd37 && Prod_37_Level < 99)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 38)
            {
                if (GameManager.money >= Pd38 && Prod_38_Level < 99 && (Pd38 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 39)
            {
                if (GameManager.money >= Pd39 && Prod_39_Level < 99 && (Pd39 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 40)
            {
                if (GameManager.money >= Pd40 && Prod_40_Level < 99 && (Pd40 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 41)
            {
                if (GameManager.money >= Pd41 && Prod_41_Level < 99 && (Pd41 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 42)
            {
                if (GameManager.money >= Pd42 && Prod_42_Level < 99 && (Pd42 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 43)
            {
                if (GameManager.money >= Pd43 && Prod_43_Level < 99 && (Pd43 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 44)
            {
                if (GameManager.money >= Pd44 && Prod_44_Level < 99 && (Pd44 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 45)
            {
                if (GameManager.money >= Pd45 && Prod_45_Level < 99 && (Pd45 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 46)
            {
                if (GameManager.money >= Pd46 && Prod_46_Level < 99 && (Pd46 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 47)
            {
                if (GameManager.money >= Pd47 && Prod_47_Level < 99 && (Pd47 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 48)
            {
                if (GameManager.money >= Pd48 && Prod_48_Level < 99 && (Pd48 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 49)
            {
                if (GameManager.money >= Pd49 && Prod_49_Level < 99 && (Pd49 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 51)
            {
                if (GameManager.money >= Pd51 && Prod_51_Level < 99 && (Pd51 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 52)
            {
                if (GameManager.money >= Pd52 && Prod_52_Level < 99 && (Pd52 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 53)
            {
                if (GameManager.money >= Pd53 && Prod_53_Level < 99 && (Pd53 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 54)
            {
                if (GameManager.money >= Pd54 && Prod_54_Level < 99 && (Pd54 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 55)
            {
                if (GameManager.money >= Pd55 && Prod_55_Level < 99 && (Pd55 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 56)
            {
                if (GameManager.money >= Pd56 && Prod_56_Level < 99 && (Pd56 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 58)
            {
                if (GameManager.money >= Pd58 && Prod_58_Level < 99 && (Pd58 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 59)
            {
                if (GameManager.money >= Pd59 && Prod_59_Level < 99 && (Pd59 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 60)
            {
                if (GameManager.money >= Pd60 && Prod_60_Level < 99 && (Pd60 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 61)
            {
                if (GameManager.money >= Pd61 && Prod_61_Level < 99 && (Pd61 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 62)
            {
                if (GameManager.money >= Pd62 && Prod_62_Level < 99 && (Pd62 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 63)
            {
                if (GameManager.money >= Pd63 && Prod_63_Level < 99 && (Pd63 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 64)
            {
                if (GameManager.money >= Pd64 && Prod_64_Level < 99 && (Pd64 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 65)
            {
                if (GameManager.money >= Pd65 && Prod_65_Level < 99 && (Pd65 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 66)
            {
                if (GameManager.money >= Pd66 && Prod_66_Level < 99 && (Pd66 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 67)
            {
                if (GameManager.money >= Pd67 && Prod_67_Level < 99 && (Pd67 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 68)
            {
                if (GameManager.money >= Pd68 && Prod_68_Level < 99 && (Pd68 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 69)
            {
                if (GameManager.money >= Pd69 && Prod_69_Level < 99 && (Pd69 > MaxPrice == false))
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 70)
            {
                if (GameManager.money >= Pd70 && Prod_70_Level < 1)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 71)
            {
                if (GameManager.money >= PdS01 && Prod_S01_Level < 1)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 72)
            {
                if (GameManager.money >= PdS02 && Prod_S02_Level < 1)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 73)
            {
                if (GameManager.money >= PdS03 && Prod_S03_Level < 1)
                {
                    UpgradeProdButton.interactable = true;
                }
                else
                {
                    UpgradeProdButton.interactable = false;
                }
            }
            else if (PanelNum == 74)
            {
                if (GameManager.money >= PdS04 && Prod_S04_Level < 1)
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

            yield return new WaitForSeconds(0.2f);
        }
    }

    IEnumerator SpecialProductIconCheck()
    {
        while(true)
        {
            if (PdS01Complete == false && Prod_20_Level > 0 && Prod_18_Level > 0 && Prod_11_Level > 0 && Prod_9_Level > 0 && Prod_8_Level > 0 && Prod_6_Level > 0)
            {
                PdS01Complete = true;
                ProdBtnS01.SetActive(true);
            }

            if (PdS02Complete == false && Prod_35_Level > 0 && Prod_26_Level > 0 && Prod_28_Level > 0 && Prod_29_Level > 0 && Prod_32_Level > 0 && Prod_33_Level > 0 && Prod_24_Level > 0)
            {
                PdS02Complete = true;
                ProdBtnS02.SetActive(true);
            }

            if (PdS03Complete == false && Prod_49_Level > 0 && Prod_40_Level > 0 && Prod_43_Level > 0 && Prod_47_Level > 0 && Prod_48_Level > 0 && Prod_38_Level > 0)
            {
                PdS03Complete = true;
                ProdBtnS03.SetActive(true);
            }

            if (PdS04Complete == false && Prod_65_Level > 0 && Prod_59_Level > 0 && Prod_60_Level > 0 && Prod_61_Level > 0 && Prod_58_Level > 0)
            {
                PdS04Complete = true;
                ProdBtnS04.SetActive(true);
            }

            if (PdS04Complete == true && PdS03Complete == true && PdS02Complete == true && PdS01Complete == true)
            {
                yield break;
            }

            yield return new WaitForSeconds(0.5f);
        }
    }

    void SaveDataCheck_ProdUnlock() // 세이브로드 관련
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
            autoMoney = (perOneAutoMoney1 * Prod_1_Level) + (perOneAutoMoney3 * Prod_3_Level) + (perOneAutoMoney4 * Prod_4_Level) +  + (perOneAutoMoney7 * Prod_7_Level) + (perOneAutoMoney8 * Prod_8_Level) +
                    (perOneAutoMoney10 * Prod_10_Level) + (perOneAutoMoney11 * Prod_11_Level) + (perOneAutoMoney12 * Prod_12_Level) + (perOneAutoMoney14 * Prod_14_Level) + (perOneAutoMoney17 * Prod_17_Level) +
                    (perOneAutoMoney19 * Prod_19_Level) + (perOneAutoMoney20 * Prod_20_Level) + (perOneAutoMoney21 * Prod_21_Level) + (perOneAutoMoney23 * Prod_23_Level) + (perOneAutoMoney25 * Prod_25_Level) +
                    (perOneAutoMoney26 * Prod_26_Level) + (perOneAutoMoney28 * Prod_28_Level) + (perOneAutoMoney29 * Prod_29_Level) + (perOneAutoMoney30 * Prod_30_Level) + (perOneAutoMoney32 * Prod_32_Level) +
                    (perOneAutoMoney33 * Prod_33_Level) + (perOneAutoMoney35 * Prod_35_Level) + (perOneAutoMoney36 * Prod_36_Level) + (perOneAutoMoney37 * Prod_37_Level) + (perOneAutoMoney38 * Prod_38_Level) + (perOneAutoMoney39 * Prod_39_Level) +
                    (perOneAutoMoney41 * Prod_41_Level) + (perOneAutoMoney42 * Prod_42_Level) + (perOneAutoMoney44 * Prod_44_Level) + (perOneAutoMoney45 * Prod_45_Level) + (perOneAutoMoney46 * Prod_46_Level) +
                    (perOneAutoMoney48 * Prod_48_Level) + (perOneAutoMoney51 * Prod_51_Level) + (perOneAutoMoney53 * Prod_53_Level) + (perOneAutoMoney55 * Prod_55_Level) + (perOneAutoMoney56 * Prod_56_Level) +
                    (perOneAutoMoney59 * Prod_59_Level) + (perOneAutoMoney61 * Prod_61_Level) + (perOneAutoMoney62 * Prod_62_Level) + (perOneAutoMoney64 * Prod_64_Level) + (perOneAutoMoney65 * Prod_65_Level) +
                    (perOneAutoMoney67 * Prod_67_Level) + (perOneAutoMoney68 * Prod_68_Level) + (perOneAutoMoney70 * Prod_70_Level);

            yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator AutoScienceGo()
    {
        while(true)
        {
            autoScience = (perOneAutoScience5 * Prod_5_Level) + (perOneAutoScience6 * Prod_6_Level) + (perOneAutoScience9 * Prod_9_Level) + (perOneAutoScience13 * Prod_13_Level) + (perOneAutoScience15 * Prod_15_Level) +
                        (perOneAutoScience18 * Prod_18_Level) + (perOneAutoScience22 * Prod_22_Level) + (perOneAutoScience24 * Prod_24_Level) + (perOneAutoScience27 * Prod_27_Level) + (perOneAutoScience31 * Prod_31_Level) +
                        (perOneAutoScience34 * Prod_34_Level) + (perOneAutoScience37 * Prod_37_Level) + (perOneAutoScience40 * Prod_40_Level) + (perOneAutoScience43 * Prod_43_Level) + (perOneAutoScience47 * Prod_47_Level) +
                        (perOneAutoScience49 * Prod_49_Level) + (perOneAutoScience52 * Prod_52_Level) + (perOneAutoScience54 * Prod_54_Level) + (perOneAutoScience58 * Prod_58_Level) + (perOneAutoScience60 * Prod_60_Level) +
                        (perOneAutoScience63 * Prod_63_Level) + (perOneAutoScience66 * Prod_66_Level) + (perOneAutoScience69 * Prod_69_Level);
            yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator ProductAgeTapCheck()
    {
        bool war = false;
        bool elec = false;
        bool modern = false;

        while (true)
        {
            if (TechManager.age_modern == true && modern == false)
            {
                indTap_ModernButton.interactable = true;
                indTap_ModernText.text = "현대";
                indTap_ModernImage.sprite = ProductTap_unlockTap;

                warTap_ModernButton.interactable = true;
                warTap_ModernText.text = "현대";
                warTap_ModernImage.sprite = ProductTap_unlockTap;

                elecTap_ModernButton.interactable = true;
                elecTap_ModernText.text = "현대";
                elecTap_ModernImage.sprite = ProductTap_unlockTap;

                modern = true;
            }

            if (TechManager.age_elec == true && elec == false)
            {
                indTap_ElecButton.interactable = true;
                indTap_ElecText.text = "전자";
                indTap_ElecImage.sprite = ProductTap_unlockTap;

                warTap_ElecButton.interactable = true;
                warTap_ElecText.text = "전자";
                warTap_ElecImage.sprite = ProductTap_unlockTap;

                elec = true;
            }

            if (TechManager.age_war == true && war == false)
            {
                indTap_WarButton.interactable = true;
                indTap_WarText.text = "전쟁";
                indTap_WarImage.sprite = ProductTap_unlockTap;

                war = true;
            }

            if (modern == true && elec == true && war == true)
            {
                yield break;
            }

            yield return new WaitForSeconds(2f);
        }
    }

    /* 제품변화요소 애니메이션 */
    IEnumerator Airship_moving()
    {
        bool DownOn = false;
        int i = 0;

        while (true)
        {
            tr_airship.Translate(Vector3.right * 0.01f);

            if (DownOn == false)
            {
                tr_airship.Translate(Vector3.up * 0.006f);
                i++;
                if (i > 250)
                {
                    i = 0;
                    DownOn = true;
                }
            }
            else if (DownOn == true)
            {
                tr_airship.Translate(Vector3.down * 0.006f);
                i++;
                if (i > 250)
                {
                    i = 0;
                    DownOn = false;
                }
            }

            if(tr_airship.position.x > 3.2)
            {
                tr_airship.Translate(-6.5f, 0, 0);
            }

            yield return new WaitForSeconds(0.04f);
        }
    }
}