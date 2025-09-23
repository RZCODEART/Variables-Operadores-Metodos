using UnityEngine;

public class miCofre : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public int tamano;

        
    
    void Start()
    {
        tamano = 1;
        print(tamano);
    }

    // Update is called once per frame
    void Update()
    {
        cambiarTamano();
    }



void cambiarTamano (){

    tamano = 2 * tamano;
    print("cambiarTamano" + tamano);
    

}



}
