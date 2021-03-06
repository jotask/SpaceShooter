﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utiles {

    public enum Prefs
    {
        MONEY
    }
    
    public static void  SetBool (string name, bool value) {
        PlayerPrefs.SetInt(name, value?1:0);
    }
 
    public static bool GetBool (string name) {
        return PlayerPrefs.GetInt(name) == 1 ? true : false;
    }
 
    public static bool GetBool (string name, bool defaultValue ) {
        if (PlayerPrefs.HasKey(name)) {
            return GetBool(name);
        }
        return defaultValue;
    }
    
}
