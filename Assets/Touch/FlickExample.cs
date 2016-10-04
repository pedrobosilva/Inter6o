using System;
using UnityEngine;
using TouchScript.Gestures;

public class FlickExample : MonoBehaviour {
    private Rigidbody rb;
    public  Camera    myCamera;
    public  float     forceMultiplier = 3;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable() {
        GetComponent<FlickGesture>().Flicked += OnFlick;
    }

    private void OnDisable() {
        GetComponent<FlickGesture>().Flicked -= OnFlick;
    }

    private void OnFlick(object sender, EventArgs e) {
        var gesture = sender as FlickGesture;

        float distanceFromCamera = Vector3.Distance(transform.position, Camera.main.transform.position);

        Vector3 wp1 = new Vector3(gesture.PreviousScreenPosition.x, gesture.PreviousScreenPosition.y, distanceFromCamera);
        wp1 = myCamera.ScreenToWorldPoint(wp1);

        Vector3 wp2 = new Vector3(gesture.ScreenPosition.x, gesture.ScreenPosition.y, distanceFromCamera);
        wp2 = myCamera.ScreenToWorldPoint(wp2);

        Vector3 velocity = forceMultiplier * (wp2 - wp1) / gesture.FlickTime;

        rb.AddForce(velocity, ForceMode.VelocityChange);
    }
}
