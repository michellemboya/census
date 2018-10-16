using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine2 : MonoBehaviour
{

    private LineRenderer lineRenderer;
    private float counter;

    private float dist;

    public Transform origin;
    public Transform destination;

    public float linewidthstart = 0.45f;
    public float linewidthend = 0.45f;



    public float lineDrawSpeed = 6f;

    // Use this for initialization
    void Start()
    {
        //caching the line renderer...saying that we are getting component LineRenderer on the object. So this means we can call functions on the line renderer.
        lineRenderer = GetComponent<LineRenderer>();
        //0 is for first position of the line and then feed into a vector. Origin is a transform
        lineRenderer.SetPosition(0, origin.position);
        lineRenderer.startWidth = linewidthstart;
        lineRenderer.endWidth = linewidthend;

        dist = Vector3.Distance(origin.position, destination.position);

    }

    // Update is called once per frame
    void Update()

    {
        counter += 0.1f / lineDrawSpeed;
        lineRenderer.SetPosition(1, Vector3.Lerp(origin.position, destination.position, counter));
        lineRenderer.SetPosition(0, Vector3.Lerp(destination.position, origin.position, counter));

    }

}