using UnityEngine;

public class ColorFantasma : MonoBehaviour
{
    private Renderer rend;
    public Material materialFinal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        rend = GetComponent<Renderer>();
        // Insertamos  y asignamos la propiedad material.
        rend.material = materialFinal;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
