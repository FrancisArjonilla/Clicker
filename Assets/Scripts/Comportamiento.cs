using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Comportamiento : MonoBehaviour
{
    //Objeto principal de la clase
    private Transform planeta;

    //Su posicion y tamaño
    private Vector2 original;

    //Registro de clicks
    private int contador = 0;

    //Texto indicativo del recuento de clicks
    private TextMeshPro texto;



    // Start is called before the first frame update
    void Start()
    {
        //Vinculamos el componente a la variable
        planeta = GetComponent<Transform>();

        // Obtenemos el componente TextMesh del objeto hijo llamado "Text"
        texto = transform.Find("Text").GetComponent<TextMeshPro>();
    }

    // Método para manejar el clic en el planeta
    private void OnMouseDown()
    {
        //Obtenemos su tamaño original y lo almacenamos
        original = new Vector2(planeta.localScale.x , planeta.localScale.y);
        //Aumentamos minimamente su tamaño
        Vector2 scaleUp = new Vector2(planeta.localScale.x + 0.05f, planeta.localScale.y + 0.05f);
        //Aplicamos el cambio
        planeta.localScale = scaleUp;
        // Incrementamos el contador
        contador++;
        //Restauramos el tamaño original con un pequeño retardo
        Invoke("retardo", 0.1f);
 
        if (texto != null)
        {
            // Actualizar el texto
            texto.text = contador.ToString();
        }
    }

    private void retardo(){
        planeta.localScale = original;
    }
}
