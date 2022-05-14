using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTrigger2 : MonoBehaviour
{
    public Tower twr;

    public bool lockE;

    public GameObject curTarget;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy2") && !lockE)
        {
            twr.target = other.gameObject.transform;
            curTarget = other.gameObject;
            lockE = true;
        }
    }
    void Update()
    {
        if (!curTarget)
        {
            lockE = false;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("enemy2") && other.gameObject == curTarget)
        {
            lockE = false;
        }
    }
}
