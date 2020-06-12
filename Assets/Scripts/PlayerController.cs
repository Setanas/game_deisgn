using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int width, height;
    private Rect rect;
    private GUIStyle labelStyle;
    private string currentTime;

    private Rigidbody rb;
    public float speed;

    void Start()
    {
        width = Screen.width;
        height = Screen.height;
        rect = new Rect(0, 0, width / 6, height / 10);
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");



        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);

    }
    void OnGUI()
    {
        // Display the label at the center of the window.
        labelStyle = new GUIStyle(GUI.skin.GetStyle("label"));
        labelStyle.alignment = TextAnchor.MiddleCenter;

        // Modify the size of the font based on the window.
        labelStyle.fontSize = 6 * (width / 200);

        // Obtain the current time.
        currentTime = Time.timeSinceLevelLoad.ToString("f6");
        currentTime = "Your time is: " + currentTime;

        // Display the current time.
        GUI.Label(rect, currentTime, labelStyle);
    }
}