using UnityEngine;

public class CubodeColores : MonoBehaviour
{

    public Color CuboColor; 
    public float tamanoCubo;
   // public GameObject nuevaPosition;
    public float velocidadDelMovimiento;
    public float transformacionTamaño = 0.1f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.localScale = new Vector3(tamanoCubo, tamanoCubo, tamanoCubo);
        GetComponent<Renderer>().material.color = CuboColor;
        


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * velocidadDelMovimiento * Time.deltaTime);
        transform.localScale += new Vector3(transformacionTamaño, transformacionTamaño, transformacionTamaño) * Time.deltaTime;
    }



}
