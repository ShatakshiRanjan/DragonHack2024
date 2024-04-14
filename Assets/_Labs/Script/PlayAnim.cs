using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnim : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private string doorOpen = "Door";
    private void OnTriggerEnter(Collider other)
    {
        myDoor.Play(doorOpen, 0, 0.0f);
    }
}
