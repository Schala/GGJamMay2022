using UnityEngine;

// Common behavior/traits for inventory items
public interface IInventoryItem
{
	// Icon displayed in inventory
	public Texture2D Icon { get; set; }

	// Item name
	public string Name { get; set; }

	// Comment
	public string Comment { get; set; }

	// Maximum number of instances allowed
	public int MaxCount { get; set; }
}
