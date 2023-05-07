using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    [SerializeField]private Transform playerTransform;
    private Vector3 initialRoration;
    private void Awake()
    {
        initialRoration = transform.eulerAngles;
    }
    private void Update()
    {
        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, playerTransform.position.z);
        transform.eulerAngles = new Vector3(playerTransform.eulerAngles.x + initialRoration.x, playerTransform.eulerAngles.y + initialRoration.y, 0);
    }

}
