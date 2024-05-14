using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class GlobalVariables
{
    public static int tikArt = 1;
    public static int scoreSayac;
    public static int otoTik;
    public static int odemeTik;
    public static int odemeSimsek;
    public static int scorer;
}

public class Upgrade : MonoBehaviour

{
    public int upgrade;
    public int price = 10;
    public Text upgradeText;
    public Text priceText;
    void Start()
    {
        
    }


    private void Update()
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
            GlobalVariables.tikArt = GlobalVariables.tikArt * 2;
            price = price * GlobalVariables.tikArt;
        }
    }
}
