# MRTK-Passthrough

*Those looking to integrate Passthrough and MRTK in an existing project, or advice on how to record Passthrough video see the end of this description*

This is an example project of MRTK's built-in samples that are relevant to Quest.
These are primarily made for Hololens 2, and with Passthrough now available on Quest, one can get a taste of the experience a true AR device can offer.

This project uses Unity 2021.1.22f1

MRTK is a great open source library for AR/VR devices that offers many systems for development.
Check out their documentation for a comlete list of features [here](https://docs.microsoft.com/en-us/windows/mixed-reality/mrtk-unity/?view=mrtkunity-2021-05).

The included examples showcase the following features:
* Hand Interaction 
* Clipping planes
* ToolTips
* MRTK Standard Shader Gallery
* Bounding Boxes
* Buttons
* Hand Menu 
* Near Menu
* Slates
* Sliders
* Scrolling Collection
* Hand Coach
* Color Picker
* Object Docking
* Elastic System
* Hand Menu Layouts
* Joystick
* Non Native Keyboard


## For developers looking to use Passthrough in an existing MRTK project
The only real trick is to set Camera clear flags to Color with 0 opacity and replace OvrCamera prefab with one that has Passhrough API enabled (copy the default Quest_OVRCameraRig.prefab to Assets and create the necessary profiles)
All Passthrough requirements still have to be met, as described [here](https://developer.oculus.com/documentation/unity/unity-passthrough/).


## Recording:

I used scrcpy through SideQuest with the Quest 2 crop setting (the TV button in the top right, only shows if a headset is connected). Then just record the window with OBS or something similar. The only problem I encountered was the lack of sound, although I'm sure it could be made to work somehow.

The original repo for this utility is [here](https://github.com/Genymobile/scrcpy)

It works with any Android device and is very low latency, I've used it for multiple live smartphone AR demos and never had a problem, highly recommend it!
