using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float duration = 8f; // Duración de la transición
    private Material material; // Material del objeto
    private float targetAlpha = 1f; // Transparencia final
    private float initialAlpha = 0f; // Transparencia inicial
    private float timer = 0f; // Temporizador
    bool delay = false;
    public PaneoCamara scriptCamara; // Referencia al script B
    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        material = renderer.material;

        // Guardar la transparencia inicial
        //initialAlpha = material.color.a;

        // Hacer que el objeto sea completamente transparente al inicio
        SetAlpha(0f);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Delay", 1f);

        if (delay){
            timer += Time.deltaTime;

        // Calcular el valor alpha basado en el temporizador
        float alpha = Mathf.Lerp(initialAlpha, targetAlpha, timer / duration);

        // Aplicar la transparencia gradualmente
        SetAlpha(alpha);
        }


        

        // Si se ha alcanzado la transparencia objetivo, reiniciar el temporizador
        /*
        if (timer >= duration)
        {
            timer = 0f;
        }
        */
    }

    private void OnMouseDown()
    {
        if (scriptCamara != null)
        {
            scriptCamara.Inicia();
        }
        else
        {
            Debug.LogError("¡El script de la cámara no está asignado en el Inspector!");
        }
    }

    private void Delay(){
        delay = true;
    }

    private void SetAlpha(float alpha)
    {
        Color color = material.color;
        color.a = alpha;
        material.color = color;
    }
}
