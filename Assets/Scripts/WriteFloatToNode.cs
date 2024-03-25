using System.Collections;
using System.Collections.Generic;
using realvirtual;
using UnityEngine;

public class WriteFloatToNode : MonoBehaviour
{
    public OPCUA_Interface oPCUAInterface;
    // Start is called before the first frame update
    public void WriteToNode(string nodeID, float value)
    {
        oPCUAInterface.WriteNodeValue(nodeID, value);
    }
}
