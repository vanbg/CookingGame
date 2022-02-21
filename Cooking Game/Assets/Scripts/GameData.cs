using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static void SetInt(string KeyName, int Value)
    {
        PlayerPrefs.SetInt(KeyName, Value);
    }

    public static int Getint(string KeyName)
    {
        return PlayerPrefs.GetInt(KeyName);
    }

    public static void SetString(string KeyName, string Value)
    {
        PlayerPrefs.SetString(KeyName, Value);
    }

    public static string GetSing(string KeyName)
    {
        return PlayerPrefs.GetString("KeyName","0");
    }

}
