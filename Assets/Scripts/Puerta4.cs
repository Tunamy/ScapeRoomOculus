using Oculus.Voice;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta4 : MonoBehaviour
{
    public AppVoiceExperience appVoice;
    public GameObject puerta;
    public Animator puertaAnim;
    public GameObject particulas;

    bool puertaCerrada = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.estaEnSalaAudio == true)
        {
            appVoice.Activate();
        }
    }


    public void AbrirPuerta(string[] values)
    {
        var abrirstring = values[0];
        var puertastring = values[1];

        if (puertaCerrada == true)
        {
            if (abrirstring == "abrir" || abrirstring == "puerta")
            {
                GameObject newParticulas = Instantiate(particulas, puerta.gameObject.transform.position, Quaternion.identity);
                Destroy(newParticulas, 2);

                puertaCerrada =false;
                puertaAnim.SetTrigger("abrir");
                Invoke("SiguienteNivel", 3.5f);

            }

            if (puertastring == "abrir" || puertastring == "puerta")
            {

                GameObject newParticulas = Instantiate(particulas, puerta.gameObject.transform.position, Quaternion.identity);
                Destroy(newParticulas, 2);
                puertaCerrada = false;
                puertaAnim.SetTrigger("abrir");
                Invoke("SiguienteNivel", 3.5f);
            }
        }

    }

    public void SiguienteNivel()
    {
        GameManager.instance.SiguienteSala(4);
        GameManager.instance.estaEnSalaAudio = false;
    }

}
