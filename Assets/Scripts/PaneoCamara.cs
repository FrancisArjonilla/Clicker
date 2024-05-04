using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaneoCamara : MonoBehaviour
{
    // Start is called before the first frame update
    //public float moveSpeed = 5f;

    private Vector3 offset = new Vector3(0f, 0f, -10f);
    private float smoothtime = 3f;

    //private bool paneo = false;

    private Vector3 velocity = Vector3.zero;
    void Start()
    {
        
    }

    private bool paneo = false;


    // Update is called once per frame
    void Update()
    {
        
        if (paneo)
        {
            GameObject planeta = GameObject.FindWithTag("Planeta");
            //transform.position = Vector2.MoveTowards(transform.position, Vector2.down, Time.deltaTime);
            Vector3 targetPosition = planeta.transform.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothtime);
        }
    }

    public void Inicia(){

        
            paneo = true;
        
    }
}



