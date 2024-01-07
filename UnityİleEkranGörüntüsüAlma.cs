using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityİleEkranGörüntüsüAlma : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            EkranGoruntusuAl();
        }
    }

    void EkranGoruntusuAl()
    {
        string dosyaAdi = "OyunEkranGoruntusu.png";
        ScreenCapture.CaptureScreenshot(dosyaAdi);
        Debug.Log("Ekran Görüntüsü Alındı: " + dosyaAdi);
    }
}


