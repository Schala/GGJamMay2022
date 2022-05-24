using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
	[SerializeField] GameObject ui = null;
	Dictionary<IInventoryItem, int> items; // item instance, count

    // Update is called once per frame
    void Update()
    {
        
    }

	// Add item to inventory with optional quantity
	void Add(IInventoryItem item, int quantity = 1) => items.Add(item, quantity);

	// Remove item from inventory with optional quantity
	void Remove(IInventoryItem item) => items.Remove(item);
}
