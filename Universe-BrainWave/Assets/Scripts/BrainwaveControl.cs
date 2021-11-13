using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class BrainwaveControl : MonoBehaviour
{
    public BrainWaveReceive brainwave;
    public Material skybox;
    public VisualEffect visualEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        skybox.SetFloat("NoiseVisual", brainwave.delta);
        //NoiseSize
        skybox.SetFloat("NoiseSize", brainwave.theta);

        visualEffect.SetFloat("Speed",brainwave.gamma);
        visualEffect.SetFloat("Drag", brainwave.theta);
        visualEffect.SetVector4("ColorControl",new Vector4(brainwave.beta, brainwave.delta , brainwave.alpha, 1));
    }
}
