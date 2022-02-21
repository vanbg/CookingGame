using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class DailyBonusManager
{
    public const string KEY_TIME_DAILY_BONUS = "dailybonus_t";
    public const string KEY_INDEX_DAILY_BONUS = "dailybonus_idx";

    public static bool IsAvailable()
    {
        //ham check ngay hom nay co dc nhan dailybonus hay k
        string timed = PlayerPrefs.GetString(KEY_TIME_DAILY_BONUS);
        
        if (string.IsNullOrEmpty(timed))
        {
            return true;
        }

        //  kiem tra xem chuyen doi co thanh cong ko 
        if (DateTime.TryParse(timed, out DateTime result))//?????
        {
            // neu ngay hien tai != result
            if (DateTime.Now.Date > result.Date)
            {   
                return true;
            }
        }
  
        return false;
    }

    public static void OnClaim()
    {
        //set key claim
        PlayerPrefs.SetString(KEY_TIME_DAILY_BONUS, DateTime.Now.ToString());

        int currentIndex = PlayerPrefs.GetInt(KEY_INDEX_DAILY_BONUS, 0);
        currentIndex++;

        if (currentIndex >= 7)
        {
            currentIndex = 0;
        }

        PlayerPrefs.SetInt(KEY_INDEX_DAILY_BONUS, currentIndex);
    }

    public static int GetLastIndexClaim()
    {
        return PlayerPrefs.GetInt(KEY_INDEX_DAILY_BONUS);
    }
}
