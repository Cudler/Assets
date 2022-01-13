using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New SpawnTable", menuName = "RPG/New SpawnTable")]
public class SpawnTable : ScriptableObject
{
    public Enemy[] spawns;
}
