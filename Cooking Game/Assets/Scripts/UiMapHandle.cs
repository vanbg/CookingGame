using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiMapHandle : MonoBehaviour
{
    public static UiMapHandle Instance { get; private set; }
    public GameObject ObjDailyBonus;
   
    public void AcitveDailyBonus()
    {
        ObjDailyBonus.SetActive(true);
    }
    public void CloseDailyBonus()
    {
        ObjDailyBonus.SetActive(false);
    }


    
   
}
