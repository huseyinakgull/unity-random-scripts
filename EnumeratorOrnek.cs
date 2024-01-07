using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumeratorOrnek : MonoBehaviour
{
    void Start() // Baþlangýç itibariyle çalýþmasýný istediðimiz kodlar.
    {
        StartCoroutine(SureBaslat(15)); // 15 deðeri üzerinden sayým baþlatma.
    }

    IEnumerator SureBaslat(int istenilenzaman) // Süre hakkýnda ki temel kodlar.
    {
        yield return new WaitForSeconds(istenilenzaman); 
        Debug.Log("Ýstenilen süre boyunca beklendildi. " + istenilenzaman.ToString());
    }
}






