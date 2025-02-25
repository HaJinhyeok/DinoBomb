using UnityEngine;

public class RightButtonController : MonoBehaviour
{
    public GameObject DinoPlayer;

    bool _isButtonPressed;

    void Update()
    {
        if (_isButtonPressed)
        {
            DinoPlayer.transform.Translate(Vector3.right * 3 * Time.deltaTime);
            Vector3 currentPos = DinoPlayer.transform.position;
            currentPos.x = Mathf.Clamp(DinoPlayer.transform.position.x, -2.5f, 2.5f);
            DinoPlayer.transform.position = currentPos;
            DinoPlayer.transform.localScale = new Vector3(1, 1, 1);
        }
    }

    public void PointerDown()
    {
        _isButtonPressed = true;
    }

    public void PointerUp()
    {
        _isButtonPressed = false;
    }
}
