using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Random = UnityEngine.Random;
public class Submit : MonoBehaviour
{
    public Button yourButton;
    public ReadInput ageGet;
    public WeScan weGet;
    string ageI;
    string we;
    public GameObject menu;
    public GameObject after;
    public Text he;
    public Text weight;
    public Text tip;
    public double H;
    public double W;
    public double bmi;
    public Text bmiD;
    public Text main;
    // Start is called before the first frame update
    void Start()
    {
        after.SetActive(false);
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TaskOnClick() {
        ageI = (ageGet.getAge());
       we=weGet.getWe();
        after.SetActive(true);
        he.text = "Height is " + ageI + " inches";
        weight.text = "Weight is " + we + " lbs";
       
        H = Convert.ToDouble(ageI);
        W = Convert.ToDouble(we);
        bmi = Math.Round((703 * W / (H*H)),2);
        bmiD.text = "Your BMI is " + bmi;

        if (bmi >= 30)
        {
            tip.text = tip.text + "BMIs OVER 30 ARE CONSIDERED OBESE!";
            int rand = (int)Random.Range(0f, 2f);
            if (rand == 0)
            {
                main.text = main.text + "Eat a balanced, calorie-controlled diet as recommended by your GP or weight loss management health professional (such as a dietitian)";
            }
            else if (rand == 1) {
                main.text = main.text + "Take up activities such as fast walking, jogging, swimming or tennis for 150 to 300 minutes (two-and-a-half to five hours) a week";
            }
            else if (rand == 2)
            {
                main.text = main.text + "Eat slowly and avoid situations where you know you could be tempted to overeat";
            }
        }
        else if (bmi >= 25.0 && bmi < 30)
        {
            main.text = main.text + "BMIs BETWEEN 25 and 29.9 ARE CONSIDERED OVERWEIGHT!";
            int rand = (int)Random.Range(0f, 2f);
            if (rand == 0)
            {
                main.text = main.text + "Don’t be afraid to load your plate with leafy green vegetables. They’re packed with nutrients, and you can eat very large amounts without greatly increasing calories and carbs.";


            }
            else if (rand == 1)
            {
                main.text = main.text + "Your body still requires healthy fats no matter what eating plan you choose. Olive oil and avocado oil are great choices for including in your eating plan.";
            }
            else if (rand == 2)
            {
                main.text = main.text + "Try going to the gym three to four times a week to lift weights. If you’re new to the gym, ask a trainer for some advice. Make sure your doctor is also aware of any new exercise plans.";
            }
        }
        else if (bmi >= 18.5 && bmi < 25)
        {
            main.text = main.text + "BMIs BETWEEN 18.5 and 24.9 ARE CONSIDERED NORMAL!";
            int rand = (int)Random.Range(0f, 2f);
            if (rand == 0)
            {
                main.text = main.text + "You have the perfect BMI. But don't stop doing what you are doing right now! Keep these habits!";


            }
            else if (rand == 1)
            {
                main.text = main.text + "Your body still requires healthy fats no matter what eating plan you choose. Olive oil and avocado oil are great choices for including in your eating plan.";
            }
            else if (rand == 2)
            {
                main.text = main.text + "Try walking or jogging every few days to keep yourself healthy!";
            }
        }
        else if (bmi < 18.5)
        {
            main.text = main.text + "BMIs BELOW 18.5 ARE CONSIDERED UNDERWEIGHT!";
            int rand = (int)Random.Range(0f, 2f);
            if (rand == 0)
            {
                main.text = main.text + "For anyone looking to gain weight, milk can be added to the diet throughout the day.";


            }
            else if (rand == 1)
            {
                main.text = main.text + "A cup of rice contains about 200 caloriesTrusted Source, and it is also a good source of carbohydrates, which contribute to weight gain. Many people find it easy to incorporate rice into meals containing proteins and vegetables.";
            }
            else if (rand == 2)
            {
                main.text = main.text + "Consuming nuts regularly can help a person to gain weight safely. Nuts are a great snack and can be added to many meals, including salads. Raw or dry roasted nuts have the most health benefits.";
            }
        }


        menu.SetActive(false);
    }
    public string getHe()
    {
        return ageI;

    }
    public string getWe()
    {
        return we;

    }

}
