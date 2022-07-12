using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject asd;
    public float sec;

    void Awake()
    {

        Destroy(asd, sec);
    }
}
