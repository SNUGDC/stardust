﻿using UnityEngine;
using System.Collections;

public class PaletteCallerLocal : MonoBehaviour
{
    public string Palettetag;

    GameObject[] Palettes;
    Vector3[] tempPos;
    Vector3[] temp;
    int routine = 0;
    private bool wasMouseDown;
    public bool active = false;
    public float smoothTime = 0.18f;
    private GameObject Girl;

    private Vector3[] velocity;

    void Start()
    {
        Palettes = GameObject.FindGameObjectsWithTag(Palettetag);

        tempPos = new Vector3[Palettes.GetLength(0)];
        temp = new Vector3[Palettes.GetLength(0)];
        velocity = new Vector3[Palettes.GetLength(0)];
        for (int i = 0; i < Palettes.GetLength(0); i++)
        {
            tempPos[i] = Palettes[i].transform.localPosition;
            Palettes[i].SetActive(false);
        }
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (active == true)
            {
                routine = 1;
            }
            else
            {
                routine = 0;
            }
            active = false;
        }
        if (routine == 1)
        {
            PaletteCall();
        }

        if (routine == 0)
        {
            for (int i = 0; i < Palettes.GetLength(0); i++)
            {
                Palettes[i].SetActive(false);
            }
        }
    }

    void PaletteCall()
    {
        for (int i = 0; i < Palettes.GetLength(0); i++)
        {
            Palettes[i].SetActive(true);
            temp[i] = Vector3.SmoothDamp(Palettes[i].transform.localPosition, tempPos[i], ref velocity[i], smoothTime);
            Palettes[i].transform.localPosition = temp[i];
        }
    }

    void OnMouseDown()
    {
        if (this.GetComponent<PaletteCallerLocal>().enabled && GetComponent<TorchControl>().torchGet == true)
        {
            active = true;
        }
        for (int i = 0; i < Palettes.GetLength(0); i++)
        {
            Palettes[i].transform.localPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        }

    }
}