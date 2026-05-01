using UnityEngine;

public class LightToggleController : MonoBehaviour
{
    public Light fireLight;
    public Light cupLight;
    public Light flashlightLight;

    public void ToggleFire()
    {
        fireLight.enabled = !fireLight.enabled;
    }

    public void ToggleCup()
    {
        cupLight.enabled = !cupLight.enabled;
    }

    public void ToggleFlashlight()
    {
        flashlightLight.enabled = !flashlightLight.enabled;
    }
}