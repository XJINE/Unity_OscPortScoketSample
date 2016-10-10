using UnityEngine;
using Osc;

public class OscPortSocket_Receiver : MonoBehaviour
{
    /// <summary>
    /// OscPortSocket がメッセージを受信したときに呼び出されます。
    /// OscPortSocket の OnReceive に設定します。
    /// </summary>
    /// <param name="e">
    /// 受信したときに通知されるイベント。
    /// </param>
    public virtual void OscMessageReceived(OscPort.Capsule e)
    {
        Debug.Log("IP   : "   + e.ip);
        Debug.Log("Path : " + e.message.path);

        int length = e.message.data.Length;

        for(int i = 0; i < length; i++)
        {
            Debug.Log("Data[" + i + "] : " + e.message.data[i]);
        }
    }
}