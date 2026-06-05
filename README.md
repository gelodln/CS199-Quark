# Quark

An augmented reality physics learning app for Grade 6, built in Unity with Vuforia and a
Supabase backend. Quark builds on and aligns with the *ARsenic* research paper, extending
its AR physics-education approach into the Friction, Gravity, Energy Transformation, and
Simple Machines modules.

## Requirements

- Unity 2022.3.62f3 (with Android Build Support)
- A Vuforia license key (free from developer.vuforia.com)
- An Android device with a camera, plus a printed copy of the image target

## Setup

1. Clone the repo and open the folder in Unity 2022.3.62f3. The first open is slow while
   Unity restores packages and rebuilds its cache.
2. Open Window > Vuforia Configuration and paste in your Vuforia license key.
3. Press Play to test login and the menus, or build to an Android device to test AR.

To build: File > Build Settings, select Android, Switch Platform, then Build And Run with a
device connected. Print the image target, open a module scene, and point the camera at it.

The Supabase URL and key are already set in the code. To use your own backend, see
Deliverables/06_Installation_Guide.md.

## Research & Contact

Quark is grounded in the *ARsenic* research paper (see
Assets/Documentation/AR/ARsenic Final Paper.pdf), whose AR physics-learning framework and
learning-outcome language this app is aligned with.

For questions about ARsenic or Quark — research collaboration, classroom use, or access to the
study materials — please contact the researchers at *nbramos4@up.edu.ph* and
*apdeleon4@up.edu.ph*.
