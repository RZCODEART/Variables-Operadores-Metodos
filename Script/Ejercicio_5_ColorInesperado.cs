using UnityEngine;

public class ColorInesperado : MonoBehaviour
{
    private Renderer rend;
    public Color colorEsperado;

    void Start()
    {
        rend = GetComponent<Renderer>();
              
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Remplazamos la variable de color fija Color.red,
            // hemos cambiado la variable publica de manera que esta
            // se pueda modificar desde el inspector sin tener que cambiar el codigo.
            rend.material.color = colorEsperado;
        }
    }
}
