using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private Transform playerTransform;
    private Vector3 offset;
    [SerializeField] private float cameraFollowSpeed;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        

        Vector3 targetToMove=playerTransform.position+ offset;
        transform.position = Vector3.Lerp(transform.position,targetToMove,cameraFollowSpeed*Time.deltaTime);
        transform.LookAt(playerTransform.position);
    }
}
