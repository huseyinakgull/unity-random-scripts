using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipOrnekleri : MonoBehaviour
{
    [Tooltip("Bu alan�n i�ine metni giriniz.")]
    public string metinAlani;

    [Range(0, 10)]
    [Tooltip("Bu alan�n de�erini 0 ile 10 aras�nda se�iniz.")]
    public int sayiDegeri;

    [Header("G�r�n�rl�k Ayarlar�")]
    [Tooltip("Bu nesnenin g�r�n�rl���n� a� veya kapat.")]
    public bool gorunurluk;

    void Start()
    {
        if (gorunurluk)
        {
            Debug.Log("Nesne g�r�n�r.");
        }
        else
        {
            Debug.Log("Nesne gizli.");
        }
    }
}


