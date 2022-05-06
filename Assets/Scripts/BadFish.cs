using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadFish : MonoBehaviour
{
    public int value = -1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UIManager.instance.updateLives(value);
            this.gameObject.SetActive(false);
        }
    }
}
