using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; // Required when using Event data.

public class dragLetter : MonoBehaviour,IDragHandler
{
    public char letter;
    public Transform pos;
    private Vector2 initPlace;

    public void Awake()
    {
        initPlace = GetComponent<RectTransform>().anchoredPosition;
        StartCoroutine(startLock());
    
    }

    IEnumerator startLock()
    {
        lck = true;
        yield return new WaitForSeconds(4.0f);
        lck = false;
    }

    public void setLetter(char l)
    {   
        Sprite[] txts = Resources.LoadAll<Sprite>("буквы_картинки/Уровень 2/" + l.ToString());
        GetComponent<Image>().sprite = txts[Random.Range(0,txts.Length)] ;
        letter = l;
    }
  

    public void OnDrag(PointerEventData eventData)
    {
        if (!lck)
        {
            transform.position = eventData.position;
        }
    }

    public void GoBack()
    {
        StartCoroutine(toInitPlace());
    }
    bool lck = false;
    private IEnumerator toInitPlace()
    {
        lck = true;

        //
        var rect = GetComponent<RectTransform>();
        Vector2 diff = initPlace - rect.anchoredPosition;
        while (diff.magnitude > 0.5f)
        {
            diff = initPlace - rect.anchoredPosition;
            rect.anchoredPosition += diff.normalized;
            yield return new WaitForSeconds(0.01f);

        }
        rect.anchoredPosition = initPlace;
        lck = false;
    }
}
