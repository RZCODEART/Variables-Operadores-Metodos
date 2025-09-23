using UnityEngine;

public class CubodeColores : MonoBehaviour
{

    public Color CuboColor; 
    public Vector3 tamanoCubo;
    public Vector3 translado;
    public GameObject nuevaPosition;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.localScale = tamanoCubo;
        GetComponent<Renderer>().material.color = CuboColor;
        nuevaPosition.transform.localPosition = translado;



    }

    // Update is called once per frame
    void Update()
    {
        transladarse();
    }
    void transladarse()
    {


    }



}
