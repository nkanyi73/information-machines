using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CurrentOrdersTableUpdater : MonoBehaviour
{
    public CurrentOrders currentOrders;

    public GameObject orderPrefab; // Prefab of the order UI element
    public Transform contentParent; // Parent transform where orders will be instantiated


    // Method to populate the table with orders
    public void PopulateOrders()
    {
        GameObject[] currentOrdersArray = GameObject.FindGameObjectsWithTag("CurrentOrder");
        // Clear existing orders from the table
        for (int i = 0; i < currentOrdersArray.Length; i++)
        {
            Destroy(currentOrdersArray[i]);
        }
        Debug.LogError(currentOrders.currentOrdersObjectArray);

        // Populate the table with new orders
        foreach (CurrentOrderJSON order in currentOrders.currentOrdersObjectArray)
        {
            GameObject orderUI = Instantiate(orderPrefab, contentParent);
            HorizontalLayoutGroup layoutGroup = orderUI.GetComponent<HorizontalLayoutGroup>();
            // Set UI elements in orderUI with order details
            orderUI.transform.Find("Order Number").GetComponent<TMP_Text>().text = order.ONo.ToString();
            orderUI.transform.Find("Customer").GetComponent<TMP_Text>().text = order.Company;
            orderUI.transform.Find("State").GetComponent<TMP_Text>().text = order.State;
            orderUI.transform.Find("Planned Start").GetComponent<TMP_Text>().text = order.PlannedStart;
            orderUI.transform.Find("Planned End").GetComponent<TMP_Text>().text = order.PlannedEnd;
            // Set other UI elements similarly
            orderUI.SetActive(true);
            layoutGroup.padding.top = 2;
            layoutGroup.padding.bottom = 2;
        }
    }
}
