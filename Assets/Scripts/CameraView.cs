using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class CameraView : MonoBehaviour
{
    [SerializeField] private float sensitivity;
    [SerializeField] private float deceleration;
    [SerializeField] private float angleMin;
    [SerializeField] private float angleMax;
    private Vector2 lastClick;
    private Vector2 delta;
    private Camera mainCam;
    private void Start()
    {
        mainCam = Camera.main;
    }
    private void OnGUI()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Vector2 tempDelta = lastClick - (Vector2)mainCam.ScreenToViewportPoint(Input.mousePosition);
                delta = Mathf.Abs(tempDelta.x) > Mathf.Abs(delta.x) ? tempDelta : delta;
                // delta = tempDelta;
            }
        }
        transform.Rotate(0, delta.x * sensitivity, 0);
        if (!EventSystem.current.IsPointerOverGameObject())
            lastClick = mainCam.ScreenToViewportPoint(Input.mousePosition);
    }

    private void Update()
    {
        delta = Vector2.Lerp(delta, new(), Time.deltaTime * deceleration);

    }
}
