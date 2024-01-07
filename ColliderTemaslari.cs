using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTemaslari : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Bir düþman ile temas edildi.");
        }
    }
}





