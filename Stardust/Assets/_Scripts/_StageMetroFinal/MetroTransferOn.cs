﻿using UnityEngine;
using System.Collections;

public class MetroTransferOn : MonoBehaviour
{


    public GameObject passenger;
    public GameObject wheretogo1;
    public GameObject wheretogo2;
    public GameObject wheretogo3;
    public GameObject wheretogo4;
    public GameObject doorright;
    public GameObject doorleft;
    public GameObject passengerturn;
    Vector3 passengermove;
    Vector3 doorrightmove;
    Vector3 doorleftmove;
    float speed = 1.5f;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(passenger.GetComponent<BoxCollider2D>());
        if (passenger.transform.position.y < wheretogo1.transform.position.y)
        {
            passengermove = Vector3.MoveTowards(passenger.transform.position, wheretogo1.transform.position, speed * Time.deltaTime);
            passenger.transform.position = passengermove;
            doorrightmove = Vector3.MoveTowards(doorright.transform.position, wheretogo3.transform.position, speed * Time.deltaTime);
            doorright.transform.position = doorrightmove;
            doorleftmove = Vector3.MoveTowards(doorleft.transform.position, wheretogo4.transform.position, speed * Time.deltaTime);
            doorleft.transform.position = doorleftmove;

        }
        else
        {
            passenger.GetComponent<SpriteRenderer>().sprite = passengerturn.GetComponent<SpriteRenderer>().sprite;
            passengermove = Vector3.MoveTowards(passenger.transform.position, wheretogo2.transform.position, speed * Time.deltaTime);
            passenger.transform.position = passengermove;
        }


    }
}
