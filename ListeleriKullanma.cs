using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListeleriKullanma : MonoBehaviour
{
    void Start()
    {
        List<string> renkListesi = new List<string>();
        renkListesi.Add("K�rm�z�");
        renkListesi.Add("Mavi");
        renkListesi.Add("Ye�il");
        Debug.Log("Renk Listesi: " + string.Join(", ", renkListesi));
    }
}





