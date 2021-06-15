using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Note", menuName = "Unbound_Master_Piece/Note", order = 0)]
public class Note : ScriptableObject
{
    public string title = "";

    [TextArea(15, 20)]
    public string description = "";
}

