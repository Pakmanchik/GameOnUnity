using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HPUI : MonoBehaviour
{

	public float		maxValue = 100;
	public Color		color = Color.red;//Цвет жизни
	public int			width = 4;
	public Slider		slider;
	public bool			isRight;
	public static float current;

	void Start()
	{
		slider.fillRect.GetComponent<Image>().color = color;
		slider.maxValue = maxValue;
		slider.minValue = 0;
		current = maxValue;

		UpdateUI();
	}

	public static float currentValue
	{
		get { return current; }
	}

	void Update()
	{
		if (current < 0) current = 0;
		if (current > maxValue) current = maxValue;
		slider.value = current;
	}

	void UpdateUI()
	{

		RectTransform rect = slider.GetComponent<RectTransform>();

		int rectDeltaX = Screen.width / width;
		float rectPosX = 0;

		if (isRight)
		{
			rectPosX = rect.position.x - (rectDeltaX - rect.sizeDelta.x) / 2;
			slider.direction = Slider.Direction.RightToLeft;
		}
		else
		{
			rectPosX = rect.position.x + (rectDeltaX - rect.sizeDelta.x) / 2;
			slider.direction = Slider.Direction.LeftToRight;
		}

		rect.sizeDelta = new Vector2(rectDeltaX, rect.sizeDelta.y);
		rect.position = new Vector3(rectPosX, rect.position.y, rect.position.z);
	}

	public static void AdjustCurrentValue(float adjust)
	{
		current += adjust;
	}
}