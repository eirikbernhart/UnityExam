using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Objective : MonoBehaviour {

    public Canvas info;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Objective")
        {
            info.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Objective")
        {
            info.enabled = false;
        }
    }
}
