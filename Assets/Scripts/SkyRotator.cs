using UnityEngine;

public class SkyRotator : MonoBehaviour
{
    private void Start()
    {
        Debug.LogFormat("{0}: SkyRotator Start()", gameObject.name);
    }
    private void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time);
    }
}
