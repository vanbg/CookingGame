using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DailyBonus : MonoBehaviour
{
    private static int currday;
    [SerializeField]
    Image[] tick;
    [SerializeField]
    Text [] txtBonus ;
    [SerializeField]
    private int[] Bonus = { 250, 5, 500, 6, 750 , 7 ,1000 };
 
    private void Awake()
    {
        SaveTick();
        ShowBonus();

    }
    public void SaveTick()
    {
        currday = DailyBonusManager.GetLastIndexClaim();
        for (var i = 0; i < currday; i++)
        {
            tick[i].gameObject.SetActive(true);
        }
    }
    public void AddRewar()
    {
        if (DailyBonusManager.IsAvailable())
        {
            if (currday == 0)
            {
                for (var i =0;i<7;i++)
                {
                    tick[i].gameObject.SetActive(false);
                }
            }
            DailyBonusManager.OnClaim();

            tick[currday].gameObject.SetActive(true);
            AddBonus();
            currday = DailyBonusManager.GetLastIndexClaim();
        }
        Debug.Log(currday);
    }
    private void ShowBonus()
    {
        for (var i = 0; i < 7; i++) 
        {
            txtBonus[i].text = Bonus[i].ToString(); 
        }
    }
    public void AddBonus()
    {
            if (Bonus[currday] < 50)
            {
                GameEvent.AddGems(Bonus[currday]);

            }
            else
            {
                GameEvent.AddCoins(Bonus[currday]);
            }
      
    }
    
    

}
