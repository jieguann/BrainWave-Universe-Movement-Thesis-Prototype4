using extOSC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainWaveReceive : MonoBehaviour
{   public float delta;
    public float theta;
    public float alpha;
    public float beta;
    public float gamma;

    public OSCReceiver Receiver;
    private const string deltaAddress = "/muse/elements/delta_absolute";
    private const string thetaAddress = "/muse/elements/theta_absolute";
    private const string alphaAddress = "/muse/elements/alpha_absolute";
    private const string betaAddress = "/muse/elements/beta_absolute";
    private const string gammaAddress = "/muse/elements/gamma_absolute";

    void Start()
    {
        Receiver.Bind(deltaAddress, deltaReceiveFloat);
        Receiver.Bind(thetaAddress, thetaReceiveFloat);
        Receiver.Bind(alphaAddress, alphaReceiveFloat);
        Receiver.Bind(betaAddress, betaReceiveFloat);
        Receiver.Bind(gammaAddress, gammaReceiveFloat);
    }

    public void deltaReceiveFloat(OSCMessage message)
    {
        if (message.ToFloat(out var value))
        {

            delta = value;
        }
    }

    public void thetaReceiveFloat(OSCMessage message)
    {
        if (message.ToFloat(out var value))
        {

            theta = value;
        }
    }

    public void alphaReceiveFloat(OSCMessage message)
    {
        if (message.ToFloat(out var value))
        {

            alpha = value;
        }
    }
    public void betaReceiveFloat(OSCMessage message)
    {
        if (message.ToFloat(out var value))
        {

            beta = value;
        }
    }
    public void gammaReceiveFloat(OSCMessage message)
    {
        if (message.ToFloat(out var value))
        {

            gamma = value;
        }
    }
}
