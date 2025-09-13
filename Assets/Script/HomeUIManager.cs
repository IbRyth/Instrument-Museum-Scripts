using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeUIManager : MonoBehaviour
{
    public GameObject FocusCameraObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void KeyPresss(string direction)
    {
        FocusCameraObj.GetComponent<FocusCameraManger>().setDirection(direction);
    }

    public void KeyUp(string direction)
    {
        FocusCameraObj.GetComponent<FocusCameraManger>().ResetDirection(direction);
    }

    public void addRatio(bool isAdd) {

        FocusCameraObj.GetComponent<FocusCameraManger>().addRatio(isAdd);
    }
}