using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPoint : MonoBehaviour
{

    [SerializeField]
    Transform originPoint;
    [SerializeField]
    GameObject player;
    [SerializeField] Camera playerHead;

    private void Awake()
    {
        ResetPosition();
    }

    [ContextMenu("Reset Position")]
    public void ResetPosition()
    {
        var rotationAngleY = originPoint.rotation.eulerAngles.y - playerHead.transform.eulerAngles.y;
        player.transform.Rotate(0, rotationAngleY, 0);

        var distanceDiff = originPoint.position - playerHead.transform.position;
        player.transform.position += distanceDiff;
    }
}
