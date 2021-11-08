using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider2D))]
public class RestartButton : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Left mouse button click.
        if (Input.GetMouseButtonDown(0)) {
            // Get the position of the mouse in world space.
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            // Determine if we clicked on something (with a Collider2D on it)
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            // If we did...
            if (hit.collider != null && hit.collider.gameObject == this.gameObject) {
                // Go back to play screen.
                SceneManager.LoadScene("FlappyBird");
            }
        }
    }
}
