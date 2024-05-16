using System.Collections;
using UnityEngine;
using TMPro;

public class TextTimer : MonoBehaviour
{
    public TextMeshProUGUI textElement; 
    public float displayTime = 5f; 
    public float delay = 0f; 

    void Start()
    {
        StartCoroutine(DisplayTextWithDelay());
    }

    IEnumerator DisplayTextWithDelay()
    {
        yield return new WaitForSeconds(delay);


        textElement.gameObject.SetActive(true);


        yield return new WaitForSeconds(displayTime);

        textElement.gameObject.SetActive(false);
    }
}

