using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip[] BGM = new AudioClip[9];
    AudioSource BGM_audioSource;

    public AudioSource EffectSource;
    public AudioClip ClickButton_effectSound; // 클릭(느낌표) 버튼 효과음
    public AudioClip TechProdButton_effectSound;  // 연구 및 제품 탭 버튼 효과음
    public AudioClip Setting_effectSound; // 설정창 버튼 효과음
    public AudioClip RobotUp_effectSound; // 로봇 업그레이드 버튼 효과음
    public AudioClip OfferChat_effectSound; // 제안탭 글자 출력 효과음
    public AudioClip TechComplete_effectSound; // 연구완료 버튼 효과음
    public AudioClip ProdBuy_effectSound; // 제품구입 버튼 효과음

    void Awake()
    {
        BGM_audioSource = this.GetComponent<AudioSource>();
    }

    void Start()
    {
        StartCoroutine(PlayBGM());
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

    public void Play_ClickButtonEffectSound() // 클릭(느낌표) 버튼 효과음
    {
        EffectSource.PlayOneShot(ClickButton_effectSound);
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
}
