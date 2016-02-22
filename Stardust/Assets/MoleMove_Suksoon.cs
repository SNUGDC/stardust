using UnityEngine;
using System.Collections;

public class MoleMove_Suksoon : MonoBehaviour {

    public Animator Suksoon;
    

	void MolemoveSuksoon () {
        Suksoon.SetBool("Suksoonmover", true);
	}
}
