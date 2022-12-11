using UnityEngine;

public class VisionSlideEditor : MonoBehaviour
{
	public int slideIndex;
	public bool nextSlide;
	public bool previousSlide;
	public bool refreshSlide;
	[Space]
	public Transform playerRoot;
	public Camera camera;
	public bool saveCamera;
	[Space]
	public bool copyCameraFromPrevious;
	[Space]
	public VisionSlide[] slides;

	private void OnValidate()
	{
		if (nextSlide)
		{
			nextSlide = false;
			slideIndex++;
			if (slideIndex > slides.Length - 1)
			{
				slideIndex = 0;
			}
			ChangeSlide();
		}
		if (previousSlide)
		{
			previousSlide = false;
			slideIndex--;
			if (slideIndex < 0)
			{
				slideIndex = slides.Length - 1;
			}
			ChangeSlide();
		}
		if (refreshSlide)
		{
			refreshSlide = false;
			ChangeSlide();
		}
		if (saveCamera)
		{
			saveCamera = false;
			if (slides.Length != 0 && slideIndex >= 0 && slideIndex < slides.Length)
			{
				slides[slideIndex].localPosition = playerRoot.localPosition;
				slides[slideIndex].localEulerAngles = playerRoot.localEulerAngles;
				slides[slideIndex].cameraTilt = camera.transform.localEulerAngles.x;
				slides[slideIndex].cameraFOV = camera.fieldOfView;
			}
		}
		if (copyCameraFromPrevious)
		{
			copyCameraFromPrevious = false;
			UpdateCamera(slideIndex - 1);
		}
	}

	private void ChangeSlide()
	{
		for (int i = 0; i < slides.Length; i++)
		{
			slides[i].SetActive(i == slideIndex);
		}
		UpdateCamera(slideIndex);
	}

	private void UpdateCamera(int index)
	{
		if (index >= 0 && index <= slides.Length - 1)
		{
			playerRoot.localPosition = slides[index].localPosition;
			playerRoot.localEulerAngles = slides[index].localEulerAngles;
			camera.transform.localEulerAngles = new Vector3(slides[index].cameraTilt, 0f, 0f);
			camera.fieldOfView = slides[index].cameraFOV;
		}
	}

	private void OnDrawGizmos()
	{
		for (int i = 0; i < slides.Length; i++)
		{
			Gizmos.color = ((i == slideIndex) ? Color.red : Color.yellow);
			Gizmos.DrawSphere(slides[i].localPosition, 0.1f);
			Quaternion quaternion = Quaternion.Euler(slides[i].localEulerAngles);
			Gizmos.DrawRay(slides[i].localPosition + Vector3.up * 0.1f, quaternion * Vector3.forward);
		}
	}
}