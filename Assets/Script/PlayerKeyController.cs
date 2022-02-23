using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyController : MonoBehaviour
{

    [SerializeField] KeyType Key;

    private List<PickableObjectData> pickableObjectDatas = new List<PickableObjectData>();

    public bool HasObject(KeyType type)
    {
        foreach (PickableObjectData data in pickableObjectDatas)
        {
            if (data.KeyType == type)
            {
                return true;
            }
        }
        return false;
    }

    public void AddObject(PickableObjectData pickableObjectData)
    {
        pickableObjectDatas.Add(pickableObjectData);
    }

}
public class PickableObjectData
{
    public KeyType KeyType;

    public PickableObjectData(KeyType keyType)
    {
        KeyType = keyType;
    }

}
public enum KeyType
{
    Red,
    Brown,
    Blue
}
