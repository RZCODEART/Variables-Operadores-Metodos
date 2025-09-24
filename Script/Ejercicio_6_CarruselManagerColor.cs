using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class CarruselManagerColor : MonoBehaviour
{
    public GameObject[] cubos; 
    public Color [] color;
    public int [] tamano;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       


    }

    // Update is called once per frame
    void Update()
    {
        carruselDeColor();

        carruselDeTamano();


    }

    void carruselDeColor()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            

            for (int i = 0; i < cubos.Length; i++)
            {
                Renderer cubito = cubos[i].GetComponent<Renderer>();
                cubito.material.color = color[i];
               
            }
            
        }

        



    }


    void carruselDeTamano()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {


            for (int i = 0; i < cubos.Length; i++)
            {
                int size = tamano[i];
                cubos[i].transform.localScale = new Vector3(size, size, size);

            }

        }



    }


}
