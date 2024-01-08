using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLogYonetimi : MonoBehaviour
{
    public void LoglariYonet(bool durum)
    {
        if(durum)
        {
            Debug.unityLogger.logEnabled = true;
        }
        else
        {
            Debug.unityLogger.logEnabled = false;
        }
    }
}


