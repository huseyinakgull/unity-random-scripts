using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebYonlendirme : MonoBehaviour
{
    public string webSayfaLinki = "https://www.unity.com";
    public void WebSayfaAc()
    {
        Application.OpenURL(webSayfaLinki);
    }
}








