using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine; 
using UnityEngine.UI;
//SCRIPT FROM CHIPI CHIPI CHAPA CHAPA RUVI RUVI RUVA RUVA BOOM BOOM BOOM BOMM
public class UISystem : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI counterTEXT;
    public Slider healthSlider;

    void Update()
    {
        counterTEXT.text = "Coins : " + player.coins.ToString();

        healthSlider.maxValue = 10;
        healthSlider.value = player.health;
    }
}
