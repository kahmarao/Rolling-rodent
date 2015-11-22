﻿using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

    private bool controlePause;

    private AudioSource bgm;

    public AudioSource efeito;

    public GUI menuPause;


    // Use this for initialization
    void Start () {
        bgm = GetComponentInChildren<AudioSource>();

        controlePause = true;
        Time.timeScale = 1; // voltar ao jogo


    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        { // se apertar a tecla esc (escape)

            if (controlePause)
            {
                Time.timeScale = 0; // pausar o jogo
                controlePause = false;
                bgm.volume = 0.1f;
                efeito.Play();
            }
            else
            {
                Time.timeScale = 1; // voltar ao jogo
                controlePause = true;

                bgm.volume = 0.65f;

                efeito.Play();
            }
        }

        if (Input.GetKeyDown(KeyCode.F4) && !controlePause)
        {

            controlePause = true;
            Application.LoadLevel("MenuInicial");
            Application.UnloadLevel("test_arena");

        }



    }
}
