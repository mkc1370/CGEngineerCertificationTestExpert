using System.Net;
using System.Net.Sockets;
using System.Threading;
using UnityEngine;

public class ThreadSample : MonoBehaviour
{
    private bool _value;
    
    private void Start()
    {
        var multicastIpAddress = IPAddress.Parse("224.0.23.0");
        var udp= new UdpClient();
        udp.JoinMulticastGroup(multicastIpAddress);
        // udp.DropMulticastGroup(multicastIpAddress);
        var remoteEp = new IPEndPoint(IPAddress.Any, 3610);
        var data = udp.Receive(ref remoteEp);
    }

    private void Foo()
    {
        // Debug.Log("これがあると何故か動く");
        if (_value)
        {
            Debug.Log("OK");
        }
        else
        {
            Debug.Log("NG");
        }
    }
}



