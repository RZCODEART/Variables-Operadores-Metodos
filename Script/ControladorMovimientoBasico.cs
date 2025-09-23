using UnityEngine;

public class ControladorMovimientoBasico : MonoBehaviour
{

    public int velocidad;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimientos();
    }

    void Movimientos()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * velocidad);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.down * velocidad);
        }
       
    }


}
