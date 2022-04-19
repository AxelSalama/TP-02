using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngresoContra : MonoBehaviour
{
    string contraCorrecta;
    string contraUsuario;
    public Text IngresoUsuario;
    public Text textoMsj;
    public GameObject cartelitomsj;
    public void validarContra()
    {
        contraUsuario = IngresoUsuario.text;
        if (contraUsuario == contraCorrecta)
        {
            cartelitomsj.SetActive(true);
            textoMsj.text = "Bienvenido"; 
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitomsj.SetActive(true);
            textoMsj.text = "Contraseña Incorrecta";
            Debug.Log("Contraseña Incorrecta");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        contraCorrecta = "12345";
        cartelitomsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
