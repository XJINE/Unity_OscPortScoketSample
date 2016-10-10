using UnityEngine;
using Osc;
using System.Net;

public class OscPortSocket_Server : MonoBehaviour
{
    /// <summary>
    /// 送信サーバー。
    /// </summary>
    public OscPort server;

    protected virtual void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SendOsc();
            Debug.Log("Send");
        }
    }

    /// <summary>
    /// OSC を送信します。
    /// </summary>
    private void SendOsc()
    {
        MessageEncoder oscEnc = new MessageEncoder("/path");

        oscEnc.Add(3.14f);
        oscEnc.Add(12345);

        this.server.Send(oscEnc.Encode());

        Debug.Log("Local Port : " + this.server.localPort);
        Debug.Log("Host : " + this.server.defaultRemoteHost);
    }
}