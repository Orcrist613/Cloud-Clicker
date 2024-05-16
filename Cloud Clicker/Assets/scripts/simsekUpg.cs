using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class simsekUpg : MonoBehaviour
{
    public int upgrade;
    public int price = 20;
    public Text upgradeText;
    public Text priceText;
    private int i = 1;
    public GameObject effect;

    void Start()
    {
    }

    void Update()
    {
        upgradeText.text = upgrade.ToString();
        priceText.text = price.ToString();
    }

    public void AddUpgrade()
    {
        if (GlobalVariables.scoreSayac >= price)
        {
            upgrade++;
            GlobalVariables.scorer -= price;
            GlobalVariables.otoTik++;
            price *= GlobalVariables.otoTik + i;
            i = 0;

            PlayEffect();
        }
    }

    private void PlayEffect()
    {
        // Efekti aktif yapmadan önce eðer zaten aktifse kapatýp tekrar aç
        if (effect.activeInHierarchy)
        {
            effect.SetActive(false);
        }
        effect.SetActive(true);
    }
}
