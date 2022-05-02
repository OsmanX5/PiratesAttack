using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using TMPro;
public class LaserGeneration : MonoBehaviour
{
    public GameObject Lazer;
    public Transform shootingpoint;
    public Animator LazerGunAnim;
    public AudioClip shootingSound;
    public AudioSource GunAudio;
    int lazerButton = 0;
    int scaleButton = 0;
    bool isShooted = false;
    public Volume postProccessVolume;
    public TMP_Text frazeText;
    WhiteBalance wb = null;
    float timer = 0f;
    public static float FrizeTimer = 3f;
    bool inFrezeMode = false;
    private void Awake()
    {
        postProccessVolume.profile.TryGet<WhiteBalance>(out wb);
    }
    // Update is called once per frame
    void Update()
    {
        lazerButton = (int)ButtonsRead.Rtrigger.action.ReadValue<float>();
        scaleButton = (int)ButtonsRead.Lgrip.action.ReadValue<float>();
        timer += Time.deltaTime;
        
        if (lazerButton == 0) isShooted = false;
        if (lazerButton == 1) LazerShoot();
        if (scaleButton==1 && FrizeTimer>0)
        {
            FrizeTimer -= Time.deltaTime *5;
            Time.timeScale = 0.2f;
            wb.active = true;
            wb.temperature.value = -100;
            frazeText.text = "Time Fraze";
        }
        if (scaleButton==0 || FrizeTimer<0)
        {
            FrizeTimer += Time.deltaTime;
            Time.timeScale = 1f;
            wb.temperature.value =0;
            frazeText.text = "";
        }
        if (FrizeTimer > 3) FrizeTimer = 3f;
    }

    void LazerShoot()
    {
        if ((!isShooted) && lazerButton == 1 && timer > 1f)
        {
            GunAudio.PlayOneShot(shootingSound);
            LazerGunAnim.Play("Discharging");
            LazerGunAnim.SetBool("charging", true);
            Instantiate(Lazer, shootingpoint.position, shootingpoint.rotation);
            isShooted = true;
            timer = 0f;
        }
        
    }
}
