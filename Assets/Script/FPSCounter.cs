
using UnityEngine;
using TMPro;

public class FPSCounter : MonoBehaviour
{
    public TextMeshProUGUI FpsText;
    public TextMeshProUGUI msPerFrameText;

    public float pollingTime = 3f;
    private float time;
    private int frameCount;


    void Update()
    {
        time += Time.deltaTime;

        frameCount++;

        if (time >= pollingTime)
        {
            int frameRate = Mathf.RoundToInt(frameCount / time);
            float milisecondsPerFrame = 1000.0f / frameRate;

            // Display FPS
            FpsText.text = frameRate.ToString() + " FPS";

            // Display miliseconds per frame
            msPerFrameText.text = milisecondsPerFrame.ToString("F2") + " ms/frame";

            time -= pollingTime;
            frameCount = 0;

            
        }
    }

}
