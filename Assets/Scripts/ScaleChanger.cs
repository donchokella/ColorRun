using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChanger : MonoBehaviour, IInteractable, IScaleChanger
{
    private void ScaleMethod(){

        Debug.Log("111");
    }
    public void BeCollected()
    {
        ScaleMethod();
    }
}
