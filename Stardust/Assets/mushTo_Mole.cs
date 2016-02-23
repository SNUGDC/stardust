using UnityEngine;
using System.Collections;

public class mushTo_Mole : MonoBehaviour {

    public Animator MoleGo;

    void MushthrowMakesMoleBig()
    {
        MoleGo.SetBool("Molemove", true);
    }
}
