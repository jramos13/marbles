using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine;

public class easy : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public AudioSource audioSource;
    public AudioClip menuSelect;
    public AudioClip hover;

    public void OnPointerClick(PointerEventData eventData)
    {
        audioSource.PlayOneShot(menuSelect, 1);
        StartCoroutine(waiter());
        SceneManager.LoadScene("Level1");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        audioSource.PlayOneShot(hover, .25f);
        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(menuSelect.length);
    }
}