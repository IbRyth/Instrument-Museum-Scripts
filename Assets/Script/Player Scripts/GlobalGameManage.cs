using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalGameManage : MonoBehaviour
{
    public GameObject Avatar;
    public GameObject AvatarPrefab;
    public static GameObject AvatarInstance;
    public float value;
    // Start is called before the first frame update
    public void Start()
    {
        if (AvatarInstance == null)
        {
            Avatar = Instantiate(AvatarPrefab, new Vector3(0f, 0f, 0f), Quaternion.identity);
            AvatarInstance = Avatar;
        }
        else
        {
            Avatar = AvatarInstance;

        }

    }

}