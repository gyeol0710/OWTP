using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SoundManager : MonoBehaviour
{
    public AudioClip[] BGM = new AudioClip[9];
    AudioSource BGM_audioSource;

    public AudioSource EffectSource;
    static public AudioSource sEffectSource;
    public AudioClip ClickButton_effectSound; // 클릭(느낌표) 버튼 효과음
    public AudioClip TechProdButton_effectSound;  // 연구 및 제품 탭 버튼 효과음
    public AudioClip Setting_effectSound; // 설정창 버튼 효과음
    public AudioClip RobotUp_effectSound; // 로봇 업그레이드 버튼 효과음
    public AudioClip OfferChat_effectSound; // 제안탭 글자 출력 효과음
    public AudioClip TechComplete_effectSound; // 연구완료 버튼 효과음
    public AudioClip ProdBuy_effectSound; // 제품구입 버튼 효과음
    public AudioClip ClickButton_BombEffect; // 클릭 폭탄 효과음
    public AudioClip Age_effectSound;
    static public AudioClip sAge_effectSound;
    public AudioClip SpaceshipUp_effectSound;
    static public AudioClip sSpaceshipUp_effectSound;
    public AudioClip Hacking_effectSound;
    static public AudioClip sHacking_effectSound;


    public AudioSource TextEffect;
    public AudioSource JokeEffect;
    public AudioSource FrogEffect;

    public Slider BGM_meter;
    public Slider SFX_meter;

    static public float BGM_Meter;
    static public float SFX_Meter;

    void Awake()
    {
        BGM_audioSource = this.GetComponent<AudioSource>();
        sEffectSource = EffectSource;
        sAge_effectSound = Age_effectSound;
        sSpaceshipUp_effectSound = SpaceshipUp_effectSound;
        sHacking_effectSound = Hacking_effectSound;
    }

    void Start()
    {
        if (GameManager.RePlay == true)
        {
            BGM_meter.value = BGM_Meter;
            SFX_meter.value = SFX_Meter;
        }
        StartCoroutine(PlayBGM());
        StartCoroutine(Volume_BGM());
        StartCoroutine(Volume_SFX());
    }

    void Update()
    {
        
    }

    IEnumerator PlayBGM()
    {
        while(true)
        {
            if (!BGM_audioSource.isPlaying)
            {
                BGM_audioSource.clip = BGM[Random.Range(0, BGM.Length)];
                BGM_audioSource.Play();
            }
                
            yield return new WaitForSeconds(1.0f);
        }
    }

    IEnumerator Volume_BGM()
    {
        while(true)
        {
            BGM_audioSource.volume = BGM_meter.value;
            BGM_Meter = BGM_meter.value;
            yield return new WaitForSeconds(0.3f);
        }
    }

    IEnumerator Volume_SFX()
    {
        while (true)
        {
            TextEffect.volume = SFX_meter.value;
            JokeEffect.volume = SFX_meter.value;
            FrogEffect.volume = SFX_meter.value;
            EffectSource.volume = SFX_meter.value;
            SFX_Meter = SFX_meter.value;
            yield return new WaitForSeconds(0.3f);
        }
    }

    public void Play_ClickButtonEffectSound() // 클릭(느낌표) 버튼 효과음
    {
        if (GameManager.eventOn == true && GameManager.Story_Fuel2_Complete == false && MessageManager.etcMessage[6] == true)
        {
            EffectSource.PlayOneShot(ClickButton_BombEffect);
        }
        else
        {
            EffectSource.PlayOneShot(ClickButton_effectSound);
        }
    }

    public void Play_TechProdButtonEffectSound() // 연구 및 제품 탭 버튼 효과음
    {
        EffectSource.PlayOneShot(TechProdButton_effectSound);
    }

    public void Play_SettingEffectSound() // 설정창 버튼 효과음
    {
        EffectSource.PlayOneShot(Setting_effectSound);
    }

    public void Play_RobotUpEffectSound() // 로봇 업그레이드 버튼 효과음
    {
        EffectSource.PlayOneShot(RobotUp_effectSound);
    }

    public void Play_OfferChatEffectSound() // 제안탭 글자 출력 효과음
    {
        EffectSource.PlayOneShot(OfferChat_effectSound);
    }

    public void Play_TechCompleteEffectSound() // 연구완료 버튼 효과음
    {
        EffectSource.PlayOneShot(TechComplete_effectSound);
    }

    public void Play_ProdBuyEffectSound() // 제품구입 버튼 효과음
    {
        EffectSource.PlayOneShot(ProdBuy_effectSound);
    }

    static public void Play_AgeEffect() // static 시대 변화 효과음
    {
        sEffectSource.PlayOneShot(sAge_effectSound);
    }

    static public void Play_SpaceshipEffect() // static 우주선 업그레이드 효과음
    {
        sEffectSource.PlayOneShot(sSpaceshipUp_effectSound);
    }

    static public void Play_HackingEffect() // static 해킹 효과음
    {
        sEffectSource.PlayOneShot(sHacking_effectSound);
    }
}
