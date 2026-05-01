using UnityEngine;

public class FlickerLight : MonoBehaviour
{
    public Light targetLight;
    public float minIntensity = 2f;
    public float maxIntensity = 4f;
    public float flickerSpeed = 5f;

    void Start()
    {
        if (targetLight == null)
        {
            targetLight = GetComponent<Light>();
        }
    }

    void Update()
    {
        if (targetLight != null)
        {
            targetLight.intensity = Mathf.Lerp(
                minIntensity,
                maxIntensity,
                Mathf.PerlinNoise(Time.time * flickerSpeed, 0f)
            );
        }
    }
}