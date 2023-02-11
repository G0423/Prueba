using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NAvegaciónREchazar : MonoBehaviour
{
    public RectTransform posNextPR;
    Vector2 posInicial;
    void Start()
    {
        posInicial = posNextPR.anchoredPosition;
    }

    public void entrarPantalla()
    {
        posNextPR.gameObject.SetActive(true);
        posNextPR.anchoredPosition = Vector2.zero;
    }
    
    public void salirPantalla()
    {
        transform.parent.gameObject.SetActive(false);
    }
}
