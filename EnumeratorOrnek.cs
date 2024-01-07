using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumeratorOrnek : MonoBehaviour
{
    void Start() // Ba�lang�� itibariyle �al��mas�n� istedi�imiz kodlar.
    {
        StartCoroutine(SureBaslat(15)); // 15 de�eri �zerinden say�m ba�latma.
    }

    IEnumerator SureBaslat(int istenilenzaman) // S�re hakk�nda ki temel kodlar.
    {
        yield return new WaitForSeconds(istenilenzaman); 
        Debug.Log("�stenilen s�re boyunca beklendildi. " + istenilenzaman.ToString());
    }
}






