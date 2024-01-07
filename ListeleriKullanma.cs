using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListeleriKullanma : MonoBehaviour
{
    void Start()
    {
        List<string> renkListesi = new List<string>();
        renkListesi.Add("Kýrmýzý");
        renkListesi.Add("Mavi");
        renkListesi.Add("Yeþil");
        Debug.Log("Renk Listesi: " + string.Join(", ", renkListesi));
    }
}





