using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipOrnekleri : MonoBehaviour
{
    [Tooltip("Bu alanýn içine metni giriniz.")]
    public string metinAlani;

    [Range(0, 10)]
    [Tooltip("Bu alanýn deðerini 0 ile 10 arasýnda seçiniz.")]
    public int sayiDegeri;

    [Header("Görünürlük Ayarlarý")]
    [Tooltip("Bu nesnenin görünürlüðünü aç veya kapat.")]
    public bool gorunurluk;

    void Start()
    {
        if (gorunurluk)
        {
            Debug.Log("Nesne görünür.");
        }
        else
        {
            Debug.Log("Nesne gizli.");
        }
    }
}


