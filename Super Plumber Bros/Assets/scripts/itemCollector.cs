using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemCollector : MonoBehaviour
{
    private int kiwies = 0;

    [SerializeField] private AudioSource collectingSoundEffect;
    [SerializeField] private Text kiwisText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("kiwi"))
        {
            Destroy(collision.gameObject);
            ++kiwies;
            collectingSoundEffect.Play();
            kiwisText.text = "Kiwis: " + kiwies;
        }
    }
}
