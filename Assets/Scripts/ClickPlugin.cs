using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tabtale.TTPlugins;

public class ClickPlugin : MonoBehaviour
{


    private void Awake()
    {
        // Initialize CLIK Plugin
        TTPCore.Setup();
        // Your code here
    }
    public void Start()

    {
        TTPCore.Setup();
    }
}