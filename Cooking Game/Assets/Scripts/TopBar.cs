using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopBar : MonoBehaviour
{
    public static TopBar Intertance;
    public Text TxtCoins,TxtGems;
    private static int gems,coins;

    private void Awake()
    {
       UpdateText();
    }

    private void OnEnable()
    {
        GameEvent.AddGems += AddGems;
        GameEvent.AddCoins += AddCoins;
    }

    private void OnDisable()
    {
        GameEvent.AddGems -= AddGems;
        GameEvent.AddCoins -= AddCoins;
    }

    public void AddGems(int gem)
    {
        gems += gem;
        GameData.SetString("key1", gems.ToString());
        UpdateText();
    }
    public void AddCoins(int coin)
    {
        coins += coin;
        GameData.SetString("key2", coins.ToString());
        UpdateText();
    }

    public void UpdateText()
    {
        TxtGems.text = PlayerPrefs.GetString("key1", "0");
        TxtCoins.text = PlayerPrefs.GetString("key2","0");
       
    }
  

}
