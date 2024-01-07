using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class ApiKullanimlari : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ApiIstegi());
    }
    IEnumerator ApiIstegi()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("https://jsonplaceholder.typicode.com/todos/1"))
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("API Yanıtı: " + www.downloadHandler.text);
            }
            else
            {
                Debug.LogError("API İsteği Hatası: " + www.error);
            }
        }
    }
}






