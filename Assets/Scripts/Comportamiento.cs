using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Comportamiento : MonoBehaviour
{
    private int contador = 0;
    private TextMeshPro texto;

    // Start is called before the first frame update
    void Start()
    {
        // Obtenemos el componente TextMesh del objeto hijo llamado "Text"
        texto = transform.Find("Text").GetComponent<TextMeshPro>();
    }

    // Método para manejar el clic en el planeta
    private void OnMouseDown()
    {
        // Incrementamos el contador
        contador++;
 
        // Aquí puedes colocar la lógica que deseas que ocurra cuando se haga clic en el planeta
        Debug.Log("Se hizo clic en el planeta");
    

        if (texto != null)
        {
            // Actualizar el texto
            texto.text = contador.ToString();
        }
    }
}
