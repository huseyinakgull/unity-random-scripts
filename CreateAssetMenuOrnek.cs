using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAssetMenuOrnek : MonoBehaviour
{
    [CreateAssetMenu(fileName = "YeniVeri", menuName = "Oyun Verisi")]
    public class OyunVerisi : ScriptableObject
    {
        public string oyuncuAdi;
        public int seviye;
        public float can;
    }
}







