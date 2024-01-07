using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UnityLibrary : MonoBehaviour
{
    public void SahneDegistir(string sahneadi)
    {
        SceneManager.LoadScene(sahneadi);
    }
}






