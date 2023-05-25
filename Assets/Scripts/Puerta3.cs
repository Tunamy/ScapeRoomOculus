using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta3 : MonoBehaviour
{
    public GameObject rojo, amarillo, verde, morado, azul;

    bool rojoeliminado = false;
    bool verdeAzulEliminado = false;
    bool sePuedeAbrir = false;

    int tabloneseElimiados = 0;

    public Animator puertaAnim;

    public GameObject particulas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(tabloneseElimiados == 3)
        {
            verdeAzulEliminado=true;
        }

        if (tabloneseElimiados == 5)
        {
            sePuedeAbrir=true;
        }
    }

    public void eliminarRojo()
    {
        if (rojo != null)
        {
            GameObject newParticulas = Instantiate(particulas, rojo.gameObject.transform.position, Quaternion.identity);
            Destroy(newParticulas, 2);
            Destroy(rojo, 0.2f);
            tabloneseElimiados++;
            rojoeliminado = true;
            Destroy(newParticulas, 2);
        }
    }

    public void eliminarVerde()
    {
        if (rojoeliminado == true)
        {
            if (verde != null)
            {
                GameObject newParticulas = Instantiate(particulas, verde.gameObject.transform.position, Quaternion.identity);
                Destroy(newParticulas, 2);
                Destroy(verde,0.2f);
                tabloneseElimiados++;
            }
        }
    }

    public void eliminarAzul()
    {
        if (rojoeliminado == true)
        {
            if (azul != null)
            {
                GameObject newParticulas = Instantiate(particulas, azul.gameObject.transform.position, Quaternion.identity);
                Destroy(newParticulas, 2);
                Destroy(azul, 0.2f);
                tabloneseElimiados++;
            }
        }
    }
    public void eliminarAmarillo()
    {
        if (verdeAzulEliminado == true)
        {
            if (amarillo != null)
            {
                GameObject newParticulas = Instantiate(particulas, amarillo.gameObject.transform.position, Quaternion.identity);
                
                Destroy(newParticulas, 2);
                Destroy(amarillo, 0.2f);
                tabloneseElimiados++;
            }
        }
    }

    public void eliminarMorado()
    {
        if (verdeAzulEliminado == true)
        {
            if (morado != null)
            {
                GameObject newParticulas = Instantiate(particulas, morado.gameObject.transform.position, Quaternion.identity);
                Destroy(newParticulas, 2);
                Destroy(morado, 0.2f);
                tabloneseElimiados++;
            }
        }
    }

    public void AbrirPuerta()
    {
        puertaAnim.SetTrigger("abrir");
        

        Invoke("SiguienteNivel", 3.5f);
    }

    public void SiguienteNivel()
    {
        GameManager.instance.SiguienteSala(3);
        GameManager.instance.estaEnSalaAudio = true;
    }
}
