using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DartController : MonoBehaviour
{

    public GameController gameController;

    private void OnCollisionEnter(Collision obj)
    {
        gameController.TargetHit(obj.gameObject);
    }
}
