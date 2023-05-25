using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta2 : MonoBehaviour
{
    public Transform puerta;
    public GameObject particulas;
    public Animator puertaAnim;

    public int puntos = 0;

    public GameObject papel, tijera, piedra;

    void Start()
    {
        papel.SetActive(false);
        tijera.SetActive(false);
        piedra.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(puntos == 1)
        {
            papel.SetActive(false);
            tijera.SetActive(true);
            piedra.SetActive(false);
        }

        if (puntos == 2)
        {
            papel.SetActive(true);
            tijera.SetActive(false);
            piedra.SetActive(false);
        }

        if (puntos == 3)
        {
            papel.SetActive(false);
            tijera.SetActive(false);
            piedra.SetActive(false);
        }
    }

    public void SiguienteNivel()
    {
        GameManager.instance.SiguienteSala(2);
    }

    public void GestoPapel() 
    {
        if(puntos == 0 && GameManager.instance.estaEnSalaGestos == true)
        {
            puntos++;
            GameObject newParticulas = Instantiate(particulas, piedra.gameObject.transform.position, Quaternion.identity);
            Destroy(newParticulas, 2);
        }

    }

    public void GestoPiedra()
    {
        if (puntos == 1)
        {
            puntos++;
            GameObject newParticulas = Instantiate(particulas, piedra.gameObject.transform.position, Quaternion.identity);
            Destroy(newParticulas, 2);
        }

    }

    public void Gestotijeras()
    {
        if (puntos == 2)
        {
            puntos++;
            GameObject newParticulas = Instantiate(particulas, piedra.gameObject.transform.position, Quaternion.identity);
            Destroy(newParticulas, 2);

            puertaAnim.SetTrigger("abrir");

            Invoke("SiguienteNivel", 3.5f);

        }

    }

}
