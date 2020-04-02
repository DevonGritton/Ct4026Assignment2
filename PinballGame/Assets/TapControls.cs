using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapControls : MonoBehaviour
{
    private Dictionary<int, GameObject> Tapfeedback = new Dictionary<int, GameObject>();
    public TouchscreenLeft Left;
    public Touchcontrols Right;
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch Touch = Input.touches[i];
            GameObject sphere = GetOrCreateSphere(Touch.fingerId);

            switch (Touch.phase)
            {
                case TouchPhase.Began:
                    sphere.SetActive(true);
                    break;
                case TouchPhase.Moved:
                    sphere.transform.position = GetWorldPosition(Touch.position);
                    break;
                case TouchPhase.Stationary:
                    break;
                case TouchPhase.Ended:
                    sphere.SetActive(false);
                    Right.Ractive = false;
                    Left.Lactive = false;
                    break;
                case TouchPhase.Canceled:
                    sphere.SetActive(false);
                    break;
            }
            if (Input.touchCount == 1)
            {
                //Touch Touch = Input.touches[i];
                if (Touch.position.x > Screen.width / 2)
                {
                    Right.Ractive = true;
                }

                else if (Touch.position.x < Screen.width / 2)
                {
                    Left.Lactive = true;
                }
            }
        }
    }
    GameObject GetOrCreateSphere(int id)
    {
        if (Tapfeedback.ContainsKey(id))
        {
            return Tapfeedback[id];
        }
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.GetComponent<MeshRenderer>().material.color = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
        Tapfeedback.Add(id, sphere);
        return sphere;
    }
    Vector3 GetWorldPosition(Vector2 screenPosition)
    {
        Vector3 screenPositionWidthZ = screenPosition;
        screenPositionWidthZ.z = -Camera.main.transform.position.z;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(screenPositionWidthZ);
        return worldPosition;
    }
}


