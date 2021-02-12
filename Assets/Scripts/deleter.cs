using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("projectile"))
        {
            gameObject.SetActive(false);
            //scoreKeeper.Increase()
        }
    }
}
