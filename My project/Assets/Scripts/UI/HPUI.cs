using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HPUI : MonoBehaviour
{

	private float		maxValue;
	public Color		color = Color.red;//Цвет жизни
	public int			width = 4;
	public Slider		slider;
	public bool			isRight;
	public  float current;
	private HeroFighter heroFighter;
	
	private FighterAttak fg;

	void Start()
	{
		 heroFighter = GetComponent<HeroFighter>();
		heroFighter.SettingsHero();
		maxValue = heroFighter.HealthHero;
		fg = GetComponent<FighterAttak>();

		slider.fillRect.GetComponent<Image>().color = color;
		slider.maxValue = maxValue;
		slider.minValue = 0;
		current = maxValue;
		UpdateAttake();
		UpdateUI();
	}

	

	 public void UpdateAttake()
	{

		if (current < 0) current = 0;
		if (current > maxValue) current = maxValue;
		slider.value = current;
		current -= fg.enemy._damage;
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

	public  void AdjustCurrentValue(float adjust)
	{
		current -= adjust;
	}
}