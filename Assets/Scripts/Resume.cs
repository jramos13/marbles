using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class Resume : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public AudioSource audioSource;
    public AudioClip resumeSelect;
    public AudioClip hover;
    public PauseGame pauseGame;

    public void OnPointerClick(PointerEventData eventData)
    {
        audioSource.PlayOneShot(resumeSelect, 1);
        StartCoroutine(waiter());
        pauseGame.unPauseGame();
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
        yield return new WaitForSeconds(resumeSelect.length);
    }
}