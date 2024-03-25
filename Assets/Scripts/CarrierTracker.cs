using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CarrierTracker : MonoBehaviour
{
    public GameObject orderPrefab;
    public Animator animator;
    private NodeReader nodeReader;
    public bool spawnUnavailable;
    public Transform parentTransform;
    // Start is called before the first frame update
    void Start()
    {
        nodeReader = GetComponent<NodeReader>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(nodeReader.dataFromOPCUANode != null) 
        {
            GameObject order;
            if(nodeReader.hasNodeChanged) {
                nodeReader.hasNodeChanged = false;
                switch (nodeReader.factoryMachineID)
                {
                    case 1:
                        if (!spawnUnavailable)
                        {
                            StartCoroutine("SpawnDelay");
                            order = Instantiate(orderPrefab, parentTransform);
                            order.SetActive(true);
                            order.GetComponent<Animator>().Play("Factory2Robot");
                            order.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = nodeReader.dataFromOPCUANode;
                            Debug.LogError("Instantiated at Five");
                        }
                        break;
                    //case 2:
                    //    order = Instantiate(orderPrefab);
                    //    order.SetActive(true);
                    //    order.GetComponent<Animator>().Play("Branch2FrontMag");
                    //    Debug.LogError("Instantiated at Four");
                    //    break;

                    //case 3:
                    //    order = Instantiate(orderPrefab);
                    //    order.SetActive(true);
                    //    order.GetComponent<Animator>().Play("Branch2FrontMag");
                    //    Debug.LogError("Instantiated at Four");
                    //    break;

                    //case 4:
                    //    if (!spawnUnavailable)
                    //    {
                    //        StartCoroutine("SpawnDelay");
                    //        order = Instantiate(orderPrefab);
                    //        order.GetComponent<Animator>().Play("Branch2FrontMag");
                    //        Debug.LogError("Instantiated at Four");
                    //    }
                    //    break;

                    case 5:
                        if (!spawnUnavailable)
                        {
                            StartCoroutine("SpawnDelay");
                            order = Instantiate(orderPrefab, parentTransform);
                            order.SetActive(true);
                            order.GetComponent<Animator>().Play("FrontMag2Measuring");
                            order.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = nodeReader.dataFromOPCUANode;
                            Debug.LogError("Instantiated at Five");
                        }
                        
                        break;

                    case 6:
                        if (!spawnUnavailable)
                        {
                            StartCoroutine("SpawnDelay");
                            order = Instantiate(orderPrefab, parentTransform);
                            order.SetActive(true);
                            order.GetComponent<Animator>().Play("StraightMoveMeasure2Drill");
                            order.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = nodeReader.dataFromOPCUANode;
                            //order.transform.Find("Value").GetComponent<TMP_Text>().text = nodeReader.dataFromOPCUANode;
                            Debug.LogError("Instantiated at Six");
                        }
                        
                        break;

                    case 7:
                        if (!spawnUnavailable)
                        {
                            StartCoroutine("SpawnDelay");
                            order = Instantiate(orderPrefab, parentTransform);
                            order.SetActive(true);
                            order.GetComponent<Animator>().Play("Drill2BackMag");
                            order.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = nodeReader.dataFromOPCUANode;
                            //order.transform.Find("Value").GetComponent<TMP_Text>().text = nodeReader.dataFromOPCUANode;
                            Debug.LogError("Instantiated at Seven");
                        }
                        break;

                    case 8:
                        if (!spawnUnavailable)
                        {
                            StartCoroutine("SpawnDelay");
                            order = Instantiate(orderPrefab, parentTransform);
                            order.SetActive(true);
                            order.GetComponent<Animator>().Play("BackMag2Press");
                            order.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = nodeReader.dataFromOPCUANode;
                            //order.transform.Find("Value").GetComponent<TMP_Text>().text = nodeReader.dataFromOPCUANode;
                            Debug.LogError("Instantiated at Eight");
                        }
                        
                        break;

                    case 9:
                        if (!spawnUnavailable)
                        {
                            StartCoroutine("SpawnDelay");
                            order = Instantiate(orderPrefab, parentTransform);
                            order.SetActive(true);
                            order.GetComponent<Animator>().Play("Press2Branch");
                            order.transform.GetChild(0).GetChild(1).GetComponent<TMP_Text>().text = nodeReader.dataFromOPCUANode;
                            //order.transform.Find("Value").GetComponent<TMP_Text>().text = nodeReader.dataFromOPCUANode;
                            Debug.LogError("Instantiated at Nine");
                        }
                        break;

                    default:
                        if (!spawnUnavailable)
                        {
                            StartCoroutine("SpawnDelay");
                            order = Instantiate(orderPrefab, parentTransform);
                            order.GetComponent<Animator>().Play("Branch2FrontMag");
                            Debug.LogError("Instantiated at Four");
                        }
                        break;


                }
                
            }
        }
    }

    public IEnumerator SpawnDelay()
    {
        spawnUnavailable = true;

        yield return new WaitForSeconds(2f);

        spawnUnavailable = false;
    }
}
