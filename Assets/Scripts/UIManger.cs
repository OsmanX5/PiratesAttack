using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class UIManger : MonoBehaviour
{
    public TMP_Text Score;
    public Image ShipLife;
    public Image PirateShipLife;
    public Image FreazeBar;
    private void Update()
    {
        Score.text = Player.score.ToString();
        ShipLife.fillAmount = Mathf.Clamp(Ship.PrecentageHealth,0f,1f);
        PirateShipLife.fillAmount = Mathf.Clamp(PiratesShip.PrecentageHealth, 0f, 1f);
        FreazeBar.fillAmount = Mathf.Clamp(LaserGeneration.FrizeTimer/3f, 0f, 1f);
    }
}
