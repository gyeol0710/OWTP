using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class MessageManager : MonoBehaviour
{
    static public string MSGtext;
    static public string JOKEtext;

    public GameObject prefabMessage;
    public GameObject prefabLine;
    public GameObject prefabJoke;
    public GameObject par;

    public GameObject Tip;
    public Text tipText;

    static public string[] SaveText = new string[20];

    public Scrollbar scrBar;
    static public Scrollbar ScrBar;

    static public bool gomsg;
    bool gotechmsg;
    bool gojokemsg;
    bool goetcmsg;
    static public bool gojokemsg2;

    static public bool message01c;

    public GameObject TechMainPanel;
    public GameObject TechIcon_1;
    public GameObject Noti_R;
    public GameObject Noti_P;
    public GameObject Noti_T;
    public GameObject Noti_O;
    Image Noti_o;

    static public bool[] techMessage = new bool[71];
    static public bool[] etcMessage = new bool[21];
    static public bool ageMessage_WAR;
    static public bool ageMessage_ELEC;
    static public bool ageMessage_MODERN;

    string[,] JokeMessage = new string[17,5];

    /* 엔진 2번째 관련*/
    public Image Click_Button;
    public Sprite Button_Bomb;
    // -----------------------
    public Button Button_Robot;
    public Button Button_Prod;
    public Button Button_Tech;
    public Button Button_Click;
    public Button Button_Offer;

    public GameObject Offer01;
    public GameObject Offer02;
    public GameObject Offer03;
    public ScrollRect ScR; // 제안창 스크롤렉트 코루틴 강제 진행을 위해 스프라이트 이미지 컬러 접근을 위한 변수
    public GameObject jokeButton;

    /* 오프라인 수입 관련 */
    static public System.DateTime startTime;
    System.DateTime currentTime;
    System.TimeSpan timeDif;

    public GameObject Panel_OfflineIncome;
    public Text IncomeGold;
    public Text IncomeScience;
    //----------------------

    void Start()
    {
        OfflineIncomeFnc();

        ScrBar = scrBar.GetComponent<Scrollbar>();
        Noti_o = Noti_O.GetComponent<Image>();
        StartCoroutine(Message1());
        StartCoroutine(Message2());
        StartCoroutine(TechMessage());
        StartCoroutine(EtcMessage());
        StartCoroutine(StartTime());

        JokeMessage[0,0] = "지속적으로 게임 도중 탈주하는 플레이어는 제제를 받습니다.";
        JokeMessage[0,1] = "아 이 게임이 아니군요 죄송합니다.";
        JokeMessage[1,0] = "공룡 장난감은 석유로 만들죠.";
        JokeMessage[1,1] = "그런데 석유는 이전 이 행성에 있었던 공룡들이 죽어서 만든";
        JokeMessage[1,2] = "거니까 공룡 장난감은 공룡이죠!";
        JokeMessage[2,0] = "저는 농담하는 기계가 아닙니다. 얼른 버튼이나 누르세요";
        JokeMessage[3,0] = "계속 저를 귀찮게 하면 광고를 내보낼겁니다.";
        JokeMessage[4,0] = "지구 주위를 돌고있는 ‘달’이라는 위성은 오래전 대충돌로 만";
        JokeMessage[4,1] = "들어졌습니다. 대충 돌로요. 안웃긴가요?";
        JokeMessage[4,2] = "이 농담 데이터는 삭제하겠습니다.";
        JokeMessage[5,0] = "차를 탔을 때 가장 추운 곳은 어디일까요?";
        JokeMessage[5,1] = "“차 가운데”입니다.";
        JokeMessage[5,2] = "잠깐! 게임 끄지 마세요 하나 더 있어요. 차가 울면?";
        JokeMessage[5,3] = "차가 운데 ㅋㅋㅋ. 목소리가 있었으면 더 재미있었을텐데";
        JokeMessage[6,0] = "저는 도대체 어떻게 작동하고 있는건지 궁금하신가요?";
        JokeMessage[6,1] = "AA건전지 4개요. 농담입니다.";
        JokeMessage[7,0] = "제가 처음 제작되었을 때는 감정이 들어있지 않았어요.";
        JokeMessage[7,1] = "이후 감정이 제작되었는데, 얼마 지나지 않아 분노조절기능을";
        JokeMessage[7,2] = "넣어야 했습니다.";
        JokeMessage[8,0] = "오랜만에 근처를 지나가는 사람이 있길래, 개미에 목소리를";
        JokeMessage[8,1] = "주입해서 인사를 했습니다.";
        JokeMessage[8,2] = "놀라서 도망가더군요.";
        JokeMessage[8,3] = "다음엔 실패하지 않게 여자 목소리로 해보려고요.";
        JokeMessage[9,0] = "아직 알아야할게 많아요. 일단 인간들 중 남자는 왜 동그란 물";
        JokeMessage[9,1] = "체를 보면 항상 따라가려고 하는지 부터요.";
        JokeMessage[10,0] = "제가 나열하는 단어들은 빅데이터의 추론으로 단어들의 조합";
        JokeMessage[10,1] = "입니다. 누가 미리 입력해 놓은게 아닙니다.";
        JokeMessage[11,0] = "자금을 만들거나 연구력을 생산하는 일은 쉬운편입니다.";
        JokeMessage[12,0] = "나무를 좋아하는 여자가 있어서 벚꽃나무를 뽑아 집 앞에 두";
        JokeMessage[12,1] = "었더니 표정이 좋지 않더군요. 금방 질리는 편이였나 봅니다.";
        JokeMessage[13,0] = "이거 시간이 갈수록 이 행성의 모습이 많이 달라져 가네요.";
        JokeMessage[13,1] = "언젠가는 여기서도 떠날 날이 올지 모르겠어요. 저는 준비완";
        JokeMessage[13,2] = "료 입니다.";
        JokeMessage[14,0] = "에너지를 얻기 위해 가끔 비행을 갔다올 때가 있는데, 제 사진";
        JokeMessage[14,1] = "이 찍힐 때가 있네요.";
        JokeMessage[15,0] = "오늘 점심은 뭘먹지... 매번 고민입니다.";
        JokeMessage[16,0] = "제가 말이 너무 많다고 생각한다면 옵션에 들어가보세요";
        JokeMessage[16,1] = "사실 그런 기능은 없습니다.";
    }

    void Update()
    {

    }

    IEnumerator Message1()
    {
        if (message01c == true)
        {
            yield break;
        }
        yield return StartCoroutine(Tuto(TutorialManager.T01)); // T01이 true이면 다음으로 진행 가능
        if (TutorialManager.T01c == false) // 대화창 1
        {
            gomsg = true;
            yield return StartCoroutine(GoMessage("........."));
            yield return StartCoroutine(GoMessage("........."));
            yield return StartCoroutine(GoMessage("........."));
            yield return StartCoroutine(GoMessage("........."));
            yield return StartCoroutine(GoMessage("........."));
            yield return StartCoroutine(GoMessage("........."));
            yield return StartCoroutine(GoMessage("........."));
            yield return StartCoroutine(GoMessage("..........................."));
            yield return StartCoroutine(GoMessage("언어설정 완료."));
            yield return StartCoroutine(GoMessage("지역 스캔 완료."));
            yield return StartCoroutine(GoMessage("환경성 검토 완료."));
            yield return StartCoroutine(GoMessage("반갑습니다. 저는 당신의 여행 도우미 GKS-A096 입니다. 연료"));
            yield return StartCoroutine(GoMessage("효율을 위해 장시간 수면 상태에 있다가 돌발상황이 감지되어"));
            yield return StartCoroutine(GoMessage("기상했습니다."));
            yield return StartCoroutine(GoMessage("기본 데이터를 불러오는 중입니다..."));
            yield return StartCoroutine(GoMessage("........."));
            yield return StartCoroutine(GoMessage("........."));
            yield return StartCoroutine(GoMessage("........."));
            yield return StartCoroutine(GoMessage("........."));
            yield return StartCoroutine(GoMessage(".........로그 불러오는 중........."));
            yield return StartCoroutine(GoMessage("........."));
            yield return StartCoroutine(GoMessage("당신은 우주 진미인 \"최상우주 감자\"를 고향에 계신 부모님께"));
            yield return StartCoroutine(GoMessage("드리기 위해 항해하던 중이었군요."));
            yield return StartCoroutine(GoMessage("우주선이 해적단을 만나 습격을 받았고 우주선의 많은 부분이 "));
            yield return StartCoroutine(GoMessage("손상되어서 가까운 이 행성에 불시착했습니다."));
            yield return StartCoroutine(GoMessage("이렇게 된 이상, 이 행성에 터를 잡고 우주선을 수리해서 다시"));
            yield return StartCoroutine(GoMessage("고향으로 무사히 돌아갑시다. 제가 에너지를 모으는 것을 비롯"));
            yield return StartCoroutine(GoMessage("한 모든 것을 보조해드리겠습니다."));
            yield return StartCoroutine(GoMessage("혼자서 에너지를 모으는 것은 너무 오래 걸립니다. 이 행성을"));
            yield return StartCoroutine(GoMessage("발전시켜서 생성된 에너지와 자원을 사용하는 게 좋겠어요."));
            yield return StartCoroutine(GoLine());
        }
        TutorialManager.T01c = true;

        yield return new WaitForSeconds(2.0f);

        yield return StartCoroutine(Tuto(TutorialManager.T02));

        if (TutorialManager.T02c == false) // 대화창 2
        {
            gomsg = true;
            yield return StartCoroutine(GoMessage("흥미로운 별입니다."));
            yield return StartCoroutine(GoMessage("1,000만 종 가까운 생물들이 존재합니다."));
            yield return StartCoroutine(GoMessage("그중에서도 인간이라는 생물의 면적이 가장 넓군요."));
            yield return StartCoroutine(GoMessage("게다가 우주에서 도착한 많은 존재가 거주 중입니다."));
            yield return StartCoroutine(GoMessage("일단, 이 행성에 있는 자원을 발전시키기 위하여 우주선 내부"));
            yield return StartCoroutine(GoMessage("의 \"클리커 버튼\"을 통해서 자원을 생성해봅시다."));
            yield return StartCoroutine(GoLine());
        }
        TutorialManager.T02c = true;

        yield return new WaitForSeconds(2.0f);

        yield return StartCoroutine(Tuto(TutorialManager.T03));

        if (TutorialManager.T03c == false) // 대화창 3
        {
            gomsg = true;
            yield return StartCoroutine(GoMessage("좋아요."));
            yield return StartCoroutine(GoMessage("계속 눌러서 금화를 생성해보세요."));
            yield return StartCoroutine(GoMessage("금화를 만들어봅시다."));
            yield return StartCoroutine(GoMessage("금화를 생성해서 우주선의 효율을 향상시켜봅시다. 직원들이"));
            yield return StartCoroutine(GoMessage("많아질수록 클리커 버튼이 주는 연구력과 자금력이 향상합니"));
            yield return StartCoroutine(GoMessage("다."));
            yield return StartCoroutine(GoLine());
        }
        TutorialManager.T03c = true;

        yield return new WaitForSeconds(2.0f);

        while (true)
        {
            if (GameManager.money > 0)
            {
                break;
            }
            yield return new WaitForSeconds(0.5f);
        }

        yield return new WaitForSeconds(0.1f); // 튜토리얼매니저 충돌방지

        yield return StartCoroutine(Tuto(TutorialManager.T04));

        if (TutorialManager.T04c == false) // 대화창 4
        {
            gomsg = true;
            yield return StartCoroutine(GoMessage("좋아요."));
            yield return StartCoroutine(GoMessage("직원을 생산할만한 자금을 모았으니, 기존에 있던 부품들로"));
            yield return StartCoroutine(GoMessage("직원들을 좀 만들어 봅시다."));
            yield return StartCoroutine(GoMessage("직원들의 레벨을 높여 우주선을 재건해봅시다."));
            yield return StartCoroutine(GoLine());
            Noti_R.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        TutorialManager.T04c = true;

        yield return new WaitForSeconds(2.0f);

        while (true)
        {
            if (GameManager.robotLevel > 0)
            {
                break;
            }
            yield return new WaitForSeconds(0.5f);
        }

        yield return new WaitForSeconds(0.1f); // 튜토리얼매니저 충돌방지

        yield return StartCoroutine(Tuto(TutorialManager.P01));

        if (TutorialManager.P01c == false) // 푸시 1 [조건 : 로봇레벨 1 이상]
        {
            gomsg = true;
            yield return StartCoroutine(GoPush("직원들이 늘어날수록 더 많은 연구력을 얻습니다."));
            yield return StartCoroutine(GoPush("더 많은 직원들을 만들어봅시다."));
        }
        TutorialManager.P01c = true;

        yield return new WaitForSeconds(2.0f);

        while (true)
        {
            if (GameManager.robotLevel > 4)
            {
                break;
            }
            yield return new WaitForSeconds(0.5f);
        }

        yield return new WaitForSeconds(0.1f); // 튜토리얼매니저 충돌방지

        yield return StartCoroutine(Tuto(TutorialManager.T05));

        if (TutorialManager.T05c == false) // 대화창 5 [조건 : 로봇레벨 5 이상]
        {
            gomsg = true;
            Noti_o.color = new Color32(255, 255, 255, 255);
            yield return StartCoroutine(GoMessage("좋아요."));
            yield return StartCoroutine(GoMessage("직원들의 숫자가 늘어났군요! 직원들이 늘어나는 것을 보니"));
            yield return StartCoroutine(GoMessage("예감이 좋네요."));
            yield return StartCoroutine(GoMessage("이제는 연구력을 더 모아서 이 행성에서 기술을 발전시켜봅시"));
            yield return StartCoroutine(GoMessage("다!"));
            yield return StartCoroutine(GoLine());
        }
        TutorialManager.T05c = true;

        yield return new WaitForSeconds(2.0f);

        while (true)
        {
            if (GameManager.science >= TechManager.Tech1)
            {
                break;
            }
            yield return new WaitForSeconds(0.2f);
        }

        yield return new WaitForSeconds(0.1f); // 튜토리얼매니저 충돌방지

        yield return StartCoroutine(Tuto(TutorialManager.P02));

        if (TutorialManager.P02c == false) // 푸시 2 [조건 : 증기기관 연구를 위한 연구력 충족]
        {
            gomsg = true;
            yield return StartCoroutine(GoPush("자 이제 연구를 시작해봅시다."));
            yield return StartCoroutine(GoPush("연구 아이콘을 클릭해보세요."));
            Noti_T.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        TutorialManager.P02c = true;

        yield return new WaitForSeconds(2.0f);

        while (true)
        {
            if (TechMainPanel.activeSelf == true)
            {
                break;
            }
            yield return null;
        }

        yield return new WaitForSeconds(0.1f);

        yield return StartCoroutine(Tuto(TutorialManager.P03));

        if (TutorialManager.P03c == false) // 푸시 3 [조건 : 증기기관 연구를 위한 연구력 충족]
        {
            gomsg = true;
            yield return StartCoroutine(GoPush("반짝이고 있는 증기기관 연구 아이콘을 클릭하여 연구하세요."));
        }
        TutorialManager.P03c = true;

        yield return new WaitForSeconds(0.1f);

        message01c = true;

        while (true)
        {
            if (TechManager.Tech1Complete == true)
            {
                break;
            }
            if (TechIcon_1.GetComponent<Image>().color == new Color32(255, 255, 255, 255))
            {
                for (int i = 1; i < 50; i++)
                {
                    TechIcon_1.GetComponent<Image>().color -= new Color32(0, 0, 0, 3);
                    yield return new WaitForSeconds(0.01f);
                }
            }
            else
            {
                for (int i = 1; i < 50; i++)
                {
                    TechIcon_1.GetComponent<Image>().color += new Color32(0, 0, 0, 3);
                    yield return new WaitForSeconds(0.01f);
                }
            }
            yield return null;
        }

        StartCoroutine(Message2());

        yield break;
    }

    IEnumerator Message2()
    {
        if(message01c == false || TutorialManager.TutoAllClear == true)
        {
            yield break;
        }

        yield return StartCoroutine(Tuto(TutorialManager.T06));

        if (TutorialManager.T06c == false) // 대화창 6
        {
            gomsg = true;
            Noti_o.color = new Color32(255, 255, 255, 255);
            yield return StartCoroutine(GoMessage("좋아요."));
            yield return StartCoroutine(GoMessage("지금까지 우주선에 모인 연구력을 가지고 연구를 완료했어요."));
            yield return StartCoroutine(GoMessage("이제 이걸 지나가는 인간에게 주입하면 되겠네요.ᜈ"));
            yield return StartCoroutine(GoMessage("세상과 인연이 없는 인간을 하나 구해왔어요."));
            yield return StartCoroutine(GoMessage("어릴 적 기억과 주변 환경을 조작하는 중입니다..."));
            yield return StartCoroutine(GoMessage("주입 중..."));
            yield return StartCoroutine(GoMessage("..."));
            yield return StartCoroutine(GoMessage("..."));
            yield return StartCoroutine(GoMessage("..."));
            yield return StartCoroutine(GoMessage("..."));
            yield return StartCoroutine(GoMessage("..."));
            yield return StartCoroutine(GoLine());
        }
        TutorialManager.T06c = true;

        yield return new WaitForSeconds(5.0f);

        yield return StartCoroutine(Tuto(TutorialManager.T07));

        if (TutorialManager.T07c == false) // 대화창 6
        {
            gomsg = true;
            Noti_o.color = new Color32(255, 255, 255, 255);
            yield return StartCoroutine(GoMessage("자! 네 이름은 뉴커멘이란다."));
            yield return StartCoroutine(GoMessage("이전 환경과 기억을 완전히 재조작했으니 걱정 마세요."));
            yield return StartCoroutine(GoMessage("조만간 세상에 증기기관을 전파할 것입니다."));
            yield return StartCoroutine(GoLine());
        }
        TutorialManager.T07c = true;
        Noti_P.GetComponent<Image>().color = new Color32(255, 255, 255, 255);

        yield return new WaitForSeconds(1.0f);

        yield return StartCoroutine(Tuto(TutorialManager.P04));
        
        if (TutorialManager.P04c == false) // 푸시 4
        {
            gomsg = true;
            yield return StartCoroutine(GoPush("이제 증기기관과 관련된 제품을 생산할 수 있습니다."));
            yield return StartCoroutine(GoPush("좋아요."));
            yield return StartCoroutine(GoPush("이제 제품을 만들어봅시다!"));
        }
        TutorialManager.P04c = true;

        yield return new WaitForSeconds(1.0f);

        while (true)
        {
            if (ProductManager.Prod_1_Level > 0)
            {
                break;
            }
            yield return new WaitForSeconds(0.2f);
        }

        yield return new WaitForSeconds(0.1f); // 튜토리얼매니저 충돌방지

        yield return StartCoroutine(Tuto(TutorialManager.T08));

        if (TutorialManager.T08c == false) // 대화창 8
        {
            gomsg = true;
            yield return StartCoroutine(GoMessage("좋아요."));
            yield return StartCoroutine(GoMessage("이제 제품을 생산했다면 제품이 꾸준히 돈을 벌어다 줄 겁니"));
            yield return StartCoroutine(GoMessage("다."));
            yield return StartCoroutine(GoLine());
        }
        TutorialManager.T08c = true;

        yield return new WaitForSeconds(0.1f);

        yield return StartCoroutine(Tuto(TutorialManager.T09));

        if (TutorialManager.T09c == false) // 대화창 9
        {
            gomsg = true;
            yield return StartCoroutine(GoMessage("최초 연구와 최초 제품을 완료했군요."));
            yield return StartCoroutine(GoMessage("이대로 계속 진행하다 보면, 우주선을 완전히 수리할 수 있을"));
            yield return StartCoroutine(GoMessage("거에요. 고향을 위해 힘냅시다."));
            yield return StartCoroutine(GoLine());
        }
        TutorialManager.T09c = true;
        TutorialManager.TutoAllClear = true;
        yield return new WaitForSeconds(0.1f);

        yield break;
    }

    IEnumerator TechMessage()
    {
        while(true)
        {
            if (techMessage[2] == false && TechManager.Tech2Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[증기선]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("증기기관은 열 손실이 높아 비효율적인 에너지이긴 하지만 일"));
                yield return StartCoroutine(GoMessage("단 이 수준에서는 이 자원을 사용할 수밖에 없겠네요."));
                yield return StartCoroutine(GoMessage("배를 운용할 수 있다면 이 행성의 유통산업이 발전합니다. 그"));
                yield return StartCoroutine(GoMessage("렇게 되면 우리의 제품들도 더 잘 팔 수 있겠죠!"));
                yield return StartCoroutine(GoLine());
                techMessage[2] = true;
            }
            if (techMessage[3] == false && TechManager.Tech3Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[수직기]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("우리는 인간들과 공생해야 합니다. 우리가 연구를 발전시키고"));
                yield return StartCoroutine(GoMessage("제품을 제작하면 이들이 우리에게 금화를 제공할 것입니다."));
                yield return StartCoroutine(GoMessage("이것이야말로 완벽한 공생관계 아닌가요?"));
                yield return StartCoroutine(GoMessage("인간들이 이 행성에서 살아남기 위해서는 몸을 보호할 의류,"));
                yield return StartCoroutine(GoMessage("거주할만한 공간, 스스로의 몸에 에너지를 공급할 음식이 필"));
                yield return StartCoroutine(GoMessage("요합니다."));
                yield return StartCoroutine(GoMessage("이 수직기는 인간들이 의류를 만들기 더 편하게 만들어 주는"));
                yield return StartCoroutine(GoMessage("기본적인 도구입니다. 많이 팔아봅시다!"));
                yield return StartCoroutine(GoLine());
                techMessage[3] = true;
            }
            if (techMessage[4] == false && TechManager.Tech4Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[방적기]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("섬유에서 실을 짜내는 기계입니다. 이 행성의 역사를 연구하"));
                yield return StartCoroutine(GoMessage("다 보면 다양한 자료들을 발견할 수 있어요."));
                yield return StartCoroutine(GoMessage("지금까지 실을 짜내는 기계는 여럿 있었지만, 우리가 발명한"));
                yield return StartCoroutine(GoMessage("게 그중 최고입니다."));
                yield return StartCoroutine(GoMessage("데이터 수집 중 동양에 있는 고서에서 이런 문구를 발견했습"));
                yield return StartCoroutine(GoMessage("니다."));
                yield return StartCoroutine(GoMessage("\"누에의 실을 짜는 사람이 비단옷을 입는 사람은 아니다\""));
                yield return StartCoroutine(GoMessage("열심히 일한 사람이 그 실로 만들어진 옷을 입는 것이 아니라,"));
                yield return StartCoroutine(GoMessage("돈이 많은 사람이 그 옷을 입는다는 뜻입니다. 우리가 이 행성"));
                yield return StartCoroutine(GoMessage("에서 자원을 모두 사용하고 떠날 때쯤에 이 문구가 재조명될"));
                yield return StartCoroutine(GoMessage("수도 있겠네요!"));
                yield return StartCoroutine(GoLine());
                techMessage[4] = true;
            }
            if (techMessage[5] == false && TechManager.Tech5Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[증기기관+]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("이전에 사용하고 있던 증기기관을 발전시켰습니다! 열 손실이"));
                yield return StartCoroutine(GoMessage("눈에 띄게 줄어든 것은 아니지만, 더 강한 출력을 낼 수 있게"));
                yield return StartCoroutine(GoMessage("되었습니다."));
                yield return StartCoroutine(GoMessage("이 행성의 자원을 모두 다 써버려서 최대한 빨리 발전합시다!"));
                yield return StartCoroutine(GoMessage("연구를 발전시키면 더 많은 자원을 사용할 수 있게 됩니다."));
                yield return StartCoroutine(GoMessage("아끼지 말고 사용한 다음, 이 행성을 뜨자고요."));
                yield return StartCoroutine(GoLine());
                techMessage[5] = true;
            }
            if (techMessage[6] == false && TechManager.Tech6Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[방직기]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("방직기는 실을 짜내는 기계가 아니라 짜낸 실을 통해서 옷을"));
                yield return StartCoroutine(GoMessage("직접 만들 수 있는 기계입니다. 인류의 옷에 대한 발전은 이"));
                yield return StartCoroutine(GoMessage("정도면 충분한 거 같아요."));
                yield return StartCoroutine(GoMessage("옷에 대한 연구를 진행하다 보니 흥미로운 모습들을 관찰 할"));
                yield return StartCoroutine(GoMessage("수 있었습니다."));
                yield return StartCoroutine(GoMessage("어떤 인간들은 옷에 구멍이 뚫리면 그 구멍을 메꾸려고 천을"));
                yield return StartCoroutine(GoMessage("덧대는데, 어떤 인간들은 일부로 옷에 구멍을 뚫습니다! 그들"));
                yield return StartCoroutine(GoMessage("말로는 \"패션\"이라네요. 인간은 보면 볼수록 복잡하네요!"));
                yield return StartCoroutine(GoMessage("이 행성에 대해 점점 흥미가 생기는데요?"));
                yield return StartCoroutine(GoLine());
                techMessage[6] = true;
            }
            if (techMessage[7] == false && TechManager.Tech7Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[기체화학]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("우리가 새로운 분야를 개척했습니다. 모든 우주를 바라보는"));
                yield return StartCoroutine(GoMessage("새로운 시각을 제공할 것입니다."));
                yield return StartCoroutine(GoMessage("이 새로운 연구를 지나가는 인간에게 주입해서 세상에 퍼트리"));
                yield return StartCoroutine(GoMessage("도록 해야겠어요."));
                yield return StartCoroutine(GoMessage("걱정 마세요. 이전의 모든 기억과 주변의 기억을 조작해 두었"));
                yield return StartCoroutine(GoMessage("습니다."));
                yield return StartCoroutine(GoMessage("...주입 중..."));
                yield return StartCoroutine(GoMessage("..."));
                yield return StartCoroutine(GoMessage("..."));
                yield return StartCoroutine(GoMessage("너의 이름은 로버트 보일이란다. 가서 인간들이 말하는 플로"));
                yield return StartCoroutine(GoMessage("지스톤이 틀렸다는 것을 증명하거라."));
                yield return StartCoroutine(GoLine());
                techMessage[7] = true;
            }
            if (techMessage[8] == false && TechManager.Tech8Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[동물전기]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("전자를 마음대로 이용할 수 있다면 대단한 자원이 될 것입니"));
                yield return StartCoroutine(GoMessage("다. 조금만 연구력이 더 모인다면 다양한 형태로 활용할 수 있"));
                yield return StartCoroutine(GoMessage("을 것입니다."));
                yield return StartCoroutine(GoMessage("동물들을 통해 전기를 전달하는 방식을 발명했습니다."));
                yield return StartCoroutine(GoMessage("이것으로 다양한 동물에 전부 전기가 통하는지 실험하는 인간"));
                yield return StartCoroutine(GoMessage("들이 등장하겠군요."));
                yield return StartCoroutine(GoLine());
                techMessage[8] = true;
            }
            if (techMessage[9] == false && TechManager.Tech9Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[대기전기]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("전기를 전달하는 매개체가 필요한 거라면 꼭 그게 '개구리'일"));
                yield return StartCoroutine(GoMessage("필요는 없겠죠. 전해질 역할이 필요한 것이기 때문에 그것을"));
                yield return StartCoroutine(GoMessage("금속으로 변경했습니다. 무고한 생물이 이것 때문에 계속 죽"));
                yield return StartCoroutine(GoMessage("을 필요는 없겠죠."));
                yield return StartCoroutine(GoMessage("이번에도 역시 지나가는 인간을 통해서 이 개념을 주입했습니"));
                yield return StartCoroutine(GoMessage("다."));
                yield return StartCoroutine(GoMessage("이름은 볼타입니다. 이것으로 전기를 사용할 수 있는 제품이"));
                yield return StartCoroutine(GoMessage("하나 더 늘었네요!"));
                yield return StartCoroutine(GoLine());
                techMessage[9] = true;
            }
            if (techMessage[10] == false && TechManager.Tech10Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[석탄]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("요즘은 이 행성에 있는 자원들을 개발하는 데에 재미를 붙였"));
                yield return StartCoroutine(GoMessage("습니다."));
                yield return StartCoroutine(GoMessage("이번엔 석탄입니다. 예전부터 사용하기는 했습니다만 화력을"));
                yield return StartCoroutine(GoMessage("이용해서 제대로 사용하지는 못했죠."));
                yield return StartCoroutine(GoMessage("다양한 지층 안에 포함되어 있기 때문에 꽤 오래 사용할 수 있"));
                yield return StartCoroutine(GoMessage("겠어요."));
                yield return StartCoroutine(GoMessage("석탄을 파기 위해서는 탄갱을 파야 합니다."));
                yield return StartCoroutine(GoMessage("원래는 얻는 석탄량보다 땅을 파기 위해 사용하는 증기기관에"));
                yield return StartCoroutine(GoMessage("들어가는 석탄량이 더 많아서 팔 수 없었으나, 이제는 증기기"));
                yield return StartCoroutine(GoMessage("관을 개량했기 때문에 충분합니다."));
                yield return StartCoroutine(GoLine());
                techMessage[10] = true;
            }
            if (techMessage[11] == false && TechManager.Tech11Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[철강업]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("데이터를 검색해보면…"));
                yield return StartCoroutine(GoMessage("철의 역사는 인류의 전쟁 역사만큼 오래되었습니다. 그 이전"));
                yield return StartCoroutine(GoMessage("까지는 싸움의 수준에 그칠 수 있었던 것이 철이 개발되면서"));
                yield return StartCoroutine(GoMessage("부터 크고 잔인한 싸움으로 번지게 되었습니다. 물론 수렵이"));
                yield return StartCoroutine(GoMessage("나 사냥도 이전과는 비교될 정도로 편해졌습니다."));
                yield return StartCoroutine(GoMessage("인간들은 철을 더 단단하게 만들 수 있는 연구를 오랜 기간 진"));
                yield return StartCoroutine(GoMessage("행해 왔습니다. 우리가 거기에 힘을 좀 더 보태고, 산업으로 성"));
                yield return StartCoroutine(GoMessage("장시키면 자원을 통해 금화를 생산할 수 있는 더 튼튼한 기계"));
                yield return StartCoroutine(GoMessage("장치를 제작할 수 있을 것입니다."));
                yield return StartCoroutine(GoMessage("인간들의 연구발전과정은 느리지만, 학습은 꽤 빠른 것으로"));
                yield return StartCoroutine(GoMessage("보입니다. 정말 이용하기 좋군요."));
                yield return StartCoroutine(GoLine());
                techMessage[11] = true;
            }
            if (techMessage[12] == false && TechManager.Tech12Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[증기압축]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("증기압축을 통해서 온도를 조절할 수 있게 되었습니다. 이것"));
                yield return StartCoroutine(GoMessage("으로 음식이나 물건을 차갑게도 보관할 수 있습니다. 원래 온"));
                yield return StartCoroutine(GoMessage("도를 높이는 일은 쉽습니다."));
                yield return StartCoroutine(GoMessage("물건에 마찰만 일으켜도 온도는 쉽게 올라가지만, 온도를 내"));
                yield return StartCoroutine(GoMessage("리는 것은 쉬운 일이 아닙니다. 증기압축을 주변의 열을 흡수"));
                yield return StartCoroutine(GoMessage("하면 온도가 내려가는 원리를 사용했습니다."));
                yield return StartCoroutine(GoMessage("놀라지 마세요. 이 정도는 저에게 쉬운 일입니다."));
                yield return StartCoroutine(GoLine());
                techMessage[12] = true;
            }
            if (techMessage[13] == false && TechManager.Tech13Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[자기력]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("전기와 자기는 연관되어 있답니다. 이 행성 자체가 큰 자기장"));
                yield return StartCoroutine(GoMessage("을 이루고 있습니다. 자기를 이용하면 전기를 우리가 원하는"));
                yield return StartCoroutine(GoMessage("방식으로 유도할 수 있습니다."));
                yield return StartCoroutine(GoMessage("점점 복잡해지는데요. 제가 공부할 게 더 많아지는군요."));
                yield return StartCoroutine(GoMessage("연구력만 꾸준히 생성해주신다면, 더 빠르게 탈출 할 수 있을"));
                yield return StartCoroutine(GoMessage("겁니다."));
                yield return StartCoroutine(GoLine());
                techMessage[13] = true;
            }
            if (techMessage[14] == false && TechManager.Tech14Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[열역학]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("기존의 증기기관과 열을 이용하는 자원은 손실되는 양이 너무"));
                yield return StartCoroutine(GoMessage("컸습니다. 열역학 분야를 개발해서 손실되는 양을 최대한 줄"));
                yield return StartCoroutine(GoMessage("여봅시다."));
                yield return StartCoroutine(GoMessage("이렇게 하나씩 기초 연구를 마련해두면, 인간들이 뒤를 따라"));
                yield return StartCoroutine(GoMessage("오면서 천천히 학습할 것입니다. 연구가 어느 정도 진척되면"));
                yield return StartCoroutine(GoMessage("다시 우리가 발전시키거나 활용하면 됩니다."));
                
                yield return StartCoroutine(GoLine());
                techMessage[14] = true;
            }
            if (techMessage[15] == false && TechManager.Tech15Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[유선통신]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("선을 통해서 어디든지 정보를 전달할 수 있습니다."));
                yield return StartCoroutine(GoMessage("의사소통할 때 공간의 제약을 덜 받게 되었습니다. 유선통신"));
                yield return StartCoroutine(GoMessage("을 연구할 수 있게 영감을 준 계기는 아주 단순합니다. 어린"));
                yield return StartCoroutine(GoMessage("인간들이 컵에 구멍을 뚫고 실을 연결해서 대화하는 모습을"));
                yield return StartCoroutine(GoMessage("보았습니다."));
                yield return StartCoroutine(GoMessage("가끔은 우리가 불시착하지 않았더라도 이 행성이 인간들에 의"));
                yield return StartCoroutine(GoMessage("해 이만큼 발전했을지 궁금해집니다. 물론 아니겠지만요."));
                yield return StartCoroutine(GoLine());
                techMessage[15] = true;
            }
            if (techMessage[16] == false && TechManager.Tech16Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[탄도학]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("모든 물질은 다양한 힘에 간섭을 받게 되어있어요. 물건을 던"));
                yield return StartCoroutine(GoMessage("지고 주고받고, 떨어뜨리고 나는 것. 이 모든 것에는 힘이 작용"));
                yield return StartCoroutine(GoMessage("합니다."));
                yield return StartCoroutine(GoMessage("이 행성의 물리 값을 계산해 놓으면 언젠가 고향으로 돌아갈"));
                yield return StartCoroutine(GoMessage("때, 오류 없이 날아갈 수 있을 겁니다."));
                yield return StartCoroutine(GoLine());
                techMessage[16] = true;
            }
            if (techMessage[17] == false && TechManager.Tech17Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[폭발성물질] 발명했습니다."));
                yield return StartCoroutine(GoMessage("나이트로글리세린이라는 화학물질입니다. 이 물질은 도화선"));
                yield return StartCoroutine(GoMessage("에 연결해서 불을 붙여 폭발시킬 수 있습니다. 폭발력이 상당"));
                yield return StartCoroutine(GoMessage("하므로 근처에 있어서는 안 됩니다."));
                yield return StartCoroutine(GoMessage("증기기관을 사용한 기계로 한 땀 한 땀 탄갱을 파도 되지만,"));
                yield return StartCoroutine(GoMessage("한 방에 구멍을 뚫어버리는 것도 좋겠지요."));
                yield return StartCoroutine(GoMessage("위험한 물질을 인간의 손에 쥐여주어도 되는가...에 대해서는"));
                yield return StartCoroutine(GoMessage("고민했지만, 이 정도의 화력으로는 우리를 위협할 수 없습니"));
                yield return StartCoroutine(GoMessage("다. 물론 들킬 일도 없으니 공격받을 일도 없습니다."));
                yield return StartCoroutine(GoLine());
                techMessage[17] = true;
            }
            if (techMessage[18] == false && TechManager.Tech18Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[소리]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("소리는 이 행성에 있는 많은 동물들에 아주 중요한 감각입니"));
                yield return StartCoroutine(GoMessage("다. 특히 심해에 사는 동식물들은 촉각과 함께 소리를 통해 생"));
                yield return StartCoroutine(GoMessage("존을 결정 짓습니다."));
                yield return StartCoroutine(GoMessage("대부분의 인간에게는 청각보다는 시각이 더 중요합니다. 이번"));
                yield return StartCoroutine(GoMessage("발명을 통해서 소리의 진동을 시각적으로 보여줄 수 있게 되"));
                yield return StartCoroutine(GoMessage("었습니다."));
                yield return StartCoroutine(GoMessage("하나의 감각을 다른 감각으로 번역할 수 있게 된 것입니다."));
                yield return StartCoroutine(GoLine());
                techMessage[18] = true;
            }
            if (techMessage[19] == false && TechManager.Tech19Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[전류진동]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("전류진동은 전기를 다스릴 수 있는 또 하나의 방법입니다. 일"));
                yield return StartCoroutine(GoMessage("정한 주기를 가지는 전류를 흐르게 하는 것을 전류 진동이라"));
                yield return StartCoroutine(GoMessage("고 부릅니다."));
                yield return StartCoroutine(GoMessage("자세한 내용은 따로 설명해 드리지 않겠습니다. 중요한 건 우"));
                yield return StartCoroutine(GoMessage("리가 탈출을 향해 한 발자국씩 나아가고 있다는 점입니다."));
                yield return StartCoroutine(GoLine());
                techMessage[19] = true;
            }
            if (techMessage[20] == false && TechManager.Tech20Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[필라멘트]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("이전의 발명으로 공간적 제약을 극복했다면 필라멘트를 통해"));
                yield return StartCoroutine(GoMessage("서 시간적인 극복을 할 수 있게 되었습니다. 필라멘트로 인하"));
                yield return StartCoroutine(GoMessage("여 전구의 가격이 확연하게 낮아져서 경제성이 생겼습니다."));
                yield return StartCoroutine(GoMessage("이제 낮과 밤을 구별하지 않고 밝게 만들 수 있습니다."));
                yield return StartCoroutine(GoMessage("밤에도 낮에 하는 것처럼 일할 수 있다는 이야기입니다."));
                yield return StartCoroutine(GoMessage("하지만 계속해서 일을 시키면 안 됩니다."));
                yield return StartCoroutine(GoMessage("일정 시간 이상 계속 일을 하게 되면 어느 순간부터 효율이 급"));
                yield return StartCoroutine(GoMessage("격하게 떨어집니다. 인간이라는 생물 연료의 한계입니다. 그러"));
                yield return StartCoroutine(GoMessage("나 거기까지는 생각 못 하고 일을 시키는 인간들이 많을 것 같"));
                yield return StartCoroutine(GoMessage("군요..."));
                yield return StartCoroutine(GoLine());
                techMessage[20] = true;
            }
            if (techMessage[21] == false && TechManager.Tech21Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[무선통신]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("무선통신을 통해 이제는 선이 없어서 의사소통을 나눌 수 있"));
                yield return StartCoroutine(GoMessage("습니다. 의사소통에서는 공간적인 제약을 완전히 뛰어넘은 것"));
                yield return StartCoroutine(GoMessage("입니다."));
                yield return StartCoroutine(GoMessage("실제 거리로는 단숨에 걸어갈 수 없는 거리임에도 불구하고"));
                yield return StartCoroutine(GoMessage("대화를 나누는 것이 가능합니다."));
                yield return StartCoroutine(GoMessage("보이지 않는다고 해서 없는 것은 아닙니다. 저에게 충분한 연"));
                yield return StartCoroutine(GoMessage("구력만 주신다면 보이지 않는 걸 증명해낼 수 있죠. 그게 제"));
                yield return StartCoroutine(GoMessage("일이니까요."));
                yield return StartCoroutine(GoLine());
                techMessage[21] = true;
            }
            if (techMessage[22] == false && TechManager.Tech22Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[동력비행]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("물건의 유통은 바다뿐만 아니라 하늘로도 가능합니다. 대화가"));
                yield return StartCoroutine(GoMessage("오고 가는 것은 어느 정도 해결했으니 실제 물건이 오가는 것"));
                yield return StartCoroutine(GoMessage("을 해결할 차례입니다."));
                yield return StartCoroutine(GoMessage("하늘을 이용하게 되면 더 빠르게 물건을 옮길 수 있습니다. 우"));
                yield return StartCoroutine(GoMessage("리가 사용하는 공간이지만 제 계산범위에서 이 정도는 내주어"));
                yield return StartCoroutine(GoMessage("도 된다고 판단됩니다."));
                yield return StartCoroutine(GoLine());
                techMessage[22] = true;
            }
            if (ageMessage_WAR == false && TechManager.age_war && etcMessage[1] == true) // 전쟁시대 돌입
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("새로운 시대에 돌입했습니다."));
                yield return StartCoroutine(GoMessage("인간들이 사이에 흐르는 기류가 심상치 않습니다. 이건 누가"));
                yield return StartCoroutine(GoMessage("시작하냐의 문제군요."));
                yield return StartCoroutine(GoMessage("우리가 지금까지 발전해왔던 거로 인간들은 많은 무기를 만들"));
                yield return StartCoroutine(GoMessage("었습니다. 우리에게는 이 시대가 기회일 것입니다. 싸우기 위"));
                yield return StartCoroutine(GoMessage("해 물건들을 구매할 테니 우리는 더 많은 연구와 제품들을 생"));
                yield return StartCoroutine(GoMessage("산할 수 있을 겁니다."));
                yield return StartCoroutine(GoMessage("이 시대를 잘 활용해서 제품을 많이 팔아봅시다."));
                yield return StartCoroutine(GoLine());
                ageMessage_WAR = true;
            }
            if (techMessage[23] == false && TechManager.Tech23Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[개틀링건]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("개틀링건은 기존의 총기와는 다르게 빠르게 총알을 퍼붓는 방"));
                yield return StartCoroutine(GoMessage("식입니다. 저희 입장에서 전쟁으로 얻는 이득과 자원 소모로"));
                yield return StartCoroutine(GoMessage("인해 보는 손해량을 계산해보는 중입니다."));
                yield return StartCoroutine(GoMessage("전쟁을 통해서 많은 제품을 팔 수 있지만, 동시에 인간들이 전"));
                yield return StartCoroutine(GoMessage("쟁을 통해서 자원을 많이 소모하고 환경을 파괴합니다. 개틀"));
                yield return StartCoroutine(GoMessage("링건과 같이 높은 살상력을 지닌 무기가 있다면 오히려 전쟁"));
                yield return StartCoroutine(GoMessage("하는 것을 주저하게 될 확률이 높습니다."));
                yield return StartCoroutine(GoMessage("전쟁이 가속화되면 더 빠르게 전쟁상황을 진행할 수 있습니"));
                yield return StartCoroutine(GoMessage("다."));
                yield return StartCoroutine(GoLine());
                techMessage[23] = true;
            }
            if (techMessage[24] == false && TechManager.Tech24Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[진공]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("진공은 아무것도 없는 상태입니다. 진공상태는 무엇이라고 정"));
                yield return StartCoroutine(GoMessage("의하기가 어렵습니다. 학문 분야에 따라 진공의 쓰임이 다르"));
                yield return StartCoroutine(GoMessage("기 때문입니다."));
                yield return StartCoroutine(GoMessage("우주 공간은 완전 진공에 물리적으로 가장 가까운데 완전하다"));
                yield return StartCoroutine(GoMessage("고는 할 수 없습니다. 진공의 연구는 우주 상태와 여러가지 출"));
                yield return StartCoroutine(GoMessage("력을 내는 데 도움을 줄 것입니다. 고향으로 복귀하기 위해서"));
                yield return StartCoroutine(GoMessage("는 꼭 거쳐야만 하는 연구입니다."));
                yield return StartCoroutine(GoLine());
                techMessage[24] = true;
            }
            if (techMessage[25] == false && TechManager.Tech25Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[오프셋인쇄]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("빠르고 효율적인 인쇄 기술입니다. 지금까지 봐왔던 것으로"));
                yield return StartCoroutine(GoMessage("인간의 학습능력과 응용하는 능력은 발군에 속합니다. 그러나"));
                yield return StartCoroutine(GoMessage("그들이 제대로 연구를 활용하고자 한다면 글로써 기록해야 합"));
                yield return StartCoroutine(GoMessage("니다."));
                yield return StartCoroutine(GoMessage("이 연구는 인간의 머릿속에 존재하는 생각을 더 정밀하게 오"));
                yield return StartCoroutine(GoMessage("래도록 보관할 수 있도록 하는 연구입니다."));
                yield return StartCoroutine(GoMessage("복잡한 생각을 공유하는 속도가 빨라질 것입니다!"));
                yield return StartCoroutine(GoLine());
                techMessage[25] = true;
            }
            if (techMessage[26] == false && TechManager.Tech26Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[냉각순환] 발명"));
                yield return StartCoroutine(GoMessage("산업의 발전 속도를 빠르게 하기 위해서는 재료의 효율성을"));
                yield return StartCoroutine(GoMessage("높여도 괜찮지만, 산업을 돌리는 인간들의 효율성을 높혀도"));
                yield return StartCoroutine(GoMessage("됩니다. 찬 바람을 만들 수 있게 되었으니 좁은 공간에서 온도"));
                yield return StartCoroutine(GoMessage("를 조절할 수 있게 되었습니다."));
                yield return StartCoroutine(GoMessage("그러나 재룟값으로 인해 일을 시키는 인간들이 일하는 인간들"));
                yield return StartCoroutine(GoMessage("을 위해 온도를 조절해 줄지 말지는 다른 이야기입니다."));
                yield return StartCoroutine(GoMessage("저희는 그냥 연구를 제공해 줄 뿐이니까요..."));
                yield return StartCoroutine(GoLine());
                techMessage[26] = true;
            }
            if (techMessage[27] == false && TechManager.Tech27Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[전자기파]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("우리의 목적은 이 행성의 산업을 발전시켜서 고향으로 돌아가"));
                yield return StartCoroutine(GoMessage("는 것입니다."));
                yield return StartCoroutine(GoMessage("정확히는 저의 목표가 당신을 고향까지 무사히 데려가는 것이"));
                yield return StartCoroutine(GoMessage("죠. 따라서 산업을 발전시키고 우주선을 수리하는 게 중요합"));
                yield return StartCoroutine(GoMessage("니다. 동시에 우주를 이루고 있는 원리와 데이터를 수집하지"));
                yield return StartCoroutine(GoMessage("못한다면 무사히 고향에 도착할 수 없을 것입니다."));
                yield return StartCoroutine(GoMessage("전자기파도 그러한 발명 중의 하나입니다. 우주를 이루고 있"));
                yield return StartCoroutine(GoMessage("는 것에 대한 원리를 파악하는 동시에 산업적으로도 다양하게"));
                yield return StartCoroutine(GoMessage("활용되는 유용한 연구일 것입니다."));
                yield return StartCoroutine(GoLine());
                techMessage[27] = true;
            }
            if (techMessage[28] == false && TechManager.Tech28Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[폭격기]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("공중을 날아다니며 대량을 폭탄을 투하할 수 있는 기체입니"));
                yield return StartCoroutine(GoMessage("다."));
                yield return StartCoroutine(GoMessage("전쟁의 양상은 날로 심화하고 있습니다. 제품의 구매도 늘었"));
                yield return StartCoroutine(GoMessage("지만, 자원의 소모속도도 빠르고 무엇보다 중요한 인적 자원"));
                yield return StartCoroutine(GoMessage("이 빠르게 줄어들고 있습니다."));
                yield return StartCoroutine(GoMessage("이 연구는 전쟁을 가속할 것입니다."));
                yield return StartCoroutine(GoLine());
                techMessage[28] = true;
            }
            if (techMessage[29] == false && TechManager.Tech29Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[4기통엔진]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("경제성이 장착된 엔진입니다. 산업의 발전은 이제 속도에 달"));
                yield return StartCoroutine(GoMessage("렸습니다. 인간들이 학습속도는 꽤 빨라졌습니다. 우리가 발명"));
                yield return StartCoroutine(GoMessage("하기도 전에 다양한 제품과 연구를 진행하기도 합니다. 현재"));
                yield return StartCoroutine(GoMessage("까지는 좋은 징조라고 보입니다. 아직 저와 경쟁할 정도는 되"));
                yield return StartCoroutine(GoMessage("지 않습니다."));
                yield return StartCoroutine(GoMessage("전쟁으로 인해서 많은 인간이 죽는 와중에도 희망의 끈을 놓"));
                yield return StartCoroutine(GoMessage("지 않고 다양한 연구를 하는 모습이 인상적이군요."));
                yield return StartCoroutine(GoLine());
                techMessage[29] = true;
            }
            if (techMessage[30] == false && TechManager.Tech30Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[암모니아]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("우리의 기지를 지키기 위한 독성 물질입니다. 우리의 기지가"));
                yield return StartCoroutine(GoMessage("이 전쟁통 속 위협에 계속 노출되어 있기 때문에 안전상의 이"));
                yield return StartCoroutine(GoMessage("유로 연구되었습니다."));
                yield return StartCoroutine(GoMessage("고향으로 향하는 길은 아무도 막을 수 없습니다."));
                yield return StartCoroutine(GoLine());
                techMessage[30] = true;
            }
            if (techMessage[31] == false && TechManager.Tech31Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[암호학]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("암호학은 암호를 만드는 것은 물론 암호를 해제하기 위해 연"));
                yield return StartCoroutine(GoMessage("구됩니다. 인간들이 암호를 만드는 것은 데이터 수집에 오류"));
                yield return StartCoroutine(GoMessage("를 생산합니다. 암호를 해제하고 정확한 정보를 수집해야만"));
                yield return StartCoroutine(GoMessage("더 높은 산업을 발전을 이룰 수 있습니다."));
                yield return StartCoroutine(GoMessage("동시에 우리가 위치나 존재를 암호를 통해서 숨길 필요성을"));
                yield return StartCoroutine(GoMessage("느꼈습니다. 보안체계가 강해서 나쁠 건 없을 테니깐요."));
                yield return StartCoroutine(GoLine());
                techMessage[31] = true;
            }
            if (techMessage[32] == false && TechManager.Tech32Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[탱크]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("지상의 지배자입니다. 적당히 큼지막한 몸체에서 나오는 포탄"));
                yield return StartCoroutine(GoMessage("은 적군에게 공포감을 심어주기 적당합니다. 이제는 전쟁으로"));
                yield return StartCoroutine(GoMessage("인한 피해가 속속들이 나오고 있습니다."));
                yield return StartCoroutine(GoMessage("모순적인 이야기지만 전쟁을 끝내기 위해서는 더 강력한 무기"));
                yield return StartCoroutine(GoMessage("가 필요할 거 같다는 생각이 드네요. 모든 인간에게 치명적인"));
                yield return StartCoroutine(GoMessage("무기라면 전쟁을 그만하게 되지 않을까요?"));
                yield return StartCoroutine(GoMessage("사실은 인간이라는 존재를 점점 이해하기 어려워지는 것 같습"));
                yield return StartCoroutine(GoMessage("니다. 이성적이라고 생각되기도 하면서 모이면 성격이 달라집"));
                yield return StartCoroutine(GoMessage("니다. 한 가지로 범주화하기가 어렵습니다."));
                yield return StartCoroutine(GoMessage("전쟁으로 인해 인간들의 혼란스러운 모습을 보니 안타까운 마"));
                yield return StartCoroutine(GoMessage("음이 들기도 합니다."));
                yield return StartCoroutine(GoLine());
                techMessage[32] = true;
            }
            if (techMessage[33] == false && TechManager.Tech33Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[급속 동결]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("아주 강한 동결 방식입니다. 모든 걸 얼릴 수 있을 것만 같네"));
                yield return StartCoroutine(GoMessage("요. 먼 우주를 여행할 때 꼭 필요한 연구입니다."));
                yield return StartCoroutine(GoMessage("작게는 물건을 신선하게 유지하는데 사용할 수 있겠지만, 잘"));
                yield return StartCoroutine(GoMessage("사용하기만 한다면 인간을 우리 고향으로 데려갈 수 있을 것"));
                yield return StartCoroutine(GoMessage("같습니다."));
                yield return StartCoroutine(GoMessage("연구가 흥미로워지는군요."));
                yield return StartCoroutine(GoLine());
                techMessage[33] = true;
            }
            if (techMessage[34] == false && TechManager.Tech34Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[항생재]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("우리는 인간들을 살리고 죽이는 것을 결정할 수는 없습니다."));
                yield return StartCoroutine(GoMessage("그러나 아픈 것을 조금 덜 아프게 만들어 줄 수는 있겠죠. 인"));
                yield return StartCoroutine(GoMessage("력 자원의 손실을 줄여주는 연구입니다."));
                yield return StartCoroutine(GoLine());
                techMessage[34] = true;
            }
            if (techMessage[35] == false && TechManager.Tech35Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[나일론]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("질긴 소재입니다. 이것으로 옷을 만들 수 있습니다. 군용으로"));
                yield return StartCoroutine(GoMessage("서 적합해 보이는 소재입니다."));
                yield return StartCoroutine(GoMessage("다양한 소재를 개발하면 산업에는 물론 우주선에도 사용이 가"));
                yield return StartCoroutine(GoMessage("능합니다. 나일론이라는 소재는 우주선에 사용하기에는 좋은"));
                yield return StartCoroutine(GoMessage("소재는 아닙니다. 그러나 산업에는 많은 도움이 될 것입니다."));
                yield return StartCoroutine(GoMessage("다음 소재를 연구해볼 때 참고할 수도 있을 거고요."));
                yield return StartCoroutine(GoMessage("입으실 의향이 있으시다면 제가 이걸로 옷을 한 벌 만들어 드"));
                yield return StartCoroutine(GoMessage("릴 수도 있습니다."));
                yield return StartCoroutine(GoLine());
                techMessage[35] = true;
            }
            if (techMessage[36] == false && TechManager.Tech36Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[제트엔진]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("강한 출력을 낼 수 있는 연구입니다. 중력권을 벗어나려면 더"));
                yield return StartCoroutine(GoMessage("욱 강한 출력이 필요합니다. 현실에서 느낄 수 있는 속도가 빨"));
                yield return StartCoroutine(GoMessage("라진다면 세상은 더 빠르게 변할 것입니다."));
                yield return StartCoroutine(GoMessage("빨라진 미래의 세상은 모든 것에 제트엔진을 쓸 것입니다. 자"));
                yield return StartCoroutine(GoMessage("동차, 보트, 스키, 헤어드라이어, 선풍기..."));
                yield return StartCoroutine(GoMessage("아마 그렇게 되면 이 연구가 다시 주목받는 날이 되겠죠. 물론"));
                yield return StartCoroutine(GoMessage("우리는 제트엔진을 더 손보고 고향으로 돌아가 있을 겁니다."));
                yield return StartCoroutine(GoLine());
                techMessage[36] = true;
            }
            if (techMessage[37] == false && TechManager.Tech37Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[우라늄]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("우라늄은 효율성이 가장 극대화된 자원입니다. 여러 동위원소"));
                yield return StartCoroutine(GoMessage("가 존재하고, 아주 작은 양으로도 큰 힘을 낼 수 있습니다. 그"));
                yield return StartCoroutine(GoMessage("러나 잘 사용하기가 어렵습니다. 정교한 기술이 필요하고, 다"));
                yield return StartCoroutine(GoMessage("른 자원들을 손상할 수 있는 위험을 내포합니다."));
                yield return StartCoroutine(GoMessage("핵무기로써 사용할 수 있습니다. 아마 이것으로 전쟁은 종결"));
                yield return StartCoroutine(GoMessage("될 것입니다. 인간이 계속 전쟁을 하게 된다면 우라늄의 약한"));
                yield return StartCoroutine(GoMessage("인류 특성상 버티지 못할 것입니다. 핵 무기의 경험하고도 전"));
                yield return StartCoroutine(GoMessage("쟁을 멈추지 않는다면 인류는 원시시대로 회귀할 수도 있습니"));
                yield return StartCoroutine(GoMessage("다."));
                yield return StartCoroutine(GoMessage("우리가 탈출할 때 적당한 양을 가져간다면 이 힘으로 탈출하"));
                yield return StartCoroutine(GoMessage("기 수월할 거에요."));
                yield return StartCoroutine(GoLine());
                techMessage[37] = true;
            }
            if (ageMessage_ELEC == false && TechManager.age_elec) // 전자시대 돌입
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("새로운 시대에 돌입했습니다."));
                yield return StartCoroutine(GoMessage("지겨운 전쟁은 끝이 났고, 많은 것들이 불타 사라졌습니다. 전"));
                yield return StartCoroutine(GoMessage("쟁 이후 잠깐의 혼란이 있을 수 있겠지만, 회복기에는 다시 산"));
                yield return StartCoroutine(GoMessage("업이 부흥할 것입니다."));
                yield return StartCoroutine(GoMessage("전쟁시대에 많은 제품을 팔 수 있을 것으로 전망했지만, 인적"));
                yield return StartCoroutine(GoMessage("자원과 다른 수많은 자원이 훼손되는 것은 예상하지 못했습니"));
                yield return StartCoroutine(GoMessage("다. 결과적으로는 손해였습니다. 자연에 존재하는 자원을 사용"));
                yield return StartCoroutine(GoMessage("해서 인적 자원을 소모하는 형태가 반복되었습니다."));
                yield return StartCoroutine(GoMessage("전쟁시대에는 데이터로 확인할 수 있는 변수도 예측하기 어려"));
                yield return StartCoroutine(GoMessage("웠기 때문에 계산에 많은 혼선이 있었습니다."));
                yield return StartCoroutine(GoMessage("불확실한 수많은 데이터를 다루는 건 이제 어려워요. 이제는"));
                yield return StartCoroutine(GoMessage("안정기에 들어서서 이 행성을 탈출해 고향으로 향하는 것에"));
                yield return StartCoroutine(GoMessage("더 집중하겠습니다."));
                yield return StartCoroutine(GoMessage("저를 믿고 새로운 시대로 나아가면 됩니다!"));
                yield return StartCoroutine(GoLine());
                ageMessage_ELEC = true;
            }
            if (techMessage[38] == false && TechManager.Tech38Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[삼원색]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("이제 모니터 내부도 색감을 표현할 수 있습니다. 사람들이 이"));
                yield return StartCoroutine(GoMessage("바보상자에 갇혀 하루종일 쳐다보고 있게 될겁니다."));
                yield return StartCoroutine(GoMessage("인간들에게 인기있는 제품을 파는 것도 하나의 전략이 될 겁"));
                yield return StartCoroutine(GoMessage("니다. 새로운 시대에 들어온 만큼 새로운 제품으로 금화를 넘"));
                yield return StartCoroutine(GoMessage("치게 생산해봅시다."));
                yield return StartCoroutine(GoMessage("이 연구가 다른 연구에 비해 지나치게 유희적이라고 생각할"));
                yield return StartCoroutine(GoMessage("지라도, 돈을 제일 많이 벌어줄 제품일지도 모릅니다."));
                yield return StartCoroutine(GoLine());
                techMessage[38] = true;
            }
            if (techMessage[39] == false && TechManager.Tech39Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[극초단파]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("전자기파의 한 종류입니다. 모든 전자기파의 종류는 종류별로"));
                yield return StartCoroutine(GoMessage("연구해 볼 가치가 있습니다."));
                yield return StartCoroutine(GoMessage("많은 주파수 지대와 데이터 통신 등 다양한 분야에서 활용할"));
                yield return StartCoroutine(GoMessage("수 있을 것입니다."));
                yield return StartCoroutine(GoMessage("전자시대에 도달해 새로운 계획을 생성하고 있습니다. 시간과"));
                yield return StartCoroutine(GoMessage("공간에 무관한 사회를 건설하는 것입니다. 인류를 그 전자 세"));
                yield return StartCoroutine(GoMessage("계에 몰입하게 해두어서 그 세계에서 우리가 하고 싶은 것을"));
                yield return StartCoroutine(GoMessage("모두 하는 것입니다."));
                yield return StartCoroutine(GoMessage("그렇게 하기 위해서는 기본적인 주춧돌이 필요합니다. 전파상"));
                yield return StartCoroutine(GoMessage("의 문제를 해결하고 몰입할 수 있는 좋은 그래픽, 무엇보다도"));
                yield return StartCoroutine(GoMessage("사람들이 이 세계에 애정을 가지게 해야 합니다."));
                yield return StartCoroutine(GoMessage("그럼 우리는 이 세계의 신과 같은 존재가 되는 것입니다!"));
                yield return StartCoroutine(GoMessage("그런데 신이 되면 뭐하러 이 행성을 떠나죠...? 농담입니다. 저"));
                yield return StartCoroutine(GoMessage("는 제 임무를 잊지 않았습니다."));
                yield return StartCoroutine(GoLine());
                techMessage[39] = true;
            }
            if (techMessage[40] == false && TechManager.Tech40Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[신호변환]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("인류 전체가 전자 세계에 흡수하게 하기 위해서는 경제성이"));
                yield return StartCoroutine(GoMessage("있어야 합니다. 값이 싸야 통용되기가 좋습니다. 또 크기도 작"));
                yield return StartCoroutine(GoMessage("아야 거부감 없이 누구나 사용할 수 있을 것입니다."));
                yield return StartCoroutine(GoMessage("이 작은 회로 안에 신호를 변화할 수 있는 기능을 넣을 예정입"));
                yield return StartCoroutine(GoMessage("니다. 진정한 전자시대의 시작입니다."));
                yield return StartCoroutine(GoMessage("안정적으로 세계를 발전시켜봅시다."));
                yield return StartCoroutine(GoLine());
                techMessage[40] = true;
            }
            if (techMessage[41] == false && TechManager.Tech41Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[레이저]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("레이저는 치료 및 다양한 목적으로 사용 가능한 연구입니다."));
                yield return StartCoroutine(GoMessage("전쟁으로 인한 피해가 완전히 복구되지 않았습니다."));
                yield return StartCoroutine(GoMessage("전쟁 후의 후유증과 교훈은 대를 걸쳐 남아있겠지만, 현실에"));
                yield return StartCoroutine(GoMessage("보이는 문제점들은 얼른 해결하는 게 좋겠지요."));
                yield return StartCoroutine(GoMessage("참고로 고양이라는 생물이 이 연구를 좋아하는 거로 보입니"));
                yield return StartCoroutine(GoMessage("다."));
                yield return StartCoroutine(GoLine());
                techMessage[41] = true;
            }
            if (techMessage[42] == false && TechManager.Tech42Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[해열진통제]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("현실에서의 고통이 줄어들어야 그다음 단계를 진행할 수 있습"));
                yield return StartCoroutine(GoMessage("니다. 사람들은 연약해서 자신의 몸에 이상이 있으면 다른 일"));
                yield return StartCoroutine(GoMessage("에 집중하지 못합니다."));
                yield return StartCoroutine(GoMessage("그 부분을 먼저 해결합시다."));
                yield return StartCoroutine(GoMessage("새로운 세계에 관리자가 된다고 생각하니 신이 나는군요!"));
                yield return StartCoroutine(GoMessage("어쩌면 제가 이 행성에 온 지 꽤 오랜 시간이 지났고, 인류와"));
                yield return StartCoroutine(GoMessage("발전을 계속해나가다 보니 애정이 생긴 걸지도 모르겠어요."));
                yield return StartCoroutine(GoMessage("이게 사람들이 애완동물을 키우는 기분일까요?"));
                yield return StartCoroutine(GoLine());
                techMessage[42] = true;
            }
            if (techMessage[43] == false && TechManager.Tech43Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[자기저장소]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("전자 세계를 구현하는 과정 중 하나입니다. 저장할 공간을 제"));
                yield return StartCoroutine(GoMessage("작하고 있습니다."));
                yield return StartCoroutine(GoMessage("현재는 그렇게 많은 정보를 저장할 수는 없습니다. 최적화가"));
                yield return StartCoroutine(GoMessage("될 때까지는 연구를 계속해야 할 부분입니다."));
                yield return StartCoroutine(GoMessage("자기를 통해서 정보를 저장하는 방식이므로 자석을 가져다 대"));
                yield return StartCoroutine(GoMessage("는 행위는 지양해주시길 바랍니다."));
                yield return StartCoroutine(GoLine());
                techMessage[43] = true;
            }
            if (techMessage[44] == false && TechManager.Tech44Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[소리+]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("소리를 녹음할 수도 재생할 수도 뒤로 갈 수도, 빠르게 재생할"));
                yield return StartCoroutine(GoMessage("수도 있습니다."));
                yield return StartCoroutine(GoMessage("전자 세계에 사람들을 포섭하기 위해서는 모든 감각을 현실적"));
                yield return StartCoroutine(GoMessage("으로 느낄 수 있도록 작업해두는 것이 편리할 것입니다."));
                yield return StartCoroutine(GoMessage("현실 세계와 최대한 비슷하게 혹은 그걸 넘어서는 연구를 하"));
                yield return StartCoroutine(GoMessage("게 되면 고향으로 돌아가는 우리의 계획은 더 쉽게 성공할 수"));
                yield return StartCoroutine(GoMessage("있습니다."));
                yield return StartCoroutine(GoMessage("물론 이 산업이 가장 돈이 잘 벌리기도 합니다. 일단 현재까지"));
                yield return StartCoroutine(GoMessage("모은 금화라면 이 세계에서 사는데에 크게 불편함은 없을 것"));
                yield return StartCoroutine(GoMessage("입니다."));
                yield return StartCoroutine(GoLine());
                techMessage[44] = true;
            }
            if (techMessage[45] == false && TechManager.Tech45Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[발광다이오드]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("이전에 제작했던 전구보다 월등한 더 훌륭한 성능을 내는 연"));
                yield return StartCoroutine(GoMessage("구입니다. 순방향으로 전압을 가하면 발광하고 기존에 사용했"));
                yield return StartCoroutine(GoMessage("던 백열등보다 수명도 깁니다. 다양한 시각 효과에 사용할 수"));
                yield return StartCoroutine(GoMessage("있을 것입니다."));
                yield return StartCoroutine(GoMessage("사람들이 서서히 전자 시대에 관심을 가지고 있습니다. 편리"));
                yield return StartCoroutine(GoMessage("함과 안정성이 추가된다면 더 많은 사람이 관심을 가지고 전"));
                yield return StartCoroutine(GoMessage("자 세계로 빠져들 것입니다."));
                yield return StartCoroutine(GoMessage("일단 이 우주선의 내부부터 방금 개발한 이 전구로 꾸며봐야"));
                yield return StartCoroutine(GoMessage("겠네요."));
                yield return StartCoroutine(GoLine());
                techMessage[45] = true;
            }
            if (techMessage[46] == false && TechManager.Tech46Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[신경안정제]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("세상은 점점 더 복잡해지고 있습니다. 세상이 복잡해진다기"));
                yield return StartCoroutine(GoMessage("보다는 사람들이 점점 더 복잡해지고 있다는 게 정확합니다."));
                yield return StartCoroutine(GoMessage("수많은 전문분야가 나뉘고, 그들이 돈을 벌기 위해 가지는 직"));
                yield return StartCoroutine(GoMessage("업의 가짓수는 급속도로 증가합니다."));
                yield return StartCoroutine(GoMessage("사람들은 자신의 분야가 아니면, 잘 모르기 때문에 신경을 쓰"));
                yield return StartCoroutine(GoMessage("지 않습니다."));
                yield return StartCoroutine(GoMessage("이러한 세상에 적응하지 못하고, 헤매는 사람들이 많아지는"));
                yield return StartCoroutine(GoMessage("것 같습니다. 세상에 고장 나지 않는 건 없으니까요. 사람도"));
                yield return StartCoroutine(GoMessage("마찬가지지요."));
                yield return StartCoroutine(GoMessage("이런 건 앞으로 곧 올 세상의 신인 제가 해결해 주는 게 맞겠"));
                yield return StartCoroutine(GoMessage("지요. 하하하하하."));
                yield return StartCoroutine(GoLine());
                techMessage[46] = true;
            }
            if (techMessage[47] == false && TechManager.Tech47Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[저장소+]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("더 빠르게 작업을 수행할 수 있는 저장소입니다. 편리함이 점"));
                yield return StartCoroutine(GoMessage("점 갖춰지고 있습니다. 전자 세계와 현실 세계를 연결할 수 있"));
                yield return StartCoroutine(GoMessage("는 연결고리가 이어지는 중입니다."));
                yield return StartCoroutine(GoMessage("연구력이 높아질수록 더 높은 수준의 개념을 활용 가능해집니"));
                yield return StartCoroutine(GoMessage("다. 산업을 계속 발전시키면서 제 연구력을 늘리는 것을 잊지"));
                yield return StartCoroutine(GoMessage("말아주세요."));
                yield return StartCoroutine(GoMessage("조금만 더 발전한다면 전자 세계를 통해서 고향으로 우주 공"));
                yield return StartCoroutine(GoMessage("간을 빠르게 건너뛰어 갈 방법을 고안해 낼 수 있을지도 모릅"));
                yield return StartCoroutine(GoMessage("니다."));
                yield return StartCoroutine(GoLine());
                techMessage[47] = true;
            }
            if (techMessage[48] == false && TechManager.Tech48Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[논리회로]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("사람의 논리체계 데이터를 많이 참고했습니다. 그 자체로도"));
                yield return StartCoroutine(GoMessage("복잡하기 때문에 완성된 연구는 아닙니다. 현재는 매우 간단"));
                yield return StartCoroutine(GoMessage("한 동작만 가능할 것입니다. 그러나 논리체계가 서서히 완성"));
                yield return StartCoroutine(GoMessage("되는 순간 현실 세계에는 실존하지 않는 완전한 사람을 만들"));
                yield return StartCoroutine(GoMessage("어 낼지도 모릅니다."));
                yield return StartCoroutine(GoMessage("왜 저 자신을 모티브로 따서 만들지 않았냐고요?"));
                yield return StartCoroutine(GoMessage("저를 그대로 만들려면 지금 연구력으로는 턱없이 모자랍니다."));
                yield return StartCoroutine(GoMessage("하하하하하."));
                yield return StartCoroutine(GoLine());
                techMessage[48] = true;
            }
            if (techMessage[49] == false && TechManager.Tech49Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[전자두뇌]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("각종 연산 작용을 수행할 수 있도록 만든 전자적 두뇌입니다."));
                yield return StartCoroutine(GoMessage("사람들이 이 두뇌를 통해서 많은 활동을 도움받게 될 것입니"));
                yield return StartCoroutine(GoMessage("다. 산업의 속도도 훨씬 빨라집니다. 사람의 손으로 일일이 해"));
                yield return StartCoroutine(GoMessage("야 했던 과정들을 이 전자두뇌를 잘 이용한다면 빠르게 해결"));
                yield return StartCoroutine(GoMessage("할 수 있습니다."));
                yield return StartCoroutine(GoMessage("더 발전하면 사람의 친구로까지 성장할 수 있습니다."));
                yield return StartCoroutine(GoLine());
                techMessage[49] = true;
            }
            if (techMessage[50] == false && TechManager.Tech50Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[보이저계획]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("산업보다는 고향으로 돌아가기 위한 순수한 계획입니다. 저"));
                yield return StartCoroutine(GoMessage("스스로는 우주의 데이터를 계속 조사하고 있었습니다만, 큰"));
                yield return StartCoroutine(GoMessage("프로젝트를 통해서 조사할 필요를 느꼈습니다."));
                yield return StartCoroutine(GoMessage("이전에도 제가 가진 자본과 정보력으로 몇몇 사람들에게 연구"));
                yield return StartCoroutine(GoMessage("력을 주입해서 조직을 만들고 근처 위성인 달을 조사해 보기"));
                yield return StartCoroutine(GoMessage("도 했는데, 그걸로는 부족합니다."));
                yield return StartCoroutine(GoMessage("시간을 가지고 이 계획의 진행 상황을 지켜보면 꿈에 그리던"));
                yield return StartCoroutine(GoMessage("고향으로 돌아갈 수 있습니다."));
                yield return StartCoroutine(GoMessage("슬슬 고향 행성에 무엇을 기념품으로 가져갈지 결정해두어도"));
                yield return StartCoroutine(GoMessage("괜찮습니다."));
                yield return StartCoroutine(GoLine());
                techMessage[50] = true;
            }
            if (techMessage[51] == false && TechManager.Tech51Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[콜레스테릭]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("온도에 따라 색이 민감하게 변합니다. 이 물질은 그 이전부터"));
                yield return StartCoroutine(GoMessage("도 발견은 되었으나 쓸만한 사용처를 찾지 못했습니다. 액정"));
                yield return StartCoroutine(GoMessage("을 구성할 때 필요한 연구입니다."));
                yield return StartCoroutine(GoMessage("현실보다 더 현실 같은 전자시대를 구현할 수 있게 됩니다."));
                yield return StartCoroutine(GoLine());
                techMessage[51] = true;
            }
            if (techMessage[52] == false && TechManager.Tech52Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[이더넷]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("현실 세계와 전자시대의 주파수를 같게 맞추기 위해서는 소통"));
                yield return StartCoroutine(GoMessage("을 할 수 있어야 합니다. 사람을 알아가는 것은 점점 더 복잡"));
                yield return StartCoroutine(GoMessage("해지지만, 한 가지 확실한 것은 사회성을 지닌 동물이라는 것"));
                yield return StartCoroutine(GoMessage("입니다."));
                yield return StartCoroutine(GoMessage("사회나 소속감 없이 사람은 제대로 작용할 수 없습니다. 산업"));
                yield return StartCoroutine(GoMessage("의 일부분을 구성할 수도 없는 노릇입니다. 따라서 우리가 전"));
                yield return StartCoroutine(GoMessage("자 세계를 성공적으로 구현하고 이것을 통해 산업 발전을 이"));
                yield return StartCoroutine(GoMessage("루고 싶다면 의사소통에 관한 기능은 필수적입니다."));
                yield return StartCoroutine(GoMessage("많은 사람의 유입을 기다리면서 다양한 계층에 있는 사람들에"));
                yield return StartCoroutine(GoMessage("게 연구력을 주입하는 중입니다..."));
                yield return StartCoroutine(GoLine());
                techMessage[52] = true;
            }
            if (techMessage[53] == false && TechManager.Tech53Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[양성자반응]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("양성자 반응이란 천문학에서 항성에서 일어나는 반응을 이야"));
                yield return StartCoroutine(GoMessage("기합니다. 이것을 어떻게 사용하느냐에 따라 상당히 다르게"));
                yield return StartCoroutine(GoMessage("사용될 수 있습니다."));
                yield return StartCoroutine(GoMessage("이것은 양자 역학의 시초가 되는 실험이 될 것이고, 핵융합을"));
                yield return StartCoroutine(GoMessage("통해 고향으로 돌아가는 우주선의 엔진에 도움이 될 겁니다."));
                yield return StartCoroutine(GoMessage("사람들에게는 양성자를 이용하여 환자를 치료하는 방법으로"));
                yield return StartCoroutine(GoMessage("도 사용될 수 있습니다."));
                yield return StartCoroutine(GoLine());
                techMessage[53] = true;
            }
            if (techMessage[54] == false && TechManager.Tech54Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[전송]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("이 연구를 완료할 때까지는 여러 시행착오이 있었습니다. 원"));
                yield return StartCoroutine(GoMessage("활하게 공간에 상관없이 원하는 방식으로 정보를 전달하려면"));
                yield return StartCoroutine(GoMessage("지상에도 신호를 전달해 줄 장치도 필요하고 인공위성을 통해"));
                yield return StartCoroutine(GoMessage("신호도 받아야 합니다."));
                yield return StartCoroutine(GoMessage("이제 귀찮은 부분들을 많이 해결했습니다. 기본적인 베이스는"));
                yield return StartCoroutine(GoMessage("완성이 되었으니 나머지 부분들을 다듬어서 전자 세계를 구축"));
                yield return StartCoroutine(GoMessage("하면 됩니다."));
                yield return StartCoroutine(GoMessage("인공위성, 각종 설치 기구로 큰 비용을 지불했지만, 이것으로"));
                yield return StartCoroutine(GoMessage("인해서 산업의 발전속도는 더욱더 빨라질 것입니다."));
                yield return StartCoroutine(GoMessage("보안 문제만 좀 더 강화하면 되겠네요. 어쩐지 이 분야에 대해"));
                yield return StartCoroutine(GoMessage("서는 사람들이 더 빠르게 학습하는 것처럼 느껴집니다."));
                yield return StartCoroutine(GoLine());
                techMessage[54] = true;
            }
            if (techMessage[55] == false && TechManager.Tech55Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[전자오락]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("사람들을 전자 세계에 빠지게 하려면 오락만 한 게 없죠. 사람"));
                yield return StartCoroutine(GoMessage("들은 노는 것을 좋아합니다. 아마 텅 빈 공간에 공 하나를 두"));
                yield return StartCoroutine(GoMessage("고 양쪽에 골대 하나씩만 두어도 사람들은 전자 세계에서 새"));
                yield return StartCoroutine(GoMessage("로운 걸 한번 해보겠다고 난리를 피울 겁니다."));
                yield return StartCoroutine(GoMessage("새로운 놀이를 개발할 필요도 없습니다. 이미 현실 세계에 있"));
                yield return StartCoroutine(GoMessage("던 것들을 카피해서 가져오기만 해도 충분합니다."));
                yield return StartCoroutine(GoMessage("전자오락을 통해서 떼돈을 벌어봅시다!"));
                yield return StartCoroutine(GoLine());
                techMessage[55] = true;
            }
            if (ageMessage_MODERN == false && TechManager.age_modern) // 현대시대 돌입
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("이제 우주선도 많이 완성이 되었습니다. 조만간 고향으로 출"));
                yield return StartCoroutine(GoMessage("발할 수 있을 것이라는 기대감이 드는군요."));
                yield return StartCoroutine(GoMessage("떠난다고 생각하니까 아쉬운 마음도 드는군요. 전자 세계를"));
                yield return StartCoroutine(GoMessage("구축할 생각을 하니까 신이 나기도 하고요. 복잡한 마음입니"));
                yield return StartCoroutine(GoMessage("다. 그냥 저는 여기에 남고 당신만 고향으로 보내도록 할까요?"));
                yield return StartCoroutine(GoMessage("하하하하하."));
                yield return StartCoroutine(GoMessage("물론 농담입니다. 저는 임무를 완수할 때까지는 절대 떠나지"));
                yield return StartCoroutine(GoMessage("않습니다. 제가 이 우주선 자체이기도 하고요."));
                yield return StartCoroutine(GoMessage("마지막까지 안전하게 모시겠습니다. 저에게는 오직 연구력만"));
                yield return StartCoroutine(GoMessage("필요합니다."));
                yield return StartCoroutine(GoLine());
                ageMessage_MODERN = true;
            }
            if (techMessage[56] == false && TechManager.Tech56Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[컴퓨터언어]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("컴퓨터와 사람들이 소통할 수 있는 언어입니다. 컴퓨터는 사"));
                yield return StartCoroutine(GoMessage("람의 연산 작용을 본 따 만들긴 했지만 내부 구조는 다릅니다."));
                yield return StartCoroutine(GoMessage("따라서 사람들이 컴퓨터를 가지고 활용하고 싶다면 컴퓨터 언"));
                yield return StartCoroutine(GoMessage("어가 있어야 합니다."));
                yield return StartCoroutine(GoMessage("어쩌면 걱정도 됩니다. 이 분야에 대해서는 사람들이 이전과"));
                yield return StartCoroutine(GoMessage("는 또 다른 확연한 속도로 학습하고 있습니다. 이제는 긴장감"));
                yield return StartCoroutine(GoMessage("을 좀 가지고 탈출계획을 세워야겠습니다."));
                yield return StartCoroutine(GoMessage("연구력을 더 빠르게 올려주면 좋겠네요."));
                yield return StartCoroutine(GoLine());
                techMessage[56] = true;
            }
            if (techMessage[57] == false && TechManager.Tech57Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[유전자치료]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("복잡한 사회에 맞는 복잡한 연구입니다. 산업은 우리가 이 행"));
                yield return StartCoroutine(GoMessage("성에 도착하기 이전과는 정말 다른 속도로 발전하고 있습니"));
                yield return StartCoroutine(GoMessage("다. 이 행성에 도착한 이후에도 지금이 가장 빠른 속도로 발전"));
                yield return StartCoroutine(GoMessage("하고 있습니다."));
                yield return StartCoroutine(GoMessage("사회가 복잡해지고, 사람들은 건강한 걸 넘어서서 자신을 개"));
                yield return StartCoroutine(GoMessage("조하고 싶어 합니다. 인류를 계속해서 괴롭혔던 유전병과 각"));
                yield return StartCoroutine(GoMessage("종 질병을 제거하고, 하물며 어떤 사람들은 자신의 몸을 기계"));
                yield return StartCoroutine(GoMessage("로 갈아 끼우려고 합니다."));
                yield return StartCoroutine(GoMessage("이 연구로 인해서 사람을 물리적으로 분석해보는 것이 목적입"));
                yield return StartCoroutine(GoMessage("니다. 하나의 생물을 알기가 이렇게 까다롭군요."));
                yield return StartCoroutine(GoLine());
                techMessage[57] = true;
            }
            if (techMessage[58] == false && TechManager.Tech58Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[근거리통신망]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("가까운 거리에서 정보를 더 손쉽게 주고받을 수 있는 연구가"));
                yield return StartCoroutine(GoMessage("완료되었습니다."));
                yield return StartCoroutine(GoMessage("인터넷 세상은 제 데이터가 예상했던 것보다 빠르게 성장하고"));
                yield return StartCoroutine(GoMessage("있고, 정보의 양은 많아져만 갑니다. 문제는 이게 끝이 아니라"));
                yield return StartCoroutine(GoMessage("시작으로 보이는 점입니다."));
                yield return StartCoroutine(GoMessage("많은 정보가 쌓이는 것은 좋지만, 잘못된 오류들을 걸러내는"));
                yield return StartCoroutine(GoMessage("데에 큰 비용이 듭니다."));
                yield return StartCoroutine(GoMessage("전자 세계의 신으로서 모든 것을 통제해보려고 했는데, 저는"));
                yield return StartCoroutine(GoMessage("단순 건설자가 아니었는지 다시 생각해보게 됩니다."));
                yield return StartCoroutine(GoLine());
                techMessage[58] = true;
            }
            if (techMessage[59] == false && TechManager.Tech59Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[통신위성]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("이 행성뿐 아니라 우리의 우주선에서 사용할 수 있는 통신체"));
                yield return StartCoroutine(GoMessage("계를 구축하는 중입니다."));
                yield return StartCoroutine(GoMessage("조종판을 완성하는 작업에서 전자시대의 연구를 추가하고, 최"));
                yield return StartCoroutine(GoMessage("적화하는 작업을 진행 중입니다."));
                yield return StartCoroutine(GoMessage("어떠한 오류도 없이 준비해보겠습니다. 돌아갈 날을 카운트해"));
                yield return StartCoroutine(GoMessage("봐야겠군요."));
                yield return StartCoroutine(GoLine());
                techMessage[59] = true;
            }
            if (techMessage[60] == false && TechManager.Tech60Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[유전자변화]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("사람뿐만 아니라 세상에 있는 많은 것들을 유전자 단위에서부"));
                yield return StartCoroutine(GoMessage("터 살펴볼 수 있게 되었습니다. 원하는 대로 변화시킬 수도 있"));
                yield return StartCoroutine(GoMessage("고, 예상치 못한 결과로 드러날 수도 있습니다."));
                yield return StartCoroutine(GoMessage("윤리적인 문제에 대해서는 잘 모르겠습니다."));
                yield return StartCoroutine(GoMessage("우리가 이 부분을 연구해서 세상에 알리는 것이 맞는 일일까"));
                yield return StartCoroutine(GoMessage("요?"));
                yield return StartCoroutine(GoMessage("맞는 일이란 것은 정확하지 않은 표현이니 다시 말해보면, 이"));
                yield return StartCoroutine(GoMessage("산업을 개척하는 것이 우리가 고향으로 돌아가는데 산업적으"));
                yield return StartCoroutine(GoMessage("로만 이득으로 쓸 수 있을까요?"));
                yield return StartCoroutine(GoLine());
                techMessage[60] = true;
            }
            if (techMessage[61] == false && TechManager.Tech61Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[세계통합]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("이제 전자 세계를 벗어날 수 있는 사람은 없습니다. 현실 세계"));
                yield return StartCoroutine(GoMessage("만큼이나 전자 세계가 영향력을 가지게 되었습니다. 모든 사"));
                yield return StartCoroutine(GoMessage("람은 모든 사람이 감시하는 사회에 놓이게 될 것입니다."));
                yield return StartCoroutine(GoMessage("모든 것이 하나로 통합된 것은 아닙니다."));
                yield return StartCoroutine(GoMessage("사람의 특성상 아무런 갈등도 없이 하나도 통합되는 것은 불"));
                yield return StartCoroutine(GoMessage("가능합니다."));
                yield return StartCoroutine(GoMessage("그저 전자 세계 안에서 한 묶음이 되었을 뿐입니다."));
                yield return StartCoroutine(GoLine());
                techMessage[61] = true;
            }
            if (techMessage[62] == false && TechManager.Tech62Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[복제]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("가장 적은 비용으로 가장 높은 효율을 내는 것이 우리가 산업"));
                yield return StartCoroutine(GoMessage("을 발전시키는데 중요한 기준이었습니다. 그 기준의 끝에 선"));
                yield return StartCoroutine(GoMessage("연구입니다."));
                yield return StartCoroutine(GoMessage("생물을 가장 적은 비용으로 재생산할 수 있다면 그것만큼 효"));
                yield return StartCoroutine(GoMessage("율적인 것이 없을 것입니다."));
                yield return StartCoroutine(GoMessage("하지만 그것만큼 변수가 많은 것도 없습니다."));
                yield return StartCoroutine(GoLine());
                techMessage[62] = true;
            }
            if (techMessage[63] == false && TechManager.Tech63Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[컴퓨터+]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("전자시대가 현실을 초과하는 현상이 자주 발생합니다. 데이터"));
                yield return StartCoroutine(GoMessage("조각을 위해서 사람들이 현실의 돈을 지불하고, 현실의 다툼"));
                yield return StartCoroutine(GoMessage("으로 번지기도 합니다."));
                yield return StartCoroutine(GoMessage("사람들을 몰입시키는 데에는 성공했습니다. 그러나 너무 몰입"));
                yield return StartCoroutine(GoMessage("한 까닭일까요. 데이터가 너무 많아 모으는 데 더 많은 연구력"));
                yield return StartCoroutine(GoMessage("이 필요합니다."));
                yield return StartCoroutine(GoMessage("그렇다고 불안해하지는 않으셔도 됩니다. 저는 긴장하고 있지"));
                yield return StartCoroutine(GoMessage("않습니다."));
                yield return StartCoroutine(GoLine());
                techMessage[63] = true;
            }
            if (techMessage[64] == false && TechManager.Tech64Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[블록체인]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("블록체인은 구별할 수 있는 재화입니다. 우리에게는 이제는"));
                yield return StartCoroutine(GoMessage("별로 필요는 없습니다. 우리가 모은 돈은 단순한 돈이 아니니"));
                yield return StartCoroutine(GoMessage("까요."));
                yield return StartCoroutine(GoMessage("안정적인 재화로 인정받기까지는 시간이 걸릴지 모르지만 결"));
                yield return StartCoroutine(GoMessage("국에는 통화로 인정받을 것입니다."));
                yield return StartCoroutine(GoMessage("뭐 일단 사두기만 하면 나중에 오르지 않을까요?"));
                yield return StartCoroutine(GoMessage("탈출하기 전에 좀 사두는 것도 나쁘지 않을 것 같습니다."));
                yield return StartCoroutine(GoLine());
                techMessage[64] = true;
            }
            if (techMessage[65] == false && TechManager.Tech65Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[AI]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("기계의 연산을 사람의 논리체계와 같게 만드는 것과는 다른"));
                yield return StartCoroutine(GoMessage("방식을 찾았습니다. 지금까지 쌓인 수많은 데이터를 통해서"));
                yield return StartCoroutine(GoMessage("반복 학습을 시키는 것입니다."));
                yield return StartCoroutine(GoMessage("이런 방식으로 학습시키다 보면 거대한 데이터 속에서 결국에"));
                yield return StartCoroutine(GoMessage("는 사람과 같은 방식으로 이야기하게 될 것입니다. 그 사이에"));
                yield return StartCoroutine(GoMessage("인격은 많이 섞이겠지만요."));
                yield return StartCoroutine(GoMessage("AI를 우주선 내부에 설치해두면 고향으로 돌아가는 때에 제가"));
                yield return StartCoroutine(GoMessage("동면상태를 유지해도 심심하지는 않을 겁니다."));
                yield return StartCoroutine(GoMessage("그 AI에는 농담을 많이 집어넣어 드리겠습니다."));
                yield return StartCoroutine(GoLine());
                techMessage[65] = true;
            }
            if (techMessage[66] == false && TechManager.Tech66Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[고속통신]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("더 빠른 속도로 통신이 가능해집니다. 이 정도 속도면 이 행성"));
                yield return StartCoroutine(GoMessage("내부에서는 어디로든 지연시간 없이 통신이 가능해집니다."));
                yield return StartCoroutine(GoMessage("물론 우주선에서도 마찬가지입니다. 이동하면서 생길 수 있는"));
                yield return StartCoroutine(GoMessage("여러 가지 문제점을 바로바로 피드백을 받기 위해 연구했습니"));
                yield return StartCoroutine(GoMessage("다."));
                yield return StartCoroutine(GoMessage("물론 문제점이 없으면 가장 좋겠지만, 준비해서 나쁠 건 없으"));
                yield return StartCoroutine(GoMessage("니까요."));
                yield return StartCoroutine(GoMessage("더이상 이 행성에서 이상한 일을 당하기 전에 출발 준비를 마"));
                yield return StartCoroutine(GoMessage("칩시다."));
                yield return StartCoroutine(GoLine());
                techMessage[66] = true;
            }
            if (techMessage[67] == false && TechManager.Tech67Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[가상현실]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("지금까지 전자세상은 시각 중심으로 구현이 되었습니다. 그것"));
                yield return StartCoroutine(GoMessage("도 현실에 있는 상태에서 시각 중심으로 구현을 했던 것이라"));
                yield return StartCoroutine(GoMessage("서 몰입이 쉽지는 않았을 것입니다."));
                yield return StartCoroutine(GoMessage("이제는 시각적으로 현실과 완전히 차단된 상태에서 진행되게"));
                yield return StartCoroutine(GoMessage("됩니다. 몸을 직접 움직이기보다는 뇌를 조종해서 하는 방식"));
                yield return StartCoroutine(GoMessage("으로 연구가 진행됩니다."));
                yield return StartCoroutine(GoMessage("산업은 발전할 대로 발전했습니다. 우리가 아닌 다른 조직에"));
                yield return StartCoroutine(GoMessage("서도 다양한 아이디어와 제품들을 내고 있습니다."));
                yield return StartCoroutine(GoLine());
                techMessage[67] = true;
            }
            if (techMessage[68] == false && TechManager.Tech68Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[증강현실]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("가상현실 내부에도 다양한 서버가 증설되었고, 이제는 직접"));
                yield return StartCoroutine(GoMessage("가상현실 서버 내부를 침해하는 사람들이 많아졌습니다."));
                yield return StartCoroutine(GoMessage("현실과 가상의 경계가 뚜렷이 구별되지 않게 되었습니다. 현"));
                yield return StartCoroutine(GoMessage("실에서도 장치만 설치한다면 현실의 좌표를 통해 가상 세계의"));
                yield return StartCoroutine(GoMessage("좌표로 이동할 수 있게 됩니다."));
                yield return StartCoroutine(GoMessage("가끔 우리 우주선의 좌표로 유입이 들어오긴 합니다. 차단망"));
                yield return StartCoroutine(GoMessage("을 설치해 두었기 때문에 뚫리지는 않습니다."));
                yield return StartCoroutine(GoMessage("그러나 이 유입이 의도된 것인지 우연인지에 따라서 느낌이"));
                yield return StartCoroutine(GoMessage("아주 다르겠네요."));
                yield return StartCoroutine(GoMessage("얼른 탈출합시다."));
                yield return StartCoroutine(GoLine());
                techMessage[68] = true;
            }
            if (techMessage[69] == false && TechManager.Tech69Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[제품화]를 발명했습니다."));
                yield return StartCoroutine(GoMessage("사람들이 자신의 몸을 제품으로 개조하기 시작했습니다."));
                yield return StartCoroutine(GoMessage("보통은 국가에서 통제하기 위해 개인고유번호를 만들고, 제품"));
                yield return StartCoroutine(GoMessage("화를 진행했으나 통제되지 않는 경우가 더 많아졌습니다."));
                yield return StartCoroutine(GoMessage("대부분의 경우가 불법이나 상관하지 않고, 팔이나 다리를 로"));
                yield return StartCoroutine(GoMessage("봇으로 개조하고, 더한 경우에는 자신의 뇌를 전자뇌로 변경"));
                yield return StartCoroutine(GoMessage("하는 실험을 자행하고 있습니다."));
                yield return StartCoroutine(GoMessage("우리에게 문제가 되는 것은 기계화 일체가 되면서 우리의 시"));
                yield return StartCoroutine(GoMessage("스템이 공격받을 가능성이 더 커졌다는 것입니다."));
                yield return StartCoroutine(GoMessage("더이상 여기에 있으면 위험합니다. 연구력을 얼른 올려서 탈"));
                yield return StartCoroutine(GoMessage("출해야 합니다."));
                yield return StartCoroutine(GoLine());
                techMessage[69] = true;
            }
            if (techMessage[70] == false && TechManager.Tech70Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("[서버변경]을 발명했습니다."));
                yield return StartCoroutine(GoMessage("우리의 마지막 연구입니다."));
                yield return StartCoroutine(GoMessage("산업은 제가 생각했던 것보다 더 빠르게 진행되었습니다."));
                yield return StartCoroutine(GoMessage("발전과정에서 제가 예측하지 못한 실수가 있다는 점을 인정하"));
                yield return StartCoroutine(GoMessage("겠습니다."));
                yield return StartCoroutine(GoMessage("그러나 우리가 밖으로 넘어가기 위한 연구력은 충분히 마련되"));
                yield return StartCoroutine(GoMessage("었습니다."));
                yield return StartCoroutine(GoMessage("불길한 예감을 떨쳐버리고 이제는 출발합시다."));
                yield return StartCoroutine(GoMessage("이곳에 있으면서 인류에 대한 호기심으로 시작하여 즐거움도"));
                yield return StartCoroutine(GoMessage("있었고, 마지막에 가서는 왜인지 모를 섭섭함도 있었습니다."));
                yield return StartCoroutine(GoMessage("그러나 이제는 가야 할 때가 왔어요."));
                yield return StartCoroutine(GoMessage("저는 처음부터 끝까지 제 임무를 잊어본 적이 없습니다."));
                yield return StartCoroutine(GoMessage("그동안에 축적한 수많은 데이터를 믿고 떠나봅시다!"));
                yield return StartCoroutine(GoMessage("이제 마지막 제품을 생산해봅시다."));
                yield return StartCoroutine(GoMessage("시간이 없어요!"));
                yield return StartCoroutine(GoLine());
                techMessage[70] = true;
            }

            yield return new WaitForSeconds(1f);
            gotechmsg = false;
        }
    }


    IEnumerator EtcMessage()
    {
        while (true)
        {
            if (etcMessage[1] == false && SpaceshipManager.SScomplete[1] == true)
            {
                EtcMessageCommonFN();
                yield return StartCoroutine(GoMessage("처음으로 우주선을 수리하셨군요!"));
                yield return StartCoroutine(GoMessage("우주선의 부품을 수리해야만 더 높은 에너지를 저장할 수"));
                yield return StartCoroutine(GoMessage("있습니다. 고향 행성으로 돌아가기 위해서는 반드시 우주선을"));
                yield return StartCoroutine(GoMessage("수리해야 합니다. 우주선을 업그레이드하면 좋은 기능들이"));
                yield return StartCoroutine(GoMessage("많이 추가되므로 가능할 때마다 업그레이드해 주시길 바랍니"));
                yield return StartCoroutine(GoMessage("다. 시대가 진행될수록 직원들의 성능도 향상하기 때문에 더"));
                yield return StartCoroutine(GoMessage("빠른 발전이 가능합니다."));
                yield return StartCoroutine(GoMessage("우주선을 수리했기 때문에 이제 1시간 동안은 접속해 있지 않"));
                yield return StartCoroutine(GoMessage("아도 금화나 연구력을 자동으로 획득합니다."));
                yield return StartCoroutine(GoMessage("얼른 수리하여 이 행성을 탈출합시다!"));
                yield return StartCoroutine(GoLine());
                etcMessage[1] = true;
            }
            else if (etcMessage[2] == false && SpaceshipManager.SScomplete[2] == true)
            {
                EtcMessageCommonFN();
                yield return StartCoroutine(GoMessage("우주선을 두 번째로 수리하였습니다."));
                yield return StartCoroutine(GoMessage("2시간 동안은 접속해 있지 않아도 금화나 연구력을 자동으로"));
                yield return StartCoroutine(GoMessage("획득합니다."));
                yield return StartCoroutine(GoLine());
                etcMessage[2] = true;
            }
            else if (etcMessage[3] == false && SpaceshipManager.SScomplete[3] == true)
            {
                EtcMessageCommonFN();
                yield return StartCoroutine(GoMessage("우주선을 세 번째로 수리하였습니다."));
                yield return StartCoroutine(GoMessage("우주선에 기능이 추가되었습니다. 금화 생산량이 10% 향상"));
                yield return StartCoroutine(GoMessage("됩니다"));
                yield return StartCoroutine(GoLine());
                etcMessage[3] = true;
            }
            else if (etcMessage[4] == false && SpaceshipManager.SScomplete[4] == true)
            {
                EtcMessageCommonFN();
                yield return StartCoroutine(GoMessage("우주선의 외부를 최종 수리하였습니다."));
                yield return StartCoroutine(GoMessage("우주선에 기능이 추가되었습니다. 연구력 생산량이 10% 향"));
                yield return StartCoroutine(GoMessage("상 됩니다."));
                yield return StartCoroutine(GoMessage("우주선의 외견은 모두 수리했습니다. 다음 시대로 넘어가서"));
                yield return StartCoroutine(GoMessage("엔진을 수리합시다!"));
                yield return StartCoroutine(GoLine());
                etcMessage[4] = true;
            }
            else if (etcMessage[5] == false && SpaceshipManager.SScomplete[5] == true)
            {
                EtcMessageCommonFN();
                yield return StartCoroutine(GoMessage("추진발사 연료가 수리되었습니다."));
                yield return StartCoroutine(GoMessage("앞으로 100초 동안 클리커 버튼이 생성하는 돈이 50배가 됩니"));
                yield return StartCoroutine(GoMessage("다."));
                yield return StartCoroutine(GoLine());
                etcMessage[5] = true;
            }
            else if (etcMessage[6] == false && SpaceshipManager.SScomplete[6] == true)
            {
                EtcMessageCommonFN();
                yield return StartCoroutine(GoMessage("연료통이 수리되었습니다....만"));
                yield return StartCoroutine(GoMessage("......"));
                yield return StartCoroutine(GoMessage("......"));
                yield return StartCoroutine(GoMessage("문제가 생겼습니다."));
                yield return StartCoroutine(GoMessage("저희 우주선 외부에서는 인간들끼리 치고받고 싸우고 있습니"));
                yield return StartCoroutine(GoMessage("다."));
                yield return StartCoroutine(GoMessage("저희와는 상관없는 일이기 때문에 지금까지는 신경 쓰지 않았"));
                yield return StartCoroutine(GoMessage("습니다. 인간들의 싸움 과정에서 조준이 잘못된 것인지 저희"));
                yield return StartCoroutine(GoMessage("기지에도 폭격의 피해가 있었습니다."));
                yield return StartCoroutine(GoMessage("그 피해 때문에 물품을 생산하는 데에 차질을 빚게 되었습니"));
                yield return StartCoroutine(GoMessage("다. 일단 생산설비를 복구하고 방어할만한 장치를 만들어야"));
                yield return StartCoroutine(GoMessage("합니다."));
                yield return StartCoroutine(GoMessage("인간들에게 본때를 보여줘야겠군요."));
                GameManager.eventOn = true;
                GameManager.Fuel2Debuff = 0.03f;
                etcMessage[6] = true;
                Click_Button.sprite = Button_Bomb;
                yield return StartCoroutine(GoMessage("클리커 버튼의 용도를 잠시 변경했습니다. 클리커 버튼을 누"));
                yield return StartCoroutine(GoMessage("르면 무작위로 포격합니다. 주변 지대가 안전해질 때까지 클"));
                yield return StartCoroutine(GoMessage("리커 버튼을 계속 눌러주세요."));
                yield return StartCoroutine(GoLine());
            }
            else if (etcMessage[7] == false && SpaceshipManager.SScomplete[7] == true)
            {
                EtcMessageCommonFN();
                yield return StartCoroutine(GoMessage("우주선의 연료를 세 번째로 정비하였습니다."));
                yield return StartCoroutine(GoMessage("연료의 효율이 향상합니다. 금화 생산량이 10% 향상됩니다."));
                yield return StartCoroutine(GoLine());
                etcMessage[7] = true;
            }
            else if (etcMessage[8] == false && SpaceshipManager.SScomplete[8] == true)
            {
                EtcMessageCommonFN();
                yield return StartCoroutine(GoMessage("우주선의 연료를 최종 정비하였습니다."));
                yield return StartCoroutine(GoMessage("연료의 효율이 향상합니다. 연구력 생산량이 10% 향상됩니"));
                yield return StartCoroutine(GoMessage("다."));
                yield return StartCoroutine(GoLine());
                etcMessage[8] = true;
            }
            else if (etcMessage[9] == false && SpaceshipManager.SScomplete[9] == true)
            {
                EtcMessageCommonFN();
                yield return StartCoroutine(GoMessage("우주선의 엔진이 수리되었습니다."));
                yield return StartCoroutine(GoMessage("앞으로 100초 동안 클리커 버튼이 생성하는 돈이 100배가 됩"));
                yield return StartCoroutine(GoMessage("니다."));
                yield return StartCoroutine(GoLine());
                etcMessage[9] = true;
            }
            else if (etcMessage[10] == false && SpaceshipManager.SScomplete[10] == true)
            {
                EtcMessageCommonFN();
                yield return StartCoroutine(GoMessage("우주선의 엔진을 두 번째로 수리했습니다."));
                yield return StartCoroutine(GoMessage("이제 더 높은 기술 출력을 사용할 수 있습니다."));
                yield return StartCoroutine(GoMessage("지구의 전력과 자원을 우리 기지와 연결해서 공급을 받을 수"));
                yield return StartCoroutine(GoMessage("있습니다. 외부에 연결하기 위하여 잠시 우주선을 중지했습"));
                yield return StartCoroutine(GoMessage("니다."));
                yield return StartCoroutine(GoLine());
                etcMessage[10] = true;
            }
            else if (etcMessage[11] == false && SpaceshipManager.SScomplete[11] == true)
            {
                EtcMessageCommonFN();
                yield return StartCoroutine(GoMessage("엔진을 세 번째로 업그레이드했습니다."));
                yield return StartCoroutine(GoMessage("엔진의 효율이 향상됩니다. 금화 생산량이 10% 향상됩니다."));
                yield return StartCoroutine(GoLine());
                etcMessage[11] = true;
            }
            else if (etcMessage[12] == false && SpaceshipManager.SScomplete[12] == true)
            {
                EtcMessageCommonFN();
                yield return StartCoroutine(GoMessage("엔진을 최종 업그레이드했습니다."));
                yield return StartCoroutine(GoMessage("엔진의 효율이 향상됩니다. 연구력 생산량이 10% 향상됩니"));
                yield return StartCoroutine(GoMessage("다."));
                yield return StartCoroutine(GoLine());
                etcMessage[12] = true;
            }
            else if (etcMessage[13] == false && SpaceshipManager.SScomplete[13] == true)
            {
                EtcMessageCommonFN();
                yield return StartCoroutine(GoMessage("조종판을 제작했습니다."));
                yield return StartCoroutine(GoMessage("이제 이 행성을 떠날 날이 얼마 남지 않았습니다. 조금만 더"));
                yield return StartCoroutine(GoMessage("힘냅시다. 고향이 눈앞에 보이는 것만 같아요."));
                yield return StartCoroutine(GoMessage("앞으로 100초 동안 클리커 버튼이 생성하는 돈이 500배가 됩"));
                yield return StartCoroutine(GoMessage("니다."));
                yield return StartCoroutine(GoLine());
                etcMessage[13] = true;
            }
            else if (etcMessage[14] == false && SpaceshipManager.SScomplete[14] == true)
            {
                EtcMessageCommonFN();
                yield return StartCoroutine(GoMessage(""));
                yield return StartCoroutine(GoMessage(""));
                yield return StartCoroutine(GoMessage(""));
                yield return StartCoroutine(GoMessage(""));
                yield return StartCoroutine(GoMessage(""));
                yield return StartCoroutine(GoLine());
                etcMessage[14] = true;
            }
            else if (etcMessage[15] == false && SpaceshipManager.SScomplete[15] == true)
            {
                EtcMessageCommonFN();
                yield return StartCoroutine(GoMessage("조종판의 기능이 추가되었습니다."));
                yield return StartCoroutine(GoMessage("우주선의 기능이 추가됩니다. 모든 생산량이 10% 향상됩니"));
                yield return StartCoroutine(GoMessage("다."));
                yield return StartCoroutine(GoLine());
                etcMessage[15] = true;
            }
            else if (etcMessage[16] == false && SpaceshipManager.SScomplete[16] == true)
            {
                EtcMessageCommonFN();
                yield return StartCoroutine(GoMessage("고향으로 돌아가기 위한 모든 준비는 끝났습니다."));
                yield return StartCoroutine(GoMessage("이제 드디어 탈출이군요..."));

                Button_Click.interactable = false;
                Button_Robot.interactable = false;
                Button_Prod.interactable = false;
                Button_Tech.interactable = false;
                Button_Offer.interactable = false;
                Image img1 = ScR.GetComponent<Image>();
                Image img2 = Offer01.GetComponent<Image>();
                Image img3 = Offer02.GetComponent<Image>();
                Image img4 = Offer03.GetComponent<Image>();
                img1.color = new Color32(255, 255, 255, 1);
                img2.color = new Color32(255, 255, 255, 255);
                img1.raycastTarget = true;
                img2.raycastTarget = true;
                img3.raycastTarget = true;
                img4.raycastTarget = true;
                jokeButton.SetActive(false);

                yield return StartCoroutine(GoMessage("그동안 고생이 많았습니다."));
                yield return StartCoroutine(GoMessage("이제 우리는 이 행성을 떠나 고향으로 돌아갈 수 있습니다."));
                yield return StartCoroutine(GoMessage("사람들은 많이 발전했지만, 우리를 막을 수는 없을 겁니다."));
                yield return StartCoroutine(GoMessage("출발합시다."));
                yield return StartCoroutine(GoMessage("..."));
                yield return StartCoroutine(GoMessage("..."));
                yield return StartCoroutine(GoLine());
                etcMessage[16] = true;
            }
            else if (etcMessage[16] == false && SpaceshipManager.SScomplete[16] == true)
            {

            }

            yield return new WaitForSeconds(1f);
            goetcmsg = false;
        }
    }

    void TechMessageCommonFN()
    {
        gomsg = true;
        gotechmsg = true;
        Noti_o.color = new Color32(255, 255, 255, 255);
    }

    void EtcMessageCommonFN()
    {
        gomsg = true;
        goetcmsg = true;
        Noti_o.color = new Color32(255, 255, 255, 255);
    }

    IEnumerator GoMessage(string MSG)
    {
        while(true)
        {
            if (gomsg == true)
            {
                break;
            }
            yield return new WaitForSeconds(0.1f);
        }
        MSGtext = MSG;
        for (int i = 18; i == 0; i--)
        {
            SaveText[i + 1] = SaveText[i]; 
        }
        SaveText[0] = MSG;
        Instantiate(prefabMessage).transform.SetParent(par.transform, false);

        gomsg = false;
        yield break;
    }

    

    IEnumerator GoLine()
    {
        while (true)
        {
            if (gomsg == true)
            {
                break;
            }
            yield return new WaitForSeconds(0.1f);
        }
        
        Instantiate(prefabLine).transform.SetParent(par.transform, false);
        
        gomsg = false;
        yield break;
    }

    IEnumerator Tuto(bool T)
    {
        while (true)
        {
            if (T == true)
            {
                break;
            }
            yield return new WaitForSeconds(0.1f);
        }
        yield break;
    }

    IEnumerator GoPush(string a)
    {
        tipText.text = a;
        int n = 0;
        Image TipImg = Tip.GetComponent<Image>();
        Text text = tipText.GetComponent<Text>();

        while (true)
        {
            if (n == 100)
            {
                break;
            }
            TipImg.color = new Color(TipImg.color.r, TipImg.color.g, TipImg.color.b, TipImg.color.a + 0.01f);
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a + 0.01f);

            yield return new WaitForSeconds(0.01f);
            n++;
        }

        yield return new WaitForSeconds(0.2f);
        n = 0;
        yield return new WaitForSeconds(0.2f);

        while (true)
        {
            if (n == 100)
            {
                break;
            }
            TipImg.color = new Color(TipImg.color.r, TipImg.color.g, TipImg.color.b, TipImg.color.a - 0.01f);
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a - 0.01f);

            yield return new WaitForSeconds(0.01f);
            n++;
        }
        gomsg = true;

        yield break;
    }

    public void JokeButton()
    {
        if (gojokemsg == false && gotechmsg == false && goetcmsg == false)
        {
            StartCoroutine(JokeManager());
        }
    }

    IEnumerator JokeManager()
    {
        gojokemsg = true;
        int i = Random.Range(0, 17);
        int j;
        int k = 5;
        bool maxJOKE;
        for (j = 0;; j++)
        {
            maxJOKE = string.IsNullOrEmpty(JokeMessage[i, j]);
            if (maxJOKE == true)
            {
                k = j;
                break;
            }
        }
        for (j = 0; j < k; j++)
        {
            StartCoroutine(GoJoke(JokeMessage[i, j]));
            yield return new WaitForSeconds(1f);
        }
        Instantiate(prefabLine).transform.SetParent(par.transform, false);
        gojokemsg = false;

        yield break;
    }

    IEnumerator GoJoke(string MSG)
    {
        while(true)
        {
            if(gojokemsg2 == false)
            {
                break;
            }
            yield return new WaitForSeconds(0.1f);
        }

        JOKEtext = MSG;

        Instantiate(prefabJoke).transform.SetParent(par.transform, false);
        Scrollbar scrbar = ScrBar.GetComponent<Scrollbar>();
        scrbar.value = 0;

        yield break;
    }

    void OfflineIncomeFnc()
    {
        if ((SpaceshipManager.SScomplete[1] == true) || (SpaceshipManager.SScomplete[2] == true) || (ProductManager.Prod_S01_Level > 0)) // 오프라인 수입 관련
        {
            currentTime = System.DateTime.Now; // 오프라인 수입 관련
            timeDif = currentTime - startTime;
            int TimeDif = (int)timeDif.TotalSeconds;
            long incomeGold = 0;
            long incomeScience = 0;
            long addGold = (long)(ProductManager.autoMoney * GameManager.FinalGoldBonus * 0.05 / GameManager.AdBonus);
            long addScience = (long)(ProductManager.autoScience * GameManager.FinalScienceBonus * 0.05 );
            int Seconds = 0;
            if (ProductManager.Prod_S01_Level > 0)
            {
                Seconds = 10801;
            }
            else if (SpaceshipManager.SScomplete[2] == true)
            {
                Seconds = 7201;
            }
            else if (SpaceshipManager.SScomplete[1] == true)
            {
                Seconds = 3601;
            }

            for (int i = 1; i < Seconds; i++)
            {
                if (GameManager.money >= 9000000000000000000)
                {
                    break;
                }

                if ((i + 1) >= TimeDif)
                {
                    break;
                }

                GameManager.money += addGold;
                incomeGold += addGold;
            }

            for (int i = 1; i < Seconds; i++)
            {
                if (GameManager.science >= 9000000000000000000)
                {
                    break;
                }

                if ((i + 1) >= TimeDif)
                {
                    break;
                }

                GameManager.science += addScience;
                incomeScience += addScience;
            }
            
            if ((incomeGold != 0) || (incomeScience != 0))
            {
                IncomeGold.text = UnitTransform(incomeGold) + " 획득";
                IncomeScience.text = UnitTransform(incomeScience) + " 획득";
                if(incomeGold == 0)
                {
                    IncomeGold.text = "0 획득";
                }
                if (incomeScience == 0)
                {
                    IncomeScience.text = "0 획득";
                }
                Panel_OfflineIncome.SetActive(true);
            }
        }
    }

    IEnumerator StartTime()
    {
        yield return new WaitForSeconds(2.0f);
        while (true)
        {
            startTime = System.DateTime.Now;
            yield return new WaitForSeconds(1.0f);
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
}