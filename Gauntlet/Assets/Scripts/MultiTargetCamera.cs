using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiTargetCamera : MonoBehaviour
{
    public List<Transform> cameraTargets;
    private GameObject[] _players;

    public float smoothTime = .5f;
    public float minZoom = 40.0f;
    public float maxZoom = 10.0f;
    public float zoomLimiter = 50.0f;
    public Vector3 offset;

    private Vector3 velocity;
    private Camera cam;

    private void Start()
    {
        cam = GetComponent<Camera>();
    }

    private void Update()
    {
        _players = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject i in _players)
        {
            if (!cameraTargets.Contains((i.GetComponent<Transform>())))
                cameraTargets.Add(i.GetComponent<Transform>());
        }
    }

    private void LateUpdate()
    {
        if (cameraTargets.Count == 0)
            return;

        CameraMove();
        CameraZoom();
    }

    private void CameraMove()
    {
        Vector3 centerPoint = GetCenterPoint();

        Vector3 newPosition = centerPoint + offset;

        transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothTime);
    }

    private void CameraZoom()
    {
        float newZoom = Mathf.Lerp(maxZoom, minZoom, GetGreatestDistance() / zoomLimiter);
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, newZoom, Time.deltaTime);
    }

    private float GetGreatestDistance()
    {
        var bounds = new Bounds(cameraTargets[0].position, Vector3.zero);
        for (int i = 0; i < cameraTargets.Count; i++)
        {
            bounds.Encapsulate(cameraTargets[i].position);
        }

        return bounds.size.x;
    }

    private Vector3 GetCenterPoint()
    {
        if (cameraTargets.Count == 1)
        {
            return cameraTargets[0].position;
        }

        var bounds = new Bounds(cameraTargets[0].position, Vector3.zero);
        for (int i = 0; i < cameraTargets.Count; i++)
        {
            bounds.Encapsulate(cameraTargets[i].position);
        }

        return bounds.center;
    }
}
