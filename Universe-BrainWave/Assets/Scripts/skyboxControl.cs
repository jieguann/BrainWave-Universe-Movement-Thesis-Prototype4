using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxControl : MonoBehaviour
{
    public BrainWaveReceive brainwave;
    public Material skybox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        skybox.SetFloat("NoiseVisual", brainwave.theta);
        //NoiseSize
        skybox.SetFloat("NoiseSize", brainwave.theta);
    }
}
