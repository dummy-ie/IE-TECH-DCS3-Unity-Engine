## Toon Shaded Material
Step by step guide to creating a Toon shaded material with an existing Base Color texture and Normal Map texture

1. In the Unity Editor, right click the "Toon Template" material and go to Create -> Material Variant. Name your new material and place it in an appropriate folder.

![Material Variant option in Unity File Explorer](Tutorial%20Images/Step1.png)

2. Select your material in the project explorer. In the Inspector, go to the "Three Color and Control Map Settings" and drag your base texture into the slot to the left of the "Base Map" option. 

![Shader Base Map Settings](Tutorial%20Images/Step2.png)

3. In the Inspector, find the "Normal Map Settings" below. Drag your normal map texture into the slot to the left of the "Normal Map" option.

![Shader Normal Map Settings](Tutorial%20Images/Step3.png)

4. If the model has an emission texture, you will find the "Emission Settings" in the Inspector below as well. Drag the emissive map texture into the slot to the left of the "Emission Map" option.

5. you are done.