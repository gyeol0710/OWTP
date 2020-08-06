using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

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
    static public bool gojokemsg2;

    bool message01c;

    public GameObject TechMainPanel;
    public GameObject TechIcon_1;
    public GameObject Noti_R;
    public GameObject Noti_P;
    public GameObject Noti_T;
    public GameObject Noti_O;

    bool[] techMessage = new bool[71];
    bool ageMessage_WAR;
    bool ageMessage_ELEC;
    bool ageMessage_MODERN;

    string[,] JokeMessage = new string[17,5];

    void Start()
    {
        ScrBar = scrBar.GetComponent<Scrollbar>();
        StartCoroutine(Message1());
        StartCoroutine(Message2());
        StartCoroutine(TechMessage());
        
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
            yield return StartCoroutine(GoMessage("언어설정완료."));
            yield return StartCoroutine(GoMessage("지역스캔완료."));
            yield return StartCoroutine(GoMessage("환경성 검토 완료"));
            yield return StartCoroutine(GoMessage("정신차리세요."));
            yield return StartCoroutine(GoMessage("일단 우주선에 남은 연료가 적어서 불시착했습니다."));
            yield return StartCoroutine(GoLine());
        }
        TutorialManager.T01c = true;

        yield return new WaitForSeconds(2.0f);

        yield return StartCoroutine(Tuto(TutorialManager.T02));

        if (TutorialManager.T02c == false) // 대화창 2
        {
            gomsg = true;
            yield return StartCoroutine(GoMessage("흥미로운 별입니다."));
            yield return StartCoroutine(GoMessage("1000만종 가까운 생물들이 존재합니다."));
            yield return StartCoroutine(GoMessage("그 중에서도 사람이라는 생물의 면적이 가장 넓군요."));
            yield return StartCoroutine(GoMessage("게다가 우주에서 도착한 많은 존재들이 거주중입니다."));
            yield return StartCoroutine(GoMessage("일단 모을 수 있는 에너지를 찾아봅시다."));
            yield return StartCoroutine(GoLine());
        }
        TutorialManager.T02c = true;

        yield return new WaitForSeconds(2.0f);

        yield return StartCoroutine(Tuto(TutorialManager.T03));

        if (TutorialManager.T03c == false) // 대화창 3
        {
            gomsg = true;
            yield return StartCoroutine(GoMessage("좋아요."));
            yield return StartCoroutine(GoMessage("우주선에 필요한 모든 부품을"));
            yield return StartCoroutine(GoMessage("우리가 캘 순 없으니 사람들이 이 행성에 있는"));
            yield return StartCoroutine(GoMessage("모든 요소들을 발견하게 만들면 되겠어요."));
            yield return StartCoroutine(GoMessage("자금을 만들어봅시다."));
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
            yield return null;
        }

        yield return new WaitForSeconds(0.1f); // 튜토리얼매니저 충돌방지

        yield return StartCoroutine(Tuto(TutorialManager.T04));

        if (TutorialManager.T04c == false) // 대화창 4
        {
            gomsg = true;
            yield return StartCoroutine(GoMessage("좋아요,"));
            yield return StartCoroutine(GoMessage("기존에 있던 부품들로"));
            yield return StartCoroutine(GoMessage("직원들을 좀 만들어 봅시다."));
            yield return StartCoroutine(GoLine());
            Noti_R.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        }
        TutorialManager.T04c = true;

        yield return new WaitForSeconds(2.0f);

        while (true)
        {
            if (GameManager.robotLevel > 0)
            {
                break;
            }
            yield return null;
        }

        yield return new WaitForSeconds(0.1f); // 튜토리얼매니저 충돌방지

        yield return StartCoroutine(Tuto(TutorialManager.P01));

        if (TutorialManager.P01c == false) // 푸시 1 [조건 : 로봇레벨 1 이상]
        {
            gomsg = true;
            yield return StartCoroutine(GoPush("직원들이 늘어날수록 연구력을 얻을 확률이 높아집니다."));
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
            yield return null;
        }

        yield return new WaitForSeconds(0.1f); // 튜토리얼매니저 충돌방지

        yield return StartCoroutine(Tuto(TutorialManager.T05));

        if (TutorialManager.T05c == false) // 대화창 5 [조건 : 로봇레벨 5 이상]
        {
            gomsg = true;
            Noti_O.GetComponent<Image>().color = new Color(255, 255, 255, 255);
            yield return StartCoroutine(GoMessage("좋아요."));
            yield return StartCoroutine(GoMessage("점점 숫자가 늘어가는 걸 보니 예감이 좋습니다."));
            yield return StartCoroutine(GoMessage("연구력을 더 모아 기술을 발전시켜봅시다!"));
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
            yield return null;
        }

        yield return new WaitForSeconds(0.1f); // 튜토리얼매니저 충돌방지

        yield return StartCoroutine(Tuto(TutorialManager.P02));

        if (TutorialManager.P02c == false) // 푸시 2 [조건 : 증기기관 연구를 위한 연구력 충족]
        {
            gomsg = true;
            yield return StartCoroutine(GoPush("자 이제 연구를 시작해봅시다."));
            yield return StartCoroutine(GoPush("연구 아이콘을 클릭해보세요."));
            Noti_T.GetComponent<Image>().color = new Color(255, 255, 255, 255);
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
        if(message01c == false)
        {
            yield break;
        }

        yield return StartCoroutine(Tuto(TutorialManager.T06));

        if (TutorialManager.T06c == false) // 대화창 6
        {
            gomsg = true;
            Noti_O.GetComponent<Image>().color = new Color(255, 255, 255, 255);
            yield return StartCoroutine(GoMessage("좋아요."));
            yield return StartCoroutine(GoMessage("지금까지 우주선에 모인 연구력을 가지고 연구를 완료했어요."));
            yield return StartCoroutine(GoMessage("이제 이걸 사람한테 주입하면 되겠네요.ᜈ"));
            yield return StartCoroutine(GoMessage("세상과 인연이 없는 사람을 하나 구해왔어요."));
            yield return StartCoroutine(GoMessage("어릴 적 기억과 주변 환경을 조작하는 중입니다..."));
            yield return StartCoroutine(GoMessage("주입중......"));
            yield return StartCoroutine(GoLine());
        }
        TutorialManager.T06c = true;

        yield return new WaitForSeconds(5.0f);

        yield return StartCoroutine(Tuto(TutorialManager.T07));

        if (TutorialManager.T07c == false) // 대화창 6
        {
            gomsg = true;
            Noti_O.GetComponent<Image>().color = new Color(255, 255, 255, 255);
            yield return StartCoroutine(GoMessage("자! 네 이름은 뉴커멘이란다."));
            yield return StartCoroutine(GoMessage("어린시절 생각과 증기기관을 완전하게 조작해 두었으니 걱정마세요."));
            yield return StartCoroutine(GoMessage("조만간 세상에 증기기관을 전파 할 것입니다."));
            yield return StartCoroutine(GoLine());
        }
        TutorialManager.T07c = true;

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
                yield return StartCoroutine(GoMessage("비효율적이긴 하지만 일단 이 에너지를 써야겠어요."));
                yield return StartCoroutine(GoMessage("배를 통해서 영향력을 넓혀봅시다."));
                yield return StartCoroutine(GoLine());
                techMessage[2] = true;
            }
            if (techMessage[3] == false && TechManager.Tech3Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("이 행성에서 살아남기 위해서는 옷, 음식, 살곳이 필요하네요."));
                yield return StartCoroutine(GoMessage("우리가 하나를 도와줄 수 있겠어요."));
                yield return StartCoroutine(GoLine());
                techMessage[3] = true;
            }
            if (techMessage[4] == false && TechManager.Tech4Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("\"누에의 실을 짜는 사람이 비단 옷을 입는 사람은 아니다\""));
                yield return StartCoroutine(GoMessage("열심히 일한 사람이 아니라 부자가 옷을 입는다는 말이래요."));
                yield return StartCoroutine(GoMessage("하지만 실은 누에가 짜지만 누에가 입지는 않잖아요.. ?"));
                yield return StartCoroutine(GoLine());
                techMessage[4] = true;
            }
            if (techMessage[5] == false && TechManager.Tech5Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("이제 더 가속이 붙겠군요"));
                yield return StartCoroutine(GoMessage("더 많은 자원을 소모합시다."));
                yield return StartCoroutine(GoLine());
                techMessage[5] = true;
            }
            if (techMessage[6] == false && TechManager.Tech6Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("재밌는 사실을 발견했습니다"));
                yield return StartCoroutine(GoMessage("사람들이 옷에 구멍을 뚫고 입기도 합니다"));
                yield return StartCoroutine(GoMessage("그들 말로는 '유행'과 '패션' 이라고합니다!"));
                yield return StartCoroutine(GoMessage("기술이 발전해서 옷의 빈틈이 더 적어지는건 아니네요!"));
                yield return StartCoroutine(GoMessage("저도 구멍을 좀 뚫어볼까봐요"));
                yield return StartCoroutine(GoLine());
                techMessage[6] = true;
            }
            if (techMessage[7] == false && TechManager.Tech7Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("신기합니다"));
                yield return StartCoroutine(GoMessage("우리가 발명하면 다른 방향으로도 응용이 됩니다"));
                yield return StartCoroutine(GoMessage("인간들의 지능이 높네요."));
                yield return StartCoroutine(GoMessage("언젠가 우리를 인식하는 날이 올지도 모르겠어요."));
                yield return StartCoroutine(GoLine());
                techMessage[7] = true;
            }
            if (techMessage[8] == false && TechManager.Tech8Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("우리 몸에는 전류가 흐르고 있습니다"));
                yield return StartCoroutine(GoMessage("네 '우리'몸이요."));
                yield return StartCoroutine(GoMessage("저만 흐르는게 아니라구요"));
                yield return StartCoroutine(GoLine());
                techMessage[8] = true;
            }
            if (techMessage[9] == false && TechManager.Tech9Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("방향을 정했습니다."));
                yield return StartCoroutine(GoMessage("지구에서는 전기를 공급하기 가장 적합한 환경입니다."));
                yield return StartCoroutine(GoMessage("더 연구력을 쌓으면 모르겠지만요"));
                yield return StartCoroutine(GoLine());
                techMessage[9] = true;
            }
            if (techMessage[10] == false && TechManager.Tech10Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("지구를 조금 더 덥게 만듭시다."));
                yield return StartCoroutine(GoMessage("인간의 건강이요?"));
                yield return StartCoroutine(GoMessage("건강을 보존하는 다른 연구를 또 하면 됩니다"));
                yield return StartCoroutine(GoLine());
                techMessage[10] = true;
            }
            if (techMessage[11] == false && TechManager.Tech11Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("좋아요"));
                yield return StartCoroutine(GoMessage("단단한 물질들이 생성되고 있어요."));
                yield return StartCoroutine(GoMessage("인간들은 주변에 단단한 물질이 많아도 크게 겁먹지 않아요."));
                yield return StartCoroutine(GoLine());
                techMessage[11] = true;
            }
            if (techMessage[12] == false && TechManager.Tech12Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("더 높은 에너지! 더 빠른 발전!"));
                yield return StartCoroutine(GoLine());
                techMessage[12] = true;
            }
            if (techMessage[13] == false && TechManager.Tech13Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("전기와 자기는 연관되어 있답니다!"));
                yield return StartCoroutine(GoMessage("조금만 더 생각해보면 알텐데요."));
                yield return StartCoroutine(GoMessage("요즘은 인간의 진화를 보는 것을 취미로 삼고 있어요."));
                yield return StartCoroutine(GoMessage("꽤 대단합니다"));
                yield return StartCoroutine(GoLine());
                techMessage[13] = true;
            }
            if (techMessage[14] == false && TechManager.Tech14Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("에너지에 대해 조금 더 효율적으로 생각합시다"));
                yield return StartCoroutine(GoLine());
                techMessage[14] = true;
            }
            if (techMessage[15] == false && TechManager.Tech15Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("좋아요!"));
                yield return StartCoroutine(GoMessage("이건 대단한 발전입니다"));
                yield return StartCoroutine(GoMessage("종이컵을 실로 연결한 이후 바로 다음 단계라구요!"));
                yield return StartCoroutine(GoLine());
                techMessage[15] = true;
            }
            if (techMessage[16] == false && TechManager.Tech16Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("모든 물질은 다양한 힘에 간섭을 받게 되어있어요"));
                yield return StartCoroutine(GoMessage("제가 말이 많다고 해서 너무 귀찮게 여기지 마십시오"));
                yield return StartCoroutine(GoLine());
                techMessage[16] = true;
            }
            if (techMessage[17] == false && TechManager.Tech17Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("좋아요."));
                yield return StartCoroutine(GoMessage("인간들은 자신보다 강한 걸 옆에 두어도 무서워하지 않으니까"));
                yield return StartCoroutine(GoMessage("이걸 광산에만 쓴다고 저도 믿어도 되겠죠?"));
                yield return StartCoroutine(GoLine());
                techMessage[17] = true;
            }
            if (techMessage[18] == false && TechManager.Tech18Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("인간이 느낄 수 있는 다른 감각을 시각으로 옮겼습니다."));
                yield return StartCoroutine(GoMessage("눈으로 보는 것은 믿을 수 있죠?"));
                yield return StartCoroutine(GoMessage("아직 우리를 볼 순 없겠군요"));
                yield return StartCoroutine(GoLine());
                techMessage[18] = true;
            }
            if (techMessage[19] == false && TechManager.Tech19Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("다음 시대로 넘어 갈 준비를 합시다. "));
                yield return StartCoroutine(GoLine());
                techMessage[19] = true;
            }
            if (techMessage[20] == false && TechManager.Tech20Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("와 필라멘트 타이어 보다 싸다!"));
                yield return StartCoroutine(GoLine());
                techMessage[20] = true;
            }
            if (techMessage[21] == false && TechManager.Tech21Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("세상을 연결하는 더 많은 끈을 준비합시다"));
                yield return StartCoroutine(GoMessage("눈에 보이지 않는다고 해서 없는 건 아닙니다. "));
                yield return StartCoroutine(GoMessage("바로 우리처럼요."));
                yield return StartCoroutine(GoLine());
                techMessage[21] = true;
            }
            if (techMessage[22] == false && TechManager.Tech22Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("이건 좀 불안하네요"));
                yield return StartCoroutine(GoMessage("우리가 차지하고 있는 공간을 인간에게 나눠주는 거잖아요."));
                yield return StartCoroutine(GoMessage("그래도 뭐 빨리 떠나려면, 최대한 많은 자원을 활용해야겠죠?"));
                yield return StartCoroutine(GoLine());
                techMessage[22] = true;
            }
            if (ageMessage_WAR == false && TechManager.age_war) // 전쟁시대 돌입
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("상황이 좋지않습니다."));
                yield return StartCoroutine(GoMessage("많은 지역에서 무차별적인 싸움이 일어나고 있습니다."));
                yield return StartCoroutine(GoMessage("우리도 대비를 할 필요가 있겠네요. "));
                yield return StartCoroutine(GoMessage("오히려 더 많은 제품을 팔수도 있지 않을까요?"));
                yield return StartCoroutine(GoLine());
                ageMessage_WAR = true;
            }
            if (techMessage[23] == false && TechManager.Tech23Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("이것이 우리를 지켜줄 것입니다."));
                yield return StartCoroutine(GoLine());
                techMessage[23] = true;
            }
            if (techMessage[24] == false && TechManager.Tech24Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("드디어 이걸 연구할 수 있었네요."));
                yield return StartCoroutine(GoMessage("제가 생각하는 세상에서 가장 아름다운 상태입니다."));
                yield return StartCoroutine(GoLine());
                techMessage[24] = true;
            }
            if (techMessage[25] == false && TechManager.Tech25Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("생각을 더 정밀하게 오래도록 보관할 수 있습니다."));
                yield return StartCoroutine(GoMessage("복잡한 생각을 공유하는 시간이 축소되겠군요"));
                yield return StartCoroutine(GoLine());
                techMessage[25] = true;
            }
            if (techMessage[26] == false && TechManager.Tech26Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("열을 내는 건 쉽지만 열을 내리는 건 쉽지않습니다."));
                yield return StartCoroutine(GoMessage("이건 저한테 필요한 발명이군요!"));
                yield return StartCoroutine(GoLine());
                techMessage[26] = true;
            }
            if (techMessage[27] == false && TechManager.Tech27Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("볼 수 없는 걸 또 한번 증명해냈습니다."));
                yield return StartCoroutine(GoMessage("이러다가 인간들이 이야기하는 신까지 증명해낼 수 있겠어요."));
                yield return StartCoroutine(GoLine());
                techMessage[27] = true;
            }
            if (techMessage[28] == false && TechManager.Tech28Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("더 강한 무기를 만들면 인간들의 싸움이 줄어들지 않을까요"));
                yield return StartCoroutine(GoMessage("잔인한 모습을 보다보면 경각심을 가질지도 모르잖아요."));
                yield return StartCoroutine(GoMessage("현재 우리 프로젝트를 지킬 도구가 필요하기도 하다구요."));
                yield return StartCoroutine(GoLine());
                techMessage[28] = true;
            }
            if (techMessage[29] == false && TechManager.Tech29Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("더 빠른 속도, 더 강한 추진력."));
                yield return StartCoroutine(GoLine());
                techMessage[29] = true;
            }
            if (techMessage[30] == false && TechManager.Tech30Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("더 막아야 합니다."));
                yield return StartCoroutine(GoMessage("우리 기지를 지키기 위해서는 더 많은 걸 발명할수 있어요."));
                yield return StartCoroutine(GoLine());
                techMessage[30] = true;
            }
            if (techMessage[31] == false && TechManager.Tech31Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("보안 체계를 강화했습니다."));
                yield return StartCoroutine(GoMessage("세계가 좀 더 복잡해지고 있군요."));
                yield return StartCoroutine(GoMessage("우리의 생각도 좀 더 복잡해질 것입니다."));
                yield return StartCoroutine(GoLine());
                techMessage[31] = true;
            }
            if (techMessage[32] == false && TechManager.Tech32Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("싸움을 더 빠르게 끝내야 합니다."));
                yield return StartCoroutine(GoMessage("이대로 가다간 끝도 없이 싸울지도 모릅니다."));
                yield return StartCoroutine(GoLine());
                techMessage[32] = true;
            }
            if (techMessage[33] == false && TechManager.Tech33Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("우리는 강한 냉각기술을 만들어 냈습니다."));
                yield return StartCoroutine(GoMessage("모든걸 얼릴 수 있어요. 심지어 인간마저도요."));
                yield return StartCoroutine(GoLine());
                techMessage[33] = true;
            }
            if (techMessage[34] == false && TechManager.Tech34Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("우리는 신이 아닙니다."));
                yield return StartCoroutine(GoMessage("살릴 사람과 죽일 사람을 결정할 수 없어요."));
                yield return StartCoroutine(GoMessage("그러나 조금 낫게 해줄 수는 있죠"));
                yield return StartCoroutine(GoLine());
                techMessage[34] = true;
            }
            if (techMessage[35] == false && TechManager.Tech35Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("더 좋은 기술 아래서 좋은 옷을 입을 수 있겠어요."));
                yield return StartCoroutine(GoMessage("강하고 질깁니다."));
                yield return StartCoroutine(GoLine());
                techMessage[35] = true;
            }
            if (techMessage[36] == false && TechManager.Tech36Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("세상을 더 빠르게 움직이게 할겁니다"));
                yield return StartCoroutine(GoMessage("이것만 있으면 인간의 머리카락도 더 빨리 마르게 할 수 있죠."));
                yield return StartCoroutine(GoLine());
                techMessage[36] = true;
            }
            if (techMessage[37] == false && TechManager.Tech37Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("마지막 경고입니다."));
                yield return StartCoroutine(GoMessage("인간이 다시 전쟁으로 위협한다면 공간을 원시시대로 돌려놓"));
                yield return StartCoroutine(GoMessage("을 수 있다는 걸 깨달아야 할겁니다"));
                yield return StartCoroutine(GoLine());
                techMessage[37] = true;
            }
            if (ageMessage_ELEC == false && TechManager.age_elec) // 전자시대 돌입
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("상황이 좋지않습니다."));
                yield return StartCoroutine(GoMessage("많은 지역에서 무차별적인 싸움이 일어나고 있습니다."));
                yield return StartCoroutine(GoMessage("우리도 대비를 할 필요가 있겠네요. "));
                yield return StartCoroutine(GoMessage("오히려 더 많은 제품을 팔수도 있지 않을까요?"));
                yield return StartCoroutine(GoLine());
                ageMessage_ELEC = true;
            }
            if (techMessage[38] == false && TechManager.Tech38Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("가상에 세계에도 색이 들어왔습니다."));
                yield return StartCoroutine(GoMessage("인간들은 더 열광하는군요."));
                yield return StartCoroutine(GoLine());
                techMessage[38] = true;
            }
            if (techMessage[39] == false && TechManager.Tech39Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("인간들은 우리가 만들 기술들을 가지고 더 많은 발전을 해나"));
                yield return StartCoroutine(GoMessage("가고 있습니다. 이러다 우리의 기술수준까지 따라올 수 있을"));
                yield return StartCoroutine(GoMessage("도 모르겠어요. 농담입니다."));
                yield return StartCoroutine(GoLine());
                techMessage[39] = true;
            }
            if (techMessage[40] == false && TechManager.Tech40Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("이제 전자시대의 시작입니다. 이 작은 것 안에 전부 들어있습"));
                yield return StartCoroutine(GoMessage("니다."));
                yield return StartCoroutine(GoLine());
                techMessage[40] = true;
            }
            if (techMessage[41] == false && TechManager.Tech41Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("많은 치료에 사용할 수 있습니다."));
                yield return StartCoroutine(GoMessage("재건활동에 힘쓰다 보면 본래대로 진행할 수 있을 것입니다."));
                yield return StartCoroutine(GoLine());
                techMessage[41] = true;
            }
            if (techMessage[42] == false && TechManager.Tech42Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("많은 곳을 치료할 수 있는 치료제입니다."));
                yield return StartCoroutine(GoMessage("인구수가 더 많아져야 속도도 더 빨라집니다."));
                yield return StartCoroutine(GoLine());
                techMessage[42] = true;
            }
            if (techMessage[43] == false && TechManager.Tech43Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("이제는 사람의 두뇌에 있는 생각을 가상의 공간에 저장가능합"));
                yield return StartCoroutine(GoMessage("니다."));
                yield return StartCoroutine(GoLine());
                techMessage[43] = true;
            }
            if (techMessage[44] == false && TechManager.Tech44Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("점점 더 많은 현실이 전자세계로 이식되고 있군요."));
                yield return StartCoroutine(GoLine());
                techMessage[44] = true;
            }
            if (techMessage[45] == false && TechManager.Tech45Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("불빛은 더 많은 암호를 암시합니다."));
                yield return StartCoroutine(GoMessage("밝은 불빛을 통해서 사람을 질서를 인식합니다."));
                yield return StartCoroutine(GoLine());
                techMessage[45] = true;
            }
            if (techMessage[46] == false && TechManager.Tech46Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("사회가 복잡해지면서 사람도 복잡해집니다."));
                yield return StartCoroutine(GoMessage("이 세상에 고장나지 않는 것은 없습니다. 완벽한 것도 없고요."));
                yield return StartCoroutine(GoLine());
                techMessage[46] = true;
            }
            if (techMessage[47] == false && TechManager.Tech47Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("완성되고 있습니다."));
                yield return StartCoroutine(GoMessage("이제 전자세계가 현실세계를 지배할 것입니다."));
                yield return StartCoroutine(GoLine());
                techMessage[47] = true;
            }
            if (techMessage[48] == false && TechManager.Tech48Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("사람 두뇌의 논리체계를 모사합니다."));
                yield return StartCoroutine(GoMessage("생각만큼 쉽지는 않아요."));
                yield return StartCoroutine(GoMessage("빠른 계산은 가능합니다."));
                yield return StartCoroutine(GoLine());
                techMessage[48] = true;
            }
            if (techMessage[49] == false && TechManager.Tech49Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("제 친구를 만들었어요!"));
                yield return StartCoroutine(GoMessage("조금 덜떨어진 친구지만 괜찮습니다"));
                yield return StartCoroutine(GoLine());
                techMessage[49] = true;
            }
            if (techMessage[50] == false && TechManager.Tech50Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("탈출하려면 이제는 준비를 해야합니다…"));
                yield return StartCoroutine(GoLine());
                techMessage[50] = true;
            }
            if (techMessage[51] == false && TechManager.Tech51Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("온도에 따라서 색이 변합니다."));
                yield return StartCoroutine(GoMessage("우리가 우주로 탈출할때는 지구를 복사해갈수도 있겠어요."));
                yield return StartCoroutine(GoLine());
                techMessage[51] = true;
            }
            if (techMessage[52] == false && TechManager.Tech52Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("제 생각을 여기서 연결할 수 있어요."));
                yield return StartCoroutine(GoMessage("그 말은 사람들이 올리는 생각을 제가 다 복사할 수 있다는 뜻"));
                yield return StartCoroutine(GoMessage("이죠"));
                yield return StartCoroutine(GoLine());
                techMessage[52] = true;
            }
            if (techMessage[53] == false && TechManager.Tech53Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("양성자를 완전히 이해하는 시점부터 우주는 변화합니다."));
                yield return StartCoroutine(GoMessage("있거나 없거나 아니면 두 상태 모두입니다."));
                yield return StartCoroutine(GoLine());
                techMessage[53] = true;
            }
            if (techMessage[54] == false && TechManager.Tech54Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("물리적인 거리는 이제 필요없습니다."));
                yield return StartCoroutine(GoMessage("사람들이 이야기하는 '영혼'이 이런거 아닐까요?"));
                yield return StartCoroutine(GoLine());
                techMessage[54] = true;
            }
            if (techMessage[55] == false && TechManager.Tech55Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("재밌네요 이거."));
                yield return StartCoroutine(GoMessage("사람들은 전자세상에 이미 많이 동화된 듯 합니다."));
                yield return StartCoroutine(GoLine());
                techMessage[55] = true;
            }
            if (ageMessage_MODERN == false && TechManager.age_modern) // 현대시대 돌입
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("지구에 정도 많이 들었습니다."));
                yield return StartCoroutine(GoMessage("막상 떠나려고 하니까 아쉽네요."));
                yield return StartCoroutine(GoLine());
                ageMessage_MODERN = true;
            }
            if (techMessage[56] == false && TechManager.Tech56Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("이제 인간들이 컴퓨터를 조절합니다."));
                yield return StartCoroutine(GoMessage("저를 조절할 순 없을걸요."));
                yield return StartCoroutine(GoLine());
                techMessage[56] = true;
            }
            if (techMessage[57] == false && TechManager.Tech57Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("조금 걱정되긴 하네요."));
                yield return StartCoroutine(GoMessage("이정도까지 진화할 필요가 있는걸까요?"));
                yield return StartCoroutine(GoLine());
                techMessage[57] = true;
            }
            if (techMessage[58] == false && TechManager.Tech58Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("복잡한 세상에서 사람들은 공유하기 시작합니다."));
                yield return StartCoroutine(GoMessage("이것으로 전자세상은 통제를 벗어났다고 봐도 무방합니다."));
                yield return StartCoroutine(GoLine());
                techMessage[58] = true;
            }
            if (techMessage[59] == false && TechManager.Tech59Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("통신위성으로 인해 우리는 이제 날아갈 준비를 합니다."));
                yield return StartCoroutine(GoMessage("사람들아 즐거웠습니다!"));
                yield return StartCoroutine(GoLine());
                techMessage[59] = true;
            }
            if (techMessage[60] == false && TechManager.Tech60Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("사람들은 호기심이 많아요."));
                yield return StartCoroutine(GoMessage("우리가 선을 넘고 있는 걸까요?"));
                yield return StartCoroutine(GoLine());
                techMessage[60] = true;
            }
            if (techMessage[61] == false && TechManager.Tech61Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("전자세계를 벗어날 수 있는 사람은 없습니다."));
                yield return StartCoroutine(GoMessage("본인의 모든 행동이 여기에 기록될 것입니다."));
                yield return StartCoroutine(GoLine());
                techMessage[61] = true;
            }
            if (techMessage[62] == false && TechManager.Tech62Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("더 많은 인구수를 향하여…"));
                yield return StartCoroutine(GoMessage("모든건 우리 통제하에 있어요. 맞죠?"));
                yield return StartCoroutine(GoLine());
                techMessage[62] = true;
            }
            if (techMessage[63] == false && TechManager.Tech63Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("성능을 높였습니다."));
                yield return StartCoroutine(GoMessage("이미 많은 사람들이 데이터조각을 자신의 현실보다 중요하게"));
                yield return StartCoroutine(GoMessage("여깁니다."));
                yield return StartCoroutine(GoLine());
                techMessage[63] = true;
            }
            if (techMessage[64] == false && TechManager.Tech64Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("이제 우리가 발명하는 기술은 특별하지 않습니다."));
                yield return StartCoroutine(GoMessage("사람들의 속도는 우리가 생각한 것보다 빨라요."));
                yield return StartCoroutine(GoMessage("이제는 정말 탈출해야 할때입니다."));
                yield return StartCoroutine(GoLine());
                techMessage[64] = true;
            }
            if (techMessage[65] == false && TechManager.Tech65Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("우리가 사람들을 여기까지 이끌었지만 사람들도 우리를 만들"));
                yield return StartCoroutine(GoMessage("고 있습니다. 앞으로는 어찌될까요?"));
                yield return StartCoroutine(GoLine());
                techMessage[65] = true;
            }
            if (techMessage[66] == false && TechManager.Tech66Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("이 속도를 막을 순 없습니다."));
                yield return StartCoroutine(GoMessage("우리는 더 빨리 나아갑니다."));
                yield return StartCoroutine(GoLine());
                techMessage[66] = true;
            }
            if (techMessage[67] == false && TechManager.Tech67Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("대단한 기술은 아닙니다."));
                yield return StartCoroutine(GoMessage("우리는 할만큼 했으니 이제 사람들의 손에 맡겨도 되겠지요."));
                yield return StartCoroutine(GoLine());
                techMessage[67] = true;
            }
            if (techMessage[68] == false && TechManager.Tech68Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("사람들이 자꾸 우리의 서버에 유입됩니다."));
                yield return StartCoroutine(GoMessage("이건 예상에 없던 일입니다."));
                yield return StartCoroutine(GoMessage("왜 자꾸 우리의 서버망에서 음란물을 올리는거죠?"));
                yield return StartCoroutine(GoLine());
                techMessage[68] = true;
            }
            if (techMessage[69] == false && TechManager.Tech69Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("우리는 탈출해야합니다."));
                yield return StartCoroutine(GoMessage("인간들은 자신의 몸을 개조하고 있습니다."));
                yield return StartCoroutine(GoMessage("그리고 우리의 존재도 알아차린 것 같습니다."));
                yield return StartCoroutine(GoMessage("마지막 연구를 진행할 때가 되었습니다."));
                yield return StartCoroutine(GoLine());
                techMessage[69] = true;
            }
            if (techMessage[70] == false && TechManager.Tech70Complete)
            {
                TechMessageCommonFN();
                yield return StartCoroutine(GoMessage("우리는 여기에 볼 일 없습니다."));
                yield return StartCoroutine(GoMessage("우리는 떠나야만 합니다."));
                yield return StartCoroutine(GoLine());
                techMessage[70] = true;
            }

            yield return new WaitForSeconds(1f);
            gotechmsg = false;
        }
    }

    void TechMessageCommonFN()
    {
        gomsg = true;
        gotechmsg = true;
        Noti_O.GetComponent<Image>().color = new Color(255, 255, 255, 255);
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
        for(int i = 18; i == 0; i--)
        {
            SaveText[i + 1] = SaveText[i]; 
        }
        SaveText[0] = MSG;
        Instantiate(prefabMessage).transform.SetParent(par.transform, false);
        Scrollbar scrbar = ScrBar.GetComponent<Scrollbar>();
        scrbar.value = 0;

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
        if (gojokemsg == false && gotechmsg == false)
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
}