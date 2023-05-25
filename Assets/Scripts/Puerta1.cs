using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta1 : MonoBehaviour
{
    public int puntos = 0;
    public Animator puertaAnim;
    public GameObject particulas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            puntos++;
            GameObject newParticulas = Instantiate(particulas, other.gameObject.transform.position, Quaternion.identity);
            other.gameObject.GetComponent<Collider>().enabled = false;
            Destroy(other.gameObject, 1f);
            Destroy(newParticulas, 2);
            

            if(puntos == 2)
            {
                Invoke("AbrirPuerta", 1.5f);
                Invoke("SiguienteNivel", 3.5f);
            }
        }
    }

    public void AbrirPuerta() 
    {
        puertaAnim.SetTrigger("abrir");
    }

    public void SiguienteNivel()
    {
        GameManager.instance.SiguienteSala(1);
        GameManager.instance.estaEnSalaGestos = true;
    }
}
