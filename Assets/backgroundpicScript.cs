using UnityEngine;
using UnityEngine.UI;  // To access UI components like Image

public class BackgroundManager : MonoBehaviour
{
    public Image backgroundImage; // Reference to the background image
    public float scrollSpeed = 2f; // Speed of background scrolling
    public float resetPositionX = -10f; // Where the background should reset after scrolling off screen
    public float startPositionX = 0f; // Starting position of the background

    void Start()
    {
        // Ensure the background image is assigned
        if (backgroundImage == null)
        {
            Debug.LogError("Background Image not assigned!");
        }
        else
        {
            // Set the starting position of the background image
            backgroundImage.rectTransform.anchoredPosition = new Vector2(startPositionX, 0f);
        }
    }

    void Update()
    {
        // Scroll the background by moving it left
        backgroundImage.rectTransform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);

        // If the background has moved past the reset position, reset its position
        if (backgroundImage.rectTransform.anchoredPosition.x <= resetPositionX)
        {
            backgroundImage.rectTransform.anchoredPosition = new Vector2(startPositionX, 0f);
        }
    }
}
