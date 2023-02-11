using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavegaciónPantallas : MonoBehaviour

{
    //Estas dos variables nos serviran para navegar entre todas las pantallas
    public RectTransform posNextPantalla;
    Vector2 posInicial;

    void Start()
    {
        posInicial = posNextPantalla.anchoredPosition;
    }

    //Sirve para mostrar la pantalla seleccionada
    public void entrarPantalla()
    {
        posNextPantalla.gameObject.SetActive(true); //Enciendo pantalla
        posNextPantalla.anchoredPosition = Vector2.zero;// la colocamos en posición
    }

    //Sirve para ocular la pantalla seleccionada
    public void salirPantalla()
    {
        //posNextPantalla.anchoredPosition = posInicial;Es más lento
        transform.parent.gameObject.SetActive(false);//apaga la pantalla actual
    }
}
