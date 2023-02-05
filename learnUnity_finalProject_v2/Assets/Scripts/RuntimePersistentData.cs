using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Current Scene Data", menuName = "Current Scene Data", order = 1)]
public class RuntimePersistentData : ScriptableObject
{

    //Any data we want to store
    public string currentUser;
    public float currentDataIWantToStoreEx;

}
