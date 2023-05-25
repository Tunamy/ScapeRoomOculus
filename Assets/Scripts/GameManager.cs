using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Transform[] salas;
    public static GameManager instance { get; private set; }

    public bool estaEnSalaGestos = false;
    public bool estaEnSalaAudio = false;

    

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SiguienteSala(int numerosala)
    {
        player.transform.position = new Vector3(salas[numerosala-1].position.x, player.transform.position.y, salas[numerosala-1].position.z);
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
