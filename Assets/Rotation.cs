using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    [Header("Вокруг чего происходит вращение")]
    public Transform Rotate;
    [Header("Скорость вращения (градусы в секунду)")]
    public float speed = 0;

    void Update()
    {
        gameObject.transform.RotateAround(Rotate.position, Vector3.up, speed * Time.deltaTime);
    }
}

