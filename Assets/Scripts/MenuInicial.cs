using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuInicial : MonoBehaviour
{
    public Text resultado, titulo;
    void Start()
    {
        if(PlayerController.state == "lost")
        {
            titulo.text = "Has Perdido";
            PlayerController.state = ""; 
        }
        else if (PlayerController.state == "won")
        {
            titulo.text = "Has Ganado!";
            PlayerController.state = ""; 
        }
    }

    void Update()
    {
        
    }
    public void Jugar()
    {
        SceneManager.LoadScene("VentanaPrincipal");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
