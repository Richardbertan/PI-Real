using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeWood : MonoBehaviour
{
   public static int Price = 75;
    [SerializeField] Text PriTxt;
    void Update ()
    {
    PriTxt.text = Price.ToString();
    }
   public void OnClick ()
   {
        if (Loja.dinheiro >= Price)
        {
            madeira.increaseRate = 1.2f * madeira.increaseRate;
            Loja.increaseRate -= Price;
            Price += 75;
            
        }
   }
}
