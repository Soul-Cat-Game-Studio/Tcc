using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "InventoryEvents", menuName = "Unbound_Master_Piece/InventoryEvents", order = 0)]
public class InventoryEvents : ScriptableObject
{
  public event UnityAction UpdateInventoryEvent = delegate { };

  public void UpdateInventory(){ UpdateInventoryEvent.Invoke();}
}
