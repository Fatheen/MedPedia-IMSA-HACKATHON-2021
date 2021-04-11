using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DiseaseS : MonoBehaviour
{
    public Text output;
    public void HandleInputData(int val) {
        //Flu
        if (val == 1) {
            output.text = "Avoid close contact, stay home when you are sick, cover your mouth and nose, clean your hands, avoid touching your eyes, nose or mouth, practice other good hygienic habits. The flu is treated primarily with rest and fluid to let the body fight the infection on its own. Over-the-counter anti-inflammatory pain relievers may help with symptoms.";
        }
        //Default
        if (val == 0)
        {
            output.text = "Please select an option in the dropdown in the left";
        }
        //Covid
        if (val == 2)
        {
            output.text = "To prevent: Use protective equipment like masks and hand sanitizer. Practice social distancing if you are sick. Stay home except to get medical care. Seperate yourself from others, and register for vaccines when available.";
        }
        //Alzheimer's Disease
        if (val == 3) {
            output.text = "Alzheimer's worsens over time. Alzheimer's is a progressive disease, where dementia symptoms gradually worsen over a number of years. In its early stages, memory loss is mild, but with late-stage Alzheimer's, individuals lose the ability to carry on a conversation and respond to their environment.(What is Alzheimer's Disease? Symptoms & Causes | alz.org) Scientists do not know exactly what role plaques and tangles play in Alzheimer's disease. Most experts believe they somehow play a critical role in blocking communication among nerve cells and disrupting processes that cells need to survive. Sadly, No cure exists, but medications and management strategies may temporarily improve symptoms.";
            // Stroke
        
        }
        if (val == 4)
        {
            output.text = "Risk factors for stroke include: high blood pressure family history of stroke smoking, especially when combined with oral contraceptives, being African-American, being female. Some risk factors of strokes can be reduced with preventative care, medications, and lifestyle changes. In general, good health habits can lower your risk. You should also maintain a healthy lifestyle, complete with regular exercise and a healthy diet that’s low in sodium. Avoid smoking, and drink only in moderation, as these activities increase your risk of stroke. ";
        }
        if (val == 5) {
            output.text = "A disease caused by a plasmodium parasite, transmitted by the bite of infected mosquitoes. Symptoms are chills, fever, and sweating, usually occurring a few weeks after being bitten. Treatment includes antimalarial drugs. Please see your local doctor.";
        }
        if (val == 6) {
            output.text = "A potentially serious infectious bacterial disease that mainly affects the lungs. Requires a medical diagnosis. Most people infected with the bacteria that cause tuberculosis don't have symptoms. When symptoms do occur, they usually include cough. SEE YOUR LOCAL DOCTOR.";
    
        }
        if (val == 7) {
            output.text = "HIV causes AIDS and interferes with the body's ability to fight infections.The virus can be transmitted through contact with infected blood and other bodily fluids. Within a few weeks of HIV infection, flu-like symptoms such as fever, sore throat, and fatigue can occur. Then the disease is usually asymptomatic until it progresses to AIDS. AIDS symptoms include weight loss, fever or night sweats, fatigue, and recurrent infections. There is no cure as of yet, but there are medications that slow the effect.";
        }
    }
}
