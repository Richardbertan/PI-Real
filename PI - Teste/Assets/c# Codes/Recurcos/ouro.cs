using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ouro : MonoBehaviour
{
    public static float increaseRate;
    void OnEnable ()
    {
        increaseRate = 10f;
    }
    void OnDisable ()
    {
        increaseRate = 0;
    }
}
