using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EkranKartiBilgisi : MonoBehaviour
{
    void Start()
    {
        string ekranKartiModeli = SystemInfo.graphicsDeviceName;
        int bellekMiktariMB = SystemInfo.graphicsMemorySize;
        Debug.Log("Ekran Kart� Modeli: " + ekranKartiModeli);
        Debug.Log("Bellek Miktar�: " + bellekMiktariMB + " MB");
    }
}







