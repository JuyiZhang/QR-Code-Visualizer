using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

public class QRObjectTouchHandle : MonoBehaviour, IMixedRealityTouchHandler
{
    [SerializeField]
    private Canvas displayCanvas;

    [SerializeField]
    private GameObject qrCodeGameObject;

    public void OnTouchStarted(HandTrackingInputEventData eventData)
    {
        string ptrName = eventData.InputSource.SourceName;
        Debug.Log($"Touch Started From {ptrName}");
    }

    public void OnTouchCompleted(HandTrackingInputEventData eventData) { }
    public void OnTouchUpdated(HandTrackingInputEventData eventData) { }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCloseCanvas()
    {
        displayCanvas.enabled = false;
        qrCodeGameObject.SetActive(true);
    }
}
