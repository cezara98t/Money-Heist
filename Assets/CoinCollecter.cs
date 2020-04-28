using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollecter : MonoBehaviour
{
    public CapsuleCollider playerCollider;


    private void OnCollisionEnter(Collision collision)
    {
         if (collision.collider == playerCollider)
         {
            gameObject.SetActive(false);
            ScoreManager.add();
         }
    }
}
