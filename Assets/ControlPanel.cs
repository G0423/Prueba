using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlPanel : MonoBehaviour
{
    public RectTransform posPantalla2;//creamos la variable pospantalla
    public string usuario;
    Vector2 posInicialP2;// Creamos una variable de Vector2 para guardar una posición
    public TextMeshProUGUI mensajeinicial;//creamos una variable de cuado de texto...wow...[Strigns es puro texto]
    public TextMeshProUGUI textU;//De esta variable tomaremos el InPut del usuario
    public TextMeshProUGUI Instrucciones;//En esta variable mandaremos nuestros mensajes de erros

    //cremos varibles para borrar su contenido cuando lo necesitemos 
    public TMP_InputField InputUsuario;
    public TMP_InputField InputPass;

    // El Start se ejecuta una sola vez
    void Start()
    {
        //Al comenzar el programa se guardará la posición inicial
        posInicialP2 = posPantalla2.anchoredPosition;
    }
    public TextMeshProUGUI textPass;
    string password;//En esta variable se verifica el password

    public void register()
    {
        if (textU.text.Length > 1 && textPass.text.Length > 8)
        {
            usuario = textU.text; //Con esta se guarda el usuario
            password = textPass.text;//con esta se guarda la contraseña
            Instrucciones.text = "Registro comletado";
        }
        else
        {
            Instrucciones.text = "Error de registro";
        }
    }
    
    //Función conectada al botón logIn
    public void LogIn()
    {
        //estos son condicionantes 1) mayor a la longitud del texto | caracteres
        //Las llaves {} son super importantes para dividir todo por bloques
        if (usuario == textU.text && password== textPass.text)
        {
            //Manda a mi pantalla a la posición [0,0]
            posPantalla2.anchoredPosition = Vector2.zero;
            usuario = textU.text;//actualizamos el usuario al dato de InPut [Osea ya el usuario que pongan sera el de el texto]
            mensajeinicial.text = "Hola " + usuario + ", Disfruta la app";
        }
       else
        {
            Instrucciones.text = "Usuario o Password incorrectos";
            Debug.Log("Error");
        }
    }
    //Función conectada al botón Back
    public void Salir()//Le vamos a cambiar e nombre por salir
    {
        posPantalla2.anchoredPosition = posInicialP2;
        Instrucciones.text = "Shalom!! Escribe tu usuario y contraseña";
        //pendiente borrar la info de los inputs en los renglones de abajo
        //Para borrar correctamente tuvimos que acceder directamente al Input y no al texto [recuerda checar bien los nombres]
        InputUsuario.text = "";
        InputPass.text = "";
    }

    // El Update se ejecuta a cada rato
    void Update()
    {
        
    }
}
